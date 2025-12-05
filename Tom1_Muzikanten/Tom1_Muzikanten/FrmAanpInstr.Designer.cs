namespace Tom1_Muzikanten
{
    partial class FrmAanpInstr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKiesInstr = new System.Windows.Forms.Label();
            this.cmbKiesInstr = new System.Windows.Forms.ComboBox();
            this.lblToon = new System.Windows.Forms.Label();
            this.lblIntroKiesLln = new System.Windows.Forms.Label();
            this.btnAanp = new System.Windows.Forms.Button();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.btnOntkoppel = new System.Windows.Forms.Button();
            this.btnKoppel = new System.Windows.Forms.Button();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.txtInstrGroep = new System.Windows.Forms.TextBox();
            this.txtInstrNaam = new System.Windows.Forms.TextBox();
            this.lblKiesLln = new System.Windows.Forms.Label();
            this.lblGroep = new System.Windows.Forms.Label();
            this.lblInstrNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKiesInstr
            // 
            this.lblKiesInstr.AutoSize = true;
            this.lblKiesInstr.Location = new System.Drawing.Point(12, 9);
            this.lblKiesInstr.Name = "lblKiesInstr";
            this.lblKiesInstr.Size = new System.Drawing.Size(98, 13);
            this.lblKiesInstr.TabIndex = 0;
            this.lblKiesInstr.Text = "Kies uw instrument:";
            // 
            // cmbKiesInstr
            // 
            this.cmbKiesInstr.FormattingEnabled = true;
            this.cmbKiesInstr.Location = new System.Drawing.Point(192, 6);
            this.cmbKiesInstr.Name = "cmbKiesInstr";
            this.cmbKiesInstr.Size = new System.Drawing.Size(138, 21);
            this.cmbKiesInstr.TabIndex = 1;
            this.cmbKiesInstr.SelectedIndexChanged += new System.EventHandler(this.cmbKiesInstr_SelectedIndexChanged);
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(12, 217);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(210, 13);
            this.lblToon.TabIndex = 47;
            this.lblToon.Text = "Volgende leerlingen zijn reeds toegevoegd:";
            // 
            // lblIntroKiesLln
            // 
            this.lblIntroKiesLln.AutoSize = true;
            this.lblIntroKiesLln.Location = new System.Drawing.Point(12, 109);
            this.lblIntroKiesLln.Name = "lblIntroKiesLln";
            this.lblIntroKiesLln.Size = new System.Drawing.Size(304, 13);
            this.lblIntroKiesLln.TabIndex = 46;
            this.lblIntroKiesLln.Text = "U kan eventueel leerlingen toevoegen die dit instrument spelen";
            // 
            // btnAanp
            // 
            this.btnAanp.Location = new System.Drawing.Point(15, 359);
            this.btnAanp.Name = "btnAanp";
            this.btnAanp.Size = new System.Drawing.Size(315, 23);
            this.btnAanp.TabIndex = 45;
            this.btnAanp.Text = "Instrument aanpassen";
            this.btnAanp.UseVisualStyleBackColor = true;
            this.btnAanp.Click += new System.EventHandler(this.btnAanp_Click);
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtToon.Location = new System.Drawing.Point(15, 245);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToon.Size = new System.Drawing.Size(315, 108);
            this.txtToon.TabIndex = 44;
            // 
            // btnOntkoppel
            // 
            this.btnOntkoppel.Location = new System.Drawing.Point(173, 173);
            this.btnOntkoppel.Name = "btnOntkoppel";
            this.btnOntkoppel.Size = new System.Drawing.Size(157, 23);
            this.btnOntkoppel.TabIndex = 43;
            this.btnOntkoppel.Text = "leerling ontkoppelen";
            this.btnOntkoppel.UseVisualStyleBackColor = true;
            this.btnOntkoppel.Click += new System.EventHandler(this.btnOntkoppel_Click);
            // 
            // btnKoppel
            // 
            this.btnKoppel.Location = new System.Drawing.Point(15, 173);
            this.btnKoppel.Name = "btnKoppel";
            this.btnKoppel.Size = new System.Drawing.Size(157, 23);
            this.btnKoppel.TabIndex = 42;
            this.btnKoppel.Text = "Leerling koppelen";
            this.btnKoppel.UseVisualStyleBackColor = true;
            this.btnKoppel.Click += new System.EventHandler(this.btnKoppel_Click);
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(192, 135);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(138, 21);
            this.cmbKies.TabIndex = 41;
            // 
            // txtInstrGroep
            // 
            this.txtInstrGroep.Location = new System.Drawing.Point(192, 72);
            this.txtInstrGroep.Name = "txtInstrGroep";
            this.txtInstrGroep.Size = new System.Drawing.Size(138, 20);
            this.txtInstrGroep.TabIndex = 40;
            // 
            // txtInstrNaam
            // 
            this.txtInstrNaam.Location = new System.Drawing.Point(192, 39);
            this.txtInstrNaam.Name = "txtInstrNaam";
            this.txtInstrNaam.Size = new System.Drawing.Size(138, 20);
            this.txtInstrNaam.TabIndex = 39;
            // 
            // lblKiesLln
            // 
            this.lblKiesLln.AutoSize = true;
            this.lblKiesLln.Location = new System.Drawing.Point(12, 138);
            this.lblKiesLln.Name = "lblKiesLln";
            this.lblKiesLln.Size = new System.Drawing.Size(90, 13);
            this.lblKiesLln.TabIndex = 38;
            this.lblKiesLln.Text = "Kies een leerling: ";
            // 
            // lblGroep
            // 
            this.lblGroep.AutoSize = true;
            this.lblGroep.Location = new System.Drawing.Point(12, 75);
            this.lblGroep.Name = "lblGroep";
            this.lblGroep.Size = new System.Drawing.Size(135, 13);
            this.lblGroep.TabIndex = 37;
            this.lblGroep.Text = "Geef de instrumentengroep";
            // 
            // lblInstrNaam
            // 
            this.lblInstrNaam.AutoSize = true;
            this.lblInstrNaam.Location = new System.Drawing.Point(12, 42);
            this.lblInstrNaam.Name = "lblInstrNaam";
            this.lblInstrNaam.Size = new System.Drawing.Size(165, 13);
            this.lblInstrNaam.TabIndex = 36;
            this.lblInstrNaam.Text = "Geef de naam van het Instrument";
            // 
            // FrmAanpInstr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 394);
            this.Controls.Add(this.lblToon);
            this.Controls.Add(this.lblIntroKiesLln);
            this.Controls.Add(this.btnAanp);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.btnOntkoppel);
            this.Controls.Add(this.btnKoppel);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.txtInstrGroep);
            this.Controls.Add(this.txtInstrNaam);
            this.Controls.Add(this.lblKiesLln);
            this.Controls.Add(this.lblGroep);
            this.Controls.Add(this.lblInstrNaam);
            this.Controls.Add(this.cmbKiesInstr);
            this.Controls.Add(this.lblKiesInstr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAanpInstr";
            this.Text = "FrmAanpInstr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiesInstr;
        private System.Windows.Forms.ComboBox cmbKiesInstr;
        private System.Windows.Forms.Label lblToon;
        private System.Windows.Forms.Label lblIntroKiesLln;
        private System.Windows.Forms.Button btnAanp;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnOntkoppel;
        private System.Windows.Forms.Button btnKoppel;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.TextBox txtInstrGroep;
        private System.Windows.Forms.TextBox txtInstrNaam;
        private System.Windows.Forms.Label lblKiesLln;
        private System.Windows.Forms.Label lblGroep;
        private System.Windows.Forms.Label lblInstrNaam;
    }
}