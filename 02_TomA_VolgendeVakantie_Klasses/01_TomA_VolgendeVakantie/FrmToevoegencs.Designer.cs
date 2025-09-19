namespace _01_TomA_VolgendeVakantie
{
    partial class FrmToevoegencs
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.lblEinde = new System.Windows.Forms.Label();
            this.txtEinde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(30, 27);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(210, 24);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam van de vakantie : ";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(63, 69);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(177, 24);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Geef de startdatum :";
            // 
            // txtNaam
            // 
            this.txtNaam.BackColor = System.Drawing.SystemColors.Control;
            this.txtNaam.Location = new System.Drawing.Point(269, 22);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(222, 29);
            this.txtNaam.TabIndex = 2;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnToevoegen.Location = new System.Drawing.Point(18, 157);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(222, 58);
            this.btnToevoegen.TabIndex = 8;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtStart.Location = new System.Drawing.Point(269, 69);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(222, 29);
            this.txtStart.TabIndex = 4;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnuleren.Location = new System.Drawing.Point(269, 157);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(222, 58);
            this.btnAnnuleren.TabIndex = 9;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // lblEinde
            // 
            this.lblEinde.AutoSize = true;
            this.lblEinde.Location = new System.Drawing.Point(59, 113);
            this.lblEinde.Name = "lblEinde";
            this.lblEinde.Size = new System.Drawing.Size(191, 24);
            this.lblEinde.TabIndex = 6;
            this.lblEinde.Text = "Geef de einddatum :  ";
            // 
            // txtEinde
            // 
            this.txtEinde.BackColor = System.Drawing.SystemColors.Control;
            this.txtEinde.Location = new System.Drawing.Point(269, 113);
            this.txtEinde.Name = "txtEinde";
            this.txtEinde.Size = new System.Drawing.Size(222, 29);
            this.txtEinde.TabIndex = 7;
            // 
            // FrmToevoegencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(512, 237);
            this.ControlBox = false;
            this.Controls.Add(this.txtEinde);
            this.Controls.Add(this.lblEinde);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmToevoegencs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vakanties toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Label lblEinde;
        private System.Windows.Forms.TextBox txtEinde;
    }
}