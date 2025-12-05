namespace Tom1_Muzikanten
{
    partial class FrmTonen
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
            this.rbAlles = new System.Windows.Forms.RadioButton();
            this.grbRb = new System.Windows.Forms.GroupBox();
            this.rb1specifiek = new System.Windows.Forms.RadioButton();
            this.grbBoxKies = new System.Windows.Forms.GroupBox();
            this.cmbKies = new System.Windows.Forms.ComboBox();
            this.lblKies = new System.Windows.Forms.Label();
            this.lblToon = new System.Windows.Forms.Label();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.grbRb.SuspendLayout();
            this.grbBoxKies.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAlles
            // 
            this.rbAlles.AutoSize = true;
            this.rbAlles.Location = new System.Drawing.Point(6, 19);
            this.rbAlles.Name = "rbAlles";
            this.rbAlles.Size = new System.Drawing.Size(72, 17);
            this.rbAlles.TabIndex = 0;
            this.rbAlles.TabStop = true;
            this.rbAlles.Text = "Toon alle ";
            this.rbAlles.UseVisualStyleBackColor = true;
            this.rbAlles.CheckedChanged += new System.EventHandler(this.rbAlles_CheckedChanged);
            // 
            // grbRb
            // 
            this.grbRb.Controls.Add(this.rb1specifiek);
            this.grbRb.Controls.Add(this.rbAlles);
            this.grbRb.Location = new System.Drawing.Point(12, 12);
            this.grbRb.Name = "grbRb";
            this.grbRb.Size = new System.Drawing.Size(400, 57);
            this.grbRb.TabIndex = 1;
            this.grbRb.TabStop = false;
            // 
            // rb1specifiek
            // 
            this.rb1specifiek.AutoSize = true;
            this.rb1specifiek.Location = new System.Drawing.Point(143, 19);
            this.rb1specifiek.Name = "rb1specifiek";
            this.rb1specifiek.Size = new System.Drawing.Size(65, 17);
            this.rb1specifiek.TabIndex = 1;
            this.rb1specifiek.TabStop = true;
            this.rb1specifiek.Text = "Toon de";
            this.rb1specifiek.UseVisualStyleBackColor = true;
            // 
            // grbBoxKies
            // 
            this.grbBoxKies.Controls.Add(this.cmbKies);
            this.grbBoxKies.Controls.Add(this.lblKies);
            this.grbBoxKies.Location = new System.Drawing.Point(12, 75);
            this.grbBoxKies.Name = "grbBoxKies";
            this.grbBoxKies.Size = new System.Drawing.Size(400, 57);
            this.grbBoxKies.TabIndex = 2;
            this.grbBoxKies.TabStop = false;
            // 
            // cmbKies
            // 
            this.cmbKies.FormattingEnabled = true;
            this.cmbKies.Location = new System.Drawing.Point(143, 17);
            this.cmbKies.Name = "cmbKies";
            this.cmbKies.Size = new System.Drawing.Size(245, 21);
            this.cmbKies.TabIndex = 1;
            // 
            // lblKies
            // 
            this.lblKies.AutoSize = true;
            this.lblKies.Location = new System.Drawing.Point(7, 20);
            this.lblKies.Name = "lblKies";
            this.lblKies.Size = new System.Drawing.Size(83, 13);
            this.lblKies.TabIndex = 0;
            this.lblKies.Text = "Kies uw leerling:";
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(19, 178);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(76, 13);
            this.lblToon.TabIndex = 3;
            this.lblToon.Text = "Uw gegevens:";
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtToon.Location = new System.Drawing.Point(18, 194);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.Size = new System.Drawing.Size(382, 244);
            this.txtToon.TabIndex = 4;
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(18, 138);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(382, 27);
            this.btnBevestig.TabIndex = 5;
            this.btnBevestig.Text = "Bevestig uw keuze";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.lblToon);
            this.Controls.Add(this.grbBoxKies);
            this.Controls.Add(this.grbRb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTonen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTonen";
            this.grbRb.ResumeLayout(false);
            this.grbRb.PerformLayout();
            this.grbBoxKies.ResumeLayout(false);
            this.grbBoxKies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAlles;
        private System.Windows.Forms.GroupBox grbRb;
        private System.Windows.Forms.RadioButton rb1specifiek;
        private System.Windows.Forms.GroupBox grbBoxKies;
        private System.Windows.Forms.ComboBox cmbKies;
        private System.Windows.Forms.Label lblKies;
        private System.Windows.Forms.Label lblToon;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnBevestig;
    }
}