namespace Weather
{
    partial class Help
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(66, 17);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 1;
            label1.Text = "This is The Help Page:";
            // 
            // button1
            // 
            button1.Location = new Point(245, 415);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 2;
            button1.Text = "Close Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 3;
            label2.Text = "To use The Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(318, 42);
            label3.TabIndex = 4;
            label3.Text = "1.You can type on the textbox and click the \r\n   search buttonto see that locations weather.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 143);
            label4.Name = "label4";
            label4.Size = new Size(324, 63);
            label4.TabIndex = 5;
            label4.Text = "2. Or You can double click on any of the \r\nstarred buttons (buttons with location written\r\non them).";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(147, 21);
            label5.TabIndex = 6;
            label5.Text = "How to Get Api Key:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(16, 274);
            label6.Name = "label6";
            label6.Size = new Size(273, 126);
            label6.TabIndex = 7;
            label6.Text = "Go To \"https://www.weatherapi.com/\".\r\nSign up for an account.\r\nGo to API section.\r\nOn the top there will be an API key.\r\nCopy it and paste it in the app.\r\n\r\n";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.AliceBlue;
            CancelButton = button1;
            ClientSize = new Size(345, 450);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Help";
            Text = "Help";
            Load += Help_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}