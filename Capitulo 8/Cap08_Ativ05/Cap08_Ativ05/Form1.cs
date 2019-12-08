using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ativ05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, nex, md, nf;

            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = double.Parse(textBox3.Text);
            n4 = double.Parse(textBox4.Text);

            md = (n1 + n2 + n3 + n4) / 4;

            if (textBox5.Enabled == true)
            {
                nex = double.Parse(textBox5.Text);
                nf = (md + nex) / 2;
                if (nf < 5)
                {
                    MessageBox.Show("Aluno reprovado", "Que pena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    label6.Text = "Reprovado nota = " + nf.ToString();
                    label6.Visible = true;
                    textBox5.Enabled = false;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox1.Focus();
                }
                else if (nf >= 5)
                {
                    MessageBox.Show("Aluno aprovado", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label6.Text = "Aprovado nota = " + nf.ToString();
                    label6.Visible = true;
                    textBox5.Enabled = false;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox1.Focus();
                }
            }
            else
            {

                if (md >= 7)
                {
                    MessageBox.Show("Aluno aprovado", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label6.Text = "Aprovado nota = " + md.ToString();
                    label6.Visible = true;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox1.Focus();
                }
                else if (md < 7)
                {
                    MessageBox.Show("Aluno em recuperação informe a nota do exame", "Não foi dessa vez", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    label6.Text = "Recuperação nota = " + md.ToString();
                    label6.Visible = true;
                    textBox5.Enabled = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Focus();
                }
            }
        }
    }
}
