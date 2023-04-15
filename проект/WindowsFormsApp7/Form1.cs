using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = 5.4;
            double x1 = 1;
            double xn = double.Parse(textBox1.Text);
            double xdel = double.Parse(textBox2.Text);

            while (x1 <= xn)
            {
                double y = Math.Log(x1 + Math.Sqrt(b * Math.Pow(Math.Sin(1), 2) * (b * x1) + 1));
                richTextBox1.Text += $"x ={x1}\n" + "y = " + Math.Round(y, 2).ToString() + "\n";
                x1 += xdel;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double b = 5.4;
            double x1 = 1;
            double xn = double.Parse(textBox1.Text);
            double xdel = double.Parse(textBox2.Text);

            for (x1 =1; x1 <= xn; x1 += xdel)
            {
                double y = Math.Log(x1 + Math.Sqrt(b * Math.Pow(Math.Sin(1), 2) * (b * x1) + 1));
                richTextBox1.Text += $"x ={x1}\n" + "y = " + Math.Round(y, 2).ToString() + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
            Form2 f = new Form2();
            f.ShowDialog();


        }
    }
}
