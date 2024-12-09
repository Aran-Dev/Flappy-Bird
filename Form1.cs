using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int i = 0;
        bool f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                f = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            f = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f == true)
            {
                pictureBox1.Top -= 5;
            }

            else
            {
                pictureBox1.Top += 5;
            }

            pictureBox2.Left -= 5;
            pictureBox3.Left -= 5;
            pictureBox5.Left -= 5;
            pictureBox6.Left -= 5;
            pictureBox7.Left -= 5;
            pictureBox8.Left -= 5;
            pictureBox9.Left -= 5;
            

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) ||pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                label1.Visible = true;
                timer1.Stop();
                MessageBox.Show("Score : " + i);

            }

            else if  (pictureBox2.Left < -200)
            {

                pictureBox2.Left = 500;
                i++;
            }

            else if  (pictureBox3.Left < -200)
            {
                
                pictureBox3.Left = 500;
                
            }

            else if  (pictureBox5.Left < -200)
            {
                
                pictureBox5.Left = 500;
                i++;
            }

            else if  (pictureBox6.Left < -200)
            {

                pictureBox6.Left = 500;
                

            }

            else if  (pictureBox7.Left < -200)
            {
                pictureBox7.Left = 500;
                i++;
            }

            else if  (pictureBox8.Left < -200)
            {
                pictureBox8.Left = 500;
                
            }

            else if  (pictureBox9.Left < -200)
            {
                pictureBox9.Left = 500;
                i++;
               
                label4.Text = i.ToString();
                
            }

            else if  (i == 2)
            {
                timer1.Interval = 40;
                
            }

            else if  (i == 4)
            {
                timer1.Interval = 35;
            }

            else if  (i == 6)
            {
                timer1.Interval = 33;
            }

            else if  (i == 8)
            {
                timer1.Interval = 30;
            }

            else if  (i == 12)
            {
                timer1.Interval = 28;
            }

            else if  (i == 20)
            {
                timer1.Interval = 25;
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
