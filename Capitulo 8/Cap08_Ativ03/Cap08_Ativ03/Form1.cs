using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ativ03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Troca de valores";
            Width = 350;
            Height = 280;
            Label label1 = new Label();
            Label label2 = new Label();
            TextBox textbox1 = new TextBox();
            TextBox textbox2 = new TextBox();
            Button button = new Button();

            label1.Name = "Label1";
            label1.Text = "Valor de a";
            label1.SetBounds(15, 20, 150, 30);
            this.Controls.Add(label1);

            label2.Name = "Label2";
            label2.Text = "Valor de b";
            label2.SetBounds(15, 50, 150, 30);
            this.Controls.Add(label2);

            button.Name = "Button1";
            button.Text = "Trocar";
            button.SetBounds(110, 90, 100, 30);
            button.Click += new EventHandler(Trocar);
            this.Controls.Add(button);

            textbox1.Name = "TextBox1";
            textbox1.SetBounds(180, 20, 100, 30);
            this.Controls.Add(textbox1);

            textbox2.Name = "TextBox2";
            textbox2.SetBounds(180, 50, 100, 30);
            this.Controls.Add(textbox2);
        }

        private void Trocar(object sender, EventArgs e)
        {
            string a, aux;
            aux = this.Controls["TextBox1"].Text;
            this.Controls["TextBox1"].Text = this.Controls["TextBox2"].Text;
            this.Controls["TextBox2"].Text = aux;

        }
    }
}
