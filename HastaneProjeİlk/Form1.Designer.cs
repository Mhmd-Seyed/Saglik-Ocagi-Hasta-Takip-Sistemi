using System;

namespace HastaneProjeİlk
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblBaslik1 = new System.Windows.Forms.Label();
            this.lblBaslik2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnGiris.Location = new System.Drawing.Point(175, 206);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(111, 43);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(418, 110);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 60);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(418, 206);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 43);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblBaslik1
            // 
            this.lblBaslik1.AutoSize = true;
            this.lblBaslik1.Location = new System.Drawing.Point(93, 110);
            this.lblBaslik1.Name = "lblBaslik1";
            this.lblBaslik1.Size = new System.Drawing.Size(76, 17);
            this.lblBaslik1.TabIndex = 3;
            this.lblBaslik1.Text = "Kullanıcı Adı";
            this.lblBaslik1.Click += new System.EventHandler(this.txtKullaniciAdi_Click);
            // 
            // lblBaslik2
            // 
            this.lblBaslik2.AutoSize = true;
            this.lblBaslik2.Location = new System.Drawing.Point(93, 153);
            this.lblBaslik2.Name = "lblBaslik2";
            this.lblBaslik2.Size = new System.Drawing.Size(34, 17);
            this.lblBaslik2.TabIndex = 4;
            this.lblBaslik2.Text = "Şifre";
            this.lblBaslik2.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 107);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 24);
            this.txtAd.TabIndex = 6;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(175, 150);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 24);
            this.txtParola.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblBaslik2);
            this.Controls.Add(this.lblBaslik1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGiris);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblBaslik1;
        private System.Windows.Forms.Label lblBaslik2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtParola;
    }
}

