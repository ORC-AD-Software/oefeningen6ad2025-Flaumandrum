using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tom1_Muzikanten
{
    public partial class FrmToevLln : Form
    {
        public FrmToevLln()
        {
            InitializeComponent();
            VulCmb();
        }

        // Velden 
        List<int> _indexen = new List<int>();

        private void VulCmb()
        {

            List<String> ontvGeg = Program.GetNaamInstrumenten();

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
            _indexen.Clear();
            txtToon.Text = "";
        }

        

        private void ToonGeg()
        {
            txtToon.Text = "";
            foreach (int i in _indexen)
            {
                txtToon.Text += cmbKies.Items[i].ToString() + Environment.NewLine;
            }
        }


        
        private void btnKoppel_Click(object sender, EventArgs e)
        {

            if (cmbKies.SelectedIndex != -1)
            {
                if (_indexen.Contains(cmbKies.SelectedIndex))
                {
                    MessageBox.Show("Dit instrument zit al in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _indexen.Add(cmbKies.SelectedIndex);
                    ToonGeg();
                }
            }
            else
            {
                MessageBox.Show("U moet eerst een instrument selecteren", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnOntkoppel_Click(object sender, EventArgs e)
        {
            if (cmbKies.SelectedIndex != -1)
            {
                if (_indexen.Contains(cmbKies.SelectedIndex))
                {
                    _indexen.Remove(cmbKies.SelectedIndex);
                    ToonGeg();
                }
                else
                {
                    MessageBox.Show("Dit instrument zit niet in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("U moet eerst een instrument selecteren", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLlnOpslaan_Click(object sender, EventArgs e)
        {
            if (txtLlnVn.Text != "" && txtLlnAn.Text != "")
            {
                Program.VoegLlnToe(txtLlnVn.Text, txtLlnAn.Text, _indexen);

                MessageBox.Show("Deze leerling werd opgeslagen", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            else
            {
                MessageBox.Show("Je vulde niet alle gegevens in", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
