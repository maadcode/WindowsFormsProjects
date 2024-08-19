namespace VideoconsolaGaming
{
    partial class Snake
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
            timerSnake = new System.Windows.Forms.Timer(components);
            timerFood = new System.Windows.Forms.Timer(components);
            timerCollision = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timerSnake
            // 
            timerSnake.Interval = 200;
            timerSnake.Tick += timerSnake_Tick;
            // 
            // timerFood
            // 
            timerFood.Interval = 1000;
            timerFood.Tick += timerFood_Tick;
            // 
            // timerCollision
            // 
            timerCollision.Tick += timerCollision_Tick;
            // 
            // Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(800, 609);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Snake";
            Text = "Snake";
            KeyDown += Snake_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.Timer timerFood;
        private System.Windows.Forms.Timer timerCollision;
    }
}