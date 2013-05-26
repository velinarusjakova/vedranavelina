using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Memory
{
    public partial class Form1 : Form
    {
        private int timeElapsed;
        private static readonly int TIME = 120; 


        public Form1()
        {
            InitializeComponent();
            timeElapsed = 0;
            updateTime();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            if (timeElapsed == TIME)
            {
                button1.Visible = false;
                timer1.Stop();
                MessageBox.Show("TAPA SIIIIIIIIIII!");
            }
            updateTime();
        }

        private void updateTime()
        {
            int left = TIME - timeElapsed;
            int min = left / 60;
            int sec = left % 60;
            lblTimeLeft.Text = string.Format("{0:00}:{1:00}", min, sec);
        }

        private void новаИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caption = string.Format("Неуспешно погодување", timeElapsed / 60, timeElapsed % 60);
            if (MessageBox.Show("Нова игра?",caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                button1.Image=Properties.Resources.im1;
            }
        }

        private void крајToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
       
        
    }
}
