namespace CameraCapturetor
{
    partial class CameraForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureCamera = new PictureBox();
            cbxCameras = new MaterialSkin.Controls.MaterialComboBox();
            btnGrabar = new MaterialSkin.Controls.MaterialButton();
            btnCapturar = new MaterialSkin.Controls.MaterialButton();
            pictureCapture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureCapture).BeginInit();
            SuspendLayout();
            // 
            // pictureCamera
            // 
            pictureCamera.Location = new Point(12, 67);
            pictureCamera.Name = "pictureCamera";
            pictureCamera.Size = new Size(440, 371);
            pictureCamera.TabIndex = 0;
            pictureCamera.TabStop = false;
            // 
            // cbxCameras
            // 
            cbxCameras.AutoResize = false;
            cbxCameras.BackColor = Color.FromArgb(255, 255, 255);
            cbxCameras.Depth = 0;
            cbxCameras.DrawMode = DrawMode.OwnerDrawVariable;
            cbxCameras.DropDownHeight = 174;
            cbxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCameras.DropDownWidth = 121;
            cbxCameras.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxCameras.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxCameras.FormattingEnabled = true;
            cbxCameras.IntegralHeight = false;
            cbxCameras.ItemHeight = 43;
            cbxCameras.Location = new Point(12, 12);
            cbxCameras.MaxDropDownItems = 4;
            cbxCameras.MouseState = MaterialSkin.MouseState.OUT;
            cbxCameras.Name = "cbxCameras";
            cbxCameras.Size = new Size(265, 49);
            cbxCameras.StartIndex = 0;
            cbxCameras.TabIndex = 2;
            // 
            // btnGrabar
            // 
            btnGrabar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGrabar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGrabar.Depth = 0;
            btnGrabar.HighEmphasis = true;
            btnGrabar.Icon = null;
            btnGrabar.Location = new Point(294, 25);
            btnGrabar.Margin = new Padding(4, 6, 4, 6);
            btnGrabar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGrabar.Name = "btnGrabar";
            btnGrabar.NoAccentTextColor = Color.Empty;
            btnGrabar.Size = new Size(78, 36);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGrabar.UseAccentColor = false;
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnStartGrabar_Click;
            // 
            // btnCapturar
            // 
            btnCapturar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCapturar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCapturar.Depth = 0;
            btnCapturar.HighEmphasis = true;
            btnCapturar.Icon = null;
            btnCapturar.Location = new Point(802, 25);
            btnCapturar.Margin = new Padding(4, 6, 4, 6);
            btnCapturar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCapturar.Name = "btnCapturar";
            btnCapturar.NoAccentTextColor = Color.Empty;
            btnCapturar.Size = new Size(96, 36);
            btnCapturar.TabIndex = 4;
            btnCapturar.Text = "Capturar";
            btnCapturar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCapturar.UseAccentColor = false;
            btnCapturar.UseVisualStyleBackColor = true;
            btnCapturar.Click += btnCapturar_Click;
            // 
            // pictureCapture
            // 
            pictureCapture.Location = new Point(458, 67);
            pictureCapture.Name = "pictureCapture";
            pictureCapture.Size = new Size(440, 371);
            pictureCapture.TabIndex = 5;
            pictureCapture.TabStop = false;
            // 
            // CameraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(pictureCapture);
            Controls.Add(btnCapturar);
            Controls.Add(btnGrabar);
            Controls.Add(cbxCameras);
            Controls.Add(pictureCamera);
            Name = "CameraForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureCapture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureCamera;
        private MaterialSkin.Controls.MaterialComboBox cbxCameras;
        private MaterialSkin.Controls.MaterialButton btnGrabar;
        private MaterialSkin.Controls.MaterialButton btnCapturar;
        private PictureBox pictureCapture;
    }
}
