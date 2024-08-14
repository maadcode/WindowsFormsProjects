namespace WebBrowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            btnLeft = new PictureBox();
            btnRight = new PictureBox();
            btnRefresh = new PictureBox();
            btnSearch = new PictureBox();
            txtSearch = new TextBox();
            panelSearch = new RoundedPanel();
            browserView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)btnLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)browserView).BeginInit();
            SuspendLayout();
            // 
            // btnLeft
            // 
            btnLeft.Image = Properties.Resources.left;
            btnLeft.Location = new Point(12, 18);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(25, 25);
            btnLeft.SizeMode = PictureBoxSizeMode.Zoom;
            btnLeft.TabIndex = 2;
            btnLeft.TabStop = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Image = Properties.Resources.right;
            btnRight.Location = new Point(43, 18);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(25, 25);
            btnRight.SizeMode = PictureBoxSizeMode.Zoom;
            btnRight.TabIndex = 3;
            btnRight.TabStop = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(74, 18);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(25, 25);
            btnRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            btnRefresh.TabIndex = 4;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(15, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(25, 25);
            btnSearch.SizeMode = PictureBoxSizeMode.Zoom;
            btnSearch.TabIndex = 0;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.DimGray;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(43, 8);
            txtSearch.Margin = new Padding(0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Escribe búsqueda o dirección web";
            txtSearch.Size = new Size(732, 18);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.BorderColor = Color.FromArgb(72, 77, 100);
            panelSearch.BorderRadius = 20;
            panelSearch.BorderThickness = 2;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Location = new Point(105, 12);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(790, 35);
            panelSearch.TabIndex = 5;
            // 
            // browserView
            // 
            browserView.AllowExternalDrop = true;
            browserView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            browserView.BackColor = Color.Peru;
            browserView.CreationProperties = null;
            browserView.DefaultBackgroundColor = Color.White;
            browserView.Location = new Point(0, 53);
            browserView.Name = "browserView";
            browserView.Size = new Size(907, 610);
            browserView.TabIndex = 6;
            browserView.ZoomFactor = 1D;
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(907, 660);
            Controls.Add(browserView);
            Controls.Add(panelSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Browser";
            Text = "Browsermad";
            ((System.ComponentModel.ISupportInitialize)btnLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)browserView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnLeft;
        private PictureBox btnRight;
        private PictureBox btnRefresh;
        private PictureBox btnSearch;
        private TextBox txtSearch;
        private RoundedPanel panelSearch;
        private Microsoft.Web.WebView2.WinForms.WebView2 browserView;
    }
}
