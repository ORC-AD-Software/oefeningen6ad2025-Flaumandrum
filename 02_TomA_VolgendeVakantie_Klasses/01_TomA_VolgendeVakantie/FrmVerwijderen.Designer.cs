namespace _01_TomA_VolgendeVakantie
{
    partial class FrmVerwijderen
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnuleren.Location = new System.Drawing.Point(254, 92);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(222, 58);
            this.btnAnnuleren.TabIndex = 21;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnVerwijderen.Location = new System.Drawing.Point(12, 92);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(222, 58);
            this.btnVerwijderen.TabIndex = 20;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(254, 30);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(222, 32);
            this.cmbKies.TabIndex = 19;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(73, 33);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(161, 24);
            this.lblKies.TabIndex = 18;
            this.lblKies.Text = "Kies de vakantie : ";
            // 
            // FrmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(498, 184);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVerwijderen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Een vakantie verwijderen";
            this.Load += new System.EventHandler(this.FrmVerwijderen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
    }
}