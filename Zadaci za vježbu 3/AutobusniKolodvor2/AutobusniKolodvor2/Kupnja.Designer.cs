namespace AutobusniKolodvor2
{
    partial class Kupnja
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
            this.cbPrtljaga = new System.Windows.Forms.CheckBox();
            this.cbPovrat = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbIspis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPrtljaga);
            this.groupBox1.Controls.Add(this.cbPovrat);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.cbVrsta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(371, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije karte";
            // 
            // cbPrtljaga
            // 
            this.cbPrtljaga.AutoSize = true;
            this.cbPrtljaga.Location = new System.Drawing.Point(148, 95);
            this.cbPrtljaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrtljaga.Name = "cbPrtljaga";
            this.cbPrtljaga.Size = new System.Drawing.Size(82, 20);
            this.cbPrtljaga.TabIndex = 4;
            this.cbPrtljaga.Text = "Prtljaga?";
            this.cbPrtljaga.UseVisualStyleBackColor = true;
            // 
            // cbPovrat
            // 
            this.cbPovrat.AutoSize = true;
            this.cbPovrat.Location = new System.Drawing.Point(148, 68);
            this.cbPovrat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPovrat.Name = "cbPovrat";
            this.cbPovrat.Size = new System.Drawing.Size(123, 20);
            this.cbPovrat.TabIndex = 3;
            this.cbPovrat.Text = "Povratna karta?";
            this.cbPovrat.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 73);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Dodatno";
            // 
            // cbVrsta
            // 
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Items.AddRange(new object[] {
            "Regularna",
            "Studentska"});
            this.cbVrsta.Location = new System.Drawing.Point(148, 23);
            this.cbVrsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(213, 24);
            this.cbVrsta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta karte:";
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(285, 171);
            this.btnIspis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(113, 38);
            this.btnIspis.TabIndex = 1;
            this.btnIspis.Text = "Ispiši kartu";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbIspis);
            this.groupBox2.Location = new System.Drawing.Point(28, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(371, 255);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ispis karte";
            // 
            // tbIspis
            // 
            this.tbIspis.Enabled = false;
            this.tbIspis.Location = new System.Drawing.Point(8, 23);
            this.tbIspis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIspis.Multiline = true;
            this.tbIspis.Name = "tbIspis";
            this.tbIspis.Size = new System.Drawing.Size(353, 224);
            this.tbIspis.TabIndex = 0;
            this.tbIspis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Kupnja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kupnja";
            this.Text = "Kupnja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbPovrat;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox cbPrtljaga;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbIspis;
    }
}