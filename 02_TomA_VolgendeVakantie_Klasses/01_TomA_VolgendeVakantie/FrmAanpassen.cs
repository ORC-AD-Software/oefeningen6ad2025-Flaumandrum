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
    public partial class FrmAanpassen : Form
    {
        public FrmAanpassen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // is alles ingevuld?
            if(cmbKies.SelectedIndex != -1 && txtNaam.Text != "" && txtStart.Text != "" && txtEinde.Text != "")
            {
                try
                {
                    // probeer de datums om te zetten
                    String naamVakantie = txtNaam.Text;
                    DateTime startDt = DateTime.Parse(txtStart.Text);
                    DateTime eindDt = DateTime.Parse(txtEinde.Text);

                    // pas de vakantie aan
                    Program.Aanpassen(cmbKies.SelectedIndex, txtNaam.Text, startDt, eindDt);

                    // geef een bericht dat het gelukt is
                    MessageBox.Show("De vakantie is aangepast.", "Aanpassen gelukt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset de formulier
                    txtNaam.Text = "";
                    txtStart.Text = "";
                    txtEinde.Text = "";

                    cmbKies.SelectedIndex = -1;
                    cmbKies.Text = "";

                    VulCmb();

                }
                catch
                {
                    // toon foutmelding
                    MessageBox.Show("Ongeldige datum." + Environment.NewLine + "(dd-mm-yyyy)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            else
            {
                // toon foutmelding
                MessageBox.Show("Vul alle velden in.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void FrmAanpassen_Load(object sender, EventArgs e)
        {
           VulCmb();    
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
    }
}
