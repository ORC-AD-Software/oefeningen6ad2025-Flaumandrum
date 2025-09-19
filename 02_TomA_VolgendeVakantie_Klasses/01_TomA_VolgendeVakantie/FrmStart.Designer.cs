namespace _01_TomA_VolgendeVakantie
{
    partial class FrmStart
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.BtnAantalDagen = new System.Windows.Forms.Button();
            this.btnToonAlle = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnToevoegen.Location = new System.Drawing.Point(12, 12);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(158, 91);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Vakantie toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAanpassen.Location = new System.Drawing.Point(176, 12);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(158, 91);
            this.btnAanpassen.TabIndex = 1;
            this.btnAanpassen.Text = "Vakantie aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.PeachPuff;
            this.btnVerwijderen.Location = new System.Drawing.Point(12, 109);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(158, 91);
            this.btnVerwijderen.TabIndex = 2;
            this.btnVerwijderen.Text = "Vakantie verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // BtnAantalDagen
            // 
            this.BtnAantalDagen.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnAantalDagen.Location = new System.Drawing.Point(176, 109);
            this.BtnAantalDagen.Name = "BtnAantalDagen";
            this.BtnAantalDagen.Size = new System.Drawing.Size(158, 91);
            this.BtnAantalDagen.TabIndex = 3;
            this.BtnAantalDagen.Text = "Toon dagen tot vakantie";
            this.BtnAantalDagen.UseVisualStyleBackColor = false;
            this.BtnAantalDagen.Click += new System.EventHandler(this.BtnAantalDagen_Click);
            // 
            // btnToonAlle
            // 
            this.btnToonAlle.BackColor = System.Drawing.Color.PeachPuff;
            this.btnToonAlle.Location = new System.Drawing.Point(12, 206);
            this.btnToonAlle.Name = "btnToonAlle";
            this.btnToonAlle.Size = new System.Drawing.Size(158, 91);
            this.btnToonAlle.TabIndex = 4;
            this.btnToonAlle.Text = "Toon alle vakanties";
            this.btnToonAlle.UseVisualStyleBackColor = false;
            this.btnToonAlle.Click += new System.EventHandler(this.btnToonAlle_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAfsluiten.Location = new System.Drawing.Point(176, 206);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(158, 91);
            this.btnAfsluiten.TabIndex = 5;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(347, 309);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnToonAlle);
            this.Controls.Add(this.BtnAantalDagen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnToevoegen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welkom!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button BtnAantalDagen;
        private System.Windows.Forms.Button btnToonAlle;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

