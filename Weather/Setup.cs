namespace Weather
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
            
            Data.Data2.apikey = textBox1.Text;
            Data.Data2.defloc = textBox2.Text;

            Data.Data2.star1 = textBox3.Text;
            Data.Data2.star2 = textBox4.Text;
            Data.Data2.star3 = textBox5.Text;
            Data.Data2.star4 = textBox6.Text;

            Data.Data2.delay = Convert.ToInt32(box7.Text);

            Data.Data2.reginterval = Convert.ToBoolean(radioButton1.Checked);
            Data.Data2.tempchange = Convert.ToBoolean(false);

            Data.Data2.firtime = false;

            Data.Data2.Save("Weather");

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void box7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
