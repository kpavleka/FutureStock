namespace FutureStock
{
    partial class formPopisProizvoda
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
            this.tema = new CS_ClassLibraryTester.NYX_Theme();
            this.gumbZatvori = new CS_ClassLibraryTester.NYX_Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.gumbici = new CS_ClassLibraryTester.NYX_ControlBox();
            this.tema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // tema
            // 
            this.tema.Animated = true;
            this.tema.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.tema.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.tema.Controls.Add(this.gumbZatvori);
            this.tema.Controls.Add(this.dgvProizvodi);
            this.tema.Controls.Add(this.gumbici);
            this.tema.Customization = "";
            this.tema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tema.Font = new System.Drawing.Font("Verdana", 8F);
            this.tema.Image = null;
            this.tema.Location = new System.Drawing.Point(0, 0);
            this.tema.Movable = true;
            this.tema.Name = "tema";
            this.tema.NoRounding = false;
            this.tema.Sizable = true;
            this.tema.Size = new System.Drawing.Size(800, 450);
            this.tema.SmartBounds = true;
            this.tema.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.tema.TabIndex = 0;
            this.tema.Text = "Popis proizvoda";
            this.tema.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.tema.Transparent = false;
            // 
            // gumbZatvori
            // 
            this.gumbZatvori.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbZatvori.Customization = "";
            this.gumbZatvori.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbZatvori.Image = null;
            this.gumbZatvori.Location = new System.Drawing.Point(21, 394);
            this.gumbZatvori.Name = "gumbZatvori";
            this.gumbZatvori.NoRounding = false;
            this.gumbZatvori.Size = new System.Drawing.Size(110, 36);
            this.gumbZatvori.TabIndex = 12;
            this.gumbZatvori.Text = "Zatvori";
            this.gumbZatvori.Transparent = false;
            this.gumbZatvori.Click += new System.EventHandler(this.gumbZatvori_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(21, 43);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(754, 331);
            this.dgvProizvodi.TabIndex = 11;
            // 
            // gumbici
            // 
            this.gumbici.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbici.Customization = "";
            this.gumbici.Font = new System.Drawing.Font("Verdana", 8F);
            this.gumbici.Image = null;
            this.gumbici.Location = new System.Drawing.Point(744, 3);
            this.gumbici.Name = "gumbici";
            this.gumbici.NoRounding = false;
            this.gumbici.Size = new System.Drawing.Size(44, 20);
            this.gumbici.TabIndex = 0;
            this.gumbici.Text = "nyX_ControlBox1";
            this.gumbici.Transparent = false;
            // 
            // formPopisProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPopisProizvoda";
            this.Text = "PopisProizvoda";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formPopisProizvoda_Load);
            this.tema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme tema;
        private CS_ClassLibraryTester.NYX_ControlBox gumbici;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private CS_ClassLibraryTester.NYX_Button gumbZatvori;
    }
}