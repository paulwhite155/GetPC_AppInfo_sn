using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPC_AppInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Environment.MachineName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Environment.UserName;
            MessageBox.Show("welcome back" + Environment.UserName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = Environment.ProcessorCount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = Environment.TickCount.ToString();
            Int32 time;
            time = Environment.TickCount / 1000;
            Int32 timemin;
            Int32 timehr;
            timemin = (time/60);
            timehr = (timemin/60);
            this.textBox5.Text = time.ToString();
            this.textBox6.Text = timemin.ToString();
            this.textBox7.Text = timehr.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox8.Text=System.Windows.Forms.Screen.PrimaryScreen.Bounds.ToString();
        }
    }
}
