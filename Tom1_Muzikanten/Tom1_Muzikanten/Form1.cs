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
    public partial class Form1 : Form
    {
        FrmTonen ToonGegevens;
        FrmToevInstr InstToev;
        FrmAanpInstr AanpInstr;
        FrmAanpLln AanpLln;
        FrmToevLln toevLln;
        FrmVerwijderen Verwijderen;

        public Form1()
        {
            InitializeComponent();
        }

        bool menuExpand = false, menuBewLlnExpand = false, menuBewInstExpand = false, zijpaneelExpand = true;

        

        private void menuOvergang_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                RaadpleegContainer.Height += 10;
                if (RaadpleegContainer.Height >= 139)
                {
                    menuOvergang.Stop();
                    menuExpand = true;
                }

            }
            else
            {
                RaadpleegContainer.Height -= 10;
                if (RaadpleegContainer.Height <= 47)
                {
                    menuOvergang.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnRaadpleegGeg_Click(object sender, EventArgs e)
        {
            menuOvergang.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBewerkLln_Click(object sender, EventArgs e)
        {
            BewLlnOverg.Start();
        }

        private void BtnBewerkInst_Click(object sender, EventArgs e)
        {
            BewInstOverg.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Zijpaneel.Start();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRaadpleegInst_Click(object sender, EventArgs e)
        {
            ToonForm(Keuze.Instrumenten);
        }

        private void ToonForm(Keuze keuze)
        {
            SluitForms();

            if (ToonGegevens == null)
            {
                ToonGegevens = new FrmTonen(keuze);
                ToonGegevens.FormClosed += ToonGegevens_FormClosed;
                ToonGegevens.MdiParent = this;
                ToonGegevens.Dock = DockStyle.Fill;
                ToonGegevens.Show();
            }
            else
            {
                ToonGegevens.Activate();
            }
        }

        private void ToonGegevens_FormClosed(object sender, FormClosedEventArgs e)
        {
            ToonGegevens = null;

        }

        private void SluitForms()
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "Form1")
                    f.Close();

            }
        }


        private void btnRaadpleegLln_Click(object sender, EventArgs e)
        {
            ToonForm(Keuze.Leerlingen);
        }

        private void btnInstToev_Click(object sender, EventArgs e)
        {
            SluitForms();

            if (ToonGegevens == null)
            {
                InstToev = new FrmToevInstr();
                InstToev.FormClosed += InstToev_FormClosed;
                InstToev.MdiParent = this;
                InstToev.Dock = DockStyle.Fill;
                InstToev.Show();
            }
            else
            {
                InstToev.Activate();
            }
        }

        private void InstToev_FormClosed(object sender, FormClosedEventArgs e)
        {
            InstToev = null;
        }

        private void Zijpaneel_Tick(object sender, EventArgs e)
        {
            // FlpSide
            if (zijpaneelExpand)
            {
                FlpSide.Width -= 10;
                if (FlpSide.Width <= 53)
                {
                    Zijpaneel.Stop();
                    zijpaneelExpand = false;
                }

            }
            else
            {
                FlpSide.Width += 10;
                if (FlpSide.Width >= 267)
                {
                    Zijpaneel.Stop();
                    zijpaneelExpand = true;
                }
            }
        }

        private void BewInstOverg_Tick(object sender, EventArgs e)
        {
            if (menuBewInstExpand == false)
            {
                MenuBewInstr.Height += 10;
                if (MenuBewInstr.Height >= 189)
                {
                    BewInstOverg.Stop();
                    menuBewInstExpand = true;
                }

            }
            else
            {
                MenuBewInstr.Height -= 10;
                if (MenuBewInstr.Height <= 47)
                {
                    BewInstOverg.Stop();
                    menuBewInstExpand = false;
                }
            }
        }

        private void btnInstVerw_Click(object sender, EventArgs e)
        {
            ToonVerwijderen(KeuzeVerw.Instrumenten);
        }

        private void BtnLlnVerw_Click(object sender, EventArgs e)
        {
            ToonVerwijderen(KeuzeVerw.Leerlingen);
        }

        private void btnInstAanp_Click(object sender, EventArgs e)
        {
            SluitForms();

            if (AanpInstr == null)
            {
                AanpInstr = new FrmAanpInstr();
                AanpInstr.FormClosed += AanpInstr_FormClosed;
                AanpInstr.MdiParent = this;
                AanpInstr.Dock = DockStyle.Fill;
                AanpInstr.Show();
            }
            else
            {
                AanpInstr.Activate();
            }
        }

        private void AanpInstr_FormClosed(object sender, FormClosedEventArgs e)
        {
            AanpInstr = null;
        }

        private void btnLlnAanpassen_Click(object sender, EventArgs e)
        {
            SluitForms();

            if (AanpLln == null)
            {
                AanpLln = new FrmAanpLln();
                AanpLln.FormClosed += AanpLln_FormClosed;
                AanpLln.MdiParent = this;
                AanpLln.Dock = DockStyle.Fill;
                AanpLln.Show();
            }
            else
            {
                AanpLln.Activate();
            }
        }

        private void AanpLln_FormClosed(object sender, FormClosedEventArgs e)
        {
            AanpLln = null;
        }

        private void btnLlnToev_Click(object sender, EventArgs e)
        {
            SluitForms();

            if (toevLln == null)
            {
                toevLln = new FrmToevLln();
                toevLln.FormClosed += toevLln_FormClosed;
                toevLln.MdiParent = this;
                toevLln.Dock = DockStyle.Fill;
                toevLln.Show();
            }
            else
            {
                toevLln.Activate();
            }
        }

        private void toevLln_FormClosed(object sender, FormClosedEventArgs e)
        {
            toevLln = null;
        }

        private void BewLlnOverg_Tick(object sender, EventArgs e)
        {
            if (menuBewLlnExpand == false)
            {
                BewerkLlnContainer.Height += 10;
                if (BewerkLlnContainer.Height >= 189)
                {
                    BewLlnOverg.Stop();
                    menuBewLlnExpand = true;
                }

            }
            else
            {
                BewerkLlnContainer.Height -= 10;
                if (BewerkLlnContainer.Height <= 47)
                {
                    BewLlnOverg.Stop();
                    menuBewLlnExpand = false;
                }
            }


        }
        private void ToonVerwijderen(KeuzeVerw keuze2)
        {
            SluitForms();

            if (Verwijderen == null)
            {
                Verwijderen = new FrmVerwijderen(keuze2);
                Verwijderen.FormClosed += Verwijderen_FormClosed;
                Verwijderen.MdiParent = this;
                Verwijderen.Dock = DockStyle.Fill;
                Verwijderen.Show();
            }
            else
            {
                Verwijderen.Activate();
            }
        }

        private void Verwijderen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Verwijderen = null;
        }

        
    }
}
