namespace Hotel.Design
{
    partial class ItemCustomer
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
            labelTC = new Label();
            labelMusteriAdi = new Label();
            labelTelefon = new Label();
            labelEmail = new Label();
            SuspendLayout();
            // 
            // labelTC
            // 
            labelTC.AutoSize = true;
            labelTC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTC.Location = new Point(5, 37);
            labelTC.Name = "labelTC";
            labelTC.Size = new Size(27, 21);
            labelTC.TabIndex = 11;
            labelTC.Text = "TC";
            // 
            // labelMusteriAdi
            // 
            labelMusteriAdi.AutoSize = true;
            labelMusteriAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMusteriAdi.Location = new Point(5, 7);
            labelMusteriAdi.Name = "labelMusteriAdi";
            labelMusteriAdi.Size = new Size(120, 30);
            labelMusteriAdi.TabIndex = 10;
            labelMusteriAdi.Text = "Müşteri Adı";
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefon.Location = new Point(5, 58);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(59, 21);
            labelTelefon.TabIndex = 14;
            labelTelefon.Text = "Telefon";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(3, 79);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // ItemCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefon);
            Controls.Add(labelTC);
            Controls.Add(labelMusteriAdi);
            Name = "ItemCustomer";
            Size = new Size(256, 114);
            Load += ItemCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTC;
        private Label labelMusteriAdi;
        private Label labelTelefon;
        private Label labelEmail;
    }
}
