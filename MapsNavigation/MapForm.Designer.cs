namespace MapsNavigation
{
    partial class MapForm
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
            splitContainer1 = new SplitContainer();
            cbxDistritos = new MaterialSkin.Controls.MaterialComboBox();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            txtCodigoZIP = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cbxProvincias = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cbxDepartamentos = new MaterialSkin.Controls.MaterialComboBox();
            mapView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mapView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cbxDistritos);
            splitContainer1.Panel1.Controls.Add(btnSearch);
            splitContainer1.Panel1.Controls.Add(txtCodigoZIP);
            splitContainer1.Panel1.Controls.Add(materialLabel4);
            splitContainer1.Panel1.Controls.Add(materialLabel3);
            splitContainer1.Panel1.Controls.Add(cbxProvincias);
            splitContainer1.Panel1.Controls.Add(materialLabel2);
            splitContainer1.Panel1.Controls.Add(materialLabel1);
            splitContainer1.Panel1.Controls.Add(cbxDepartamentos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(mapView);
            splitContainer1.Size = new Size(868, 564);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.TabIndex = 0;
            // 
            // cbxDistritos
            // 
            cbxDistritos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxDistritos.AutoResize = false;
            cbxDistritos.BackColor = Color.FromArgb(255, 255, 255);
            cbxDistritos.Depth = 0;
            cbxDistritos.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDistritos.DropDownHeight = 174;
            cbxDistritos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDistritos.DropDownWidth = 121;
            cbxDistritos.FlatStyle = FlatStyle.Flat;
            cbxDistritos.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDistritos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDistritos.FormattingEnabled = true;
            cbxDistritos.IntegralHeight = false;
            cbxDistritos.ItemHeight = 43;
            cbxDistritos.Location = new Point(10, 260);
            cbxDistritos.Margin = new Padding(10, 5, 10, 15);
            cbxDistritos.MaxDropDownItems = 4;
            cbxDistritos.MouseState = MaterialSkin.MouseState.OUT;
            cbxDistritos.Name = "cbxDistritos";
            cbxDistritos.Size = new Size(263, 49);
            cbxDistritos.StartIndex = 0;
            cbxDistritos.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(10, 440);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(77, 36);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Buscar";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCodigoZIP
            // 
            txtCodigoZIP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoZIP.AnimateReadOnly = false;
            txtCodigoZIP.BorderStyle = BorderStyle.None;
            txtCodigoZIP.Depth = 0;
            txtCodigoZIP.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigoZIP.LeadingIcon = null;
            txtCodigoZIP.Location = new Point(10, 369);
            txtCodigoZIP.Margin = new Padding(10, 5, 10, 15);
            txtCodigoZIP.MaxLength = 50;
            txtCodigoZIP.MouseState = MaterialSkin.MouseState.OUT;
            txtCodigoZIP.Multiline = false;
            txtCodigoZIP.Name = "txtCodigoZIP";
            txtCodigoZIP.Size = new Size(263, 50);
            txtCodigoZIP.TabIndex = 7;
            txtCodigoZIP.Text = "";
            txtCodigoZIP.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(10, 335);
            materialLabel4.Margin = new Padding(10);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(79, 19);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "Codigo ZIP";
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(10, 226);
            materialLabel3.Margin = new Padding(10);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(52, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Distrito";
            // 
            // cbxProvincias
            // 
            cbxProvincias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxProvincias.AutoResize = false;
            cbxProvincias.BackColor = Color.FromArgb(255, 255, 255);
            cbxProvincias.Depth = 0;
            cbxProvincias.DrawMode = DrawMode.OwnerDrawVariable;
            cbxProvincias.DropDownHeight = 174;
            cbxProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProvincias.DropDownWidth = 121;
            cbxProvincias.FlatStyle = FlatStyle.Flat;
            cbxProvincias.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxProvincias.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxProvincias.FormattingEnabled = true;
            cbxProvincias.IntegralHeight = false;
            cbxProvincias.ItemHeight = 43;
            cbxProvincias.Location = new Point(10, 152);
            cbxProvincias.Margin = new Padding(10, 5, 10, 15);
            cbxProvincias.MaxDropDownItems = 4;
            cbxProvincias.MouseState = MaterialSkin.MouseState.OUT;
            cbxProvincias.Name = "cbxProvincias";
            cbxProvincias.Size = new Size(263, 49);
            cbxProvincias.StartIndex = 0;
            cbxProvincias.TabIndex = 3;
            cbxProvincias.SelectedIndexChanged += cbxProvincias_SelectedIndexChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(10, 118);
            materialLabel2.Margin = new Padding(10);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(67, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Provincia";
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(10, 10);
            materialLabel1.Margin = new Padding(10);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(102, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Departamento";
            // 
            // cbxDepartamentos
            // 
            cbxDepartamentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxDepartamentos.AutoResize = false;
            cbxDepartamentos.BackColor = Color.FromArgb(255, 255, 255);
            cbxDepartamentos.Depth = 0;
            cbxDepartamentos.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDepartamentos.DropDownHeight = 174;
            cbxDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDepartamentos.DropDownWidth = 121;
            cbxDepartamentos.FlatStyle = FlatStyle.Flat;
            cbxDepartamentos.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDepartamentos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDepartamentos.FormattingEnabled = true;
            cbxDepartamentos.IntegralHeight = false;
            cbxDepartamentos.ItemHeight = 43;
            cbxDepartamentos.Location = new Point(10, 44);
            cbxDepartamentos.Margin = new Padding(10, 5, 10, 15);
            cbxDepartamentos.MaxDropDownItems = 4;
            cbxDepartamentos.MouseState = MaterialSkin.MouseState.OUT;
            cbxDepartamentos.Name = "cbxDepartamentos";
            cbxDepartamentos.Size = new Size(263, 49);
            cbxDepartamentos.StartIndex = 0;
            cbxDepartamentos.TabIndex = 0;
            cbxDepartamentos.SelectedIndexChanged += cbxDepartamentos_SelectedIndexChanged;
            // 
            // mapView
            // 
            mapView.AllowExternalDrop = true;
            mapView.CreationProperties = null;
            mapView.DefaultBackgroundColor = Color.White;
            mapView.Location = new Point(3, 0);
            mapView.Name = "mapView";
            mapView.Size = new Size(572, 564);
            mapView.TabIndex = 0;
            mapView.ZoomFactor = 1D;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 564);
            Controls.Add(splitContainer1);
            Name = "MapForm";
            Text = "Mapmaad";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mapView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Microsoft.Web.WebView2.WinForms.WebView2 mapView;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbxDepartamentos;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtCodigoZIP;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbxProvincias;
        private MaterialSkin.Controls.MaterialComboBox cbxDistritos;
        private MaterialSkin.Controls.MaterialButton btnSearch;
    }
}
