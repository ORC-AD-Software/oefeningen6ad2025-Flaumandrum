namespace _01_TomA_VolgendeVakantie
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
            this.lblToon = new System.Windows.Forms.Label();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(25, 25);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(382, 24);
            this.lblToon.TabIndex = 0;
            this.lblToon.Text = "Hieronder vind je alle toekomstige vakanties:";
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.Color.PeachPuff;
            this.txtToon.Location = new System.Drawing.Point(29, 62);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToon.Size = new System.Drawing.Size(378, 193);
            this.txtToon.TabIndex = 1;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnnuleren.Location = new System.Drawing.Point(102, 270);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(222, 58);
            this.btnAnnuleren.TabIndex = 22;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = false;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(436, 349);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.lblToon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTonen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hier worden alle vakanties getoond.";
            this.Load += new System.EventHandler(this.FrmTonen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToon;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}