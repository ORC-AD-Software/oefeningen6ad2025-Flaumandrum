namespace Tom1_Muzikanten
{
    partial class FrmToevLln
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
            this.lblToon = new System.Windows.Forms.Label();
            this.lblIntroKies = new System.Windows.Forms.Label();
            this.btnLlnOpslaan = new System.Windows.Forms.Button();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.btnOntkoppel = new System.Windows.Forms.Button();
            this.btnKoppel = new System.Windows.Forms.Button();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.txtLlnAn = new System.Windows.Forms.TextBox();
            this.txtLlnVn = new System.Windows.Forms.TextBox();
            this.lblKiesInstr = new System.Windows.Forms.Label();
            this.lblLlnAn = new System.Windows.Forms.Label();
            this.lblLlnVn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(12, 184);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(210, 13);
            this.lblToon.TabIndex = 35;
            this.lblToon.Text = "Volgende leerlingen zijn reeds toegevoegd:";
            // 
            // lblIntroKies
            // 
            this.lblIntroKies.AutoSize = true;
            this.lblIntroKies.Location = new System.Drawing.Point(12, 76);
            this.lblIntroKies.Name = "lblIntroKies";
            this.lblIntroKies.Size = new System.Drawing.Size(304, 13);
            this.lblIntroKies.TabIndex = 34;
            this.lblIntroKies.Text = "U kan eventueel leerlingen toevoegen die dit instrument spelen";
            // 
            // btnLlnOpslaan
            // 
            this.btnLlnOpslaan.Location = new System.Drawing.Point(15, 326);
            this.btnLlnOpslaan.Name = "btnLlnOpslaan";
            this.btnLlnOpslaan.Size = new System.Drawing.Size(315, 23);
            this.btnLlnOpslaan.TabIndex = 33;
            this.btnLlnOpslaan.Text = "Leerling opslaan";
            this.btnLlnOpslaan.UseVisualStyleBackColor = true;
            this.btnLlnOpslaan.Click += new System.EventHandler(this.btnLlnOpslaan_Click);
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtToon.Location = new System.Drawing.Point(15, 212);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToon.Size = new System.Drawing.Size(315, 108);
            this.txtToon.TabIndex = 32;
            // 
            // btnOntkoppel
            // 
            this.btnOntkoppel.Location = new System.Drawing.Point(173, 140);
            this.btnOntkoppel.Name = "btnOntkoppel";
            this.btnOntkoppel.Size = new System.Drawing.Size(157, 23);
            this.btnOntkoppel.TabIndex = 31;
            this.btnOntkoppel.Text = "Instrument ontkoppelen";
            this.btnOntkoppel.UseVisualStyleBackColor = true;
            this.btnOntkoppel.Click += new System.EventHandler(this.btnOntkoppel_Click);
            // 
            // btnKoppel
            // 
            this.btnKoppel.Location = new System.Drawing.Point(15, 140);
            this.btnKoppel.Name = "btnKoppel";
            this.btnKoppel.Size = new System.Drawing.Size(157, 23);
            this.btnKoppel.TabIndex = 30;
            this.btnKoppel.Text = "Instrument koppelen";
            this.btnKoppel.UseVisualStyleBackColor = true;
            this.btnKoppel.Click += new System.EventHandler(this.btnKoppel_Click);
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(192, 102);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(138, 21);
            this.cmbKies.TabIndex = 29;
            // 
            // txtLlnAn
            // 
            this.txtLlnAn.Location = new System.Drawing.Point(192, 39);
            this.txtLlnAn.Name = "txtLlnAn";
            this.txtLlnAn.Size = new System.Drawing.Size(138, 20);
            this.txtLlnAn.TabIndex = 28;
            // 
            // txtLlnVn
            // 
            this.txtLlnVn.Location = new System.Drawing.Point(192, 6);
            this.txtLlnVn.Name = "txtLlnVn";
            this.txtLlnVn.Size = new System.Drawing.Size(138, 20);
            this.txtLlnVn.TabIndex = 27;
            // 
            // lblKiesInstr
            // 
            this.lblKiesInstr.AutoSize = true;
            this.lblKiesInstr.Location = new System.Drawing.Point(12, 105);
            this.lblKiesInstr.Name = "lblKiesInstr";
            this.lblKiesInstr.Size = new System.Drawing.Size(105, 13);
            this.lblKiesInstr.TabIndex = 26;
            this.lblKiesInstr.Text = "Kies een instrument: ";
            // 
            // lblLlnAn
            // 
            this.lblLlnAn.AutoSize = true;
            this.lblLlnAn.Location = new System.Drawing.Point(12, 42);
            this.lblLlnAn.Name = "lblLlnAn";
            this.lblLlnAn.Size = new System.Drawing.Size(107, 13);
            this.lblLlnAn.TabIndex = 25;
            this.lblLlnAn.Text = "Geef de achternaam:";
            // 
            // lblLlnVn
            // 
            this.lblLlnVn.AutoSize = true;
            this.lblLlnVn.Location = new System.Drawing.Point(12, 9);
            this.lblLlnVn.Name = "lblLlnVn";
            this.lblLlnVn.Size = new System.Drawing.Size(173, 13);
            this.lblLlnVn.TabIndex = 24;
            this.lblLlnVn.Text = "Geef de voornaam van de leerling: ";
            // 
            // FrmToevLln
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 359);
            this.Controls.Add(this.lblToon);
            this.Controls.Add(this.lblIntroKies);
            this.Controls.Add(this.btnLlnOpslaan);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.btnOntkoppel);
            this.Controls.Add(this.btnKoppel);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.txtLlnAn);
            this.Controls.Add(this.txtLlnVn);
            this.Controls.Add(this.lblKiesInstr);
            this.Controls.Add(this.lblLlnAn);
            this.Controls.Add(this.lblLlnVn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmToevLln";
            this.Text = "frmToevLln";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToon;
        private System.Windows.Forms.Label lblIntroKies;
        private System.Windows.Forms.Button btnLlnOpslaan;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnOntkoppel;
        private System.Windows.Forms.Button btnKoppel;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.TextBox txtLlnAn;
        private System.Windows.Forms.TextBox txtLlnVn;
        private System.Windows.Forms.Label lblKiesInstr;
        private System.Windows.Forms.Label lblLlnAn;
        private System.Windows.Forms.Label lblLlnVn;
    }
}