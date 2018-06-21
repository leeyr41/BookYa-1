using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookYa
{
    public partial class Form2 : Form
    {
        Form1 f1;

        System.Timers.Timer t;
        public Form2()
        {
            InitializeComponent();
        }
    
        public Form2(Form1 _form)
        {
            InitializeComponent();
            f1 = _form;            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            timer1.Interval = 1000;

            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }

            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }

            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }

          

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
            }
        }
    }
}
