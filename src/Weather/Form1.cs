using Weather.OtherClass;
namespace Weather
{
    public partial class Form1 : Form
    {
        Forecast x;
        WFetcher wFetcher = new WFetcher();
        Starred star = new Starred();

        private bool closingConfirmed = false;

        public Form1()
        {
            InitializeComponent();

            // Data.Data2.Load("Weather");
            this.MaximizeBox = false;

            //star1.MouseClick  star1_MouseClick;
            star1.MouseClick += star1_mouseclick;
            star2.MouseClick += star2_mouseclick;
            star3.MouseClick += star3_mouseclick;
            star4.MouseClick += star4_mouseclick;

            foreach (Control control in this.Controls)
            {
                control.MouseClick += Control_MouseClick;
                // control.MouseMove += Control_MouseMove;
            }

            star1.Text = Data.Data2.star1;
            star2.Text = Data.Data2.star2;
            star3.Text = Data.Data2.star3;
            star4.Text = Data.Data2.star4;




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Notifications noti = new Notifications(notifyIcon1);
            Data.Data2.Load("Weather");
            noti.ShowNotifications(Data.Data2.defloc);
            noti.PassiveNotifications(Data.Data2.delay);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
          

            Forecast x = await wFetcher.GetCast(PlaceT.Text);

            if (x != null)
            {
                Data.Data.temp = "Temp: " + x.Temp;
                Data.Data.humid = "Humidity: " + x.Humidity;
                Data.Data.windir = "Wind Dir: " + x.WindDirection;
                Data.Data.tempfeel = "What it feels like: " + x.TempFeel;
                Data.Data.windspeed = "Windspeed: " + x.WindSpeed;
                Data.Data.condition = "Condition: " + x.Condition;
                Data.Data.place = "Place: " + PlaceT.Text;


            }
            UpdateUI();
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {

            UpdateUI();

        }


        private void windir_Click(object sender, EventArgs e)
        {

        }

        private void star1_mouseclick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                star.SButton(1, 1, star1.Text);
            }


        }

        private void star2_mouseclick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                star.SButton(2, 1, star2.Text);
            }


        }

        private void star3_mouseclick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                star.SButton(3, 1, star3.Text);
            }


        }

        private void star4_mouseclick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                star.SButton(4, 1, star4.Text);
            }


        }

        private void mstar_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void settim_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings(notifyIcon1);

            // Show the SecondForm
            Settings.Show();
        }

        private void star1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            star1.Text = Data.Data2.star1;
            star2.Text = Data.Data2.star2;
            star3.Text = Data.Data2.star3;
            star4.Text = Data.Data2.star4;
        }

        private void star3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closingConfirmed)
            {
                e.Cancel = true; // Cancel the form closing
                ShowCloseConfirmation(); // Show confirmation dialog
            }
            else
            {
                // User has confirmed to close or minimize to tray
                if (notifyIcon1 != null)
                {
                    //notifyIcon1.Visible = false; // Hide the tray icon if closing
                    // notifyIcon1.Dispose(); // Dispose the NotifyIcon instance
                }
            }
        }

        private void ShowCloseConfirmation()
        {
            DialogResult result = MessageBox.Show("Close the application or minimize to tray?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                closingConfirmed = true;
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                closingConfirmed = false;
                this.Hide(); // Minimize to tray
                notifyIcon1.ShowBalloonTip(1000, "Weather App", "The application is still running in the system tray.", ToolTipIcon.Info);
            }
            // If user selects Cancel, do nothing and keep the form open
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        public void UpdateUI()
        {
            temp.Text = Data.Data.temp;
            humid.Text = Data.Data.humid;
            windir.Text = Data.Data.windir;
            tempfeel.Text = Data.Data.tempfeel;
            windspeed.Text = Data.Data.windspeed;
            condition.Text = Data.Data.condition;
            label2.Text = Data.Data.place;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            closingConfirmed = true;
            Application.Exit();
        }
    }


}
