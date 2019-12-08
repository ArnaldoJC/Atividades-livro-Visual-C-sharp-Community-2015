using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ativ07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Soma dos 100 primeiros números";
            Width = 200;
            Height = 200;
            Label label = new Label();
            label.Text = result();
            label.SetBounds(20, 20, 153, 25);
            this.Controls.Add(label);
        }

        private string result()
        {
            int vi = 0;
            for (int i = 0; i <= 100; i++)
            {
                vi += i;
            }

            return vi.ToString();
        }
    }
}
