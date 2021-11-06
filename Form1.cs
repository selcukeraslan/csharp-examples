using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        public void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        public void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy,kilo,vki;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);

            vki = kilo / (boy * boy);

            label4.Text = vki.ToString();

            string durum;

            if (vki < 18 )
            {
                durum = "Sıska";
            }
            else if (vki >= 18 && vki <= 25)
            {
                durum = "Normal";
            }
            else if (vki > 25 && vki <= 30)
            {
                durum = "Kilolu";
            }
            else if (vki > 30 && vki <= 35 )
            {
                durum = "Obez";
            }
            else
            {
                durum = "Damızlık FatShit";
            }

            label6.Text = durum.ToString();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
