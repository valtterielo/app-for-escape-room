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
    public partial class Hakusivu : Form
    {
        
        public string syote;
        public int _ticks;


        public Hakusivu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            hakukentta.Text += "0";
        }

        private void vihje_Click(object sender, EventArgs e)
        {
            Tulossivu vastaus = new Tulossivu();

            //ajastin käynnistyy vihjenappia painettaessa ja määrittää sen, kuinka usein vihjeitä voidaan hakea
            timer1.Enabled = true;
            progressBar.Value = 0;
            syote = hakukentta.Text;

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
                vastaus.setTeksti("Tunnusta vastaavaa vihjettä ei löytynyt ");
            }

            //vastaus näytetään erillisessä "vastausikkunassa"
            vastaus.ShowDialog();
        }

        private void nollaa_Click(object sender, EventArgs e)
        {
            hakukentta.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;

            //ajastin asetettu tällä hetkellä 15 sekunttiin projektin demoamista varten, normaali arvo olisi 600

            if (_ticks >= 15)
            {
                timer1.Enabled = false;
                _ticks = 0;
            }

            if (progressBar.Value < 15)
            {
                progressBar.Value += 1;
            }
            else
            {
                timer1.Stop();
            }

            if (timer1.Enabled)
            {
                vihje.Enabled = false;
            }
            else
            {
                vihje.Enabled = true;
            }

        }

    }
}
