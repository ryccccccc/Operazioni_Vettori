using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operazioni_Vettori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            label1.Text = (v1 + v2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            label1.Text = (v1 - v2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* if (Vector.TryParse(Console.ReadLine(), ref v1))
           {
               Console.WriteLine(v1 + v2);
           }
           else
           {
               Console.WriteLine("COMPONENTI NON CORRETTE");
           }
           if (Vector.TryParse(Console.ReadLine(), ref v2))
           {
               Console.WriteLine(v1 + v2);
           }
           else
           {
               Console.WriteLine("COMPONENTI NON CORRETTE");
           }*/
            int n = int.Parse(textBox1.Text);
            Vector v = Vector.Parse(textBox2.Text);
            label1.Text = (n * v).ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(textBox1.Text);
            int n = int.Parse(textBox2.Text);
            label1.Text = (v * n).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            label1.Text = (v1 * v2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(label1.Text);
            label1.Text = (-v).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vector v1 = Vector.Parse(textBox1.Text);
            Vector v2 = Vector.Parse(textBox2.Text);
            label1.Text = (v1 / v2).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(textBox1.Text);
            label2.Text = (v.Versore()).ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Vector v = Vector.Parse(textBox2.Text);
            label3.Text = (v.Versore()).ToString();
        }
    }
}
