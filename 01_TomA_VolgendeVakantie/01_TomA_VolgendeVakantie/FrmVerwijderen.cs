using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TomA_VolgendeVakantie
{
    public partial class FrmVerwijderen : Form
    {
        public FrmVerwijderen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VulCmb()
        {
            // vraag de namen van de vakantie op
            List<String> vakanties = Program.StuurVakantieDoor();

            // Maak de cmb leeg
            cmbKies.Items.Clear();

            // vul de cmb met de vakantienamen
            for (int i = 0; i < vakanties.Count(); i++)
            {
                cmbKies.Items.Add(vakanties[i]);
            }


        }

        private void FrmVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }
    }
}
