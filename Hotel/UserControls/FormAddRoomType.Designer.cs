namespace Hotel.UserControls
{
    partial class FormAddRoomType
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
            groupBox2 = new GroupBox();
            textBoxFiyat = new TextBox();
            groupBox3 = new GroupBox();
            textBoxYatakSayisi = new TextBox();
            groupBox1 = new GroupBox();
            textBoxBaslik = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 557);
            panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxFiyat);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(220, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 62);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat";
            // 
            // textBoxFiyat
            // 
            textBoxFiyat.Location = new Point(6, 26);
            textBoxFiyat.Name = "textBoxFiyat";
            textBoxFiyat.Size = new Size(177, 27);
            textBoxFiyat.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxYatakSayisi);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(20, 92);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(194, 62);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yatak Sayısı";
            // 
            // textBoxYatakSayisi
            // 
            textBoxYatakSayisi.Location = new Point(6, 26);
            textBoxYatakSayisi.Name = "textBoxYatakSayisi";
            textBoxYatakSayisi.Size = new Size(182, 27);
            textBoxYatakSayisi.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxBaslik);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Başlık";
            // 
            // textBoxBaslik
            // 
            textBoxBaslik.Location = new Point(6, 26);
            textBoxBaslik.Name = "textBoxBaslik";
            textBoxBaslik.Size = new Size(383, 27);
            textBoxBaslik.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 52);
            panel2.TabIndex = 3;
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
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 1;
            label1.Text = "Oda Tipi Ekle";
            // 
            // FormAddRoomType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormAddRoomType";
            Size = new Size(832, 609);
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private TextBox textBoxYatakSayisi;
        private GroupBox groupBox1;
        private TextBox textBoxBaslik;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBoxFiyat;
    }
}
