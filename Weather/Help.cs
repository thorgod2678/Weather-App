using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(10, 10);
            pictureBox.Size = new Size(48, 48);
            Bitmap x = SystemIcons.Question.ToBitmap();

            pictureBox.Image = x;

            this.Controls.Add(pictureBox);
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
