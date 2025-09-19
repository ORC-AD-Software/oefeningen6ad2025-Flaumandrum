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
    public partial class FrmToevoegencs : Form
    {
        public FrmToevoegencs()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // controleren of alle velden zijn ingevuld
            if(txtNaam.Text != "" && txtStart.Text != "" && txtEinde.Text != "")
            {
                // probeer de datums om te zetten 
                try
                {
                    DateTime startDt = DateTime.Parse(txtStart.Text);
                    DateTime eindDt = DateTime.Parse(txtEinde.Text);

                    // voeg de vakantie toe
                    Program.Toevoegen(txtNaam.Text, startDt, eindDt);

                    // geef een bericht dat het gelukt is
                    MessageBox.Show("De vakantie is toegevoegd.", "toevoegen gelukt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // reset de velden
                    txtNaam.Text = "";
                    txtStart.Text = "";
                    txtEinde.Text = "";

                    // zet cursor terug naar naam
                    txtNaam.Focus();
                  

                }
                catch
                {
                    // toon foutmelding
                    MessageBox.Show("Ongeldige datum."+Environment.NewLine+"(dd-mm-yyyy)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            else 
            {
                // toon foutmelding
                MessageBox.Show("Vul alle velden in.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
    }
}
