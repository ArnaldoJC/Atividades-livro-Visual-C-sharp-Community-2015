using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label rotulo1 = new Label();
            Label rotulo2 = new Label();
            Label rotulo3 = new Label();
            Button botao1 = new Button();
            Button botao2 = new Button();
            int i, posicao;

            this.Text = "Média escolar - Variável Indexada";
            this.Width = 329;
            this.Height = 300;

            rotulo1.Text = "Entre com as médias escolares:";
            rotulo1.SetBounds(12, 19, 176, 13);
            this.Controls.Add(rotulo1);

            rotulo2.Text = "Média geral:";
            rotulo2.SetBounds(141, 234, 67, 13);
            this.Controls.Add(rotulo2);

            rotulo3.Name = "Label3";
            rotulo3.Text = "Label3";
            rotulo3.SetBounds(214, 234, 39, 13);
            this.Controls.Add(rotulo3);

            posicao = 45;

            for (i = 1; i <= 8; i++)
            {
                TextBox campo = new TextBox();
                campo.Name = "TextBox" + i.ToString();
                campo.SetBounds(15, posicao, 60, 20);
                this.Controls.Add(campo);
                posicao += 26;
            }

            botao1.Text = "Processar";
            botao1.SetBounds(133, 198, 73, 23);
            botao1.Click += new System.EventHandler(Processar);
            this.Controls.Add(botao1);

            botao2.Text = "Limpar";
            botao2.SetBounds(215, 198, 73, 23);
            botao2.Click += new System.EventHandler(Limpar);
            this.Controls.Add(botao2);
        }
        
        private void Processar(object sender, EventArgs e)
        {
            float soma, media, valor;
            int j;
            soma = 0;
            j = 0;
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                    j += 1;
                }

                media = soma / 8;
                this.Controls["Label3"].Text = media.ToString();
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }

                this.Controls["Label3"].Text = "Label3";
                this.Controls["TextBox1"].Focus();
            }
        }
    }
}
