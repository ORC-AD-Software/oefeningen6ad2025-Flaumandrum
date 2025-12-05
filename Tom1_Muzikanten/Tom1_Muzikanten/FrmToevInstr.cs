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
    public partial class FrmToevInstr : Form
    {
        public FrmToevInstr()
        {
            InitializeComponent();
            VulCmb();
        }

        // Velden 
        List<int> _indexen = new List<int>();

        private void VulCmb()
        {

            List<String> ontvGeg = Program.GetNaamLln();
            
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

        private void btnKoppel_Click(object sender, EventArgs e)
        {
            if(cmbKies.SelectedIndex != -1)
            {
                if (_indexen.Contains(cmbKies.SelectedIndex))
                {
                    MessageBox.Show("Deze leerling zit al in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _indexen.Add(cmbKies.SelectedIndex);
                    ToonGeg();
                }
            }
            else
            {
                MessageBox.Show("U moet eerst een leerling selecteren.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ToonGeg()
        {
            txtToon.Text = "";
            foreach (int i in _indexen)
            {
                txtToon.Text += cmbKies.Items[i].ToString() + Environment.NewLine;
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
                    MessageBox.Show("Deze leerling zit niet in de lijst", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("U moet eerst een leerling selecteren.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnOpsl_Click(object sender, EventArgs e)
        {
            if(txtInstrGroep.Text != "" && txtInstrNaam.Text != "")
            {
                Program.VoegInstToe(txtInstrNaam.Text, txtInstrGroep.Text, _indexen);

                MessageBox.Show("Dit instrument werd opgeslagen", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            else
            {
                MessageBox.Show("Je vulde niet alle gegevens in", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
