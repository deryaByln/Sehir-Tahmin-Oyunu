
namespace Sehir_Tahmin_Oyunu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblkalanhak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGirilenHarfler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKelime = new System.Windows.Forms.TextBox();
            this.BtnTahmineEt = new System.Windows.Forms.Button();
            this.BtnHarfGir = new System.Windows.Forms.Button();
            this.TxtHarf = new System.Windows.Forms.TextBox();
            this.BtnYeniOyunBaslat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(67, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru Alanı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblkalanhak);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblGirilenHarfler);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtKelime);
            this.groupBox2.Controls.Add(this.BtnTahmineEt);
            this.groupBox2.Controls.Add(this.BtnHarfGir);
            this.groupBox2.Controls.Add(this.TxtHarf);
            this.groupBox2.Location = new System.Drawing.Point(76, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cevap Alanı";
            // 
            // lblkalanhak
            // 
            this.lblkalanhak.AutoSize = true;
            this.lblkalanhak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkalanhak.Location = new System.Drawing.Point(108, 133);
            this.lblkalanhak.Name = "lblkalanhak";
            this.lblkalanhak.Size = new System.Drawing.Size(18, 20);
            this.lblkalanhak.TabIndex = 9;
            this.lblkalanhak.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kalan Hak:";
            // 
            // LblGirilenHarfler
            // 
            this.LblGirilenHarfler.AutoSize = true;
            this.LblGirilenHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGirilenHarfler.Location = new System.Drawing.Point(159, 99);
            this.LblGirilenHarfler.Name = "LblGirilenHarfler";
            this.LblGirilenHarfler.Size = new System.Drawing.Size(0, 20);
            this.LblGirilenHarfler.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Girilen Harfler:";
            // 
            // TxtKelime
            // 
            this.TxtKelime.Location = new System.Drawing.Point(210, 51);
            this.TxtKelime.Name = "TxtKelime";
            this.TxtKelime.Size = new System.Drawing.Size(130, 22);
            this.TxtKelime.TabIndex = 5;
            // 
            // BtnTahmineEt
            // 
            this.BtnTahmineEt.Location = new System.Drawing.Point(346, 50);
            this.BtnTahmineEt.Name = "BtnTahmineEt";
            this.BtnTahmineEt.Size = new System.Drawing.Size(93, 23);
            this.BtnTahmineEt.TabIndex = 4;
            this.BtnTahmineEt.Text = "Tahmin Et";
            this.BtnTahmineEt.UseVisualStyleBackColor = true;
            this.BtnTahmineEt.Click += new System.EventHandler(this.BtnTahmineEt_Click);
            // 
            // BtnHarfGir
            // 
            this.BtnHarfGir.Location = new System.Drawing.Point(112, 50);
            this.BtnHarfGir.Name = "BtnHarfGir";
            this.BtnHarfGir.Size = new System.Drawing.Size(82, 23);
            this.BtnHarfGir.TabIndex = 3;
            this.BtnHarfGir.Text = "Harf Gir";
            this.BtnHarfGir.UseVisualStyleBackColor = true;
            this.BtnHarfGir.Click += new System.EventHandler(this.BtnHarfGir_Click);
            // 
            // TxtHarf
            // 
            this.TxtHarf.Location = new System.Drawing.Point(6, 51);
            this.TxtHarf.Name = "TxtHarf";
            this.TxtHarf.Size = new System.Drawing.Size(100, 22);
            this.TxtHarf.TabIndex = 2;
            // 
            // BtnYeniOyunBaslat
            // 
            this.BtnYeniOyunBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniOyunBaslat.Location = new System.Drawing.Point(67, 12);
            this.BtnYeniOyunBaslat.Name = "BtnYeniOyunBaslat";
            this.BtnYeniOyunBaslat.Size = new System.Drawing.Size(448, 37);
            this.BtnYeniOyunBaslat.TabIndex = 0;
            this.BtnYeniOyunBaslat.Text = "Yeni Oyun Baslat";
            this.BtnYeniOyunBaslat.UseVisualStyleBackColor = true;
            this.BtnYeniOyunBaslat.Click += new System.EventHandler(this.BtnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.BtnYeniOyunBaslat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblkalanhak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGirilenHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKelime;
        private System.Windows.Forms.Button BtnTahmineEt;
        private System.Windows.Forms.Button BtnHarfGir;
        private System.Windows.Forms.TextBox TxtHarf;
        private System.Windows.Forms.Button BtnYeniOyunBaslat;
    }
}

