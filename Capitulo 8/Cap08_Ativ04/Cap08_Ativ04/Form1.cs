using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ativ04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox1.Text) == 0)
            {
                MessageBox.Show("Valor de a deve ser diferente de 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (float.Parse(textBox2.Text) == 0)
            {
                MessageBox.Show("Valor de b deve ser diferente de 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
            }
            else if (float.Parse(textBox3.Text) == 0)
            {
                MessageBox.Show("Valor de c deve ser diferente de 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                textBox3.Focus();
            }
            else
            {
                double a, b, c, delta, x1, x2;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);

                delta = Math.Pow(b, 2) - (4 * a * c);

                if (delta < 0)
                {
                    label4.Text = "Delta = " + delta.ToString();
                    label4.Visible = true;
                    if (label5.Visible == true)
                        label5.Visible = false;
                }
                else if (delta == 0)
                {
                    x1 = (-b + Math.Pow(delta, (1.0 / 2.0))) / (2 * a);
                    label4.Text = "X1 = " + x1.ToString();
                    label4.Visible = true;
                }
                else
                {
                    x1 = (-b + Math.Pow(delta, (1.0 / 2.0))) / (2 * a);
                    x2 = (-b - Math.Pow(delta, (1.0 / 2.0))) / (2 * a);
                    label4.Text = "X1 = " + x1.ToString();
                    label5.Text = "X2 = " + x2.ToString();
                    label4.Visible = true;
                    label5.Visible = true;
                }
            }
        }
    }
}
