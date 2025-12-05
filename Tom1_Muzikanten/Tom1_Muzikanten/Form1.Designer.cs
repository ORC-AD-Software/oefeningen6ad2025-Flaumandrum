namespace Tom1_Muzikanten
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHoofding = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlpSide = new System.Windows.Forms.FlowLayoutPanel();
            this.RaadpleegContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRaadpleegGeg = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRaadpleegLln = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRaadpleegInst = new System.Windows.Forms.Button();
            this.BewerkLlnContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBewerkLln = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLlnToev = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLlnAanpassen = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnLlnVerw = new System.Windows.Forms.Button();
            this.MenuBewInstr = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuBerwerkLln = new System.Windows.Forms.Panel();
            this.BtnBewerkInst = new System.Windows.Forms.Button();
            this.InstrToevoegen = new System.Windows.Forms.Panel();
            this.btnInstToev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInstAanp = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnInstVerw = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.menuOvergang = new System.Windows.Forms.Timer(this.components);
            this.BewLlnOverg = new System.Windows.Forms.Timer(this.components);
            this.BewInstOverg = new System.Windows.Forms.Timer(this.components);
            this.Zijpaneel = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FlpSide.SuspendLayout();
            this.RaadpleegContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.BewerkLlnContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.MenuBewInstr.SuspendLayout();
            this.MenuBerwerkLln.SuspendLayout();
            this.InstrToevoegen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblHoofding);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1029, 54);
            this.pnlTop.TabIndex = 0;
            // 
            // lblHoofding
            // 
            this.lblHoofding.AutoSize = true;
            this.lblHoofding.Location = new System.Drawing.Point(53, 15);
            this.lblHoofding.Name = "lblHoofding";
            this.lblHoofding.Size = new System.Drawing.Size(165, 17);
            this.lblHoofding.TabIndex = 2;
            this.lblHoofding.Text = "Leerlingen en instrumenten";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FlpSide
            // 
            this.FlpSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.FlpSide.Controls.Add(this.RaadpleegContainer);
            this.FlpSide.Controls.Add(this.BewerkLlnContainer);
            this.FlpSide.Controls.Add(this.MenuBewInstr);
            this.FlpSide.Controls.Add(this.panel3);
            this.FlpSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlpSide.Location = new System.Drawing.Point(0, 54);
            this.FlpSide.Name = "FlpSide";
            this.FlpSide.Size = new System.Drawing.Size(267, 632);
            this.FlpSide.TabIndex = 1;
            // 
            // RaadpleegContainer
            // 
            this.RaadpleegContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.RaadpleegContainer.Controls.Add(this.panel1);
            this.RaadpleegContainer.Controls.Add(this.panel5);
            this.RaadpleegContainer.Controls.Add(this.panel6);
            this.RaadpleegContainer.Location = new System.Drawing.Point(3, 3);
            this.RaadpleegContainer.Name = "RaadpleegContainer";
            this.RaadpleegContainer.Size = new System.Drawing.Size(266, 45);
            this.RaadpleegContainer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnRaadpleegGeg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 47);
            this.panel1.TabIndex = 4;
            // 
            // btnRaadpleegGeg
            // 
            this.btnRaadpleegGeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnRaadpleegGeg.FlatAppearance.BorderSize = 0;
            this.btnRaadpleegGeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaadpleegGeg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaadpleegGeg.Image = ((System.Drawing.Image)(resources.GetObject("btnRaadpleegGeg.Image")));
            this.btnRaadpleegGeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaadpleegGeg.Location = new System.Drawing.Point(2, 0);
            this.btnRaadpleegGeg.Margin = new System.Windows.Forms.Padding(0);
            this.btnRaadpleegGeg.Name = "btnRaadpleegGeg";
            this.btnRaadpleegGeg.Size = new System.Drawing.Size(264, 51);
            this.btnRaadpleegGeg.TabIndex = 2;
            this.btnRaadpleegGeg.Text = "Raadpleeg Gegevens";
            this.btnRaadpleegGeg.UseVisualStyleBackColor = false;
            this.btnRaadpleegGeg.Click += new System.EventHandler(this.btnRaadpleegGeg_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.btnRaadpleegLln);
            this.panel5.Location = new System.Drawing.Point(0, 47);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 47);
            this.panel5.TabIndex = 9;
            // 
            // btnRaadpleegLln
            // 
            this.btnRaadpleegLln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnRaadpleegLln.FlatAppearance.BorderSize = 0;
            this.btnRaadpleegLln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaadpleegLln.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaadpleegLln.Image = ((System.Drawing.Image)(resources.GetObject("btnRaadpleegLln.Image")));
            this.btnRaadpleegLln.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaadpleegLln.Location = new System.Drawing.Point(0, 0);
            this.btnRaadpleegLln.Margin = new System.Windows.Forms.Padding(0);
            this.btnRaadpleegLln.Name = "btnRaadpleegLln";
            this.btnRaadpleegLln.Size = new System.Drawing.Size(264, 43);
            this.btnRaadpleegLln.TabIndex = 2;
            this.btnRaadpleegLln.Text = "Raadpleeg leerlingen";
            this.btnRaadpleegLln.UseVisualStyleBackColor = false;
            this.btnRaadpleegLln.Click += new System.EventHandler(this.btnRaadpleegLln_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.btnRaadpleegInst);
            this.panel6.Location = new System.Drawing.Point(0, 94);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 47);
            this.panel6.TabIndex = 10;
            // 
            // btnRaadpleegInst
            // 
            this.btnRaadpleegInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnRaadpleegInst.FlatAppearance.BorderSize = 0;
            this.btnRaadpleegInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaadpleegInst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaadpleegInst.Image = ((System.Drawing.Image)(resources.GetObject("btnRaadpleegInst.Image")));
            this.btnRaadpleegInst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaadpleegInst.Location = new System.Drawing.Point(0, 0);
            this.btnRaadpleegInst.Margin = new System.Windows.Forms.Padding(0);
            this.btnRaadpleegInst.Name = "btnRaadpleegInst";
            this.btnRaadpleegInst.Size = new System.Drawing.Size(264, 43);
            this.btnRaadpleegInst.TabIndex = 2;
            this.btnRaadpleegInst.Text = "Raadpleeg instrumenten";
            this.btnRaadpleegInst.UseVisualStyleBackColor = false;
            this.btnRaadpleegInst.Click += new System.EventHandler(this.btnRaadpleegInst_Click);
            // 
            // BewerkLlnContainer
            // 
            this.BewerkLlnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.BewerkLlnContainer.Controls.Add(this.panel4);
            this.BewerkLlnContainer.Controls.Add(this.panel8);
            this.BewerkLlnContainer.Controls.Add(this.panel7);
            this.BewerkLlnContainer.Controls.Add(this.panel9);
            this.BewerkLlnContainer.Location = new System.Drawing.Point(3, 54);
            this.BewerkLlnContainer.Name = "BewerkLlnContainer";
            this.BewerkLlnContainer.Size = new System.Drawing.Size(268, 43);
            this.BewerkLlnContainer.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.btnBewerkLln);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 47);
            this.panel4.TabIndex = 10;
            // 
            // btnBewerkLln
            // 
            this.btnBewerkLln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnBewerkLln.FlatAppearance.BorderSize = 0;
            this.btnBewerkLln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBewerkLln.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewerkLln.Image = ((System.Drawing.Image)(resources.GetObject("btnBewerkLln.Image")));
            this.btnBewerkLln.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBewerkLln.Location = new System.Drawing.Point(0, 0);
            this.btnBewerkLln.Margin = new System.Windows.Forms.Padding(0);
            this.btnBewerkLln.Name = "btnBewerkLln";
            this.btnBewerkLln.Size = new System.Drawing.Size(264, 43);
            this.btnBewerkLln.TabIndex = 2;
            this.btnBewerkLln.Text = "Bewerk leerlingen";
            this.btnBewerkLln.UseVisualStyleBackColor = false;
            this.btnBewerkLln.Click += new System.EventHandler(this.btnBewerkLln_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.btnLlnToev);
            this.panel8.Location = new System.Drawing.Point(0, 47);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 47);
            this.panel8.TabIndex = 7;
            // 
            // btnLlnToev
            // 
            this.btnLlnToev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnLlnToev.FlatAppearance.BorderSize = 0;
            this.btnLlnToev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlnToev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlnToev.Image = ((System.Drawing.Image)(resources.GetObject("btnLlnToev.Image")));
            this.btnLlnToev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLlnToev.Location = new System.Drawing.Point(0, 0);
            this.btnLlnToev.Margin = new System.Windows.Forms.Padding(0);
            this.btnLlnToev.Name = "btnLlnToev";
            this.btnLlnToev.Size = new System.Drawing.Size(264, 43);
            this.btnLlnToev.TabIndex = 2;
            this.btnLlnToev.Text = "Leerling toevoegen";
            this.btnLlnToev.UseVisualStyleBackColor = false;
            this.btnLlnToev.Click += new System.EventHandler(this.btnLlnToev_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.btnLlnAanpassen);
            this.panel7.Location = new System.Drawing.Point(0, 94);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(264, 47);
            this.panel7.TabIndex = 10;
            // 
            // btnLlnAanpassen
            // 
            this.btnLlnAanpassen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnLlnAanpassen.FlatAppearance.BorderSize = 0;
            this.btnLlnAanpassen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlnAanpassen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlnAanpassen.Image = ((System.Drawing.Image)(resources.GetObject("btnLlnAanpassen.Image")));
            this.btnLlnAanpassen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLlnAanpassen.Location = new System.Drawing.Point(0, 0);
            this.btnLlnAanpassen.Margin = new System.Windows.Forms.Padding(0);
            this.btnLlnAanpassen.Name = "btnLlnAanpassen";
            this.btnLlnAanpassen.Size = new System.Drawing.Size(264, 43);
            this.btnLlnAanpassen.TabIndex = 2;
            this.btnLlnAanpassen.Text = "Leerling aanpassen";
            this.btnLlnAanpassen.UseVisualStyleBackColor = false;
            this.btnLlnAanpassen.Click += new System.EventHandler(this.btnLlnAanpassen_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.BtnLlnVerw);
            this.panel9.Location = new System.Drawing.Point(0, 141);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(264, 47);
            this.panel9.TabIndex = 11;
            // 
            // BtnLlnVerw
            // 
            this.BtnLlnVerw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.BtnLlnVerw.FlatAppearance.BorderSize = 0;
            this.BtnLlnVerw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLlnVerw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLlnVerw.Image = ((System.Drawing.Image)(resources.GetObject("BtnLlnVerw.Image")));
            this.BtnLlnVerw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLlnVerw.Location = new System.Drawing.Point(0, 0);
            this.BtnLlnVerw.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLlnVerw.Name = "BtnLlnVerw";
            this.BtnLlnVerw.Size = new System.Drawing.Size(264, 43);
            this.BtnLlnVerw.TabIndex = 2;
            this.BtnLlnVerw.Text = "Leerling verwijderen";
            this.BtnLlnVerw.UseVisualStyleBackColor = false;
            this.BtnLlnVerw.Click += new System.EventHandler(this.BtnLlnVerw_Click);
            // 
            // MenuBewInstr
            // 
            this.MenuBewInstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.MenuBewInstr.Controls.Add(this.MenuBerwerkLln);
            this.MenuBewInstr.Controls.Add(this.InstrToevoegen);
            this.MenuBewInstr.Controls.Add(this.panel2);
            this.MenuBewInstr.Controls.Add(this.panel10);
            this.MenuBewInstr.Location = new System.Drawing.Point(3, 103);
            this.MenuBewInstr.Name = "MenuBewInstr";
            this.MenuBewInstr.Size = new System.Drawing.Size(266, 46);
            this.MenuBewInstr.TabIndex = 9;
            // 
            // MenuBerwerkLln
            // 
            this.MenuBerwerkLln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.MenuBerwerkLln.Controls.Add(this.BtnBewerkInst);
            this.MenuBerwerkLln.Location = new System.Drawing.Point(0, 0);
            this.MenuBerwerkLln.Margin = new System.Windows.Forms.Padding(0);
            this.MenuBerwerkLln.Name = "MenuBerwerkLln";
            this.MenuBerwerkLln.Size = new System.Drawing.Size(264, 47);
            this.MenuBerwerkLln.TabIndex = 8;
            // 
            // BtnBewerkInst
            // 
            this.BtnBewerkInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.BtnBewerkInst.FlatAppearance.BorderSize = 0;
            this.BtnBewerkInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBewerkInst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBewerkInst.Image = ((System.Drawing.Image)(resources.GetObject("BtnBewerkInst.Image")));
            this.BtnBewerkInst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBewerkInst.Location = new System.Drawing.Point(0, 0);
            this.BtnBewerkInst.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBewerkInst.Name = "BtnBewerkInst";
            this.BtnBewerkInst.Size = new System.Drawing.Size(264, 43);
            this.BtnBewerkInst.TabIndex = 2;
            this.BtnBewerkInst.Text = "Bewerk Instrument";
            this.BtnBewerkInst.UseVisualStyleBackColor = false;
            this.BtnBewerkInst.Click += new System.EventHandler(this.BtnBewerkInst_Click);
            // 
            // InstrToevoegen
            // 
            this.InstrToevoegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.InstrToevoegen.Controls.Add(this.btnInstToev);
            this.InstrToevoegen.Location = new System.Drawing.Point(0, 47);
            this.InstrToevoegen.Margin = new System.Windows.Forms.Padding(0);
            this.InstrToevoegen.Name = "InstrToevoegen";
            this.InstrToevoegen.Size = new System.Drawing.Size(264, 47);
            this.InstrToevoegen.TabIndex = 6;
            // 
            // btnInstToev
            // 
            this.btnInstToev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnInstToev.FlatAppearance.BorderSize = 0;
            this.btnInstToev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstToev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstToev.Image = ((System.Drawing.Image)(resources.GetObject("btnInstToev.Image")));
            this.btnInstToev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstToev.Location = new System.Drawing.Point(0, 0);
            this.btnInstToev.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstToev.Name = "btnInstToev";
            this.btnInstToev.Size = new System.Drawing.Size(264, 43);
            this.btnInstToev.TabIndex = 2;
            this.btnInstToev.Text = "Instrument toevoegen";
            this.btnInstToev.UseVisualStyleBackColor = false;
            this.btnInstToev.Click += new System.EventHandler(this.btnInstToev_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnInstAanp);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 47);
            this.panel2.TabIndex = 10;
            // 
            // btnInstAanp
            // 
            this.btnInstAanp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnInstAanp.FlatAppearance.BorderSize = 0;
            this.btnInstAanp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstAanp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstAanp.Image = ((System.Drawing.Image)(resources.GetObject("btnInstAanp.Image")));
            this.btnInstAanp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstAanp.Location = new System.Drawing.Point(0, 0);
            this.btnInstAanp.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstAanp.Name = "btnInstAanp";
            this.btnInstAanp.Size = new System.Drawing.Size(264, 43);
            this.btnInstAanp.TabIndex = 2;
            this.btnInstAanp.Text = "Instrument aanpassen";
            this.btnInstAanp.UseVisualStyleBackColor = false;
            this.btnInstAanp.Click += new System.EventHandler(this.btnInstAanp_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel10.Controls.Add(this.btnInstVerw);
            this.panel10.Location = new System.Drawing.Point(0, 141);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(264, 47);
            this.panel10.TabIndex = 11;
            // 
            // btnInstVerw
            // 
            this.btnInstVerw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnInstVerw.FlatAppearance.BorderSize = 0;
            this.btnInstVerw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstVerw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstVerw.Image = ((System.Drawing.Image)(resources.GetObject("btnInstVerw.Image")));
            this.btnInstVerw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstVerw.Location = new System.Drawing.Point(0, 0);
            this.btnInstVerw.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstVerw.Name = "btnInstVerw";
            this.btnInstVerw.Size = new System.Drawing.Size(264, 43);
            this.btnInstVerw.TabIndex = 2;
            this.btnInstVerw.Text = "Instument verwijderen";
            this.btnInstVerw.UseVisualStyleBackColor = false;
            this.btnInstVerw.Click += new System.EventHandler(this.btnInstVerw_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnAfsluiten);
            this.panel3.Location = new System.Drawing.Point(3, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 47);
            this.panel3.TabIndex = 7;
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(0)))));
            this.btnAfsluiten.FlatAppearance.BorderSize = 0;
            this.btnAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfsluiten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfsluiten.Image = ((System.Drawing.Image)(resources.GetObject("btnAfsluiten.Image")));
            this.btnAfsluiten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfsluiten.Location = new System.Drawing.Point(0, 0);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(264, 43);
            this.btnAfsluiten.TabIndex = 2;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // menuOvergang
            // 
            this.menuOvergang.Interval = 15;
            this.menuOvergang.Tick += new System.EventHandler(this.menuOvergang_Tick);
            // 
            // BewLlnOverg
            // 
            this.BewLlnOverg.Interval = 15;
            this.BewLlnOverg.Tick += new System.EventHandler(this.BewLlnOverg_Tick);
            // 
            // BewInstOverg
            // 
            this.BewInstOverg.Interval = 15;
            this.BewInstOverg.Tick += new System.EventHandler(this.BewInstOverg_Tick);
            // 
            // Zijpaneel
            // 
            this.Zijpaneel.Interval = 10;
            this.Zijpaneel.Tick += new System.EventHandler(this.Zijpaneel_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 686);
            this.Controls.Add(this.FlpSide);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FlpSide.ResumeLayout(false);
            this.RaadpleegContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.BewerkLlnContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.MenuBewInstr.ResumeLayout(false);
            this.MenuBerwerkLln.ResumeLayout(false);
            this.InstrToevoegen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHoofding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel FlpSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRaadpleegGeg;
        private System.Windows.Forms.FlowLayoutPanel RaadpleegContainer;
        private System.Windows.Forms.Panel InstrToevoegen;
        private System.Windows.Forms.Button btnInstToev;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRaadpleegLln;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRaadpleegInst;
        private System.Windows.Forms.Panel MenuBerwerkLln;
        private System.Windows.Forms.Button BtnBewerkInst;
        private System.Windows.Forms.Timer menuOvergang;
        private System.Windows.Forms.FlowLayoutPanel BewerkLlnContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBewerkLln;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLlnAanpassen;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnLlnToev;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BtnLlnVerw;
        private System.Windows.Forms.Timer BewLlnOverg;
        private System.Windows.Forms.FlowLayoutPanel MenuBewInstr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInstAanp;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnInstVerw;
        private System.Windows.Forms.Timer BewInstOverg;
        private System.Windows.Forms.Timer Zijpaneel;
    }
}

