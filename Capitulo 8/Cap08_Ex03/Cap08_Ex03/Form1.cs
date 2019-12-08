using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, x, a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            x = a + b;
            if (x >= 10)
            {
                r = x + 5;
                MessageBox.Show("r = " + r.ToString(), "Resultado v");
            }
            else
            {
                r = x - 7;
                MessageBox.Show("r = " + r.ToString(), "Resultado p");
            }
            textBox1.Focus();
        }
    }
}
