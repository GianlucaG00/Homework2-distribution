using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2___distribuzione
{
    public partial class Form1 : Form
    {
        List<double> list = new List<double>();
        int[] counter = new int[] { 0,0,0,0,0,0,0,0,0,0};
        int count = 0; 

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            double num = 0;


            num = random.NextDouble();

            if (num >= 0 && num < 0.1) textBox1.Text = (++counter[0]).ToString();
            else if (num >= 0.1 && num < 0.2) textBox2.Text = (++counter[1]).ToString();
            else if (num >= 0.2 && num < 0.3) textBox3.Text = (++counter[2]).ToString();
            else if (num >= 0.3 && num < 0.4) textBox4.Text = (++counter[3]).ToString();
            else if (num >= 0.4 && num < 0.5) textBox5.Text = (++counter[4]).ToString();
            else if (num >= 0.5 && num < 0.6) textBox6.Text = (++counter[5]).ToString();
            else if (num >= 0.6 && num < 0.7) textBox7.Text = (++counter[6]).ToString();
            else if (num >= 0.7 && num < 0.8) textBox8.Text = (++counter[7]).ToString();
            else if (num >= 0.8 && num < 0.9) textBox9.Text = (++counter[8]).ToString();
            else if (num >= 0.9 && num < 1) textBox10.Text = (++counter[9]).ToString();

            // calculate the average
            list.Add(num);
            double avg = list.Average();
            this.richTextBox1.AppendText(num.ToString() + " ----> CURR_AVG: " + avg + "\n");

            // print the amount of number generated
            amountNumbers.Text = (++count).ToString();
            currAvg.Text = avg.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Enabled = true; 
                GenerateBtn.Text = "Stop"; 
            }
            else
            {
                timer1.Enabled = false; 
                GenerateBtn.Text = "Generate"; 
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
