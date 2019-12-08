using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float r = 0, a, b;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            if (radioButton1.Checked)
                r = a + b;
            if (radioButton2.Checked)
                r = a - b;
            if (radioButton3.Checked)
                r = a * b;
            if (radioButton4.Checked)
                if (b == 0)
                    MessageBox.Show("ERRO - Divisão por zero!");
                else
                    r = a / b;

            textBox3.Text = r.ToString();
            textBox1.Focus();

        }
    }
}
