namespace FutureStock
{
    partial class formEntiteti
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
            this.temaEntiteti = new CS_ClassLibraryTester.NYX_Theme();
            this.gumbici = new CS_ClassLibraryTester.NYX_ControlBox();
            this.tabKompletno = new CS_ClassLibraryTester.CrystalClearTabControl();
            this.tabDobavljaci = new System.Windows.Forms.TabPage();
            this.gumbPovratakDob = new CS_ClassLibraryTester.NYX_Button();
            this.gumbBrisiDob = new CS_ClassLibraryTester.NYX_Button();
            this.gumbKreirajDob = new CS_ClassLibraryTester.NYX_Button();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.tabProizvodi = new System.Windows.Forms.TabPage();
            this.gumbPovratakPro = new CS_ClassLibraryTester.NYX_Button();
            this.gumbBrisiPro = new CS_ClassLibraryTester.NYX_Button();
            this.gumbKreirajPro = new CS_ClassLibraryTester.NYX_Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.tabKategorije = new System.Windows.Forms.TabPage();
            this.gumbPovratakKat = new CS_ClassLibraryTester.NYX_Button();
            this.gumbBrisiKat = new CS_ClassLibraryTester.NYX_Button();
            this.gumbKreirajKat = new CS_ClassLibraryTester.NYX_Button();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.tabNarudzbenice = new System.Windows.Forms.TabPage();
            this.gumbDetalji = new CS_ClassLibraryTester.NYX_Button();
            this.gumbPovratakNar = new CS_ClassLibraryTester.NYX_Button();
            this.gumbBrisiNar = new CS_ClassLibraryTester.NYX_Button();
            this.gumbKreirajNar = new CS_ClassLibraryTester.NYX_Button();
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.tabOtpremnice = new System.Windows.Forms.TabPage();
            this.gumbDetalji2 = new CS_ClassLibraryTester.NYX_Button();
            this.gumbPovratakOtp = new CS_ClassLibraryTester.NYX_Button();
            this.gumbBrisiOtp = new CS_ClassLibraryTester.NYX_Button();
            this.gumbKreirajOtp = new CS_ClassLibraryTester.NYX_Button();
            this.dgvOtpremnice = new System.Windows.Forms.DataGridView();
            this.temaEntiteti.SuspendLayout();
            this.tabKompletno.SuspendLayout();
            this.tabDobavljaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.tabProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.tabKategorije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.tabNarudzbenice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            this.tabOtpremnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).BeginInit();
            this.SuspendLayout();
            // 
            // temaEntiteti
            // 
            this.temaEntiteti.Animated = true;
            this.temaEntiteti.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.temaEntiteti.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.temaEntiteti.Controls.Add(this.gumbici);
            this.temaEntiteti.Controls.Add(this.tabKompletno);
            this.temaEntiteti.Customization = "";
            this.temaEntiteti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temaEntiteti.Font = new System.Drawing.Font("Verdana", 8F);
            this.temaEntiteti.Image = null;
            this.temaEntiteti.Location = new System.Drawing.Point(0, 0);
            this.temaEntiteti.Movable = true;
            this.temaEntiteti.Name = "temaEntiteti";
            this.temaEntiteti.NoRounding = false;
            this.temaEntiteti.Sizable = true;
            this.temaEntiteti.Size = new System.Drawing.Size(800, 450);
            this.temaEntiteti.SmartBounds = true;
            this.temaEntiteti.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.temaEntiteti.TabIndex = 0;
            this.temaEntiteti.Text = "Rad s entitetima";
            this.temaEntiteti.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.temaEntiteti.Transparent = false;
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
            this.gumbici.TabIndex = 1;
            this.gumbici.Text = "gumbici";
            this.gumbici.Transparent = false;
            // 
            // tabKompletno
            // 
            this.tabKompletno.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabKompletno.Controls.Add(this.tabDobavljaci);
            this.tabKompletno.Controls.Add(this.tabProizvodi);
            this.tabKompletno.Controls.Add(this.tabKategorije);
            this.tabKompletno.Controls.Add(this.tabNarudzbenice);
            this.tabKompletno.Controls.Add(this.tabOtpremnice);
            this.tabKompletno.Location = new System.Drawing.Point(12, 27);
            this.tabKompletno.Name = "tabKompletno";
            this.tabKompletno.SelectedIndex = 0;
            this.tabKompletno.Size = new System.Drawing.Size(776, 411);
            this.tabKompletno.TabIndex = 0;
            this.tabKompletno.SelectedIndexChanged += new System.EventHandler(this.tabKompletno_SelectedIndexChanged);
            // 
            // tabDobavljaci
            // 
            this.tabDobavljaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabDobavljaci.Controls.Add(this.gumbPovratakDob);
            this.tabDobavljaci.Controls.Add(this.gumbBrisiDob);
            this.tabDobavljaci.Controls.Add(this.gumbKreirajDob);
            this.tabDobavljaci.Controls.Add(this.dgvDobavljaci);
            this.tabDobavljaci.ForeColor = System.Drawing.Color.Black;
            this.tabDobavljaci.Location = new System.Drawing.Point(4, 29);
            this.tabDobavljaci.Name = "tabDobavljaci";
            this.tabDobavljaci.Padding = new System.Windows.Forms.Padding(3);
            this.tabDobavljaci.Size = new System.Drawing.Size(768, 378);
            this.tabDobavljaci.TabIndex = 0;
            this.tabDobavljaci.Text = "Dobavljači";
            // 
            // gumbPovratakDob
            // 
            this.gumbPovratakDob.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakDob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakDob.Customization = "";
            this.gumbPovratakDob.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakDob.Image = null;
            this.gumbPovratakDob.Location = new System.Drawing.Point(6, 336);
            this.gumbPovratakDob.Name = "gumbPovratakDob";
            this.gumbPovratakDob.NoRounding = false;
            this.gumbPovratakDob.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakDob.TabIndex = 6;
            this.gumbPovratakDob.Text = "Povratak";
            this.gumbPovratakDob.Transparent = false;
            this.gumbPovratakDob.Click += new System.EventHandler(this.gumbPovratakDob_Click);
            // 
            // gumbBrisiDob
            // 
            this.gumbBrisiDob.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbBrisiDob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbBrisiDob.Customization = "";
            this.gumbBrisiDob.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbBrisiDob.Image = null;
            this.gumbBrisiDob.Location = new System.Drawing.Point(392, 336);
            this.gumbBrisiDob.Name = "gumbBrisiDob";
            this.gumbBrisiDob.NoRounding = false;
            this.gumbBrisiDob.Size = new System.Drawing.Size(114, 36);
            this.gumbBrisiDob.TabIndex = 2;
            this.gumbBrisiDob.Text = "Briši";
            this.gumbBrisiDob.Transparent = false;
            this.gumbBrisiDob.Click += new System.EventHandler(this.gumbBrisiDob_Click);
            // 
            // gumbKreirajDob
            // 
            this.gumbKreirajDob.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbKreirajDob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbKreirajDob.Customization = "";
            this.gumbKreirajDob.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbKreirajDob.Image = null;
            this.gumbKreirajDob.Location = new System.Drawing.Point(261, 336);
            this.gumbKreirajDob.Name = "gumbKreirajDob";
            this.gumbKreirajDob.NoRounding = false;
            this.gumbKreirajDob.Size = new System.Drawing.Size(125, 36);
            this.gumbKreirajDob.TabIndex = 1;
            this.gumbKreirajDob.Text = "Kreiraj";
            this.gumbKreirajDob.Transparent = false;
            this.gumbKreirajDob.Click += new System.EventHandler(this.gumbKreirajDob_Click);
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Location = new System.Drawing.Point(0, 0);
            this.dgvDobavljaci.MultiSelect = false;
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.ReadOnly = true;
            this.dgvDobavljaci.RowTemplate.Height = 24;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(768, 330);
            this.dgvDobavljaci.TabIndex = 0;
            // 
            // tabProizvodi
            // 
            this.tabProizvodi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabProizvodi.Controls.Add(this.gumbPovratakPro);
            this.tabProizvodi.Controls.Add(this.gumbBrisiPro);
            this.tabProizvodi.Controls.Add(this.gumbKreirajPro);
            this.tabProizvodi.Controls.Add(this.dgvProizvodi);
            this.tabProizvodi.Location = new System.Drawing.Point(4, 29);
            this.tabProizvodi.Name = "tabProizvodi";
            this.tabProizvodi.Padding = new System.Windows.Forms.Padding(3);
            this.tabProizvodi.Size = new System.Drawing.Size(768, 378);
            this.tabProizvodi.TabIndex = 1;
            this.tabProizvodi.Text = "Proizvodi";
            // 
            // gumbPovratakPro
            // 
            this.gumbPovratakPro.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakPro.Customization = "";
            this.gumbPovratakPro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakPro.Image = null;
            this.gumbPovratakPro.Location = new System.Drawing.Point(6, 336);
            this.gumbPovratakPro.Name = "gumbPovratakPro";
            this.gumbPovratakPro.NoRounding = false;
            this.gumbPovratakPro.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakPro.TabIndex = 5;
            this.gumbPovratakPro.Text = "Povratak";
            this.gumbPovratakPro.Transparent = false;
            this.gumbPovratakPro.Click += new System.EventHandler(this.gumbPovratakPro_Click);
            // 
            // gumbBrisiPro
            // 
            this.gumbBrisiPro.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbBrisiPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbBrisiPro.Customization = "";
            this.gumbBrisiPro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbBrisiPro.Image = null;
            this.gumbBrisiPro.Location = new System.Drawing.Point(392, 336);
            this.gumbBrisiPro.Name = "gumbBrisiPro";
            this.gumbBrisiPro.NoRounding = false;
            this.gumbBrisiPro.Size = new System.Drawing.Size(114, 36);
            this.gumbBrisiPro.TabIndex = 4;
            this.gumbBrisiPro.Text = "Briši";
            this.gumbBrisiPro.Transparent = false;
            this.gumbBrisiPro.Click += new System.EventHandler(this.gumbBrisiPro_Click);
            // 
            // gumbKreirajPro
            // 
            this.gumbKreirajPro.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbKreirajPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbKreirajPro.Customization = "";
            this.gumbKreirajPro.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbKreirajPro.Image = null;
            this.gumbKreirajPro.Location = new System.Drawing.Point(261, 336);
            this.gumbKreirajPro.Name = "gumbKreirajPro";
            this.gumbKreirajPro.NoRounding = false;
            this.gumbKreirajPro.Size = new System.Drawing.Size(125, 36);
            this.gumbKreirajPro.TabIndex = 3;
            this.gumbKreirajPro.Text = "Kreiraj";
            this.gumbKreirajPro.Transparent = false;
            this.gumbKreirajPro.Click += new System.EventHandler(this.gumbKreirajPro_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.EnableHeadersVisualStyles = false;
            this.dgvProizvodi.Location = new System.Drawing.Point(0, 0);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(768, 330);
            this.dgvProizvodi.TabIndex = 1;
            // 
            // tabKategorije
            // 
            this.tabKategorije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabKategorije.Controls.Add(this.gumbPovratakKat);
            this.tabKategorije.Controls.Add(this.gumbBrisiKat);
            this.tabKategorije.Controls.Add(this.gumbKreirajKat);
            this.tabKategorije.Controls.Add(this.dgvKategorije);
            this.tabKategorije.Location = new System.Drawing.Point(4, 29);
            this.tabKategorije.Name = "tabKategorije";
            this.tabKategorije.Padding = new System.Windows.Forms.Padding(3);
            this.tabKategorije.Size = new System.Drawing.Size(768, 378);
            this.tabKategorije.TabIndex = 2;
            this.tabKategorije.Text = "Kategorije";
            // 
            // gumbPovratakKat
            // 
            this.gumbPovratakKat.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakKat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakKat.Customization = "";
            this.gumbPovratakKat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakKat.Image = null;
            this.gumbPovratakKat.Location = new System.Drawing.Point(6, 336);
            this.gumbPovratakKat.Name = "gumbPovratakKat";
            this.gumbPovratakKat.NoRounding = false;
            this.gumbPovratakKat.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakKat.TabIndex = 6;
            this.gumbPovratakKat.Text = "Povratak";
            this.gumbPovratakKat.Transparent = false;
            this.gumbPovratakKat.Click += new System.EventHandler(this.gumbPovratakKat_Click);
            // 
            // gumbBrisiKat
            // 
            this.gumbBrisiKat.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbBrisiKat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbBrisiKat.Customization = "";
            this.gumbBrisiKat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbBrisiKat.Image = null;
            this.gumbBrisiKat.Location = new System.Drawing.Point(393, 336);
            this.gumbBrisiKat.Name = "gumbBrisiKat";
            this.gumbBrisiKat.NoRounding = false;
            this.gumbBrisiKat.Size = new System.Drawing.Size(114, 36);
            this.gumbBrisiKat.TabIndex = 4;
            this.gumbBrisiKat.Text = "Briši";
            this.gumbBrisiKat.Transparent = false;
            this.gumbBrisiKat.Click += new System.EventHandler(this.gumbBrisiKat_Click);
            // 
            // gumbKreirajKat
            // 
            this.gumbKreirajKat.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbKreirajKat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbKreirajKat.Customization = "";
            this.gumbKreirajKat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbKreirajKat.Image = null;
            this.gumbKreirajKat.Location = new System.Drawing.Point(262, 336);
            this.gumbKreirajKat.Name = "gumbKreirajKat";
            this.gumbKreirajKat.NoRounding = false;
            this.gumbKreirajKat.Size = new System.Drawing.Size(125, 36);
            this.gumbKreirajKat.TabIndex = 3;
            this.gumbKreirajKat.Text = "Kreiraj";
            this.gumbKreirajKat.Transparent = false;
            this.gumbKreirajKat.Click += new System.EventHandler(this.gumbKreirajKat_Click);
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToAddRows = false;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.EnableHeadersVisualStyles = false;
            this.dgvKategorije.Location = new System.Drawing.Point(0, 0);
            this.dgvKategorije.MultiSelect = false;
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.RowTemplate.Height = 24;
            this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorije.Size = new System.Drawing.Size(768, 330);
            this.dgvKategorije.TabIndex = 2;
            // 
            // tabNarudzbenice
            // 
            this.tabNarudzbenice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabNarudzbenice.Controls.Add(this.gumbDetalji);
            this.tabNarudzbenice.Controls.Add(this.gumbPovratakNar);
            this.tabNarudzbenice.Controls.Add(this.gumbBrisiNar);
            this.tabNarudzbenice.Controls.Add(this.gumbKreirajNar);
            this.tabNarudzbenice.Controls.Add(this.dgvNarudzbenice);
            this.tabNarudzbenice.Location = new System.Drawing.Point(4, 29);
            this.tabNarudzbenice.Name = "tabNarudzbenice";
            this.tabNarudzbenice.Padding = new System.Windows.Forms.Padding(3);
            this.tabNarudzbenice.Size = new System.Drawing.Size(768, 378);
            this.tabNarudzbenice.TabIndex = 3;
            this.tabNarudzbenice.Text = "Narudžbenice";
            // 
            // gumbDetalji
            // 
            this.gumbDetalji.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbDetalji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbDetalji.Customization = "";
            this.gumbDetalji.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbDetalji.Image = null;
            this.gumbDetalji.Location = new System.Drawing.Point(648, 336);
            this.gumbDetalji.Name = "gumbDetalji";
            this.gumbDetalji.NoRounding = false;
            this.gumbDetalji.Size = new System.Drawing.Size(114, 36);
            this.gumbDetalji.TabIndex = 7;
            this.gumbDetalji.Text = "Detalji";
            this.gumbDetalji.Transparent = false;
            this.gumbDetalji.Click += new System.EventHandler(this.gumbDetalji_Click);
            // 
            // gumbPovratakNar
            // 
            this.gumbPovratakNar.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakNar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakNar.Customization = "";
            this.gumbPovratakNar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakNar.Image = null;
            this.gumbPovratakNar.Location = new System.Drawing.Point(6, 336);
            this.gumbPovratakNar.Name = "gumbPovratakNar";
            this.gumbPovratakNar.NoRounding = false;
            this.gumbPovratakNar.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakNar.TabIndex = 6;
            this.gumbPovratakNar.Text = "Povratak";
            this.gumbPovratakNar.Transparent = false;
            this.gumbPovratakNar.Click += new System.EventHandler(this.gumbPovratakNar_Click);
            // 
            // gumbBrisiNar
            // 
            this.gumbBrisiNar.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbBrisiNar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbBrisiNar.Customization = "";
            this.gumbBrisiNar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbBrisiNar.Image = null;
            this.gumbBrisiNar.Location = new System.Drawing.Point(391, 336);
            this.gumbBrisiNar.Name = "gumbBrisiNar";
            this.gumbBrisiNar.NoRounding = false;
            this.gumbBrisiNar.Size = new System.Drawing.Size(114, 36);
            this.gumbBrisiNar.TabIndex = 5;
            this.gumbBrisiNar.Text = "Briši";
            this.gumbBrisiNar.Transparent = false;
            this.gumbBrisiNar.Click += new System.EventHandler(this.gumbBrisiNar_Click);
            // 
            // gumbKreirajNar
            // 
            this.gumbKreirajNar.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbKreirajNar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbKreirajNar.Customization = "";
            this.gumbKreirajNar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbKreirajNar.Image = null;
            this.gumbKreirajNar.Location = new System.Drawing.Point(260, 336);
            this.gumbKreirajNar.Name = "gumbKreirajNar";
            this.gumbKreirajNar.NoRounding = false;
            this.gumbKreirajNar.Size = new System.Drawing.Size(125, 36);
            this.gumbKreirajNar.TabIndex = 4;
            this.gumbKreirajNar.Text = "Kreiraj";
            this.gumbKreirajNar.Transparent = false;
            this.gumbKreirajNar.Click += new System.EventHandler(this.gumbKreirajNar_Click);
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.AllowUserToAddRows = false;
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.EnableHeadersVisualStyles = false;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(0, 0);
            this.dgvNarudzbenice.MultiSelect = false;
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.ReadOnly = true;
            this.dgvNarudzbenice.RowTemplate.Height = 24;
            this.dgvNarudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbenice.Size = new System.Drawing.Size(768, 330);
            this.dgvNarudzbenice.TabIndex = 3;
            // 
            // tabOtpremnice
            // 
            this.tabOtpremnice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.tabOtpremnice.Controls.Add(this.gumbDetalji2);
            this.tabOtpremnice.Controls.Add(this.gumbPovratakOtp);
            this.tabOtpremnice.Controls.Add(this.gumbBrisiOtp);
            this.tabOtpremnice.Controls.Add(this.gumbKreirajOtp);
            this.tabOtpremnice.Controls.Add(this.dgvOtpremnice);
            this.tabOtpremnice.Location = new System.Drawing.Point(4, 29);
            this.tabOtpremnice.Name = "tabOtpremnice";
            this.tabOtpremnice.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtpremnice.Size = new System.Drawing.Size(768, 378);
            this.tabOtpremnice.TabIndex = 4;
            this.tabOtpremnice.Text = "Otpremnice";
            // 
            // gumbDetalji2
            // 
            this.gumbDetalji2.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbDetalji2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbDetalji2.Customization = "";
            this.gumbDetalji2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbDetalji2.Image = null;
            this.gumbDetalji2.Location = new System.Drawing.Point(648, 336);
            this.gumbDetalji2.Name = "gumbDetalji2";
            this.gumbDetalji2.NoRounding = false;
            this.gumbDetalji2.Size = new System.Drawing.Size(114, 36);
            this.gumbDetalji2.TabIndex = 8;
            this.gumbDetalji2.Text = "Detalji";
            this.gumbDetalji2.Transparent = false;
            this.gumbDetalji2.Click += new System.EventHandler(this.gumbDetalji2_Click);
            // 
            // gumbPovratakOtp
            // 
            this.gumbPovratakOtp.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbPovratakOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbPovratakOtp.Customization = "";
            this.gumbPovratakOtp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPovratakOtp.Image = null;
            this.gumbPovratakOtp.Location = new System.Drawing.Point(6, 336);
            this.gumbPovratakOtp.Name = "gumbPovratakOtp";
            this.gumbPovratakOtp.NoRounding = false;
            this.gumbPovratakOtp.Size = new System.Drawing.Size(110, 36);
            this.gumbPovratakOtp.TabIndex = 6;
            this.gumbPovratakOtp.Text = "Povratak";
            this.gumbPovratakOtp.Transparent = false;
            this.gumbPovratakOtp.Click += new System.EventHandler(this.gumbPovratakOtp_Click);
            // 
            // gumbBrisiOtp
            // 
            this.gumbBrisiOtp.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbBrisiOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbBrisiOtp.Customization = "";
            this.gumbBrisiOtp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbBrisiOtp.Image = null;
            this.gumbBrisiOtp.Location = new System.Drawing.Point(392, 336);
            this.gumbBrisiOtp.Name = "gumbBrisiOtp";
            this.gumbBrisiOtp.NoRounding = false;
            this.gumbBrisiOtp.Size = new System.Drawing.Size(114, 36);
            this.gumbBrisiOtp.TabIndex = 5;
            this.gumbBrisiOtp.Text = "Briši";
            this.gumbBrisiOtp.Transparent = false;
            this.gumbBrisiOtp.Click += new System.EventHandler(this.gumbBrisiOtp_Click);
            // 
            // gumbKreirajOtp
            // 
            this.gumbKreirajOtp.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.gumbKreirajOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbKreirajOtp.Customization = "";
            this.gumbKreirajOtp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbKreirajOtp.Image = null;
            this.gumbKreirajOtp.Location = new System.Drawing.Point(261, 336);
            this.gumbKreirajOtp.Name = "gumbKreirajOtp";
            this.gumbKreirajOtp.NoRounding = false;
            this.gumbKreirajOtp.Size = new System.Drawing.Size(125, 36);
            this.gumbKreirajOtp.TabIndex = 4;
            this.gumbKreirajOtp.Text = "Kreiraj";
            this.gumbKreirajOtp.Transparent = false;
            this.gumbKreirajOtp.Click += new System.EventHandler(this.gumbKreirajOtp_Click);
            // 
            // dgvOtpremnice
            // 
            this.dgvOtpremnice.AllowUserToAddRows = false;
            this.dgvOtpremnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpremnice.EnableHeadersVisualStyles = false;
            this.dgvOtpremnice.Location = new System.Drawing.Point(0, 0);
            this.dgvOtpremnice.MultiSelect = false;
            this.dgvOtpremnice.Name = "dgvOtpremnice";
            this.dgvOtpremnice.ReadOnly = true;
            this.dgvOtpremnice.RowTemplate.Height = 24;
            this.dgvOtpremnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOtpremnice.Size = new System.Drawing.Size(768, 330);
            this.dgvOtpremnice.TabIndex = 3;
            // 
            // formEntiteti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temaEntiteti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEntiteti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KreiranjeEntiteta";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formEntiteti_Load);
            this.temaEntiteti.ResumeLayout(false);
            this.tabKompletno.ResumeLayout(false);
            this.tabDobavljaci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.tabProizvodi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.tabKategorije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.tabNarudzbenice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            this.tabOtpremnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremnice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme temaEntiteti;
        private CS_ClassLibraryTester.CrystalClearTabControl tabKompletno;
        private System.Windows.Forms.TabPage tabDobavljaci;
        private System.Windows.Forms.TabPage tabProizvodi;
        private System.Windows.Forms.TabPage tabKategorije;
        private System.Windows.Forms.TabPage tabNarudzbenice;
        private System.Windows.Forms.TabPage tabOtpremnice;
        private CS_ClassLibraryTester.NYX_ControlBox gumbici;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.DataGridView dgvOtpremnice;
        private CS_ClassLibraryTester.NYX_Button gumbBrisiDob;
        private CS_ClassLibraryTester.NYX_Button gumbKreirajDob;
        private CS_ClassLibraryTester.NYX_Button gumbBrisiPro;
        private CS_ClassLibraryTester.NYX_Button gumbKreirajPro;
        private CS_ClassLibraryTester.NYX_Button gumbBrisiKat;
        private CS_ClassLibraryTester.NYX_Button gumbKreirajKat;
        private CS_ClassLibraryTester.NYX_Button gumbBrisiNar;
        private CS_ClassLibraryTester.NYX_Button gumbKreirajNar;
        private CS_ClassLibraryTester.NYX_Button gumbBrisiOtp;
        private CS_ClassLibraryTester.NYX_Button gumbKreirajOtp;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakDob;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakPro;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakKat;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakNar;
        private CS_ClassLibraryTester.NYX_Button gumbPovratakOtp;
        private CS_ClassLibraryTester.NYX_Button gumbDetalji;
        private CS_ClassLibraryTester.NYX_Button gumbDetalji2;
    }
}