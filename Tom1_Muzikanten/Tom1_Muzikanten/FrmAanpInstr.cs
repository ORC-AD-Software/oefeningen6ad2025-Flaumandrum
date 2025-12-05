using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomA_Muzikanten_Klasses;

namespace Tom1_Muzikanten
{
    public partial class FrmAanpInstr : Form
    {
        public FrmAanpInstr()
        {
            InitializeComponent();
            VulCmbInstr();
            VulCmbLln();
        }

        // Velden 
        List<int> _indexen = new List<int>();

        private void VulCmbInstr()
        {

            List<String> ontvGeg = Program.GetNaamInstrumenten();

            cmbKiesInstr.Items.Clear();

            foreach (String s in ontvGeg)
            {
                cmbKiesInstr.Items.Add(s);
            }

        }

        private void VulCmbLln()
        {

            List<String> ontvGeg = Program.GetNaamLln();

            cmbKies.Items.Clear();

            foreach (String s in ontvGeg)
            {
                cmbKies.Items.Add(s);
            }


        }

        private void VullijstIndexen(int indexInst)
        {
            Instrument ontvInstrument = Program.GetInstrument(indexInst);
            foreach(Leerling l in ontvInstrument.PropLeerlingen)
            {
                for(int i = 0; i < cmbKies.Items.Count; i++)
                {
                    if(l.VolledigeNaam() == cmbKies.Items[i].ToString())
                        _indexen.Add(i);
                }
                
            }
        }

        private void ToonIndexlijst ()
        {
            txtToon.Text = "";
            foreach (int i in _indexen)
            {
                txtToon.Text += cmbKies.Items[i].ToString() + Environment.NewLine;
            }
        }
        private void ResetForm()
        {
            cmbKiesInstr.SelectedIndex = -1;
            cmbKiesInstr.Text = "";
            cmbKies.SelectedIndex = -1;
            cmbKies.Text = "";
            txtToon.Text = "";
            _indexen.Clear();
            txtInstrNaam.Text = "";
            txtInstrGroep.Text = "";
        }

        private void cmbKiesInstr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKiesInstr.SelectedIndex != -1)
            {

                VullijstIndexen(cmbKiesInstr.SelectedIndex);
                Instrument ontvInstrument = Program.GetInstrument(cmbKiesInstr.SelectedIndex);
                txtInstrNaam.Text = ontvInstrument.PropNaam;
                txtInstrGroep.Text = ontvInstrument.PropGroep;
                ToonIndexlijst();

            }
        }

        private void btnKoppel_Click(object sender, EventArgs e)
        {
            if (_indexen.Contains(cmbKies.SelectedIndex))
            {
                MessageBox.Show("Deze leerling zit al in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _indexen.Add(cmbKies.SelectedIndex);
                ToonIndexlijst();
            }
        }

        private void btnOntkoppel_Click(object sender, EventArgs e)
        {
            if (_indexen.Contains(cmbKies.SelectedIndex))
            {
                _indexen.Remove(cmbKies.SelectedIndex);
                ToonIndexlijst();
            }
            else
            {
                MessageBox.Show("Deze leerling zit niet in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAanp_Click(object sender, EventArgs e)
        {
            if(cmbKies.SelectedIndex != -1)
            {

                Program.InstAanpassen(cmbKiesInstr.SelectedIndex, txtInstrNaam.Text, txtInstrGroep.Text, _indexen);

                MessageBox.Show("Dit instrument werd aangepast", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();

            }
            else
            {
                MessageBox.Show("U seleceteerde geen item", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
