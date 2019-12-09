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
    public partial class Tulossivu : Form

    {
        public string syote;
        public Tulossivu()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        public void setTeksti(String syote)
        {
            Vihje.Text = syote;
        }
    }
}
