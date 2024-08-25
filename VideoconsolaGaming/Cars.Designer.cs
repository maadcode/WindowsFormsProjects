namespace VideoconsolaGaming
{
    partial class Cars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imgCar = new PictureBox();
            btnStart = new MaterialSkin.Controls.MaterialButton();
            lblPoints = new Label();
            timerGenerator = new System.Windows.Forms.Timer(components);
            timerMovement = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            SuspendLayout();
            // 
            // imgCar
            // 
            imgCar.BackColor = Color.MediumBlue;
            imgCar.Location = new Point(12, 699);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(120, 50);
            imgCar.TabIndex = 0;
            imgCar.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStart.Depth = 0;
            btnStart.HighEmphasis = true;
            btnStart.Icon = null;
            btnStart.Location = new Point(81, 282);
            btnStart.Margin = new Padding(4, 6, 4, 6);
            btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            btnStart.Name = "btnStart";
            btnStart.NoAccentTextColor = Color.Empty;
            btnStart.Size = new Size(111, 36);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Game";
            btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStart.UseAccentColor = false;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoints.ForeColor = Color.Peru;
            lblPoints.Location = new Point(12, 19);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(129, 31);
            lblPoints.TabIndex = 3;
            lblPoints.Text = "Puntos: 0";
            // 
            // timerGenerator
            // 
            timerGenerator.Interval = 1000;
            timerGenerator.Tick += timerGenerator_Tick;
            // 
            // timerMovement
            // 
            timerMovement.Interval = 1;
            timerMovement.Tick += timerMovement_Tick;
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(284, 761);
            Controls.Add(lblPoints);
            Controls.Add(btnStart);
            Controls.Add(imgCar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Cars";
            Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgCar;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private Label lblPoints;
        private System.Windows.Forms.Timer timerGenerator;
        private System.Windows.Forms.Timer timerMovement;
    }
}