namespace FutureStock
{
    partial class formStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.temaStatistika = new CS_ClassLibraryTester.NYX_Theme();
            this.btnPovratak = new CS_ClassLibraryTester.NYX_Button();
            this.gumbic = new CS_ClassLibraryTester.NYX_ControlBox();
            this.graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temaStatistika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graf)).BeginInit();
            this.SuspendLayout();
            // 
            // temaStatistika
            // 
            this.temaStatistika.Animated = true;
            this.temaStatistika.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.temaStatistika.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.temaStatistika.Controls.Add(this.btnPovratak);
            this.temaStatistika.Controls.Add(this.graf);
            this.temaStatistika.Controls.Add(this.gumbic);
            this.temaStatistika.Customization = "";
            this.temaStatistika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temaStatistika.Font = new System.Drawing.Font("Verdana", 8F);
            this.temaStatistika.Image = null;
            this.temaStatistika.Location = new System.Drawing.Point(0, 0);
            this.temaStatistika.Movable = true;
            this.temaStatistika.Name = "temaStatistika";
            this.temaStatistika.NoRounding = false;
            this.temaStatistika.Sizable = true;
            this.temaStatistika.Size = new System.Drawing.Size(800, 450);
            this.temaStatistika.SmartBounds = true;
            this.temaStatistika.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.temaStatistika.TabIndex = 0;
            this.temaStatistika.Text = "Skladišna statistika";
            this.temaStatistika.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.temaStatistika.Transparent = false;
            // 
            // btnPovratak
            // 
            this.btnPovratak.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.btnPovratak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPovratak.Customization = "";
            this.btnPovratak.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Image = null;
            this.btnPovratak.Location = new System.Drawing.Point(14, 396);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.NoRounding = false;
            this.btnPovratak.Size = new System.Drawing.Size(129, 39);
            this.btnPovratak.TabIndex = 14;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.Transparent = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
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
            // graf
            // 
            chartArea1.Name = "ChartArea1";
            this.graf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graf.Legends.Add(legend1);
            this.graf.Location = new System.Drawing.Point(12, 30);
            this.graf.Name = "graf";
            this.graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "X";
            series1.YValueMembers = "Y";
            this.graf.Series.Add(series1);
            this.graf.Size = new System.Drawing.Size(776, 408);
            this.graf.TabIndex = 1;
            this.graf.Text = "chart1";
            // 
            // formStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temaStatistika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formStatistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.formStatistika_Load);
            this.temaStatistika.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Theme temaStatistika;
        private CS_ClassLibraryTester.NYX_ControlBox gumbic;
        private CS_ClassLibraryTester.NYX_Button btnPovratak;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf;
    }
}