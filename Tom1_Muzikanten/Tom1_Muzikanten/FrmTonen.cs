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
    public partial class FrmTonen : Form
    {

        Keuze _gekozen;

        public FrmTonen(Keuze keuze)
        {
            InitializeComponent();
            uitzicht(keuze);
            _gekozen = keuze;
            VulCmb();
        }



        private void uitzicht(Keuze ontvKeuze)
        {
            switch (ontvKeuze)
            {
                case Keuze.Instrumenten:
                    rbAlles.Text = "Toon alle instrumenten";
                    rb1specifiek.Text = "Toon de leerlingen van 1 specifieke instrument";
                    lblKies.Text = "Kies uw instrument:";
                    lblKies.Visible = false;
                    cmbKies.Visible = false;
                    rbAlles.Checked = true;


                    break;

                case Keuze.Leerlingen:
                    rbAlles.Text = "Toon alle leerlingen";
                    rb1specifiek.Text = "Toon de instrumenten van 1 specifieke leerling";
                    lblKies.Text = "Kies uw leerling:";
                    lblKies.Visible = false;
                    cmbKies.Visible = false;
                    rbAlles.Checked = true;

                    break;

                default:
                    throw new NotImplementedException();
                    break;
            }

        }

        private void VulCmb()
        {
            
            List<String> ontvGeg;
            if (_gekozen == Keuze.Instrumenten)
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

        private void rbAlles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlles.Checked)
            {
                lblKies.Visible = false;
                cmbKies.Visible = false;
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";
                txtToon.Text = "";
            }
            else
            {
                lblKies.Visible = true;
                cmbKies.Visible = true;
                txtToon.Text = "";
                
            }
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if(rbAlles.Checked)
            {
                if(_gekozen == Keuze.Instrumenten)
                {
                    txtToon.Text = Program.GetAlleGegInstrumenten();
                }
                else
                {
                    txtToon.Text = Program.GetAlleGegLln();
                }
            }
            else
            {
                int index = cmbKies.SelectedIndex;
                if (_gekozen == Keuze.Instrumenten)
                {
                    txtToon.Text = Program.LlnVanInstrument(index);
                }
                else
                {
                    txtToon.Text = Program.InstrVanLln(index);
                }
            }
        }
    }
    public enum Keuze : byte
    {
        Instrumenten,
        Leerlingen
    }
}
