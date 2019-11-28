using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vihjetaulu2
{
    public partial class Form2 : Form
    {
        
        public string syote;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kentta.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kentta.Text += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kentta.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kentta.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kentta.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kentta.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kentta.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kentta.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kentta.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            kentta.Text += "0";
        }

        private void vihje_Click(object sender, EventArgs e)
        {
            Form1 vastaus = new Form1();
            syote = kentta.Text;
            string polku = "C:\\Users\\Valtteri\\Desktop\\vihjeita\\" + syote + ".txt";


            try
            {
                using (System.IO.StreamReader sr = File.OpenText(polku))
                {
                    string teksti = sr.ReadToEnd();
                    vastaus.setTeksti(teksti);
                }
            }
            catch (Exception)
            {
                vastaus.setTeksti("Tapahtui virhe ");
            }

            this.Hide();
            vastaus.ShowDialog();
            this.Close();
            
        }

        private void nollaa_Click(object sender, EventArgs e)
        {
            kentta.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
