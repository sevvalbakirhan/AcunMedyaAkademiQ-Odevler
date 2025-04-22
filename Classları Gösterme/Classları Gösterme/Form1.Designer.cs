namespace Classları_Gösterme
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
            lstClasses = new ListBox();
            btnDllSec = new Button();
            SuspendLayout();
            // 
            // lstClasses
            // 
            lstClasses.FormattingEnabled = true;
            lstClasses.Location = new Point(293, 168);
            lstClasses.Name = "lstClasses";
            lstClasses.Size = new Size(150, 104);
            lstClasses.TabIndex = 0;
            lstClasses.Tag = "lstClasses";
            // 
            // btnDllSec
            // 
            btnDllSec.Location = new Point(318, 113);
            btnDllSec.Name = "btnDllSec";
            btnDllSec.Size = new Size(94, 29);
            btnDllSec.TabIndex = 1;
            btnDllSec.Text = "Seç";
            btnDllSec.UseVisualStyleBackColor = true;
            btnDllSec.Click += btnDllSec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDllSec);
            Controls.Add(lstClasses);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstClasses;
        private Button btnDllSec;
    }
}
