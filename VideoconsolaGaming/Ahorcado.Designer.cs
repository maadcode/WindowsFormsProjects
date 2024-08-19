namespace VideoconsolaGaming
{
    partial class Ahorcado
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
            flFichas = new FlowLayoutPanel();
            imgAhorcado = new PictureBox();
            flPalabra = new FlowLayoutPanel();
            lblGameOver = new Label();
            label2 = new Label();
            btnStart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgAhorcado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStart).BeginInit();
            SuspendLayout();
            // 
            // flFichas
            // 
            flFichas.Location = new Point(12, 111);
            flFichas.Name = "flFichas";
            flFichas.Size = new Size(445, 372);
            flFichas.TabIndex = 0;
            // 
            // imgAhorcado
            // 
            imgAhorcado.Image = Properties.Resources._1;
            imgAhorcado.Location = new Point(463, 111);
            imgAhorcado.Name = "imgAhorcado";
            imgAhorcado.Size = new Size(309, 372);
            imgAhorcado.SizeMode = PictureBoxSizeMode.Zoom;
            imgAhorcado.TabIndex = 1;
            imgAhorcado.TabStop = false;
            // 
            // flPalabra
            // 
            flPalabra.Anchor = AnchorStyles.None;
            flPalabra.AutoSize = true;
            flPalabra.Location = new Point(12, 489);
            flPalabra.Name = "flPalabra";
            flPalabra.Size = new Size(760, 71);
            flPalabra.TabIndex = 2;
            flPalabra.WrapContents = false;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = Color.Firebrick;
            lblGameOver.Location = new Point(531, 70);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(118, 21);
            lblGameOver.TabIndex = 4;
            lblGameOver.Text = "!Perdiste!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(79, 70);
            label2.Name = "label2";
            label2.Size = new Size(321, 21);
            label2.TabIndex = 5;
            label2.Text = "Adivina la palabra o muere";
            // 
            // btnStart
            // 
            btnStart.Image = Properties.Resources.btnStart;
            btnStart.Location = new Point(12, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(445, 40);
            btnStart.TabIndex = 6;
            btnStart.TabStop = false;
            btnStart.Click += btnStart_Click;
            // 
            // Ahorcado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(lblGameOver);
            Controls.Add(flPalabra);
            Controls.Add(imgAhorcado);
            Controls.Add(flFichas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Ahorcado";
            Text = "Ahorcado";
            ((System.ComponentModel.ISupportInitialize)imgAhorcado).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flFichas;
        private PictureBox imgAhorcado;
        private FlowLayoutPanel flPalabra;
        private Label lblGameOver;
        private Label label2;
        private PictureBox btnStart;
    }
}
