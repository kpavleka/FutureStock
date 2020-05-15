namespace FutureStock
{
    partial class formNarudzbenicaDetalji
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
            this.temaNarDetalji = new CS_ClassLibraryTester.NYX_Theme();
            this.dgvDetaljiNarudzbenice = new System.Windows.Forms.DataGridView();
            this.gumbPovratakNar = new CS_ClassLibraryTester.NYX_Button();
            this.gumbic = new CS_ClassLibraryTester.NYX_ControlBox();
            this.temaNarDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiNarudzbenice)).BeginInit();
            this.SuspendLayout();
            // 
            // temaNarDetalji
            // 
            this.temaNarDetalji.Animated = true;
            this.temaNarDetalji.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.temaNarDetalji.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.temaNarDetalji.Controls.Add(this.dgvDetaljiNarudzbenice);
            this.temaNarDetalji.Controls.Add(this.gumbPovratakNar);
            this.temaNarDetalji.Controls.Add(this.gumbic);
            this.temaNarDetalji.Customization = "";
            this.temaNarDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temaNarDetalji.Font = new System.Drawing.Font("Verdana", 8F);
            this.temaNarDetalji.Image = null;
            this.temaNarDetalji.Location = new System.Drawing.Point(0, 0);
            this.temaNarDetalji.Movable = true;
            this.temaNarDetalji.Name = "temaNarDetalji";
            this.temaNarDetalji.NoRounding = false;
            this.temaNarDetalji.Sizable = true;
            this.temaNarDetalji.Size = new System.Drawing.Size(800, 450);
            this.temaNarDetalji.SmartBounds = true;
            this.temaNarDetalji.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.temaNarDetalji.TabIndex = 0;
            this.temaNarDetalji.Text = "Detalji narudžbenice";
            this.temaNarDetalji.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.temaNarDetalji.Transparent = false;
            // 
            // dgvDetaljiNarudzbenice
            // 
            this.dgvDetaljiNarudzbenice.AllowUserToAddRows = false;
            this.dgvDetaljiNarudzbenice.AllowUserToDeleteRows = false;
            this.dgvDetaljiNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiNarudzbenice.Location = new System.Drawing.Point(22, 42);
            this.dgvDetaljiNarudzbenice.MultiSelect = false;
            this.dgvDetaljiNarudzbenice.Name = "dgvDetaljiNarudzbenice";
            this.dgvDetaljiNarudzbenice.ReadOnly = true;
            this.dgvDetaljiNarudzbenice.RowTemplate.Height = 24;
            this.dgvDetaljiNarudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiNarudzbenice.Size = new System.Drawing.Size(754, 331);
            this.dgvDetaljiNarudzbenice.TabIndex = 8;
            // 
            // gumbPovratakNar
            // 
            this.gumbPovratakNar.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakNar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakNar.Customization = "";
            this.gumbPovratakNar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakNar.Image = null;
            this.gumbPovratakNar.Location = new System.Drawing.Point(22, 393);
            this.gumbPovratakNar.Name = "gumbPovratakNar";
            this.gumbPovratakNar.NoRounding = false;
            this.gumbPovratakNar.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakNar.TabIndex = 7;
            this.gumbPovratakNar.Text = "Povratak";
            this.gumbPovratakNar.Transparent = false;
            this.gumbPovratakNar.Click += new System.EventHandler(this.gumbPovratakNar_Click);
            // 
            // gumbic
            // 
            this.gumbic.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbic.Customization = "";
            this.gumbic.Font = new System.Drawing.Font("Verdana", 8F);
            this.gumbic.Image = null;
            this.gumbic.Location = new System.Drawing.Point(744, 3);
            this.gumbic.Name = "gumbic";
            this.gumbic.NoRounding = false;
            this.gumbic.Size = new System.Drawing.Size(44, 20);
            this.gumbic.TabIndex = 0;
            this.gumbic.Text = "gumbic";
            this.gumbic.Transparent = false;
            // 
            // formNarudzbenicaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temaNarDetalji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formNarudzbenicaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NarudzbenicaDetalji";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formNarudzbenicaDetalji_Load);
            this.temaNarDetalji.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiNarudzbenice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme temaNarDetalji;
        private CS_ClassLibraryTester.NYX_ControlBox gumbic;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakNar;
        private System.Windows.Forms.DataGridView dgvDetaljiNarudzbenice;
    }
}