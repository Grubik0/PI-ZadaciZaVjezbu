namespace FiltriranjeTransakcija
{
    partial class Detalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxIBAN = new System.Windows.Forms.TextBox();
            this.textBoxVlasnik = new System.Windows.Forms.TextBox();
            this.textBoxStanje = new System.Windows.Forms.TextBox();
            this.textBoxPromet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni promet:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(92, 180);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 43);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxIBAN
            // 
            this.textBoxIBAN.Enabled = false;
            this.textBoxIBAN.Location = new System.Drawing.Point(140, 23);
            this.textBoxIBAN.Name = "textBoxIBAN";
            this.textBoxIBAN.Size = new System.Drawing.Size(141, 22);
            this.textBoxIBAN.TabIndex = 5;
            // 
            // textBoxVlasnik
            // 
            this.textBoxVlasnik.Enabled = false;
            this.textBoxVlasnik.Location = new System.Drawing.Point(140, 51);
            this.textBoxVlasnik.Name = "textBoxVlasnik";
            this.textBoxVlasnik.Size = new System.Drawing.Size(141, 22);
            this.textBoxVlasnik.TabIndex = 6;
            // 
            // textBoxStanje
            // 
            this.textBoxStanje.Enabled = false;
            this.textBoxStanje.Location = new System.Drawing.Point(140, 98);
            this.textBoxStanje.Name = "textBoxStanje";
            this.textBoxStanje.Size = new System.Drawing.Size(141, 22);
            this.textBoxStanje.TabIndex = 7;
            // 
            // textBoxPromet
            // 
            this.textBoxPromet.Enabled = false;
            this.textBoxPromet.Location = new System.Drawing.Point(140, 126);
            this.textBoxPromet.Name = "textBoxPromet";
            this.textBoxPromet.Size = new System.Drawing.Size(141, 22);
            this.textBoxPromet.TabIndex = 8;
            // 
            // Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 293);
            this.Controls.Add(this.textBoxPromet);
            this.Controls.Add(this.textBoxStanje);
            this.Controls.Add(this.textBoxVlasnik);
            this.Controls.Add(this.textBoxIBAN);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Detalji";
            this.Text = "Detalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxIBAN;
        private System.Windows.Forms.TextBox textBoxVlasnik;
        private System.Windows.Forms.TextBox textBoxStanje;
        private System.Windows.Forms.TextBox textBoxPromet;
    }
}