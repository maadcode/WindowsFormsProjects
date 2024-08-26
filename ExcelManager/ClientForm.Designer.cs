namespace ExcelManager
{
    partial class ClientForm
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
            dataGV = new DataGridView();
            btnImportar = new MaterialSkin.Controls.MaterialButton();
            btnExportar = new MaterialSkin.Controls.MaterialButton();
            btnPrint = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGV).BeginInit();
            SuspendLayout();
            // 
            // dataGV
            // 
            dataGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV.Location = new Point(12, 60);
            dataGV.Name = "dataGV";
            dataGV.Size = new Size(776, 378);
            dataGV.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImportar.Depth = 0;
            btnImportar.HighEmphasis = true;
            btnImportar.Icon = null;
            btnImportar.Location = new Point(13, 15);
            btnImportar.Margin = new Padding(4, 6, 4, 6);
            btnImportar.MouseState = MaterialSkin.MouseState.HOVER;
            btnImportar.Name = "btnImportar";
            btnImportar.NoAccentTextColor = Color.Empty;
            btnImportar.Size = new Size(95, 36);
            btnImportar.TabIndex = 1;
            btnImportar.Text = "Importar";
            btnImportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImportar.UseAccentColor = false;
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExportar.Depth = 0;
            btnExportar.HighEmphasis = true;
            btnExportar.Icon = null;
            btnExportar.Location = new Point(597, 15);
            btnExportar.Margin = new Padding(4, 6, 4, 6);
            btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            btnExportar.Name = "btnExportar";
            btnExportar.NoAccentTextColor = Color.Empty;
            btnExportar.Size = new Size(95, 36);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExportar.UseAccentColor = false;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnPrint
            // 
            btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrint.Depth = 0;
            btnPrint.HighEmphasis = true;
            btnPrint.Icon = null;
            btnPrint.Location = new Point(700, 15);
            btnPrint.Margin = new Padding(4, 6, 4, 6);
            btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrint.Name = "btnPrint";
            btnPrint.NoAccentTextColor = Color.Empty;
            btnPrint.Size = new Size(87, 36);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Imprimir";
            btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrint.UseAccentColor = false;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(dataGV);
            Name = "ClientForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGV;
        private MaterialSkin.Controls.MaterialButton btnImportar;
        private MaterialSkin.Controls.MaterialButton btnExportar;
        private MaterialSkin.Controls.MaterialButton btnPrint;
    }
}
