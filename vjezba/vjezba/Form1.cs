using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listabrojeva = new List<int>();
            Random random_br = new Random();

            for (int i = 0; i < 2; i++)
            {
                int broj = random_br.Next(1, 100);
                listabrojeva.Add(broj);

        
            }

            textBox1.Text = listabrojeva[0].ToString();
            textBox2.Text = listabrojeva[1].ToString();

            int najveci = listabrojeva.Max();

            textBox3.Text = najveci.ToString();
        }


    }
}
