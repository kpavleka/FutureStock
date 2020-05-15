namespace FutureStock
{
    partial class formOtpremnicaDetalji
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
            this.temaOtpremnicaDetalji = new CS_ClassLibraryTester.NYX_Theme();
            this.dgvDetaljiOtpremnice = new System.Windows.Forms.DataGridView();
            this.gumbPovratakOtp = new CS_ClassLibraryTester.NYX_Button();
            this.gumbic = new CS_ClassLibraryTester.NYX_ControlBox();
            this.temaOtpremnicaDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // temaOtpremnicaDetalji
            // 
            this.temaOtpremnicaDetalji.Animated = true;
            this.temaOtpremnicaDetalji.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.temaOtpremnicaDetalji.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.temaOtpremnicaDetalji.Controls.Add(this.dgvDetaljiOtpremnice);
            this.temaOtpremnicaDetalji.Controls.Add(this.gumbPovratakOtp);
            this.temaOtpremnicaDetalji.Controls.Add(this.gumbic);
            this.temaOtpremnicaDetalji.Customization = "";
            this.temaOtpremnicaDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temaOtpremnicaDetalji.Font = new System.Drawing.Font("Verdana", 8F);
            this.temaOtpremnicaDetalji.Image = null;
            this.temaOtpremnicaDetalji.Location = new System.Drawing.Point(0, 0);
            this.temaOtpremnicaDetalji.Movable = true;
            this.temaOtpremnicaDetalji.Name = "temaOtpremnicaDetalji";
            this.temaOtpremnicaDetalji.NoRounding = false;
            this.temaOtpremnicaDetalji.Sizable = true;
            this.temaOtpremnicaDetalji.Size = new System.Drawing.Size(800, 450);
            this.temaOtpremnicaDetalji.SmartBounds = true;
            this.temaOtpremnicaDetalji.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.temaOtpremnicaDetalji.TabIndex = 0;
            this.temaOtpremnicaDetalji.Text = "Detalji otpremnice";
            this.temaOtpremnicaDetalji.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.temaOtpremnicaDetalji.Transparent = false;
            // 
            // dgvDetaljiOtpremnice
            // 
            this.dgvDetaljiOtpremnice.AllowUserToAddRows = false;
            this.dgvDetaljiOtpremnice.AllowUserToDeleteRows = false;
            this.dgvDetaljiOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiOtpremnice.Location = new System.Drawing.Point(21, 43);
            this.dgvDetaljiOtpremnice.MultiSelect = false;
            this.dgvDetaljiOtpremnice.Name = "dgvDetaljiOtpremnice";
            this.dgvDetaljiOtpremnice.ReadOnly = true;
            this.dgvDetaljiOtpremnice.RowTemplate.Height = 24;
            this.dgvDetaljiOtpremnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiOtpremnice.Size = new System.Drawing.Size(754, 331);
            this.dgvDetaljiOtpremnice.TabIndex = 10;
            // 
            // gumbPovratakOtp
            // 
            this.gumbPovratakOtp.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakOtp.Customization = "";
            this.gumbPovratakOtp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakOtp.Image = null;
            this.gumbPovratakOtp.Location = new System.Drawing.Point(21, 394);
            this.gumbPovratakOtp.Name = "gumbPovratakOtp";
            this.gumbPovratakOtp.NoRounding = false;
            this.gumbPovratakOtp.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakOtp.TabIndex = 9;
            this.gumbPovratakOtp.Text = "Povratak";
            this.gumbPovratakOtp.Transparent = false;
            this.gumbPovratakOtp.Click += new System.EventHandler(this.gumbPovratakOtp_Click);
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
            this.gumbic.Text = "nyX_ControlBox1";
            this.gumbic.Transparent = false;
            // 
            // formOtpremnicaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temaOtpremnicaDetalji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOtpremnicaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtpremnicaDetalji";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formOtpremnicaDetalji_Load);
            this.temaOtpremnicaDetalji.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiOtpremnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme temaOtpremnicaDetalji;
        private CS_ClassLibraryTester.NYX_ControlBox gumbic;
        private System.Windows.Forms.DataGridView dgvDetaljiOtpremnice;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakOtp;
    }
}