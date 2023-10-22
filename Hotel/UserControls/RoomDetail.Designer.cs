namespace Hotel.UserControls
{
    partial class RoomDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            labelKalanGunDegeri = new Label();
            label9 = new Label();
            labelRezarvasyonGunuDegeri = new Label();
            label1 = new Label();
            textBoxToplamOdeme = new TextBox();
            label8 = new Label();
            textBoxGeceSayisi = new TextBox();
            label6 = new Label();
            textBoxMusteriAdi = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBoxOdaNo = new TextBox();
            button3 = new Button();
            textBoxGecelikFiyat = new TextBox();
            label2 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(3, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(136, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Oda Adı";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 121);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 169, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 70);
            button1.Name = "button1";
            button1.Size = new Size(225, 45);
            button1.TabIndex = 0;
            button1.Text = "Rezerve Et";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(234, 70);
            button2.Name = "button2";
            button2.Size = new Size(225, 45);
            button2.TabIndex = 1;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 473);
            panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelKalanGunDegeri);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(labelRezarvasyonGunuDegeri);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxToplamOdeme);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxGeceSayisi);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxMusteriAdi);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(321, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(439, 473);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // labelKalanGunDegeri
            // 
            labelKalanGunDegeri.AutoSize = true;
            labelKalanGunDegeri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelKalanGunDegeri.Location = new Point(245, 195);
            labelKalanGunDegeri.Name = "labelKalanGunDegeri";
            labelKalanGunDegeri.Size = new Size(131, 21);
            labelKalanGunDegeri.TabIndex = 15;
            labelKalanGunDegeri.Text = "Kalan Gün Değeri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(242, 170);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 14;
            label9.Text = "Kalan Gün Sayısı";
            // 
            // labelRezarvasyonGunuDegeri
            // 
            labelRezarvasyonGunuDegeri.AutoSize = true;
            labelRezarvasyonGunuDegeri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRezarvasyonGunuDegeri.Location = new Point(11, 195);
            labelRezarvasyonGunuDegeri.Name = "labelRezarvasyonGunuDegeri";
            labelRezarvasyonGunuDegeri.Size = new Size(190, 21);
            labelRezarvasyonGunuDegeri.TabIndex = 13;
            labelRezarvasyonGunuDegeri.Text = "Rezarvasyon Günü Değeri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 170);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 2;
            label1.Text = "Rezarvasyon Günü";
            // 
            // textBoxToplamOdeme
            // 
            textBoxToplamOdeme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxToplamOdeme.Location = new Point(242, 123);
            textBoxToplamOdeme.Name = "textBoxToplamOdeme";
            textBoxToplamOdeme.Size = new Size(171, 29);
            textBoxToplamOdeme.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(242, 99);
            label8.Name = "label8";
            label8.Size = new Size(115, 21);
            label8.TabIndex = 11;
            label8.Text = "Toplam Ödeme";
            // 
            // textBoxGeceSayisi
            // 
            textBoxGeceSayisi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeceSayisi.Location = new Point(11, 123);
            textBoxGeceSayisi.Name = "textBoxGeceSayisi";
            textBoxGeceSayisi.Size = new Size(222, 29);
            textBoxGeceSayisi.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 99);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 7;
            label6.Text = "Gece Sayısı";
            // 
            // textBoxMusteriAdi
            // 
            textBoxMusteriAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMusteriAdi.Location = new Point(11, 67);
            textBoxMusteriAdi.Name = "textBoxMusteriAdi";
            textBoxMusteriAdi.Size = new Size(402, 29);
            textBoxMusteriAdi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 43);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 3;
            label4.Text = "Müşteri Adı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxOdaNo);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBoxGecelikFiyat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 473);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oda Bilgileri";
            // 
            // textBoxOdaNo
            // 
            textBoxOdaNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOdaNo.Location = new Point(18, 67);
            textBoxOdaNo.Name = "textBoxOdaNo";
            textBoxOdaNo.Size = new Size(222, 29);
            textBoxOdaNo.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(18, 158);
            button3.Name = "button3";
            button3.Size = new Size(222, 45);
            button3.TabIndex = 2;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBoxGecelikFiyat
            // 
            textBoxGecelikFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGecelikFiyat.Location = new Point(18, 123);
            textBoxGecelikFiyat.Name = "textBoxGecelikFiyat";
            textBoxGecelikFiyat.Size = new Size(222, 29);
            textBoxGecelikFiyat.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 3;
            label2.Text = "Oda Numarası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 99);
            label7.Name = "label7";
            label7.Size = new Size(97, 21);
            label7.TabIndex = 9;
            label7.Text = "Gecelik Fiyat";
            // 
            // RoomDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RoomDetail";
            Size = new Size(760, 594);
            Load += RoomDetail_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox textBoxToplamOdeme;
        private Label label8;
        private TextBox textBoxGeceSayisi;
        private Label label6;
        private TextBox textBoxMusteriAdi;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBoxOdaNo;
        private Button button3;
        private TextBox textBoxGecelikFiyat;
        private Label label2;
        private Label label7;
        private Label labelKalanGunDegeri;
        private Label label9;
        private Label labelRezarvasyonGunuDegeri;
        private Label label1;
    }
}
