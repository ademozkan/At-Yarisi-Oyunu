namespace WFAAtYarısı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.tmratkosusu = new System.Windows.Forms.Timer(this.components);
            this.lblFavoriAt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSahaSecimi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.cbBahis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOynanılanAt = new System.Windows.Forms.ComboBox();
            this.tmrKumSaha = new System.Windows.Forms.Timer(this.components);
            this.tmrToprakSaha = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAt1
            // 
            this.pbAt1.Enabled = false;
            this.pbAt1.Image = ((System.Drawing.Image)(resources.GetObject("pbAt1.Image")));
            this.pbAt1.Location = new System.Drawing.Point(12, 23);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(68, 50);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt1.TabIndex = 0;
            this.pbAt1.TabStop = false;
            this.pbAt1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbAt2
            // 
            this.pbAt2.Enabled = false;
            this.pbAt2.Image = ((System.Drawing.Image)(resources.GetObject("pbAt2.Image")));
            this.pbAt2.Location = new System.Drawing.Point(12, 100);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(68, 50);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt2.TabIndex = 1;
            this.pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.Enabled = false;
            this.pbAt3.Image = ((System.Drawing.Image)(resources.GetObject("pbAt3.Image")));
            this.pbAt3.Location = new System.Drawing.Point(12, 188);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(68, 54);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAt3.TabIndex = 2;
            this.pbAt3.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(612, 55);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(105, 54);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Yarışı Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.Location = new System.Drawing.Point(679, 1);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(49, 260);
            this.lblFinish.TabIndex = 5;
            this.lblFinish.Text = "FİNİSH";
            // 
            // tmratkosusu
            // 
            this.tmratkosusu.Interval = 50;
            this.tmratkosusu.Tick += new System.EventHandler(this.tmratkosusu_Tick);
            // 
            // lblFavoriAt
            // 
            this.lblFavoriAt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFavoriAt.Location = new System.Drawing.Point(317, 30);
            this.lblFavoriAt.Name = "lblFavoriAt";
            this.lblFavoriAt.Size = new System.Drawing.Size(119, 92);
            this.lblFavoriAt.TabIndex = 9;
            this.lblFavoriAt.Text = "FAVORİ AT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saha Seçimi";
            // 
            // cbSahaSecimi
            // 
            this.cbSahaSecimi.FormattingEnabled = true;
            this.cbSahaSecimi.Items.AddRange(new object[] {
            "Çim Saha",
            "Kum Saha",
            "Toprak Saha"});
            this.cbSahaSecimi.Location = new System.Drawing.Point(163, 39);
            this.cbSahaSecimi.Name = "cbSahaSecimi";
            this.cbSahaSecimi.Size = new System.Drawing.Size(121, 21);
            this.cbSahaSecimi.TabIndex = 13;
            this.cbSahaSecimi.SelectedIndexChanged += new System.EventHandler(this.cbSahaSecimi_SelectedIndexChanged);
            this.cbSahaSecimi.SizeChanged += new System.EventHandler(this.cbSahaSecimi_SizeChanged);
            this.cbSahaSecimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSahaSecimi_KeyPress);
            this.cbSahaSecimi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSahaSecimi_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bakiyeniz:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(84, 33);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(28, 13);
            this.lblBakiye.TabIndex = 15;
            this.lblBakiye.Text = "500";
            // 
            // cbBahis
            // 
            this.cbBahis.FormattingEnabled = true;
            this.cbBahis.Items.AddRange(new object[] {
            "100",
            "250",
            "500",
            "1000"});
            this.cbBahis.Location = new System.Drawing.Point(6, 76);
            this.cbBahis.Name = "cbBahis";
            this.cbBahis.Size = new System.Drawing.Size(121, 21);
            this.cbBahis.TabIndex = 16;
            this.cbBahis.SelectedIndexChanged += new System.EventHandler(this.cbBahis_SelectedIndexChanged);
            this.cbBahis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBahis_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bahis Miktarını Giriniz:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbOynanılanAt);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.lblFavoriAt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSahaSecimi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBahis);
            this.groupBox1.Controls.Add(this.lblBakiye);
            this.groupBox1.Location = new System.Drawing.Point(1, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 162);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEMLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Oynadığınız At";
            // 
            // cbOynanılanAt
            // 
            this.cbOynanılanAt.FormattingEnabled = true;
            this.cbOynanılanAt.Items.AddRange(new object[] {
            "1.AT",
            "2.AT",
            "3.AT"});
            this.cbOynanılanAt.Location = new System.Drawing.Point(163, 115);
            this.cbOynanılanAt.Name = "cbOynanılanAt";
            this.cbOynanılanAt.Size = new System.Drawing.Size(121, 21);
            this.cbOynanılanAt.TabIndex = 20;
            this.cbOynanılanAt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOynanılanAt_KeyPress);
            // 
            // tmrKumSaha
            // 
            this.tmrKumSaha.Interval = 50;
            this.tmrKumSaha.Tick += new System.EventHandler(this.tmrKumSaha_Tick);
            // 
            // tmrToprakSaha
            // 
            this.tmrToprakSaha.Interval = 50;
            this.tmrToprakSaha.Tick += new System.EventHandler(this.tmrToprakSaha_Tick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Location = new System.Drawing.Point(442, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 114);
            this.listBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Yarıs Sonucları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Timer tmratkosusu;
        private System.Windows.Forms.Label lblFavoriAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSahaSecimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.ComboBox cbBahis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOynanılanAt;
        private System.Windows.Forms.Timer tmrKumSaha;
        private System.Windows.Forms.Timer tmrToprakSaha;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}

