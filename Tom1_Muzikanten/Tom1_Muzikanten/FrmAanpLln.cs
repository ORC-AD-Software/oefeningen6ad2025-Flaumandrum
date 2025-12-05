using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomA_Muzikanten_Klasses;

namespace Tom1_Muzikanten
{
    public partial class FrmAanpLln : Form
    {
        public FrmAanpLln()
        {
            InitializeComponent();
            VulCmbLln();
            VulCmbInst();
        }

        // Velden 
        List<int> _indexen = new List<int>();

        private void VulCmbLln()
        {
            List<String> ontvGeg = Program.GetNaamLln();

            cmbKiesLln.Items.Clear();

            foreach (String s in ontvGeg)
            {
                cmbKiesLln.Items.Add(s);
            }

        }

        private void VulCmbInst()
        {

            List<String> ontvGeg = Program.GetNaamInstrumenten();

            cmbKies.Items.Clear();

            foreach (String s in ontvGeg)
            {
                cmbKies.Items.Add(s);
            }

        }

        private void VullijstIndexen(int indexInst)
        {
            Leerling ontvLln = Program.GetLeerling(indexInst);
            foreach (Instrument inst in ontvLln.PropInstrumenten)
            {
                for (int i = 0; i < cmbKies.Items.Count; i++)
                {
                    if (inst.PropNaam == cmbKies.Items[i].ToString())
                        _indexen.Add(i);
                }

            }
        }

        private void ToonIndexlijst()
        {
            txtToon.Text = "";
            foreach (int i in _indexen)
            {
                txtToon.Text += cmbKies.Items[i].ToString() + Environment.NewLine;
            }
        }

        private void ResetForm()
        {
            cmbKiesLln.SelectedIndex = -1;
            cmbKiesLln.Text = "";
            cmbKies.SelectedIndex = -1;
            cmbKies.Text = "";
            txtToon.Text = "";
            _indexen.Clear();
            txtLlnVn.Text = "";
            txtLlnAn.Text = "";
        }

        private void cmbKiesLln_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKiesLln.SelectedIndex != -1)
            {
                VullijstIndexen(cmbKiesLln.SelectedIndex);
                Leerling ontvLln = Program.GetLeerling(cmbKiesLln.SelectedIndex);
                txtLlnVn.Text = ontvLln.PropVoornaam;
                txtLlnAn.Text = ontvLln.PropAchternaam;
                ToonIndexlijst();
            }
            
        }

        private void btnKoppel_Click(object sender, EventArgs e)
        {
            if (_indexen.Contains(cmbKies.SelectedIndex))
            {
                MessageBox.Show("Dit instrument zit al in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Dit instrument zit niet in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLlnAanp_Click(object sender, EventArgs e)
        {
            if (cmbKies.SelectedIndex != -1)
            {

                Program.LlnAanpassen(cmbKiesLln.SelectedIndex, txtLlnVn.Text, txtLlnAn.Text, _indexen);

                MessageBox.Show("Deze leerling werd aangepast", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            else
            {
                MessageBox.Show("U seleceteerde geen item", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    
}
