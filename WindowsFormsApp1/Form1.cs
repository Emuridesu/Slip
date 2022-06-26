using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static double ans;
        public Form1()
        {
            InitializeComponent();
        }
        public int flag;
        public double taxc;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "課税")
            {
                flag = 1;
            }
            else if(comboBox1.Text == "非課税")
            {
                flag = 0;
                taxc = 0;

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
             textBox1.Select(0,0);
        }

   

        private void label1_Click_2(object sender, EventArgs e)
        {
            int a = int.Parse(textBox10.Text);
            int b = int.Parse(textBox9.Text);
            ans = 0;
            ans = a * b;
            label1.Text = ans.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            double taxc1 = 0.08;
            double taxc2 = 0.05;
            double taxc3 = 0.03;

            double taxc4 = 0;
            double w=0;

            DateTime time = dateTimePicker1.Value;

            DateTime time1 = DateTime.Parse("2014/4/1");
            DateTime time2 = DateTime.Parse("1997/4/1");
            DateTime time3 = DateTime.Parse("1989/4/1");
            if (time > time1)
            {
                w = ans * taxc1*flag;


            }


            else if (time1 >= time && time2 < time)
            {
                w = ans * taxc2 * flag;
            }
            else if (time2 >= time && time3 < time)
            {
                w = ans * taxc3 * flag;
            }




            else if (time3 >= time)
            {
                w = ans * taxc4 * flag;

            }

            label2.Text = w.ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label2_Click(object sender, CancelEventArgs e)
        {

        }
    }
}
