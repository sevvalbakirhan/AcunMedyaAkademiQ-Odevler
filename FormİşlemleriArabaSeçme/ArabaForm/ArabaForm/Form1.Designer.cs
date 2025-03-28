namespace ArabaForm
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAdiniz = new Label();
            lblSoyadiniz = new Label();
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            btnBilgileriGöster = new Button();
            ımageList1 = new ImageList(components);
            cmbPencere = new ComboBox();
            cmbRenk = new ComboBox();
            cmbKapı = new ComboBox();
            txtAdiniz = new TextBox();
            txtSoyadiniz = new TextBox();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            lblKapiSayisi = new Label();
            lblPencereSayisi = new Label();
            lblYakıt = new Label();
            cmbYakıt = new ComboBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblAdiniz
            // 
            lblAdiniz.AutoSize = true;
            lblAdiniz.Location = new Point(139, 34);
            lblAdiniz.Name = "lblAdiniz";
            lblAdiniz.Size = new Size(58, 20);
            lblAdiniz.TabIndex = 0;
            lblAdiniz.Text = "Adınız :";
            // 
            // lblSoyadiniz
            // 
            lblSoyadiniz.AutoSize = true;
            lblSoyadiniz.Location = new Point(139, 72);
            lblSoyadiniz.Name = "lblSoyadiniz";
            lblSoyadiniz.Size = new Size(80, 20);
            lblSoyadiniz.TabIndex = 1;
            lblSoyadiniz.Text = "Soyadınız :";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.BorderStyle = BorderStyle.Fixed3D;
            lblMarka.ImageAlign = ContentAlignment.TopLeft;
            lblMarka.Location = new Point(41, 36);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(67, 22);
            lblMarka.TabIndex = 2;
            lblMarka.Text = " Marka : ";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BorderStyle = BorderStyle.Fixed3D;
            lblModel.Location = new Point(41, 68);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(61, 22);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model :";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.BorderStyle = BorderStyle.Fixed3D;
            lblRenk.Location = new Point(39, 105);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(50, 22);
            lblRenk.TabIndex = 4;
            lblRenk.Text = "Renk :";
            // 
            // btnBilgileriGöster
            // 
            btnBilgileriGöster.ForeColor = Color.YellowGreen;
            btnBilgileriGöster.ImageAlign = ContentAlignment.BottomRight;
            btnBilgileriGöster.ImageIndex = 0;
            btnBilgileriGöster.ImageList = ımageList1;
            btnBilgileriGöster.Location = new Point(442, 378);
            btnBilgileriGöster.Name = "btnBilgileriGöster";
            btnBilgileriGöster.Size = new Size(240, 40);
            btnBilgileriGöster.TabIndex = 2;
            btnBilgileriGöster.Text = "Bilgileri Göster";
            btnBilgileriGöster.UseVisualStyleBackColor = true;
            btnBilgileriGöster.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Black;
            ımageList1.Images.SetKeyName(0, "correct.ico");
            ımageList1.Images.SetKeyName(1, "car_info.ico");
            ımageList1.Images.SetKeyName(2, "Door.ico");
            ımageList1.Images.SetKeyName(3, "Fuel.ico");
            ımageList1.Images.SetKeyName(4, "Palette.ico");
            ımageList1.Images.SetKeyName(5, "user.ico");
            ımageList1.Images.SetKeyName(6, "Window.ico");
            // 
            // cmbPencere
            // 
            cmbPencere.FlatStyle = FlatStyle.Flat;
            cmbPencere.FormattingEnabled = true;
            cmbPencere.Items.AddRange(new object[] { "2", "4", "6" });
            cmbPencere.Location = new Point(155, 182);
            cmbPencere.Name = "cmbPencere";
            cmbPencere.Size = new Size(151, 28);
            cmbPencere.TabIndex = 4;
            cmbPencere.SelectedIndexChanged += cmbPencere_SelectedIndexChanged;
            // 
            // cmbRenk
            // 
            cmbRenk.FlatStyle = FlatStyle.Flat;
            cmbRenk.FormattingEnabled = true;
            cmbRenk.Items.AddRange(new object[] { "Beyaz", "Siyah", "Kırmızı" });
            cmbRenk.Location = new Point(155, 105);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(151, 28);
            cmbRenk.TabIndex = 2;
            cmbRenk.SelectedIndexChanged += cmbRenk_SelectedIndexChanged;
            // 
            // cmbKapı
            // 
            cmbKapı.FlatStyle = FlatStyle.Flat;
            cmbKapı.FormattingEnabled = true;
            cmbKapı.Items.AddRange(new object[] { "2", "4", "6" });
            cmbKapı.Location = new Point(155, 148);
            cmbKapı.Name = "cmbKapı";
            cmbKapı.Size = new Size(151, 28);
            cmbKapı.TabIndex = 3;
            cmbKapı.SelectedIndexChanged += cmbKapı_SelectedIndexChanged;
            // 
            // txtAdiniz
            // 
            txtAdiniz.Location = new Point(238, 31);
            txtAdiniz.Name = "txtAdiniz";
            txtAdiniz.Size = new Size(151, 27);
            txtAdiniz.TabIndex = 0;
            txtAdiniz.TextChanged += textBox1_TextChanged;
            // 
            // txtSoyadiniz
            // 
            txtSoyadiniz.Location = new Point(238, 72);
            txtSoyadiniz.Name = "txtSoyadiniz";
            txtSoyadiniz.Size = new Size(151, 27);
            txtSoyadiniz.TabIndex = 1;
            txtSoyadiniz.TextChanged += txtSoyadiniz_TextChanged;
            // 
            // txtMarka
            // 
            txtMarka.BorderStyle = BorderStyle.FixedSingle;
            txtMarka.Location = new Point(155, 39);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(151, 27);
            txtMarka.TabIndex = 0;
            txtMarka.TextChanged += txtMarka_TextChanged;
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(155, 72);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(151, 27);
            txtModel.TabIndex = 1;
            txtModel.TextChanged += txtModel_TextChanged;
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.BorderStyle = BorderStyle.Fixed3D;
            lblKapiSayisi.Location = new Point(39, 142);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(89, 22);
            lblKapiSayisi.TabIndex = 13;
            lblKapiSayisi.Text = "Kapı Sayısı :";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.BorderStyle = BorderStyle.Fixed3D;
            lblPencereSayisi.Location = new Point(39, 185);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(110, 22);
            lblPencereSayisi.TabIndex = 14;
            lblPencereSayisi.Text = "Pencere Sayısı :";
            // 
            // lblYakıt
            // 
            lblYakıt.AutoSize = true;
            lblYakıt.BorderStyle = BorderStyle.Fixed3D;
            lblYakıt.Location = new Point(39, 223);
            lblYakıt.Name = "lblYakıt";
            lblYakıt.Size = new Size(70, 22);
            lblYakıt.TabIndex = 15;
            lblYakıt.Text = "Yakıt (L) :";
            // 
            // cmbYakıt
            // 
            cmbYakıt.FlatStyle = FlatStyle.Flat;
            cmbYakıt.FormattingEnabled = true;
            cmbYakıt.Items.AddRange(new object[] { "6,5", "7,8" });
            cmbYakıt.Location = new Point(155, 218);
            cmbYakıt.Name = "cmbYakıt";
            cmbYakıt.Size = new Size(151, 28);
            cmbYakıt.TabIndex = 5;
            cmbYakıt.SelectedIndexChanged += cmbYakıt_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lblAdiniz);
            groupBox1.Controls.Add(txtAdiniz);
            groupBox1.Controls.Add(lblSoyadiniz);
            groupBox1.Controls.Add(txtSoyadiniz);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(9, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişisel Bilgiler";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(6, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lblModel);
            groupBox2.Controls.Add(lblRenk);
            groupBox2.Controls.Add(cmbYakıt);
            groupBox2.Controls.Add(txtModel);
            groupBox2.Controls.Add(lblYakıt);
            groupBox2.Controls.Add(cmbRenk);
            groupBox2.Controls.Add(cmbPencere);
            groupBox2.Controls.Add(lblPencereSayisi);
            groupBox2.Controls.Add(lblMarka);
            groupBox2.Controls.Add(cmbKapı);
            groupBox2.Controls.Add(lblKapiSayisi);
            groupBox2.Controls.Add(txtMarka);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(9, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 261);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Araba Bilgileri";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Fuel;
            pictureBox7.Location = new Point(6, 221);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(27, 22);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Window;
            pictureBox6.Location = new Point(6, 185);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(27, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Door;
            pictureBox5.Location = new Point(6, 145);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.car_info;
            pictureBox3.Location = new Point(6, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.car_info;
            pictureBox2.Location = new Point(8, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 427);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBilgileriGöster);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oto Galeri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdiniz;
        private Label lblSoyadiniz;
        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Button btnBilgileriGöster;
        private ComboBox cmbPencere;
        private ComboBox cmbRenk;
        private ComboBox cmbKapı;
        private TextBox txtAdiniz;
        private TextBox txtSoyadiniz;
        private ImageList ımageList1;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Label lblKapiSayisi;
        private Label lblPencereSayisi;
        private Label lblYakıt;
        private ComboBox cmbYakıt;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
