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
            List<Vakantie> vakanties = Program.StuurVakantieDoor();

            // Maak de cmb leeg
            cmbKies.Items.Clear();

            // vul de cmb met de vakantienamen van de verschillede vakatieobjecten
            for (int i = 0; i < vakanties.Count(); i++)
            {
                cmbKies.Items.Add(vakanties[i].PropVakantienaam);
            }


        }

        private void FrmVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // controleer of er iets is geselecteerd
            if(cmbKies.SelectedIndex != -1)
            {
                // verwijder de vakantie op basis van de index
                Program.Verwijderen(cmbKies.SelectedIndex);

                // geef een bericht dat het gelukt is
                MessageBox.Show("De vakantie is verwijderd.", "Verwijderen gelukt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // form resetten
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";

                // herlaad de cmb
                VulCmb();
            }
            else
            {
                // geef een bericht dat er niets is geselecteerd
                MessageBox.Show("Er is geen vakantie geselecteerd om te verwijderen.", "Verwijderen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
