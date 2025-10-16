namespace _03_TomA_Minigolf
{
    partial class SpelFormulier
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
            this.Split = new System.Windows.Forms.SplitContainer();
            this.txtToon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).BeginInit();
            this.Split.Panel2.SuspendLayout();
            this.Split.SuspendLayout();
            this.SuspendLayout();
            // 
            // Split
            // 
            this.Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Split.Location = new System.Drawing.Point(0, 0);
            this.Split.Name = "Split";
            // 
            // Split.Panel1
            // 
            this.Split.Panel1.BackColor = System.Drawing.Color.Tan;
            // 
            // Split.Panel2
            // 
            this.Split.Panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.Split.Panel2.Controls.Add(this.txtToon);
            this.Split.Size = new System.Drawing.Size(844, 561);
            this.Split.SplitterDistance = 281;
            this.Split.TabIndex = 0;
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.Color.Cornsilk;
            this.txtToon.Location = new System.Drawing.Point(17, 25);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToon.Size = new System.Drawing.Size(517, 524);
            this.txtToon.TabIndex = 0;
            // 
            // SpelFormulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.ControlBox = false;
            this.Controls.Add(this.Split);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SpelFormulier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minigolf!!";
            this.Split.Panel2.ResumeLayout(false);
            this.Split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Split)).EndInit();
            this.Split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Split;
        private System.Windows.Forms.TextBox txtToon;
    }
}

