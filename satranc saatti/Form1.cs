using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satranc_saatti
{
    public partial class Form1 : Form
    {
        int sureBeyaz = 10, sureSiyah=10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start();
            this.lblBeyaz.ForeColor= Color.White;
        }

        private void timerBeyaz_Tick(object sender, EventArgs e)
        {
            sureBeyaz--;
            lblBeyaz.Text=sureBeyaz.ToString();
            if(sureBeyaz <= 0)
            {
                timerBeyaz.Stop();
                lblMesaj.Text = "sıyah kazandı";
            }

        }

        private void timerSiyah_Tick(object sender, EventArgs e)
        {
           sureSiyah--;
         lblSiyah.Text = sureSiyah.ToString();
            if (sureSiyah <= 0)
            {
                timerSiyah.Stop();
                lblMesaj.Text = "beyaz kazandı";
            }


        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timerBeyaz.Stop();
            timerSiyah.Start();
        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            timerSiyah.Stop();
            timerBeyaz.Start();
                
        }

        
    }
}
