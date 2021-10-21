using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeDoen;

namespace TeDoem
{
    public partial class Form1 : Form
    {

        Rij<Taak> toDoList = new Rij<Taak>();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void cbTijdstip_CheckedChanged(object sender, EventArgs e)
        {
            dtpTijdstip.Enabled = false;
            dtpTijdstip.Visible = false;
            label2.Visible = false;
            if (cbTijdstip.Checked)
            {
                dtpTijdstip.Enabled = true; 
                dtpTijdstip.Visible = true;
                label2.Visible = true;
            }
        }

        private void btOpslaan_Click(object sender, EventArgs e)
        {
            string titel = tbTitel.Text;
            string informatie = tbInformatie.Text;
            DateTime tijdstip = DateTime.Parse(dtpTijdstip.Text);

            Taak test = new Taak(titel, informatie, tijdstip);

            toDoList.Toevoegen(test);

            tbString.Text = toDoList.ToString();

            tbTitel.Clear();
            tbInformatie.Clear();

        }

        private void btAllesMeedelen_Click(object sender, EventArgs e)
        {
            btAllesMeedelen.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void btVolgendeTaak_Click(object sender, EventArgs e)
        {
            //hier moet het event uitgevoerd worden. 
            Taak test = new Taak();
            //test.ToonMij += new Toon();



        }
    }
}
