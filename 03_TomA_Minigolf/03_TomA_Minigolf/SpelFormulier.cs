﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_TomA_Minigolf
{
    public partial class SpelFormulier : Form
    {
        public SpelFormulier()
        {
            InitializeComponent();
        }

        private void Uiterlijk(String thema)
        {
            if (thema == "Startform")
            {
                lblKies.Visible = false;
                lblKies.Text = "Kies een speler:";
                cmbKies.Visible = false;
                lblVoorn.Visible = false;
                lblVoorn.Text = "Voornaam:";
                lblVoorn.Font = new Font(lblVoorn.Font, FontStyle.Regular);
                txtVoorn.Visible = false;
                lblFamN.Visible = false;
                lblFamN.Text = "Familienaam:";
                txtFamN.Visible = false;
                btnActie.Visible = false;
                btnAnnuleren.Visible = false;
                btnVorige.Visible = false;
                btnVolgende.Visible = false;
                txtToon.Size = new Size(517, 300);
                this.Size = new Size(860, 380);
            }
            else if (thema == "Toevoegen")
            {
                lblKies.Visible = false;
                cmbKies.Visible = false;
                lblVoorn.Visible = true;
                lblVoorn.Location = new Point(24, 330);
                txtVoorn.Visible = true;
                txtVoorn.Location = new Point(24, 358);
                lblFamN.Visible = true;
                lblFamN.Location = new Point(24, 393);
                txtFamN.Visible = true;
                txtFamN.Location = new Point(24, 420);
                btnActie.Visible = true;
                btnActie.Text = "Toevoegen";
                btnActie.Location = new Point(24, 471);
                btnAnnuleren.Visible = true;
                btnAnnuleren.Location = new Point(24, 521);
                btnVorige.Visible = false;
                btnVolgende.Visible = false;
                txtToon.Size = new Size(517, 535);
                this.Size = new Size(860, 615);
            }
            else if (thema == "Aanpassen")
            {
                lblKies.Visible = true;
                lblKies.Location = new Point(24, 330);
                cmbKies.Visible = true;
                cmbKies.Location = new Point(24, 358);
                lblVoorn.Visible = true;
                lblVoorn.Location = new Point(24, 393);
                txtVoorn.Visible = true;
                txtVoorn.Location = new Point(24, 420);
                lblFamN.Visible = true;
                lblFamN.Location = new Point(24, 455);
                txtFamN.Visible = true;
                txtFamN.Location = new Point(24, 482);
                btnActie.Visible = true;
                btnActie.Text = "Aanpassen";
                btnActie.Location = new Point(24, 531);
                btnAnnuleren.Visible = true;
                btnAnnuleren.Location = new Point(24, 581);
                btnVorige.Visible = false;
                btnVolgende.Visible = false;

                txtToon.Size = new Size(517, 590);
                this.Size = new Size(860, 690);
            }
            else if (thema == "Verwijderen")
            {
                lblKies.Visible = true;
                lblKies.Location = new Point(24, 330);
                cmbKies.Visible = true;
                cmbKies.Location = new Point(24, 358);
                lblVoorn.Visible = false;
                txtVoorn.Visible = false;
                lblFamN.Visible = false;
                txtFamN.Visible = false;
                btnActie.Visible = true;
                btnActie.Text = "Verwijderen";
                btnActie.Location = new Point(24, 409);
                btnAnnuleren.Visible = true;
                btnAnnuleren.Location = new Point(24, 459);
                btnVorige.Visible = false;
                btnVolgende.Visible = false;
                txtToon.Size = new Size(517, 470);
                this.Size = new Size(860, 560);
            }
            else if (thema == "Startspel")
            {
                lblKies.Visible = true;
                lblKies.Text = "Actieve Speler:";
                lblKies.Location = new Point(24, 330);

                cmbKies.Visible = false;

                lblVoorn.Visible = true;
                lblVoorn.Text = "";
                lblVoorn.Font = new Font(lblVoorn.Font, FontStyle.Bold);
                lblVoorn.Location = new Point(24, 358);

                btnVorige.Visible = true;
                btnVorige.Location = new Point(24, 393);
                btnVolgende.Visible = true;
                btnVolgende.Location = new Point(130, 393);

                txtVoorn.Visible = false;

                lblFamN.Visible = true;
                lblFamN.Text = "Voeg extra slagen toe:";
                lblFamN.Location = new Point(24, 478);
                txtFamN.Visible = true;
                txtFamN.Location = new Point(24, 505);


                btnActie.Visible = true;
                btnActie.Text = "Toevoegen";
                btnActie.Location = new Point(24, 550);
                btnAnnuleren.Visible = true;
                btnAnnuleren.Location = new Point(24, 600);

                txtToon.Size = new Size(517, 610);
                this.Size = new Size(860, 710);
            }
        }

        private void SpelFormulier_Load(object sender, EventArgs e)
        {
            Uiterlijk("Startform");
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            if (btnAnnuleren.Visible == true)
            {
                Uiterlijk("Startform");
            }
            else
                Close();
        }

        private void btnToev_Click(object sender, EventArgs e)
        {
            Uiterlijk("Toevoegen");
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Uiterlijk("Startform");
        }

        private void btnAanp_Click(object sender, EventArgs e)
        {
            Uiterlijk("Aanpassen");
            VulCmb();
        }

        private void btnVerw_Click(object sender, EventArgs e)
        {
            Uiterlijk("Verwijderen");
            VulCmb();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Uiterlijk("Startspel");
        }

        private void btnNieuwSpel_Click(object sender, EventArgs e)
        {
            Program.NieuwSpel();
            txtToon.Text = Program.ToonGegevens();

        }

        private void btnActie_Click(object sender, EventArgs e)
        {
            if (btnActie.Text == "Toevoegen")
            {
                if (txtVoorn.Text == "" || txtFamN.Text == "")
                {
                    MessageBox.Show("Niet alle gegevens zijn ingevuld", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // haal de gegevens uit de tekstvakken en stuur ze door naar de business (program.cs)
                    Program.ToevoegenSpeler(txtVoorn.Text, txtFamN.Text);

                    // pas  het rechterdeel van het formulier aan met de nieuwe gegevens
                    txtToon.Text = Program.ToonGegevens();

                    //reset velden
                    txtVoorn.Text = "";
                    txtFamN.Text = "";
                }

            }
            else if (btnActie.Text == "Aanpassen")
            {
                if (cmbKies.SelectedIndex != -1)
                {
                    if (txtVoorn.Text == "" || txtFamN.Text == "")
                    {
                        MessageBox.Show("Niet alle gegevens zijn ingevuld", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        // haal de gegevens uit de tekstvakken en stuur ze door naar de business (program.cs)
                        Program.AanpassenSpeler(cmbKies.SelectedIndex, txtVoorn.Text, txtFamN.Text);

                        // pas  het rechterdeel van het formulier aan met de nieuwe gegevens
                        txtToon.Text = Program.ToonGegevens();

                        //reset velden
                        txtVoorn.Text = "";
                        txtFamN.Text = "";

                        cmbKies.SelectedIndex = -1;
                        cmbKies.Text = "";
                        VulCmb();
                    }
                }
                else
                {
                    MessageBox.Show("U selecteerde geen speler", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (btnActie.Text == "Verwijderen")
            {
               
            }
            
        }

        /// <summary>
        /// Vul de combobox met de namen van de spelers
        /// </summary>
        private void VulCmb()
        {
            // Maak de combobox leeg
            cmbKies.Items.Clear();

            // Haal de lijst van spelers op uit de business laag
            List<Speler> spelersLijst = Program.StuurSpelersDoor();

            // overloop de lijst en voeg de naam van elke speler toe aan de combobox
            foreach (Speler speler in spelersLijst)
            {
                cmbKies.Items.Add(speler.VolledigeNaam());
            }
        }
    }
}
