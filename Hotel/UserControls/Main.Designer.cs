namespace Hotel.UserControls
{
    partial class Main
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button7 = new Button();
            button6 = new Button();
            button8 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 302);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(781, 272);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.Gray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(232, 3);
            button7.Name = "button7";
            button7.Size = new Size(112, 103);
            button7.TabIndex = 6;
            button7.Text = "Odalar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(232, 106);
            button6.Name = "button6";
            button6.Size = new Size(112, 103);
            button6.TabIndex = 7;
            button6.Text = "Müşteriler";
            button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(224, 206);
            button8.TabIndex = 5;
            button8.Text = "Rezervasyonlar";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(350, 3);
            button5.Name = "button5";
            button5.Size = new Size(112, 103);
            button5.TabIndex = 8;
            button5.Text = "Mali Kayıtlar";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 228);
            panel1.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Main";
            Size = new Size(781, 574);
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button7;
        private Button button6;
        private Button button8;
        private Button button5;
        private Panel panel1;
    }
}
