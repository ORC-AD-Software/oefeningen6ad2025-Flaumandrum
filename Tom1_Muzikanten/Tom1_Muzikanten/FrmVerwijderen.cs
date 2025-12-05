using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tom1_Muzikanten.FrmVerwijderen;

namespace Tom1_Muzikanten
{
    public enum KeuzeVerw : byte
    {
        Instrumenten,
        Leerlingen

    }

    public partial class FrmVerwijderen : Form
    {

        KeuzeVerw _gekozen;

        public FrmVerwijderen(KeuzeVerw ontKeuze)
        {
            InitializeComponent();
            Uitzicht(ontKeuze);
            _gekozen = ontKeuze;
            VulCmb();
        }

        private void Uitzicht (KeuzeVerw ontKeuze)
        {
            switch (ontKeuze)
            {
                case KeuzeVerw.Instrumenten:
                    lblKies.Text = "Kies uw instrument";
                    break;
                case KeuzeVerw.Leerlingen:
                    lblKies.Text = "Kies uw leerling";
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
        }

        private void VulCmb()
        {

            List<String> ontvGeg;
            if (_gekozen == KeuzeVerw.Instrumenten)
            {
                ontvGeg = Program.GetNaamInstrumenten();
            }
            else
            {
                ontvGeg = Program.GetNaamLln();
            }

            cmbKies.Items.Clear();

            foreach (String s in ontvGeg)
            {
                cmbKies.Items.Add(s);
            }

        }

        private void ResetForm()
        {
            cmbKies.SelectedIndex = -1;
            cmbKies.Text = "";
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (cmbKies.SelectedIndex != -1) 
            { 
                if (_gekozen == KeuzeVerw.Instrumenten)
                {
                    Program.InstrVerwijderen(cmbKies.SelectedIndex);
                    
                    MessageBox.Show("Dit instrument werd verwijderd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Program.LlnVerwijderen(cmbKies.SelectedIndex);

                    MessageBox.Show("Deze leerling werd verwijderd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                ResetForm();

            }
            else
            {
                MessageBox.Show("U seleceteerde geen item", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
