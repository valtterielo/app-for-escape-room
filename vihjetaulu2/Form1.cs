using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vihjetaulu2
{
    public partial class Form1 : Form

    {
        public string syote;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Vihje_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 valikko = new Form2();
            valikko.ShowDialog();
            this.Close();
        }

        public void setTeksti(String syote)
        {
            Vihje.Text = syote;
        }
    }
}
