namespace tugasweek14
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
            this.labelMasukkanKalimat = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelMasukkanHuruf = new System.Windows.Forms.Label();
            this.textBoxHuruf1 = new System.Windows.Forms.TextBox();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.textBoxHuruf2 = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMasukkanKalimat
            // 
            this.labelMasukkanKalimat.AutoSize = true;
            this.labelMasukkanKalimat.Location = new System.Drawing.Point(34, 47);
            this.labelMasukkanKalimat.Name = "labelMasukkanKalimat";
            this.labelMasukkanKalimat.Size = new System.Drawing.Size(93, 13);
            this.labelMasukkanKalimat.TabIndex = 0;
            this.labelMasukkanKalimat.Text = "Masukkan kalimat";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(140, 44);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(206, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // labelMasukkanHuruf
            // 
            this.labelMasukkanHuruf.AutoSize = true;
            this.labelMasukkanHuruf.Location = new System.Drawing.Point(34, 81);
            this.labelMasukkanHuruf.Name = "labelMasukkanHuruf";
            this.labelMasukkanHuruf.Size = new System.Drawing.Size(84, 13);
            this.labelMasukkanHuruf.TabIndex = 2;
            this.labelMasukkanHuruf.Text = "Masukkan huruf";
            // 
            // textBoxHuruf1
            // 
            this.textBoxHuruf1.Location = new System.Drawing.Point(140, 78);
            this.textBoxHuruf1.Name = "textBoxHuruf1";
            this.textBoxHuruf1.Size = new System.Drawing.Size(58, 20);
            this.textBoxHuruf1.TabIndex = 3;
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(221, 81);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(44, 13);
            this.labelMenjadi.TabIndex = 4;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // textBoxHuruf2
            // 
            this.textBoxHuruf2.Location = new System.Drawing.Point(288, 78);
            this.textBoxHuruf2.Name = "textBoxHuruf2";
            this.textBoxHuruf2.Size = new System.Drawing.Size(58, 20);
            this.textBoxHuruf2.TabIndex = 5;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(140, 117);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(206, 23);
            this.buttonKonversi.TabIndex = 6;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(34, 163);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(39, 13);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil : ";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(140, 163);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 235);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxHuruf2);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.textBoxHuruf1);
            this.Controls.Add(this.labelMasukkanHuruf);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelMasukkanKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMasukkanKalimat;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelMasukkanHuruf;
        private System.Windows.Forms.TextBox textBoxHuruf1;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.TextBox textBoxHuruf2;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelOutput;
    }
}

