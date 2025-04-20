namespace Reflection_ile_Ödeme_Sistemi
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
            cmbOdemeYontemi = new ComboBox();
            label1 = new Label();
            txt_tutar = new TextBox();
            lbl_tutar = new Label();
            btn_ödeme = new Button();
            lbl_sonuc = new Label();
            SuspendLayout();
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(338, 55);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(151, 28);
            cmbOdemeYontemi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 58);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 1;
            label1.Text = "Ödeme Yöntemi Seçiniz";
            // 
            // txt_tutar
            // 
            txt_tutar.Location = new Point(347, 113);
            txt_tutar.Name = "txt_tutar";
            txt_tutar.Size = new Size(142, 27);
            txt_tutar.TabIndex = 2;
            // 
            // lbl_tutar
            // 
            lbl_tutar.AutoSize = true;
            lbl_tutar.Location = new Point(256, 120);
            lbl_tutar.Name = "lbl_tutar";
            lbl_tutar.Size = new Size(50, 20);
            lbl_tutar.TabIndex = 3;
            lbl_tutar.Text = "Tutar :";
            // 
            // btn_ödeme
            // 
            btn_ödeme.Location = new Point(256, 195);
            btn_ödeme.Name = "btn_ödeme";
            btn_ödeme.Size = new Size(233, 29);
            btn_ödeme.TabIndex = 4;
            btn_ödeme.Text = "Ödeme";
            btn_ödeme.UseVisualStyleBackColor = true;
            btn_ödeme.Click += btn_ödeme_Click;
            // 
            // lbl_sonuc
            // 
            lbl_sonuc.AutoSize = true;
            lbl_sonuc.Location = new Point(256, 288);
            lbl_sonuc.Name = "lbl_sonuc";
            lbl_sonuc.Size = new Size(56, 20);
            lbl_sonuc.TabIndex = 5;
            lbl_sonuc.Text = "Sonuç :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_sonuc);
            Controls.Add(btn_ödeme);
            Controls.Add(lbl_tutar);
            Controls.Add(txt_tutar);
            Controls.Add(label1);
            Controls.Add(cmbOdemeYontemi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOdemeYontemi;
        private Label label1;
        private TextBox txt_tutar;
        private Label lbl_tutar;
        private Button btn_ödeme;
        private Label lbl_sonuc;
    }
}
