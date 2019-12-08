using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ativ02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Temperatura convertida em graus Fahrenheit";
            this.Width = 350;
            this.Height = 250;
            Label label1 = new Label();
            Label label2 = new Label();
            TextBox textbox1 = new TextBox();
            TextBox textbox2 = new TextBox();
            Button button = new Button();

            label1.Name = "Label1";
            label1.Text = "Digite a temperatura em graus Fahrenheit:";
            label1.SetBounds(10, 20, 210, 30);
            this.Controls.Add(label1);

            label2.Name = "Label2";
            label2.Text = "Temperatura em graus Celsius:";
            label2.SetBounds(10, 120, 210, 30);
            this.Controls.Add(label2);

            textbox1.Name = "TextBox1";
            textbox1.SetBounds(220, 20, 100, 30);
            this.Controls.Add(textbox1);

            textbox2.Name = "TextBox2";
            textbox2.SetBounds(220, 120, 100, 30);
            textbox2.Enabled = false;
            this.Controls.Add(textbox2);

            button.Name = "Button1";
            button.Text = "Calcular";
            button.SetBounds(10, 60, 100, 30);
            button.Click += new System.EventHandler(Calcular);
            this.Controls.Add(button);
        }

        private void Calcular(object sender, EventArgs e)
        {
            float v = 0, r;
            v = float.Parse(this.Controls["TextBox1"].Text);
            r = ((v - 32) * 5) / 9;
            this.Controls["TextBox2"].Text = r.ToString();
        }
    }
}
