using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ativ08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Soma dos números divisiveis por 4 até 200";
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
            for (int i = 1; i <= 200; i++)
            {
                if (i % 4 == 0)
                {
                    vi += i;
                }
            }

            return vi.ToString();
        }
    }
}
