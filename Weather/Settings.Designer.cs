namespace Weather
{
    partial class Settings
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
            tabControl1 = new TabControl();
            General = new TabPage();
            box6 = new TextBox();
            box5 = new TextBox();
            box4 = new TextBox();
            box3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            s1 = new Label();
            box2 = new TextBox();
            label2 = new Label();
            box1 = new TextBox();
            label1 = new Label();
            Notifications = new TabPage();
            button2 = new Button();
            box7 = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            button1 = new Button();
            tabControl1.SuspendLayout();
            General.SuspendLayout();
            Notifications.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(General);
            tabControl1.Controls.Add(Notifications);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(535, 263);
            tabControl1.TabIndex = 0;
            // 
            // General
            // 
            General.Controls.Add(box6);
            General.Controls.Add(box5);
            General.Controls.Add(box4);
            General.Controls.Add(box3);
            General.Controls.Add(label6);
            General.Controls.Add(label5);
            General.Controls.Add(label4);
            General.Controls.Add(s1);
            General.Controls.Add(box2);
            General.Controls.Add(label2);
            General.Controls.Add(box1);
            General.Controls.Add(label1);
            General.Location = new Point(4, 24);
            General.Name = "General";
            General.Padding = new Padding(3);
            General.Size = new Size(527, 235);
            General.TabIndex = 0;
            General.Text = "General";
            General.UseVisualStyleBackColor = true;
            General.Click += General_Click;
            // 
            // box6
            // 
            box6.Location = new Point(377, 110);
            box6.Name = "box6";
            box6.Size = new Size(137, 23);
            box6.TabIndex = 25;
            box6.Text = "Enter a place";
            // 
            // box5
            // 
            box5.Location = new Point(377, 80);
            box5.Name = "box5";
            box5.Size = new Size(137, 23);
            box5.TabIndex = 24;
            box5.Text = "Enter a place";
            // 
            // box4
            // 
            box4.Location = new Point(377, 51);
            box4.Name = "box4";
            box4.Size = new Size(137, 23);
            box4.TabIndex = 23;
            box4.Text = "Enter a place";
            // 
            // box3
            // 
            box3.Location = new Point(377, 20);
            box3.Name = "box3";
            box3.Size = new Size(137, 23);
            box3.TabIndex = 22;
            box3.Text = "Enter a place";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(295, 47);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 21;
            label6.Text = "Starred 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(295, 76);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 20;
            label5.Text = "Starred 3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(295, 108);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 19;
            label4.Text = "Starred 4:";
            // 
            // s1
            // 
            s1.AutoSize = true;
            s1.Font = new Font("Segoe UI", 12F);
            s1.Location = new Point(295, 18);
            s1.Name = "s1";
            s1.Size = new Size(76, 21);
            s1.TabIndex = 18;
            s1.Text = "Starred 1:";
            // 
            // box2
            // 
            box2.Location = new Point(32, 134);
            box2.Name = "box2";
            box2.Size = new Size(203, 23);
            box2.TabIndex = 17;
            box2.Text = "Enter a Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 108);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 16;
            label2.Text = "Defualt Location:";
            // 
            // box1
            // 
            box1.Location = new Point(32, 51);
            box1.Name = "box1";
            box1.Size = new Size(203, 23);
            box1.TabIndex = 14;
            box1.Text = "Enter a key";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 13;
            label1.Text = "API Key:";
            // 
            // Notifications
            // 
            Notifications.Controls.Add(button2);
            Notifications.Controls.Add(box7);
            Notifications.Controls.Add(label3);
            Notifications.Controls.Add(radioButton1);
            Notifications.Location = new Point(4, 24);
            Notifications.Name = "Notifications";
            Notifications.Padding = new Padding(3);
            Notifications.Size = new Size(527, 235);
            Notifications.TabIndex = 1;
            Notifications.Text = "Notifications";
            Notifications.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(36, 122);
            button2.Name = "button2";
            button2.Size = new Size(212, 23);
            button2.TabIndex = 4;
            button2.Text = "Send Test Notification";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // box7
            // 
            box7.Location = new Point(100, 80);
            box7.Name = "box7";
            box7.Size = new Size(100, 23);
            box7.TabIndex = 3;
            box7.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "Interval:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(28, 44);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Send in fixed intervals";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(379, 263);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 1;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 298);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            tabControl1.ResumeLayout(false);
            General.ResumeLayout(false);
            General.PerformLayout();
            Notifications.ResumeLayout(false);
            Notifications.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage General;
        private TextBox box6;
        private TextBox box5;
        private TextBox box4;
        private TextBox box3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label s1;
        private TextBox box2;
        private Label label2;
        private TextBox box1;
        private Label label1;
        private TabPage Notifications;
        private Button button1;
        private RadioButton radioButton1;
        private TextBox box7;
        private Label label3;
        private Button button2;
    }
}