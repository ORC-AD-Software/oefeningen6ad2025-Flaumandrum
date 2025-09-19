namespace _01_TomA_VolgendeVakantie
{
    partial class FrmAanpassen
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
            this.lblKies = new System.Windows.Forms.Label();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.txtEinde = new System.Windows.Forms.TextBox();
            this.lblEinde = new System.Windows.Forms.Label();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(81, 34);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(161, 24);
            this.lblKies.TabIndex = 0;
            this.lblKies.Text = "Kies de vakantie : ";
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(271, 31);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(222, 32);
            this.cmbKies.TabIndex = 1;
            // 
            // txtEinde
            // 
            this.txtEinde.BackColor = System.Drawing.SystemColors.Control;
            this.txtEinde.Location = new System.Drawing.Point(271, 139);
            this.txtEinde.Name = "txtEinde";
            this.txtEinde.Size = new System.Drawing.Size(222, 29);
            this.txtEinde.TabIndex = 15;
            // 
            // lblEinde
            // 
            this.lblEinde.AutoSize = true;
            this.lblEinde.Location = new System.Drawing.Point(56, 142);
            this.lblEinde.Name = "lblEinde";
            this.lblEinde.Size = new System.Drawing.Size(186, 24);
            this.lblEinde.TabIndex = 14;
            this.lblEinde.Text = "Geef de einddatum : ";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnuleren.Location = new System.Drawing.Point(271, 192);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(222, 58);
            this.btnAnnuleren.TabIndex = 17;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtStart.Location = new System.Drawing.Point(271, 104);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(222, 29);
            this.txtStart.TabIndex = 13;
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAanpassen.Location = new System.Drawing.Point(20, 192);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(222, 58);
            this.btnAanpassen.TabIndex = 16;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.BackColor = System.Drawing.SystemColors.Control;
            this.txtNaam.Location = new System.Drawing.Point(271, 69);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(222, 29);
            this.txtNaam.TabIndex = 12;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(60, 107);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(182, 24);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Geef de startdatum : ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(32, 72);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(210, 24);
            this.lblNaam.TabIndex = 10;
            this.lblNaam.Text = "Naam van de vakantie : ";
            // 
            // FrmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(523, 277);
            this.ControlBox = false;
            this.Controls.Add(this.txtEinde);
            this.Controls.Add(this.lblEinde);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAanpassen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Een vakantie aanpassen";
            this.Load += new System.EventHandler(this.FrmAanpassen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.TextBox txtEinde;
        private System.Windows.Forms.Label lblEinde;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblNaam;
    }
}