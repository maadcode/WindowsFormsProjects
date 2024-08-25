namespace VideoconsolaGaming
{
    partial class SimonSays
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
            lblNivel = new Label();
            btnStart = new MaterialSkin.Controls.MaterialButton();
            lblGameOver = new Label();
            tblCards = new TableLayoutPanel();
            progressTime = new ColoredProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblNivel
            // 
            lblNivel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNivel.Location = new Point(507, 24);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(96, 27);
            lblNivel.TabIndex = 1;
            lblNivel.Text = "Nivel: 0";
            // 
            // btnStart
            // 
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.BackColor = SystemColors.Control;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStart.Depth = 0;
            btnStart.HighEmphasis = true;
            btnStart.Icon = null;
            btnStart.Location = new Point(13, 15);
            btnStart.Margin = new Padding(4, 6, 4, 6);
            btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            btnStart.Name = "btnStart";
            btnStart.NoAccentTextColor = Color.Empty;
            btnStart.Size = new Size(141, 36);
            btnStart.TabIndex = 2;
            btnStart.Text = "Reiniciar juego";
            btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStart.UseAccentColor = false;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.Location = new Point(12, 494);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(353, 39);
            lblGameOver.TabIndex = 3;
            lblGameOver.Text = "¡Felicidades ganaste!";
            lblGameOver.Visible = false;
            // 
            // tblCards
            // 
            tblCards.ColumnCount = 2;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCards.Location = new Point(13, 110);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 2;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.Size = new Size(590, 381);
            tblCards.TabIndex = 4;
            // 
            // progressTime
            // 
            progressTime.ForeColor = Color.CornflowerBlue;
            progressTime.Location = new Point(13, 70);
            progressTime.Maximum = 60;
            progressTime.Name = "progressTime";
            progressTime.ProgressBarColor = Color.CornflowerBlue;
            progressTime.Size = new Size(590, 23);
            progressTime.Step = 1;
            progressTime.TabIndex = 5;
            progressTime.Value = 60;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // SimonSays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 542);
            Controls.Add(progressTime);
            Controls.Add(tblCards);
            Controls.Add(lblGameOver);
            Controls.Add(btnStart);
            Controls.Add(lblNivel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SimonSays";
            Text = "SimonSays";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNivel;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private Label lblGameOver;
        private TableLayoutPanel tblCards;
        private ColoredProgressBar progressTime;
        private System.Windows.Forms.Timer timer;
    }
}