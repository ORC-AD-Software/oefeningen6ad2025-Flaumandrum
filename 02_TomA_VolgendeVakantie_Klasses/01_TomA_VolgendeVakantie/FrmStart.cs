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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmToevoegencs nieuwFrom = new FrmToevoegencs();

            // oude form verbergen
            Hide();

            // nieuwe form tonen
            nieuwFrom.ShowDialog();

            // oude form tonen
            Show();

        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAantalDagen_Click(object sender, EventArgs e)
        {
            // vraag het aantal dagen op
            String antwoord = Program.AantalDagen();

            // toon het antwoord
            MessageBox.Show(antwoord, "Aantal dagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmVerwijderen nieuwFrom = new FrmVerwijderen();

            // oude form verbergen
            Hide();

            // nieuwe form tonen
            nieuwFrom.ShowDialog();

            // oude form tonen
            Show();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmAanpassen nieuwFrom = new FrmAanpassen();

            // oude form verbergen
            Hide();

            // nieuwe form tonen
            nieuwFrom.ShowDialog();

            // oude form tonen
            Show();
        }

        private void btnToonAlle_Click(object sender, EventArgs e)
        {
            // nieuwe form aanmaken
            FrmTonen nieuwFrom = new FrmTonen();

            // oude form verbergen
            Hide();

            // nieuwe form tonen
            nieuwFrom.ShowDialog();

            // oude form tonen
            Show();
        }
    }
}
