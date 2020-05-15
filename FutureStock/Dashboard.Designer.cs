namespace FutureStock
{
    partial class formDashboard
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
            this.temaDashboard = new CS_ClassLibraryTester.NYX_Theme();
            this.btnStatistika = new CS_ClassLibraryTester.NYX_Button();
            this.grpPosiljke = new CS_ClassLibraryTester.NYX_GroupBox();
            this.btnZaprimi = new CS_ClassLibraryTester.NYX_Button();
            this.txtSkladiste = new CS_ClassLibraryTester.CrystalClearTextBox();
            this.progressSkladiste = new CS_ClassLibraryTester.NYX_ProgressBar();
            this.dgvSkladiste = new System.Windows.Forms.DataGridView();
            this.kontrole2 = new CS_ClassLibraryTester.NYX_ControlBox();
            this.grpEntiteti = new CS_ClassLibraryTester.NYX_GroupBox();
            this.btnEntiteti = new CS_ClassLibraryTester.NYX_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temaDashboard.SuspendLayout();
            this.grpPosiljke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).BeginInit();
            this.grpEntiteti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // temaDashboard
            // 
            this.temaDashboard.Animated = true;
            this.temaDashboard.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.temaDashboard.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.temaDashboard.Controls.Add(this.btnStatistika);
            this.temaDashboard.Controls.Add(this.grpPosiljke);
            this.temaDashboard.Controls.Add(this.txtSkladiste);
            this.temaDashboard.Controls.Add(this.progressSkladiste);
            this.temaDashboard.Controls.Add(this.dgvSkladiste);
            this.temaDashboard.Controls.Add(this.kontrole2);
            this.temaDashboard.Controls.Add(this.grpEntiteti);
            this.temaDashboard.Controls.Add(this.pictureBox1);
            this.temaDashboard.Customization = "";
            this.temaDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temaDashboard.Font = new System.Drawing.Font("Verdana", 8F);
            this.temaDashboard.Image = null;
            this.temaDashboard.Location = new System.Drawing.Point(0, 0);
            this.temaDashboard.Movable = true;
            this.temaDashboard.Name = "temaDashboard";
            this.temaDashboard.NoRounding = false;
            this.temaDashboard.Sizable = true;
            this.temaDashboard.Size = new System.Drawing.Size(800, 450);
            this.temaDashboard.SmartBounds = true;
            this.temaDashboard.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.temaDashboard.TabIndex = 0;
            this.temaDashboard.Text = "Dashboard";
            this.temaDashboard.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.temaDashboard.Transparent = false;
            // 
            // btnStatistika
            // 
            this.btnStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistika.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.btnStatistika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistika.Customization = "";
            this.btnStatistika.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatistika.Image = null;
            this.btnStatistika.Location = new System.Drawing.Point(573, 140);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.NoRounding = false;
            this.btnStatistika.Size = new System.Drawing.Size(200, 59);
            this.btnStatistika.TabIndex = 11;
            this.btnStatistika.Text = "Skladišna statistika";
            this.btnStatistika.Transparent = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // grpPosiljke
            // 
            this.grpPosiljke.Animated = true;
            this.grpPosiljke.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grpPosiljke.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.grpPosiljke.Controls.Add(this.btnZaprimi);
            this.grpPosiljke.Customization = "";
            this.grpPosiljke.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpPosiljke.Image = null;
            this.grpPosiljke.Location = new System.Drawing.Point(573, 39);
            this.grpPosiljke.Movable = true;
            this.grpPosiljke.Name = "grpPosiljke";
            this.grpPosiljke.NoRounding = false;
            this.grpPosiljke.Sizable = true;
            this.grpPosiljke.Size = new System.Drawing.Size(200, 86);
            this.grpPosiljke.SmartBounds = true;
            this.grpPosiljke.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.grpPosiljke.TabIndex = 10;
            this.grpPosiljke.Text = "Zaprimanje pošiljke";
            this.grpPosiljke.TransparencyKey = System.Drawing.Color.Empty;
            this.grpPosiljke.Transparent = false;
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZaprimi.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.btnZaprimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZaprimi.Customization = "";
            this.btnZaprimi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaprimi.Image = null;
            this.btnZaprimi.Location = new System.Drawing.Point(43, 41);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.NoRounding = false;
            this.btnZaprimi.Size = new System.Drawing.Size(112, 33);
            this.btnZaprimi.TabIndex = 2;
            this.btnZaprimi.Text = "Pošiljke";
            this.btnZaprimi.Transparent = false;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.txtSkladiste.Customization = "";
            this.txtSkladiste.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSkladiste.Image = null;
            this.txtSkladiste.Location = new System.Drawing.Point(27, 140);
            this.txtSkladiste.MaxLength = 32767;
            this.txtSkladiste.Multiline = false;
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.NoRounding = false;
            this.txtSkladiste.ReadOnly = true;
            this.txtSkladiste.Size = new System.Drawing.Size(200, 32);
            this.txtSkladiste.TabIndex = 9;
            this.txtSkladiste.Text = "Popunjenost skladišta";
            this.txtSkladiste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSkladiste.Transparent = false;
            this.txtSkladiste.UseSystemPasswordChar = false;
            // 
            // progressSkladiste
            // 
            this.progressSkladiste.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.progressSkladiste.Customization = "";
            this.progressSkladiste.Font = new System.Drawing.Font("Verdana", 8F);
            this.progressSkladiste.Image = null;
            this.progressSkladiste.Location = new System.Drawing.Point(27, 174);
            this.progressSkladiste.Maximum = 100;
            this.progressSkladiste.Name = "progressSkladiste";
            this.progressSkladiste.NoRounding = false;
            this.progressSkladiste.Size = new System.Drawing.Size(200, 25);
            this.progressSkladiste.TabIndex = 8;
            this.progressSkladiste.Text = "Progress";
            this.progressSkladiste.Transparent = false;
            this.progressSkladiste.Value = 0;
            // 
            // dgvSkladiste
            // 
            this.dgvSkladiste.AllowUserToAddRows = false;
            this.dgvSkladiste.AllowUserToDeleteRows = false;
            this.dgvSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladiste.EnableHeadersVisualStyles = false;
            this.dgvSkladiste.Location = new System.Drawing.Point(49, 214);
            this.dgvSkladiste.MultiSelect = false;
            this.dgvSkladiste.Name = "dgvSkladiste";
            this.dgvSkladiste.ReadOnly = true;
            this.dgvSkladiste.RowTemplate.Height = 24;
            this.dgvSkladiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladiste.Size = new System.Drawing.Size(696, 224);
            this.dgvSkladiste.TabIndex = 7;
            // 
            // kontrole2
            // 
            this.kontrole2.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.kontrole2.Customization = "";
            this.kontrole2.Font = new System.Drawing.Font("Verdana", 8F);
            this.kontrole2.Image = null;
            this.kontrole2.Location = new System.Drawing.Point(744, 3);
            this.kontrole2.Name = "kontrole2";
            this.kontrole2.NoRounding = false;
            this.kontrole2.Size = new System.Drawing.Size(44, 20);
            this.kontrole2.TabIndex = 6;
            this.kontrole2.Text = "nyX_ControlBox1";
            this.kontrole2.Transparent = false;
            // 
            // grpEntiteti
            // 
            this.grpEntiteti.Animated = true;
            this.grpEntiteti.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grpEntiteti.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.grpEntiteti.Controls.Add(this.btnEntiteti);
            this.grpEntiteti.Customization = "";
            this.grpEntiteti.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpEntiteti.Image = null;
            this.grpEntiteti.Location = new System.Drawing.Point(27, 39);
            this.grpEntiteti.Movable = true;
            this.grpEntiteti.Name = "grpEntiteti";
            this.grpEntiteti.NoRounding = false;
            this.grpEntiteti.Sizable = true;
            this.grpEntiteti.Size = new System.Drawing.Size(200, 86);
            this.grpEntiteti.SmartBounds = true;
            this.grpEntiteti.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.grpEntiteti.TabIndex = 5;
            this.grpEntiteti.Text = "Rad s entitetima";
            this.grpEntiteti.TransparencyKey = System.Drawing.Color.Empty;
            this.grpEntiteti.Transparent = false;
            // 
            // btnEntiteti
            // 
            this.btnEntiteti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntiteti.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.btnEntiteti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntiteti.Customization = "";
            this.btnEntiteti.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEntiteti.Image = null;
            this.btnEntiteti.Location = new System.Drawing.Point(43, 41);
            this.btnEntiteti.Name = "btnEntiteti";
            this.btnEntiteti.NoRounding = false;
            this.btnEntiteti.Size = new System.Drawing.Size(112, 33);
            this.btnEntiteti.TabIndex = 2;
            this.btnEntiteti.Text = "Entiteti";
            this.btnEntiteti.Transparent = false;
            this.btnEntiteti.Click += new System.EventHandler(this.btnKreiranje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FutureStock.Properties.Resources.robodash;
            this.pictureBox1.Location = new System.Drawing.Point(247, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 169);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temaDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.temaDashboard.ResumeLayout(false);
            this.grpPosiljke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).EndInit();
            this.grpEntiteti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme temaDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CS_ClassLibraryTester.NYX_Button btnEntiteti;
        private CS_ClassLibraryTester.NYX_GroupBox grpEntiteti;
        private CS_ClassLibraryTester.NYX_ControlBox kontrole2;
        private CS_ClassLibraryTester.NYX_ProgressBar progressSkladiste;
        private System.Windows.Forms.DataGridView dgvSkladiste;
        private CS_ClassLibraryTester.CrystalClearTextBox txtSkladiste;
        private CS_ClassLibraryTester.NYX_GroupBox grpPosiljke;
        private CS_ClassLibraryTester.NYX_Button btnZaprimi;
        private CS_ClassLibraryTester.NYX_Button btnStatistika;
    }
}