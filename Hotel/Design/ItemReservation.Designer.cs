namespace Hotel.Design
{
    partial class ItemReservation
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
            labelKalanGun = new Label();
            labelFiyat = new Label();
            button1 = new Button();
            labelOdaBilgileri = new Label();
            labelMusteriAdi = new Label();
            SuspendLayout();
            // 
            // labelKalanGun
            // 
            labelKalanGun.AutoSize = true;
            labelKalanGun.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelKalanGun.Location = new Point(7, 58);
            labelKalanGun.Name = "labelKalanGun";
            labelKalanGun.Size = new Size(85, 15);
            labelKalanGun.TabIndex = 9;
            labelKalanGun.Text = "Kalan gün saısı";
            // 
            // labelFiyat
            // 
            labelFiyat.AutoSize = true;
            labelFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFiyat.Location = new Point(7, 85);
            labelFiyat.Name = "labelFiyat";
            labelFiyat.Size = new Size(28, 21);
            labelFiyat.TabIndex = 8;
            labelFiyat.Text = "0₺";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(178, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "İptal et";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // labelOdaBilgileri
            // 
            labelOdaBilgileri.AutoSize = true;
            labelOdaBilgileri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelOdaBilgileri.Location = new Point(7, 37);
            labelOdaBilgileri.Name = "labelOdaBilgileri";
            labelOdaBilgileri.Size = new Size(161, 21);
            labelOdaBilgileri.TabIndex = 6;
            labelOdaBilgileri.Text = "Oda Numarası Ve Tipi";
            // 
            // labelMusteriAdi
            // 
            labelMusteriAdi.AutoSize = true;
            labelMusteriAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMusteriAdi.Location = new Point(7, 7);
            labelMusteriAdi.Name = "labelMusteriAdi";
            labelMusteriAdi.Size = new Size(120, 30);
            labelMusteriAdi.TabIndex = 5;
            labelMusteriAdi.Text = "Müşteri Adı";
            // 
            // ItemReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(labelKalanGun);
            Controls.Add(labelFiyat);
            Controls.Add(button1);
            Controls.Add(labelOdaBilgileri);
            Controls.Add(labelMusteriAdi);
            Name = "ItemReservation";
            Size = new Size(256, 114);
            Load += ItemReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKalanGun;
        private Label labelFiyat;
        private Button button1;
        private Label labelOdaBilgileri;
        private Label labelMusteriAdi;
    }
}
