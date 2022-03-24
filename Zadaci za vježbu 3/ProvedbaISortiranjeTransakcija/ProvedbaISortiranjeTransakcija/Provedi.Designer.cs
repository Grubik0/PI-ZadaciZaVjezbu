namespace ProvedbaISortiranjeTransakcija
{
    partial class Provedi
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
            this.textBoxIznos = new System.Windows.Forms.TextBox();
            this.comboBoxPlatitelj = new System.Windows.Forms.ComboBox();
            this.comboBoxPrimatelj = new System.Windows.Forms.ComboBox();
            this.buttonProvedi = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platitelj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primatelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iznos:";
            // 
            // textBoxIznos
            // 
            this.textBoxIznos.Location = new System.Drawing.Point(123, 120);
            this.textBoxIznos.Name = "textBoxIznos";
            this.textBoxIznos.Size = new System.Drawing.Size(162, 22);
            this.textBoxIznos.TabIndex = 3;
            // 
            // comboBoxPlatitelj
            // 
            this.comboBoxPlatitelj.FormattingEnabled = true;
            this.comboBoxPlatitelj.Location = new System.Drawing.Point(123, 37);
            this.comboBoxPlatitelj.Name = "comboBoxPlatitelj";
            this.comboBoxPlatitelj.Size = new System.Drawing.Size(162, 24);
            this.comboBoxPlatitelj.TabIndex = 4;
            // 
            // comboBoxPrimatelj
            // 
            this.comboBoxPrimatelj.FormattingEnabled = true;
            this.comboBoxPrimatelj.Location = new System.Drawing.Point(123, 73);
            this.comboBoxPrimatelj.Name = "comboBoxPrimatelj";
            this.comboBoxPrimatelj.Size = new System.Drawing.Size(162, 24);
            this.comboBoxPrimatelj.TabIndex = 5;
            // 
            // buttonProvedi
            // 
            this.buttonProvedi.Location = new System.Drawing.Point(71, 180);
            this.buttonProvedi.Name = "buttonProvedi";
            this.buttonProvedi.Size = new System.Drawing.Size(104, 35);
            this.buttonProvedi.TabIndex = 6;
            this.buttonProvedi.Text = "Provedi";
            this.buttonProvedi.UseVisualStyleBackColor = true;
            this.buttonProvedi.Click += new System.EventHandler(this.buttonProvedi_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.Location = new System.Drawing.Point(181, 180);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(104, 35);
            this.buttonOdustani.TabIndex = 7;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = true;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // Provedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 284);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonProvedi);
            this.Controls.Add(this.comboBoxPrimatelj);
            this.Controls.Add(this.comboBoxPlatitelj);
            this.Controls.Add(this.textBoxIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Provedi";
            this.Text = "Provedi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIznos;
        private System.Windows.Forms.ComboBox comboBoxPlatitelj;
        private System.Windows.Forms.ComboBox comboBoxPrimatelj;
        private System.Windows.Forms.Button buttonProvedi;
        private System.Windows.Forms.Button buttonOdustani;
    }
}