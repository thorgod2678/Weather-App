namespace Weather
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Title = new Label();
            label1 = new Label();
            PlaceT = new TextBox();
            button1 = new Button();
            star1 = new Button();
            star2 = new Button();
            star3 = new Button();
            star4 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            Show = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            t1 = new TabPage();
            label2 = new Label();
            condition = new Label();
            windspeed = new Label();
            tempfeel = new Label();
            windir = new Label();
            humid = new Label();
            temp = new Label();
            t2 = new TabPage();
            humid4 = new Label();
            temp4 = new Label();
            humid3 = new Label();
            temp3 = new Label();
            humid2 = new Label();
            temp2 = new Label();
            label12 = new Label();
            label11 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            Settings = new ToolStripMenuItem();
            Help = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            t1.SuspendLayout();
            t2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Roboto Thin", 18F, FontStyle.Bold);
            Title.Location = new Point(12, 24);
            Title.Name = "Title";
            Title.Size = new Size(108, 29);
            Title.TabIndex = 0;
            Title.Text = "Weather";
            Title.Click += Title_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "Place:";
            // 
            // PlaceT
            // 
            PlaceT.Location = new Point(75, 58);
            PlaceT.Name = "PlaceT";
            PlaceT.Size = new Size(100, 23);
            PlaceT.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(181, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // star1
            // 
            star1.BackColor = SystemColors.Menu;
            star1.Location = new Point(15, 122);
            star1.Name = "star1";
            star1.Size = new Size(108, 23);
            star1.TabIndex = 10;
            star1.Text = "Starred 1";
            star1.UseVisualStyleBackColor = false;
            star1.Paint += star1_Paint;
            // 
            // star2
            // 
            star2.BackColor = SystemColors.Menu;
            star2.Location = new Point(138, 122);
            star2.Name = "star2";
            star2.Size = new Size(108, 23);
            star2.TabIndex = 11;
            star2.Text = "Starred 2";
            star2.UseVisualStyleBackColor = false;
            // 
            // star3
            // 
            star3.BackColor = SystemColors.Menu;
            star3.Location = new Point(264, 122);
            star3.Name = "star3";
            star3.Size = new Size(108, 23);
            star3.TabIndex = 12;
            star3.Text = "Starred 3";
            star3.UseVisualStyleBackColor = false;
            star3.Click += star3_Click;
            // 
            // star4
            // 
            star4.BackColor = SystemColors.Menu;
            star4.Location = new Point(378, 122);
            star4.Name = "star4";
            star4.Size = new Size(108, 23);
            star4.TabIndex = 13;
            star4.Text = "Starred 4";
            star4.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "Weather App\r\n";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Weather";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Show, Exit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // Show
            // 
            Show.Name = "Show";
            Show.Size = new Size(103, 22);
            Show.Text = "Show";
            Show.Click += Show_Click;
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(103, 22);
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(t1);
            tabControl1.Controls.Add(t2);
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(540, 258);
            tabControl1.TabIndex = 17;
            // 
            // t1
            // 
            t1.Controls.Add(label2);
            t1.Controls.Add(condition);
            t1.Controls.Add(windspeed);
            t1.Controls.Add(tempfeel);
            t1.Controls.Add(windir);
            t1.Controls.Add(humid);
            t1.Controls.Add(temp);
            t1.Location = new Point(4, 24);
            t1.Name = "t1";
            t1.Padding = new Padding(3);
            t1.Size = new Size(532, 230);
            t1.TabIndex = 0;
            t1.Text = "Current Weather";
            t1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(227, 13);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 22;
            label2.Text = "Place:";
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.Font = new Font("Segoe UI", 16F);
            condition.Location = new Point(227, 177);
            condition.Name = "condition";
            condition.Size = new Size(112, 30);
            condition.TabIndex = 21;
            condition.Text = "Condition:";
            // 
            // windspeed
            // 
            windspeed.AutoSize = true;
            windspeed.Font = new Font("Segoe UI", 16F);
            windspeed.Location = new Point(227, 127);
            windspeed.Name = "windspeed";
            windspeed.Size = new Size(143, 30);
            windspeed.TabIndex = 20;
            windspeed.Text = "Wind Speed: ";
            // 
            // tempfeel
            // 
            tempfeel.AutoSize = true;
            tempfeel.Font = new Font("Segoe UI", 16F);
            tempfeel.Location = new Point(227, 75);
            tempfeel.Name = "tempfeel";
            tempfeel.Size = new Size(178, 30);
            tempfeel.TabIndex = 19;
            tempfeel.Text = "What It feels like:";
            // 
            // windir
            // 
            windir.AutoSize = true;
            windir.Font = new Font("Segoe UI", 16F);
            windir.Location = new Point(10, 114);
            windir.Name = "windir";
            windir.Size = new Size(103, 30);
            windir.TabIndex = 18;
            windir.Text = "Wind Dir:";
            // 
            // humid
            // 
            humid.AutoSize = true;
            humid.Font = new Font("Segoe UI", 16F);
            humid.Location = new Point(11, 75);
            humid.Name = "humid";
            humid.Size = new Size(106, 30);
            humid.TabIndex = 17;
            humid.Text = "Humidity:";
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            temp.ForeColor = Color.Red;
            temp.Location = new Point(11, 13);
            temp.Name = "temp";
            temp.Size = new Size(88, 31);
            temp.TabIndex = 16;
            temp.Text = "Temp:";
            // 
            // t2
            // 
            t2.Controls.Add(humid4);
            t2.Controls.Add(temp4);
            t2.Controls.Add(humid3);
            t2.Controls.Add(temp3);
            t2.Controls.Add(humid2);
            t2.Controls.Add(temp2);
            t2.Controls.Add(label12);
            t2.Controls.Add(label11);
            t2.Controls.Add(label5);
            t2.Controls.Add(label4);
            t2.Controls.Add(label3);
            t2.Location = new Point(4, 24);
            t2.Name = "t2";
            t2.Padding = new Padding(3);
            t2.Size = new Size(532, 230);
            t2.TabIndex = 1;
            t2.Text = "This Week";
            t2.UseVisualStyleBackColor = true;
            t2.Click += t2_Click;
            // 
            // humid4
            // 
            humid4.AutoSize = true;
            humid4.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            humid4.ForeColor = Color.Black;
            humid4.Location = new Point(356, 174);
            humid4.Name = "humid4";
            humid4.Size = new Size(107, 25);
            humid4.TabIndex = 32;
            humid4.Text = "Humidity:";
            // 
            // temp4
            // 
            temp4.AutoSize = true;
            temp4.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            temp4.ForeColor = Color.Black;
            temp4.Location = new Point(356, 129);
            temp4.Name = "temp4";
            temp4.Size = new Size(72, 25);
            temp4.TabIndex = 31;
            temp4.Text = "Temp:";
            temp4.Click += label13_Click;
            // 
            // humid3
            // 
            humid3.AutoSize = true;
            humid3.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            humid3.ForeColor = Color.Black;
            humid3.Location = new Point(180, 138);
            humid3.Name = "humid3";
            humid3.Size = new Size(107, 25);
            humid3.TabIndex = 30;
            humid3.Text = "Humidity:";
            // 
            // temp3
            // 
            temp3.AutoSize = true;
            temp3.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            temp3.ForeColor = Color.Black;
            temp3.Location = new Point(180, 93);
            temp3.Name = "temp3";
            temp3.Size = new Size(72, 25);
            temp3.TabIndex = 29;
            temp3.Text = "Temp:";
            // 
            // humid2
            // 
            humid2.AutoSize = true;
            humid2.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            humid2.ForeColor = Color.Black;
            humid2.Location = new Point(11, 138);
            humid2.Name = "humid2";
            humid2.Size = new Size(107, 25);
            humid2.TabIndex = 28;
            humid2.Text = "Humidity:";
            // 
            // temp2
            // 
            temp2.AutoSize = true;
            temp2.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            temp2.ForeColor = Color.Black;
            temp2.Location = new Point(11, 93);
            temp2.Name = "temp2";
            temp2.Size = new Size(72, 25);
            temp2.TabIndex = 27;
            temp2.Text = "Temp:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(356, 47);
            label12.Name = "label12";
            label12.Size = new Size(146, 62);
            label12.TabIndex = 26;
            label12.Text = "Day After \r\nTomorrow:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(11, 3);
            label11.Name = "label11";
            label11.Size = new Size(86, 31);
            label11.TabIndex = 25;
            label11.Text = "Place:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(11, 138);
            label5.Name = "label5";
            label5.Size = new Size(0, 31);
            label5.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(177, 47);
            label4.Name = "label4";
            label4.Size = new Size(146, 31);
            label4.TabIndex = 18;
            label4.Text = "Tomorrow:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(11, 47);
            label3.Name = "label3";
            label3.Size = new Size(95, 31);
            label3.TabIndex = 17;
            label3.Text = "Today:";
            // 
            // button2
            // 
            button2.Location = new Point(262, 58);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 18;
            button2.Text = "Custom API";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Settings, Help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new Size(540, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // Settings
            // 
            Settings.Name = "Settings";
            Settings.Size = new Size(61, 20);
            Settings.Text = "Settings";
            Settings.Click += Settings_Click;
            // 
            // Help
            // 
            Help.Name = "Help";
            Help.Size = new Size(44, 20);
            Help.Text = "Help";
            Help.Click += Help_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(540, 411);
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(star4);
            Controls.Add(star3);
            Controls.Add(star2);
            Controls.Add(star1);
            Controls.Add(button1);
            Controls.Add(PlaceT);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Weather App";
            TransparencyKey = SystemColors.MenuHighlight;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Paint += Form1_Paint;
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            t1.ResumeLayout(false);
            t1.PerformLayout();
            t2.ResumeLayout(false);
            t2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private TextBox PlaceT;
        private Button button1;
        private Button star1;
        private Button star2;
        private Button star3;
        private Button star4;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Show;
        private ToolStripMenuItem Exit;
        private TabControl tabControl1;
        private TabPage t1;
        private Label label2;
        private Label condition;
        private Label windspeed;
        private Label tempfeel;
        private Label windir;
        private Label humid;
        private Label temp;
        private TabPage t2;
        private Label label11;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label12;
        private Label humid2;
        private Label temp2;
        private Label humid4;
        private Label temp4;
        private Label humid3;
        private Label temp3;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Settings;
        private ToolStripMenuItem Help;
    }
}
