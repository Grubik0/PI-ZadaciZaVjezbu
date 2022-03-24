namespace AutobusniKolodvor1
{
    partial class KreiranjeKarte
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPol = new System.Windows.Forms.TextBox();
            this.tbOdr = new System.Windows.Forms.TextBox();
            this.tbUd = new System.Windows.Forms.TextBox();
            this.tbAuto = new System.Windows.Forms.TextBox();
            this.btOdaberi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbReg = new System.Windows.Forms.RadioButton();
            this.rbStud = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPovrat = new System.Windows.Forms.CheckBox();
            this.cbPrtljaga = new System.Windows.Forms.CheckBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btOdaberi);
            this.groupBox1.Controls.Add(this.tbAuto);
            this.groupBox1.Controls.Add(this.tbUd);
            this.groupBox1.Controls.Add(this.tbOdr);
            this.groupBox1.Controls.Add(this.tbPol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autobusna linija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Polazište:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odredište:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Udaljenost (km):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autoprijevoznik";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPol
            // 
            this.tbPol.Location = new System.Drawing.Point(122, 29);
            this.tbPol.Name = "tbPol";
            this.tbPol.Size = new System.Drawing.Size(200, 22);
            this.tbPol.TabIndex = 4;
            // 
            // tbOdr
            // 
            this.tbOdr.Location = new System.Drawing.Point(122, 63);
            this.tbOdr.Name = "tbOdr";
            this.tbOdr.Size = new System.Drawing.Size(200, 22);
            this.tbOdr.TabIndex = 5;
            // 
            // tbUd
            // 
            this.tbUd.Location = new System.Drawing.Point(122, 95);
            this.tbUd.Name = "tbUd";
            this.tbUd.Size = new System.Drawing.Size(200, 22);
            this.tbUd.TabIndex = 6;
            // 
            // tbAuto
            // 
            this.tbAuto.Location = new System.Drawing.Point(122, 131);
            this.tbAuto.Name = "tbAuto";
            this.tbAuto.Size = new System.Drawing.Size(200, 22);
            this.tbAuto.TabIndex = 7;
            // 
            // btOdaberi
            // 
            this.btOdaberi.Location = new System.Drawing.Point(349, 29);
            this.btOdaberi.Name = "btOdaberi";
            this.btOdaberi.Size = new System.Drawing.Size(141, 56);
            this.btOdaberi.TabIndex = 8;
            this.btOdaberi.Text = "Odaberi liniju";
            this.btOdaberi.UseVisualStyleBackColor = true;
            this.btOdaberi.Click += new System.EventHandler(this.btOdaberi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStud);
            this.groupBox2.Controls.Add(this.rbReg);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrsta karte:";
            // 
            // rbReg
            // 
            this.rbReg.AutoSize = true;
            this.rbReg.Location = new System.Drawing.Point(20, 21);
            this.rbReg.Name = "rbReg";
            this.rbReg.Size = new System.Drawing.Size(124, 20);
            this.rbReg.TabIndex = 0;
            this.rbReg.TabStop = true;
            this.rbReg.Text = "Regularna karta";
            this.rbReg.UseVisualStyleBackColor = true;
            // 
            // rbStud
            // 
            this.rbStud.AutoSize = true;
            this.rbStud.Location = new System.Drawing.Point(166, 21);
            this.rbStud.Name = "rbStud";
            this.rbStud.Size = new System.Drawing.Size(128, 20);
            this.rbStud.TabIndex = 1;
            this.rbStud.TabStop = true;
            this.rbStud.Text = "Studentska karta";
            this.rbStud.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPrtljaga);
            this.groupBox3.Controls.Add(this.cbPovrat);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ostale opcije";
            // 
            // cbPovrat
            // 
            this.cbPovrat.AutoSize = true;
            this.cbPovrat.Location = new System.Drawing.Point(20, 21);
            this.cbPovrat.Name = "cbPovrat";
            this.cbPovrat.Size = new System.Drawing.Size(123, 20);
            this.cbPovrat.TabIndex = 0;
            this.cbPovrat.Text = "Povratna karta?";
            this.cbPovrat.UseVisualStyleBackColor = true;
            // 
            // cbPrtljaga
            // 
            this.cbPrtljaga.AutoSize = true;
            this.cbPrtljaga.Location = new System.Drawing.Point(166, 21);
            this.cbPrtljaga.Name = "cbPrtljaga";
            this.cbPrtljaga.Size = new System.Drawing.Size(82, 20);
            this.cbPrtljaga.TabIndex = 1;
            this.cbPrtljaga.Text = "Prtljaga?";
            this.cbPrtljaga.UseVisualStyleBackColor = true;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(12, 341);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(138, 63);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "Kreiraj kartu";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj karte:";
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(82, 436);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(162, 22);
            this.tbBroj.TabIndex = 5;
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(321, 436);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.Size = new System.Drawing.Size(162, 22);
            this.tbCijena.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cijena:";
            // 
            // KreiranjeKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 489);
            this.Controls.Add(this.tbCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KreiranjeKarte";
            this.Text = "Kupnja karte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOdaberi;
        private System.Windows.Forms.TextBox tbAuto;
        private System.Windows.Forms.TextBox tbUd;
        private System.Windows.Forms.TextBox tbOdr;
        private System.Windows.Forms.TextBox tbPol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbStud;
        private System.Windows.Forms.RadioButton rbReg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbPrtljaga;
        private System.Windows.Forms.CheckBox cbPovrat;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.Label label6;
    }
}

