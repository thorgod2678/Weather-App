namespace Weather
{
    partial class Setup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            radioButton1 = new RadioButton();
            box7 = new TextBox();
            label12 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(15, 14);
            label2.Name = "label2";
            label2.Size = new Size(233, 25);
            label2.TabIndex = 1;
            label2.Text = "Welcome To Weather App:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 55);
            label3.Name = "label3";
            label3.Size = new Size(320, 21);
            label3.TabIndex = 2;
            label3.Text = "Please Enter The Following Values (required):\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 98);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "API Key:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 127);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 5;
            label5.Text = "Default Location:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 205);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 7;
            label6.Text = "Starred 1:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(79, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 234);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 9;
            label7.Text = "Starred 2:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(79, 260);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 23);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 263);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 11;
            label8.Text = "Starred 3:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(79, 289);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(203, 23);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 292);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 13;
            label9.Text = "Starred 4:";
            // 
            // button1
            // 
            button1.Location = new Point(539, 415);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 15;
            button1.Text = "Proceed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(367, 415);
            button2.Name = "button2";
            button2.Size = new Size(137, 23);
            button2.TabIndex = 16;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(24, 170);
            label10.Name = "label10";
            label10.Size = new Size(295, 21);
            label10.TabIndex = 17;
            label10.Text = "Please Enter The places you want Starred:\r\n";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(341, 92);
            label11.Name = "label11";
            label11.Size = new Size(335, 21);
            label11.TabIndex = 18;
            label11.Text = "Please Enter The Settings for your notifications:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(364, 136);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 19);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Send in fixed intervals";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // box7
            // 
            box7.Location = new Point(367, 239);
            box7.Name = "box7";
            box7.Size = new Size(100, 23);
            box7.TabIndex = 24;
            box7.TextChanged += box7_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.Location = new Point(364, 184);
            label12.Name = "label12";
            label12.Size = new Size(263, 42);
            label12.TabIndex = 23;
            label12.Text = "Interval Between in each Notification\r\n(in seconds,can be expression):";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(23, 358);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I Don't Know What to Do?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(linkLabel1);
            Controls.Add(box7);
            Controls.Add(label12);
            Controls.Add(radioButton1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Setup";
            Text = "Setup";
            Load += Setup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label label10;
        private Label label11;
        private RadioButton radioButton1;
        private TextBox box7;
        private Label label12;
        private LinkLabel linkLabel1;
    }
}