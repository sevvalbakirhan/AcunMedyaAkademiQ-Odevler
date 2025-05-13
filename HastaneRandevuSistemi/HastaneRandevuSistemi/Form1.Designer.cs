namespace HastaneRandevuSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_ad = new Label();
            lbl_soyad = new Label();
            lbl_doktor = new Label();
            lbl_brans = new Label();
            lbl_saat = new Label();
            cmb_doktor = new ComboBox();
            cmb_brans = new ComboBox();
            txt_ad = new TextBox();
            txt_soyad = new TextBox();
            btn_randevuOlustur = new Button();
            dgv_randevular = new DataGridView();
            cmb_saat = new ComboBox();
            lbl_tarih = new Label();
            dtp_tarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_randevular).BeginInit();
            SuspendLayout();
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.Location = new Point(48, 45);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(35, 20);
            lbl_ad.TabIndex = 0;
            lbl_ad.Text = "Ad :";
            // 
            // lbl_soyad
            // 
            lbl_soyad.AutoSize = true;
            lbl_soyad.Location = new Point(48, 93);
            lbl_soyad.Name = "lbl_soyad";
            lbl_soyad.Size = new Size(57, 20);
            lbl_soyad.TabIndex = 1;
            lbl_soyad.Text = "Soyad :";
            // 
            // lbl_doktor
            // 
            lbl_doktor.AutoSize = true;
            lbl_doktor.Location = new Point(48, 186);
            lbl_doktor.Name = "lbl_doktor";
            lbl_doktor.Size = new Size(62, 20);
            lbl_doktor.TabIndex = 2;
            lbl_doktor.Text = "Doktor :";
            // 
            // lbl_brans
            // 
            lbl_brans.AutoSize = true;
            lbl_brans.Location = new Point(48, 142);
            lbl_brans.Name = "lbl_brans";
            lbl_brans.Size = new Size(52, 20);
            lbl_brans.TabIndex = 3;
            lbl_brans.Text = "Branş :";
            // 
            // lbl_saat
            // 
            lbl_saat.AutoSize = true;
            lbl_saat.Location = new Point(50, 266);
            lbl_saat.Name = "lbl_saat";
            lbl_saat.Size = new Size(45, 20);
            lbl_saat.TabIndex = 4;
            lbl_saat.Text = "Saat :";
            // 
            // cmb_doktor
            // 
            cmb_doktor.FormattingEnabled = true;
            cmb_doktor.Location = new Point(160, 186);
            cmb_doktor.Name = "cmb_doktor";
            cmb_doktor.Size = new Size(250, 28);
            cmb_doktor.TabIndex = 3;
            // 
            // cmb_brans
            // 
            cmb_brans.FormattingEnabled = true;
            cmb_brans.Location = new Point(160, 139);
            cmb_brans.Name = "cmb_brans";
            cmb_brans.Size = new Size(250, 28);
            cmb_brans.TabIndex = 2;
            cmb_brans.SelectedIndexChanged += cmb_brans_SelectedIndexChanged;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(160, 45);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(250, 27);
            txt_ad.TabIndex = 0;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(160, 93);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(250, 27);
            txt_soyad.TabIndex = 1;
            // 
            // btn_randevuOlustur
            // 
            btn_randevuOlustur.Location = new Point(50, 342);
            btn_randevuOlustur.Name = "btn_randevuOlustur";
            btn_randevuOlustur.Size = new Size(414, 29);
            btn_randevuOlustur.TabIndex = 6;
            btn_randevuOlustur.Text = "Randevu Oluştur";
            btn_randevuOlustur.UseVisualStyleBackColor = true;
            btn_randevuOlustur.Click += btn_randevuOlustur_Click;
            // 
            // dgv_randevular
            // 
            dgv_randevular.BackgroundColor = Color.SkyBlue;
            dgv_randevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_randevular.Location = new Point(488, 26);
            dgv_randevular.Name = "dgv_randevular";
            dgv_randevular.RowHeadersWidth = 51;
            dgv_randevular.Size = new Size(542, 412);
            dgv_randevular.TabIndex = 11;
            // 
            // cmb_saat
            // 
            cmb_saat.FormattingEnabled = true;
            cmb_saat.Location = new Point(160, 266);
            cmb_saat.Name = "cmb_saat";
            cmb_saat.Size = new Size(250, 28);
            cmb_saat.TabIndex = 5;
            // 
            // lbl_tarih
            // 
            lbl_tarih.AutoSize = true;
            lbl_tarih.Location = new Point(48, 222);
            lbl_tarih.Name = "lbl_tarih";
            lbl_tarih.Size = new Size(47, 20);
            lbl_tarih.TabIndex = 13;
            lbl_tarih.Text = "Tarih :";
            // 
            // dtp_tarih
            // 
            dtp_tarih.Location = new Point(160, 225);
            dtp_tarih.Name = "dtp_tarih";
            dtp_tarih.Size = new Size(250, 27);
            dtp_tarih.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1042, 479);
            Controls.Add(dtp_tarih);
            Controls.Add(lbl_tarih);
            Controls.Add(cmb_saat);
            Controls.Add(dgv_randevular);
            Controls.Add(btn_randevuOlustur);
            Controls.Add(txt_soyad);
            Controls.Add(txt_ad);
            Controls.Add(cmb_brans);
            Controls.Add(cmb_doktor);
            Controls.Add(lbl_saat);
            Controls.Add(lbl_brans);
            Controls.Add(lbl_doktor);
            Controls.Add(lbl_soyad);
            Controls.Add(lbl_ad);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Randevu Ekranı";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_randevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ad;
        private Label lbl_soyad;
        private Label lbl_doktor;
        private Label lbl_brans;
        private Label lbl_saat;
        private ComboBox cmb_doktor;
        private ComboBox cmb_brans;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private Button btn_randevuOlustur;
        private DataGridView dgv_randevular;
        private ComboBox cmb_saat;
        private Label lbl_tarih;
        private DateTimePicker dtp_tarih;
    }
}
