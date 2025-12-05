namespace Tom1_Muzikanten
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
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(157, 29);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(187, 21);
            this.cmbKies.TabIndex = 5;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(26, 32);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(33, 13);
            this.lblKies.TabIndex = 4;
            this.lblKies.Text = "Kies :";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(29, 70);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(315, 23);
            this.btnVerwijderen.TabIndex = 46;
            this.btnVerwijderen.Text = " verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // FrmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 123);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.cmbKies);
            this.Controls.Add(this.lblKies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerwijderen";
            this.Text = "FrmVerwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}