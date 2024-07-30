using Weather.OtherClass;

namespace Weather
{
    public partial class Settings : Form
    {
        NotifyIcon notu;

        public Settings(NotifyIcon not)
        {
            InitializeComponent();
            notu = not;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void General_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Data.Data2.Load("Weather");

            box1.Text = Data.Data2.apikey;
            box2.Text = Data.Data2.defloc;

            box3.Text = Data.Data2.star1;
            box4.Text = Data.Data2.star2;
            box5.Text = Data.Data2.star3;
            box6.Text = Data.Data2.star4;

            radioButton1.Checked = Data.Data2.reginterval;
           
            box7.Text = Data.Data2.delay.ToString();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Data.Data2.apikey = box1.Text;
            Data.Data2.defloc = box2.Text;

            Data.Data2.star1 = box3.Text;
            Data.Data2.star2 = box4.Text;
            Data.Data2.star3 = box5.Text;
            Data.Data2.star4 = box6.Text;

            Data.Data2.delay = Convert.ToInt32(box7.Text);
            Data.Data2.reginterval = radioButton1.Checked;
            Data.Data2.tempchange = false;



            Data.Data2.Save("Weather");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notifications noti = new Notifications(notu);
            noti.ShowNotifications(Data.Data2.defloc);

        }
    }
}
