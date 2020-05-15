namespace FutureStock
{
    partial class formPosiljke
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.temaPosiljke = new CS_ClassLibraryTester.NYX_Theme();
            this.nyX_ControlBox1 = new CS_ClassLibraryTester.NYX_ControlBox();
            this.gumbZaprimi = new CS_ClassLibraryTester.NYX_Button();
            this.gumbPovratakPos = new CS_ClassLibraryTester.NYX_Button();
            this.grpZaprimljene = new CS_ClassLibraryTester.NYX_GroupBox();
            this.dgvZaprimljene = new System.Windows.Forms.DataGridView();
            this.grpNezaprimljene = new CS_ClassLibraryTester.NYX_GroupBox();
            this.dgvNezaprimljene = new System.Windows.Forms.DataGridView();
            this.temaPosiljke.SuspendLayout();
            this.grpZaprimljene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljene)).BeginInit();
            this.grpNezaprimljene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNezaprimljene)).BeginInit();
            this.SuspendLayout();
            // 
            // temaPosiljke
            // 
            this.temaPosiljke.Animated = true;
            this.temaPosiljke.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.temaPosiljke.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.temaPosiljke.Controls.Add(this.nyX_ControlBox1);
            this.temaPosiljke.Controls.Add(this.gumbZaprimi);
            this.temaPosiljke.Controls.Add(this.gumbPovratakPos);
            this.temaPosiljke.Controls.Add(this.grpZaprimljene);
            this.temaPosiljke.Controls.Add(this.grpNezaprimljene);
            this.temaPosiljke.Customization = "";
            this.temaPosiljke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temaPosiljke.Font = new System.Drawing.Font("Verdana", 8F);
            this.temaPosiljke.Image = null;
            this.temaPosiljke.Location = new System.Drawing.Point(0, 0);
            this.temaPosiljke.Movable = true;
            this.temaPosiljke.Name = "temaPosiljke";
            this.temaPosiljke.NoRounding = false;
            this.temaPosiljke.Sizable = true;
            this.temaPosiljke.Size = new System.Drawing.Size(800, 450);
            this.temaPosiljke.SmartBounds = true;
            this.temaPosiljke.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.temaPosiljke.TabIndex = 0;
            this.temaPosiljke.Text = "Narudžbenice";
            this.temaPosiljke.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.temaPosiljke.Transparent = false;
            // 
            // nyX_ControlBox1
            // 
            this.nyX_ControlBox1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_ControlBox1.Customization = "";
            this.nyX_ControlBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_ControlBox1.Image = null;
            this.nyX_ControlBox1.Location = new System.Drawing.Point(744, 3);
            this.nyX_ControlBox1.Name = "nyX_ControlBox1";
            this.nyX_ControlBox1.NoRounding = false;
            this.nyX_ControlBox1.Size = new System.Drawing.Size(44, 20);
            this.nyX_ControlBox1.TabIndex = 8;
            this.nyX_ControlBox1.Text = "nyX_ControlBox1";
            this.nyX_ControlBox1.Transparent = false;
            // 
            // gumbZaprimi
            // 
            this.gumbZaprimi.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbZaprimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbZaprimi.Customization = "";
            this.gumbZaprimi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbZaprimi.Image = null;
            this.gumbZaprimi.Location = new System.Drawing.Point(345, 402);
            this.gumbZaprimi.Name = "gumbZaprimi";
            this.gumbZaprimi.NoRounding = false;
            this.gumbZaprimi.Size = new System.Drawing.Size(110, 36);
            this.gumbZaprimi.TabIndex = 7;
            this.gumbZaprimi.Text = "Zaprimi";
            this.gumbZaprimi.Transparent = false;
            this.gumbZaprimi.Click += new System.EventHandler(this.gumbZaprimi_Click);
            // 
            // gumbPovratakPos
            // 
            this.gumbPovratakPos.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakPos.Customization = "";
            this.gumbPovratakPos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakPos.Image = null;
            this.gumbPovratakPos.Location = new System.Drawing.Point(12, 402);
            this.gumbPovratakPos.Name = "gumbPovratakPos";
            this.gumbPovratakPos.NoRounding = false;
            this.gumbPovratakPos.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakPos.TabIndex = 6;
            this.gumbPovratakPos.Text = "Povratak";
            this.gumbPovratakPos.Transparent = false;
            this.gumbPovratakPos.Click += new System.EventHandler(this.gumbPovratakPos_Click);
            // 
            // grpZaprimljene
            // 
            this.grpZaprimljene.Animated = true;
            this.grpZaprimljene.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grpZaprimljene.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.grpZaprimljene.Controls.Add(this.dgvZaprimljene);
            this.grpZaprimljene.Customization = "";
            this.grpZaprimljene.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpZaprimljene.Image = null;
            this.grpZaprimljene.Location = new System.Drawing.Point(23, 224);
            this.grpZaprimljene.Movable = true;
            this.grpZaprimljene.Name = "grpZaprimljene";
            this.grpZaprimljene.NoRounding = false;
            this.grpZaprimljene.Sizable = true;
            this.grpZaprimljene.Size = new System.Drawing.Size(753, 172);
            this.grpZaprimljene.SmartBounds = true;
            this.grpZaprimljene.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.grpZaprimljene.TabIndex = 1;
            this.grpZaprimljene.Text = "Zaprimljene";
            this.grpZaprimljene.TransparencyKey = System.Drawing.Color.Empty;
            this.grpZaprimljene.Transparent = false;
            // 
            // dgvZaprimljene
            // 
            this.dgvZaprimljene.AllowUserToAddRows = false;
            this.dgvZaprimljene.AllowUserToDeleteRows = false;
            this.dgvZaprimljene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaprimljene.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaprimljene.Location = new System.Drawing.Point(3, 30);
            this.dgvZaprimljene.MultiSelect = false;
            this.dgvZaprimljene.Name = "dgvZaprimljene";
            this.dgvZaprimljene.ReadOnly = true;
            this.dgvZaprimljene.RowTemplate.Height = 24;
            this.dgvZaprimljene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaprimljene.Size = new System.Drawing.Size(747, 139);
            this.dgvZaprimljene.TabIndex = 2;
            // 
            // grpNezaprimljene
            // 
            this.grpNezaprimljene.Animated = true;
            this.grpNezaprimljene.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grpNezaprimljene.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.grpNezaprimljene.Controls.Add(this.dgvNezaprimljene);
            this.grpNezaprimljene.Customization = "";
            this.grpNezaprimljene.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpNezaprimljene.Image = null;
            this.grpNezaprimljene.Location = new System.Drawing.Point(23, 38);
            this.grpNezaprimljene.Movable = true;
            this.grpNezaprimljene.Name = "grpNezaprimljene";
            this.grpNezaprimljene.NoRounding = false;
            this.grpNezaprimljene.Sizable = true;
            this.grpNezaprimljene.Size = new System.Drawing.Size(753, 180);
            this.grpNezaprimljene.SmartBounds = true;
            this.grpNezaprimljene.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.grpNezaprimljene.TabIndex = 0;
            this.grpNezaprimljene.Text = "Nezaprimljene";
            this.grpNezaprimljene.TransparencyKey = System.Drawing.Color.Empty;
            this.grpNezaprimljene.Transparent = false;
            // 
            // dgvNezaprimljene
            // 
            this.dgvNezaprimljene.AllowUserToAddRows = false;
            this.dgvNezaprimljene.AllowUserToDeleteRows = false;
            this.dgvNezaprimljene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNezaprimljene.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNezaprimljene.Location = new System.Drawing.Point(3, 30);
            this.dgvNezaprimljene.MultiSelect = false;
            this.dgvNezaprimljene.Name = "dgvNezaprimljene";
            this.dgvNezaprimljene.ReadOnly = true;
            this.dgvNezaprimljene.RowTemplate.Height = 24;
            this.dgvNezaprimljene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNezaprimljene.Size = new System.Drawing.Size(747, 147);
            this.dgvNezaprimljene.TabIndex = 0;
            // 
            // formPosiljke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temaPosiljke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPosiljke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pošiljke";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Pošiljke_Load);
            this.temaPosiljke.ResumeLayout(false);
            this.grpZaprimljene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljene)).EndInit();
            this.grpNezaprimljene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNezaprimljene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme temaPosiljke;
        private CS_ClassLibraryTester.NYX_GroupBox grpZaprimljene;
        private System.Windows.Forms.DataGridView dgvZaprimljene;
        private CS_ClassLibraryTester.NYX_GroupBox grpNezaprimljene;
        private System.Windows.Forms.DataGridView dgvNezaprimljene;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakPos;
        private CS_ClassLibraryTester.NYX_Button gumbZaprimi;
        private CS_ClassLibraryTester.NYX_ControlBox nyX_ControlBox1;
    }
}