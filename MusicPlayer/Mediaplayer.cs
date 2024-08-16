using System.Xml.Linq;

namespace MusicPlayer;

public partial class Mediaplayer : Form
{
    private List<string> RutasArchivosMp3;
    private CancellationTokenSource cancellationTokenScrollTitle;
    private CancellationTokenSource cancellationTokenProgressSong;

    public Mediaplayer()
    {
        InitializeComponent();
        player.uiMode = "none";
        RutasArchivosMp3 = new List<string>();
        ResetProgressSong();
    }

    private void ResetProgressSong()
    {
        progressSong.RangeMax = 100;
        progressSong.Value = 0;
    }

    private void PlaySong(int index, string name)
    {
        lblTitleSong.Text = name;
        player.URL = RutasArchivosMp3[index];
        btnPlay.Image = Properties.Resources.pause;

        StartScrollTitle(name);
        StartProgressSong();
    }

    private void StopSong()
    {
        lblTitleSong.Text = "Ninguna canción reproduciendo";
        player.URL = string.Empty;
        btnPlay.Image = Properties.Resources.play;

        StopScrollTitle();
        StopProgressStatus();
        ResetProgressSong();
    }

    private void StartProgressSong()
    {
        cancellationTokenProgressSong = new CancellationTokenSource();
        var token = cancellationTokenProgressSong.Token;

        Task.Run(async () =>
        {
            progressSong.Value = 0;
            while (!token.IsCancellationRequested)
            {
                double duration = player.Ctlcontrols.currentItem.duration;
                double currentPosition = player.Ctlcontrols.currentPosition;
                if (duration > 0 && currentPosition >= 0 && currentPosition <= duration)
                {
                    progressSong.Invoke(() =>
                    {
                        progressSong.RangeMax = (int)duration;
                        progressSong.Value = (int)currentPosition;
                    });
                }
                await Task.Delay(1000);
            }
        }, token);
    }

    private void StartScrollTitle(string songTitle)
    {
        StopScrollTitle();
        cancellationTokenScrollTitle = new CancellationTokenSource();
        var token = cancellationTokenScrollTitle.Token;

        Task.Run(async () =>
        {
            while (!token.IsCancellationRequested)
            {
                for (int i = 0; i < songTitle.Length; i++)
                {
                    if (token.IsCancellationRequested)
                        break;

                    lblTitleSong.Invoke(() =>
                    {
                        lblTitleSong.Text = songTitle.Substring(i) + " " + songTitle.Substring(0, i);
                    });
                    await Task.Delay(200);
                }
            }
        }, token);
    }

    private void StopScrollTitle()
    {
        if (cancellationTokenScrollTitle != null)
        {
            cancellationTokenScrollTitle.Cancel();
            cancellationTokenScrollTitle.Dispose();
            cancellationTokenScrollTitle = null;
        }
    }

    private void StopProgressStatus()
    {
        if (cancellationTokenProgressSong != null)
        {
            cancellationTokenProgressSong.Cancel();
            cancellationTokenProgressSong.Dispose();
            cancellationTokenProgressSong = null;
        }
    }

    private void btnAdjuntar_Click(object sender, EventArgs e)
    {
        try
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RutasArchivosMp3.AddRange(ofd.FileNames);
                listSongs.Items.AddRange(ofd.SafeFileNames);

                if (player.playState == WMPLib.WMPPlayState.wmppsReady || player.playState == WMPLib.WMPPlayState.wmppsUndefined)
                    listSongs.SelectedIndex = 0;
            }
            MessageBox.Show($"Se agregaron {listSongs.Items.Count} las canciones con éxito");
        }
        catch (Exception)
        {
            MessageBox.Show($"Ocurrió un error al agregar las canciones");
        }
    }

    private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            StopSong();

        PlaySong(listSongs.SelectedIndex, listSongs.SelectedItem.ToString());
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
        {
            player.Ctlcontrols.pause();
            btnPlay.Image = Properties.Resources.play;
        }
        else if (player.playState == WMPLib.WMPPlayState.wmppsReady)
        {
            PlaySong(listSongs.SelectedIndex, listSongs.SelectedItem.ToString());
        }
        else
        {
            player.Ctlcontrols.play();
            btnPlay.Image = Properties.Resources.pause;
        }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        player.Ctlcontrols?.stop();
        StopSong();
    }

    private void scrollVolumen_onValueChanged(object sender, int newValue)
    {
        player.settings.volume = newValue;
    }

    private void progressSong_onValueChanged(object sender, int newValue)
    {
        player.Ctlcontrols.currentPosition = newValue;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        if (listSongs.SelectedIndex > 0)
            listSongs.SelectedIndex--;
        else
            MessageBox.Show("No hay canciones más arriba.");
    }

    private void btnSkip_Click(object sender, EventArgs e)
    {
        if (listSongs.SelectedIndex < listSongs.Items.Count - 1)
            listSongs.SelectedIndex++;
        else
            MessageBox.Show("No hay canciones más abajo.");
    }
}