using System.Drawing.Imaging;
using OpenCvSharp;
using DirectShowLib;

namespace CameraCapturetor;

public partial class CameraForm : Form
{
    private readonly string FolderImageCaptures;
    private VideoCapture _capture;
    private System.Windows.Forms.Timer timer;

    public CameraForm()
    {
        InitializeComponent();
        FolderImageCaptures = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
        if (!Directory.Exists(FolderImageCaptures))
            Directory.CreateDirectory(FolderImageCaptures);
        timer = new System.Windows.Forms.Timer();
        timer.Interval = 30;
        LoadCameras();
    }

    private void LoadCameras()
    {
        cbxCameras.Items.Clear();
        DsDevice[] devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
        foreach (var device in devices)
            cbxCameras.Items.Add(device.Name);
    }

    private void StartCamera(int cameraIndex)
    {
        if (_capture == null)
            _capture = new VideoCapture(cameraIndex);

        if (!_capture.IsOpened())
        {
            MessageBox.Show($"No se pudo abrir la cámara con índice {cameraIndex}");
            return;
        }

        _capture.Set(VideoCaptureProperties.FrameWidth, 640);
        _capture.Set(VideoCaptureProperties.FrameHeight, 480);

        Mat testFrame = new Mat();
        _capture.Read(testFrame);
        if (testFrame.Empty())
        {
            MessageBox.Show("No se pudo capturar un frame de prueba. Asegúrate de que la cámara esté conectada correctamente.");
            _capture.Release();
            _capture.Dispose();
            _capture = null;
        }
        testFrame.Dispose();
    }

    private void StopCamera()
    {
        _capture.Release();
        _capture.Dispose();
        pictureCamera.Image = null;
    }

    private void CapturePhoto(int cameraIndex)
    {
        StartCamera(cameraIndex);
        using (Mat frame = new Mat())
        {
            _capture.Read(frame);
            if (!frame.Empty())
            {
                pictureCamera.Image?.Dispose();
                pictureCamera.Image = frame.ToBitmap();
                string fileName = $"captura_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
                string filePath = Path.Combine(FolderImageCaptures, fileName);
                frame.SaveImage(filePath);
                MessageBox.Show($"Imagen guardada en: {filePath}");
            }
            else
            {
                MessageBox.Show("No se pudo capturar una imagen.");
            }
        }
        StopCamera();
    }

    private void btnStartGrabar_Click(object sender, EventArgs e)
    {
        if( cbxCameras.SelectedIndex == -1 )
        {
            MessageBox.Show("Selecciona una cámara");
            return;
        }

        StartCamera(cbxCameras.SelectedIndex);
        timer.Start();
        btnGrabar.Text = "Detener";
        btnGrabar.Click -= btnStartGrabar_Click;
        btnGrabar.Click += btnStopGrabar_Click;
    }

    private void btnStopGrabar_Click(object sender, EventArgs e)
    {
        StopCamera();
        timer.Stop();
        btnGrabar.Text = "Grabar";
        btnGrabar.Click -= btnStopGrabar_Click;
        btnGrabar.Click += btnStartGrabar_Click;
    }

    private void timer_Tick_1(object sender, EventArgs e)
    {
        using (Mat frame = new Mat())
        {
            _capture.Read(frame);
            if (!frame.Empty())
            {
                pictureCamera.Image?.Dispose();
                pictureCamera.Image = frame.ToBitmap();
            }
        }
    }

    private void btnCapturar_Click(object sender, EventArgs e)
    {
        if (cbxCameras.SelectedIndex == -1)
        {
            MessageBox.Show("Selecciona una cámara");
            return;
        }

        CapturePhoto(cbxCameras.SelectedIndex);
    }
}

public static class MatExtensions
{
    public static Bitmap ToBitmap(this Mat mat)
    {
        using (var memoryStream = mat.ToMemoryStream())
        {
            return new Bitmap(memoryStream);
        }
    }

    private static MemoryStream ToMemoryStream(this Mat mat)
    {
        using (var image = mat.Clone())
        {
            var ms = new MemoryStream();
            var bitmap = image.ToBitmap();
            bitmap.Save(ms, ImageFormat.Bmp);
            ms.Position = 0;
            return ms;
        }
    }
}