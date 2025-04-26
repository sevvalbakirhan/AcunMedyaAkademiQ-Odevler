namespace custom_attribute
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
            txtögrAd = new TextBox();
            txtögrSoyad = new TextBox();
            txtögrBölüm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBilgileriDogrula = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtögrAd
            // 
            txtögrAd.BackColor = SystemColors.Window;
            txtögrAd.BorderStyle = BorderStyle.FixedSingle;
            txtögrAd.Location = new Point(331, 34);
            txtögrAd.Name = "txtögrAd";
            txtögrAd.Size = new Size(125, 27);
            txtögrAd.TabIndex = 0;
            txtögrAd.TextChanged += txtögrAd_TextChanged;
            // 
            // txtögrSoyad
            // 
            txtögrSoyad.BorderStyle = BorderStyle.FixedSingle;
            txtögrSoyad.Location = new Point(331, 83);
            txtögrSoyad.Name = "txtögrSoyad";
            txtögrSoyad.Size = new Size(125, 27);
            txtögrSoyad.TabIndex = 1;
            txtögrSoyad.EnabledChanged += txtögrSoyad_EnabledChanged;
            txtögrSoyad.TextChanged += txtögrSoyad_TextChanged;
            // 
            // txtögrBölüm
            // 
            txtögrBölüm.BorderStyle = BorderStyle.FixedSingle;
            txtögrBölüm.Location = new Point(331, 138);
            txtögrBölüm.Name = "txtögrBölüm";
            txtögrBölüm.Size = new Size(125, 27);
            txtögrBölüm.TabIndex = 2;
            txtögrBölüm.EnabledChanged += txtögrBölüm_EnabledChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 37);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 86);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Soyadı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 138);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci Bölümü :";
            // 
            // btnBilgileriDogrula
            // 
            btnBilgileriDogrula.BackColor = Color.Honeydew;
            btnBilgileriDogrula.FlatStyle = FlatStyle.Popup;
            btnBilgileriDogrula.Location = new Point(288, 190);
            btnBilgileriDogrula.Name = "btnBilgileriDogrula";
            btnBilgileriDogrula.Size = new Size(168, 29);
            btnBilgileriDogrula.TabIndex = 3;
            btnBilgileriDogrula.Text = "Bilgileri Doğrula";
            btnBilgileriDogrula.UseVisualStyleBackColor = false;
            btnBilgileriDogrula.Click += btnBilgileriDogrula_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Honeydew;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(539, 250);
            Controls.Add(pictureBox1);
            Controls.Add(btnBilgileriDogrula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtögrBölüm);
            Controls.Add(txtögrSoyad);
            Controls.Add(txtögrAd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Bilgi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtögrAd;
        private TextBox txtögrSoyad;
        private TextBox txtögrBölüm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBilgileriDogrula;
        private PictureBox pictureBox1;
    }
}
