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
            temp = new Label();
            humid = new Label();
            windir = new Label();
            tempfeel = new Label();
            windspeed = new Label();
            condition = new Label();
            star1 = new Button();
            star2 = new Button();
            star3 = new Button();
            star4 = new Button();
            label2 = new Label();
            settim = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            Show = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Roboto Thin", 18F, FontStyle.Bold);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(200, 29);
            Title.TabIndex = 0;
            Title.Text = "Today's Weather";
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
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            temp.ForeColor = Color.Red;
            temp.Location = new Point(13, 183);
            temp.Name = "temp";
            temp.Size = new Size(88, 31);
            temp.TabIndex = 4;
            temp.Text = "Temp:";
            // 
            // humid
            // 
            humid.AutoSize = true;
            humid.Font = new Font("Segoe UI", 16F);
            humid.Location = new Point(13, 245);
            humid.Name = "humid";
            humid.Size = new Size(106, 30);
            humid.TabIndex = 5;
            humid.Text = "Humidity:";
            // 
            // windir
            // 
            windir.AutoSize = true;
            windir.Font = new Font("Segoe UI", 16F);
            windir.Location = new Point(12, 284);
            windir.Name = "windir";
            windir.Size = new Size(103, 30);
            windir.TabIndex = 6;
            windir.Text = "Wind Dir:";
            windir.Click += windir_Click;
            // 
            // tempfeel
            // 
            tempfeel.AutoSize = true;
            tempfeel.Font = new Font("Segoe UI", 16F);
            tempfeel.Location = new Point(229, 245);
            tempfeel.Name = "tempfeel";
            tempfeel.Size = new Size(178, 30);
            tempfeel.TabIndex = 7;
            tempfeel.Text = "What It feels like:";
            // 
            // windspeed
            // 
            windspeed.AutoSize = true;
            windspeed.Font = new Font("Segoe UI", 16F);
            windspeed.Location = new Point(229, 297);
            windspeed.Name = "windspeed";
            windspeed.Size = new Size(143, 30);
            windspeed.TabIndex = 8;
            windspeed.Text = "Wind Speed: ";
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.Font = new Font("Segoe UI", 16F);
            condition.Location = new Point(229, 347);
            condition.Name = "condition";
            condition.Size = new Size(112, 30);
            condition.TabIndex = 9;
            condition.Text = "Condition:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(229, 183);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 15;
            label2.Text = "Place:";
            // 
            // settim
            // 
            settim.Location = new Point(321, 5);
            settim.Name = "settim";
            settim.Size = new Size(185, 23);
            settim.TabIndex = 16;
            settim.Text = "Settings";
            settim.UseVisualStyleBackColor = true;
            settim.Click += settim_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "Weather App\r\n";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 411);
            Controls.Add(settim);
            Controls.Add(label2);
            Controls.Add(star4);
            Controls.Add(star3);
            Controls.Add(star2);
            Controls.Add(star1);
            Controls.Add(condition);
            Controls.Add(windspeed);
            Controls.Add(tempfeel);
            Controls.Add(windir);
            Controls.Add(humid);
            Controls.Add(temp);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private TextBox PlaceT;
        private Button button1;
        private Label temp;
        private Label humid;
        private Label windir;
        private Label tempfeel;
        private Label windspeed;
        private Label condition;
        private Button star1;
        private Button star2;
        private Button star3;
        private Button star4;
        private Label label2;
        private Button settim;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Show;
        private ToolStripMenuItem Exit;
    }
}
