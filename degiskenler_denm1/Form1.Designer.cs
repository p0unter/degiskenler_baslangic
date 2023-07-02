namespace degiskenler_denm1
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            button3 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 96);
            button1.Name = "button1";
            button1.Size = new Size(329, 39);
            button1.TabIndex = 0;
            button1.Text = "ÇALIŞTIR!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(144, 41);
            label1.TabIndex = 1;
            label1.Text = "Unknow1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(75, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 39);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 291);
            label3.Name = "label3";
            label3.Size = new Size(130, 54);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(21, 240);
            button2.Name = "button2";
            button2.Size = new Size(329, 48);
            button2.TabIndex = 5;
            button2.Text = "ÇALIŞTIR!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(206, 42);
            label4.Name = "label4";
            label4.Size = new Size(144, 41);
            label4.TabIndex = 6;
            label4.Text = "Unknow2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 355);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temel:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(403, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(715, 355);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödev:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(174, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 39);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(19, 306);
            button3.Name = "button3";
            button3.Size = new Size(373, 42);
            button3.TabIndex = 7;
            button3.Text = "ÇALIŞTIR!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(416, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 254);
            listBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(108, 257);
            label7.Name = "label7";
            label7.Size = new Size(60, 41);
            label7.TabIndex = 14;
            label7.Text = "Yaş";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(174, 258);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(58, 42);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(56, 196);
            label6.Name = "label6";
            label6.Size = new Size(122, 41);
            label6.TabIndex = 12;
            label6.Text = "Cinsiyet";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Regarenk", "Erkek ", "Kız", "Belirtemiyorum..." });
            comboBox2.Location = new Point(174, 196);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(218, 40);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Züccaciyeci", "Serbet Meslek", "Kanafınıza Göre Diye Mültecici" });
            comboBox1.Location = new Point(174, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 40);
            comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 136);
            label5.Name = "label5";
            label5.Size = new Size(112, 41);
            label5.TabIndex = 9;
            label5.Text = "Meslek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 74);
            label2.Name = "label2";
            label2.Size = new Size(149, 41);
            label2.TabIndex = 7;
            label2.Text = "Ad/Soyad";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 372);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label5;
        private Button button3;
        private ListBox listBox1;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox2;
    }
}