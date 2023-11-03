namespace Hotel.UserControls
{
    partial class FormReservation
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
            panel1 = new Panel();
            groupBox11 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox4 = new GroupBox();
            groupBox9 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox8 = new GroupBox();
            textBoxGeceSayisi = new TextBox();
            groupBox7 = new GroupBox();
            textBoxEmail = new TextBox();
            groupBox5 = new GroupBox();
            button2 = new Button();
            groupBox6 = new GroupBox();
            textBoxSearchTC = new TextBox();
            groupBox1 = new GroupBox();
            textBoxTC = new TextBox();
            groupBox2 = new GroupBox();
            textBoxTelefon = new TextBox();
            groupBox3 = new GroupBox();
            textBoxAdSoyad = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBox11);
            panel1.Controls.Add(groupBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 488);
            panel1.TabIndex = 6;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(comboBox1);
            groupBox11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox11.Location = new Point(429, 22);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(383, 62);
            groupBox11.TabIndex = 2;
            groupBox11.TabStop = false;
            groupBox11.Text = "Oda ";
            groupBox11.Paint += groupBox11_Paint;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(371, 28);
            comboBox1.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox9);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(16, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(407, 436);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Müşteri Bilgileri";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(dateTimePicker1);
            groupBox9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox9.Location = new Point(6, 360);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(395, 62);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "Rezarvasyon Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(377, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBoxGeceSayisi);
            groupBox8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox8.Location = new Point(206, 292);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(195, 62);
            groupBox8.TabIndex = 6;
            groupBox8.TabStop = false;
            groupBox8.Text = "Kalınacak Gece Sayısı";
            // 
            // textBoxGeceSayisi
            // 
            textBoxGeceSayisi.Location = new Point(6, 26);
            textBoxGeceSayisi.Name = "textBoxGeceSayisi";
            textBoxGeceSayisi.Size = new Size(177, 27);
            textBoxGeceSayisi.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBoxEmail);
            groupBox7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.Location = new Point(6, 292);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(195, 62);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(6, 26);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(177, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(6, 26);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(395, 124);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Müşteri Bul";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(284, 88);
            button2.Name = "button2";
            button2.Size = new Size(105, 30);
            button2.TabIndex = 3;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBoxSearchTC);
            groupBox6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(6, 26);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(383, 62);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "TC";
            // 
            // textBoxSearchTC
            // 
            textBoxSearchTC.Location = new Point(6, 26);
            textBoxSearchTC.Name = "textBoxSearchTC";
            textBoxSearchTC.Size = new Size(371, 27);
            textBoxSearchTC.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTC);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TC";
            // 
            // textBoxTC
            // 
            textBoxTC.Location = new Point(6, 26);
            textBoxTC.Name = "textBoxTC";
            textBoxTC.Size = new Size(383, 27);
            textBoxTC.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxTelefon);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(206, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 62);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Telefon";
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(6, 26);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(177, 27);
            textBoxTelefon.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxAdSoyad);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(6, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(194, 62);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ad Soyad";
            // 
            // textBoxAdSoyad
            // 
            textBoxAdSoyad.Location = new Point(6, 26);
            textBoxAdSoyad.Name = "textBoxAdSoyad";
            textBoxAdSoyad.Size = new Size(182, 27);
            textBoxAdSoyad.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 52);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(0, 169, 255);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(645, 0);
            button1.Name = "button1";
            button1.Size = new Size(187, 52);
            button1.TabIndex = 2;
            button1.Text = "Rezerve Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 1;
            label1.Text = "Rezarvasyon";
            // 
            // FormReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormReservation";
            Size = new Size(832, 540);
            Load += FormReservation_Load;
            panel1.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox4;
        private GroupBox groupBox7;
        private TextBox textBoxEmail;
        private GroupBox groupBox5;
        private Button button2;
        private GroupBox groupBox6;
        private TextBox textBoxSearchTC;
        private GroupBox groupBox1;
        private TextBox textBoxTC;
        private GroupBox groupBox2;
        private TextBox textBoxTelefon;
        private GroupBox groupBox3;
        private TextBox textBoxAdSoyad;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private GroupBox groupBox9;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox8;
        private TextBox textBoxGeceSayisi;
        private GroupBox groupBox11;
        private ComboBox comboBox1;
    }
}
