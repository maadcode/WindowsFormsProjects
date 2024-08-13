namespace MusicPlayer
{
    partial class Mediaplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mediaplayer));
            player = new AxWMPLib.AxWindowsMediaPlayer();
            btnAdjuntar = new PictureBox();
            listSongs = new ListBox();
            btnStop = new PictureBox();
            btnPlay = new PictureBox();
            lblTitleSong = new Label();
            pictureBox3 = new PictureBox();
            scrollVolumen = new MaterialSkin.Controls.MaterialSlider();
            panel1 = new Panel();
            btnSkip = new PictureBox();
            btnBack = new PictureBox();
            progressSong = new MaterialSkin.Controls.MaterialSlider();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdjuntar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSkip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Enabled = true;
            player.Location = new Point(12, 27);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(705, 112);
            player.TabIndex = 0;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.Image = Properties.Resources.plus;
            btnAdjuntar.Location = new Point(12, 481);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(48, 48);
            btnAdjuntar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnAdjuntar.TabIndex = 2;
            btnAdjuntar.TabStop = false;
            btnAdjuntar.Click += btnAdjuntar_Click;
            // 
            // listSongs
            // 
            listSongs.BorderStyle = BorderStyle.FixedSingle;
            listSongs.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listSongs.FormattingEnabled = true;
            listSongs.ItemHeight = 17;
            listSongs.Location = new Point(12, 286);
            listSongs.Name = "listSongs";
            listSongs.Size = new Size(705, 189);
            listSongs.TabIndex = 3;
            listSongs.SelectedIndexChanged += listSongs_SelectedIndexChanged;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Transparent;
            btnStop.Image = Properties.Resources.stop;
            btnStop.Location = new Point(209, 16);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(48, 48);
            btnStop.SizeMode = PictureBoxSizeMode.AutoSize;
            btnStop.TabIndex = 5;
            btnStop.TabStop = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.Image = Properties.Resources.play;
            btnPlay.Location = new Point(263, 16);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(48, 48);
            btnPlay.SizeMode = PictureBoxSizeMode.AutoSize;
            btnPlay.TabIndex = 6;
            btnPlay.TabStop = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblTitleSong
            // 
            lblTitleSong.Font = new Font("Source Sans Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleSong.ForeColor = Color.White;
            lblTitleSong.Location = new Point(12, 142);
            lblTitleSong.Name = "lblTitleSong";
            lblTitleSong.Size = new Size(705, 20);
            lblTitleSong.TabIndex = 7;
            lblTitleSong.Text = "No se está reproduciendo ninguna canción.";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.audio;
            pictureBox3.Location = new Point(57, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // scrollVolumen
            // 
            scrollVolumen.BackColor = Color.White;
            scrollVolumen.Depth = 0;
            scrollVolumen.Font = new Font("Segoe UI", 9F);
            scrollVolumen.ForeColor = Color.Transparent;
            scrollVolumen.Location = new Point(101, 232);
            scrollVolumen.MouseState = MaterialSkin.MouseState.HOVER;
            scrollVolumen.Name = "scrollVolumen";
            scrollVolumen.ShowText = false;
            scrollVolumen.ShowValue = false;
            scrollVolumen.Size = new Size(121, 40);
            scrollVolumen.TabIndex = 9;
            scrollVolumen.Text = "";
            scrollVolumen.ValueMax = 100;
            scrollVolumen.onValueChanged += scrollVolumen_onValueChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnSkip);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnPlay);
            panel1.Location = new Point(254, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 81);
            panel1.TabIndex = 11;
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.Transparent;
            btnSkip.Image = (Image)resources.GetObject("btnSkip.Image");
            btnSkip.Location = new Point(317, 16);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(48, 48);
            btnSkip.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSkip.TabIndex = 13;
            btnSkip.TabStop = false;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(155, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.SizeMode = PictureBoxSizeMode.AutoSize;
            btnBack.TabIndex = 12;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // progressSong
            // 
            progressSong.Depth = 0;
            progressSong.ForeColor = Color.FromArgb(222, 0, 0, 0);
            progressSong.Location = new Point(12, 165);
            progressSong.MouseState = MaterialSkin.MouseState.HOVER;
            progressSong.Name = "progressSong";
            progressSong.ShowText = false;
            progressSong.ShowValue = false;
            progressSong.Size = new Size(705, 40);
            progressSong.TabIndex = 12;
            progressSong.Text = "materialSlider1";
            progressSong.onValueChanged += progressSong_onValueChanged;
            // 
            // Mediaplayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(729, 541);
            Controls.Add(progressSong);
            Controls.Add(lblTitleSong);
            Controls.Add(scrollVolumen);
            Controls.Add(listSongs);
            Controls.Add(pictureBox3);
            Controls.Add(btnAdjuntar);
            Controls.Add(player);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Mediaplayer";
            Text = "Musicmad";
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdjuntar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSkip).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private PictureBox btnAdjuntar;
        private ListBox listSongs;
        private PictureBox btnStop;
        private PictureBox btnPlay;
        private Label lblTitleSong;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialSlider scrollVolumen;
        private Panel panel1;
        private PictureBox btnBack;
        private PictureBox btnSkip;
        private MaterialSkin.Controls.MaterialSlider progressSong;
    }
}
