namespace KucnaKnjiznica2
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSve = new System.Windows.Forms.RadioButton();
            this.radioButtonTren = new System.Windows.Forms.RadioButton();
            this.radioButtonProsle = new System.Windows.Forms.RadioButton();
            this.dgvIspis = new System.Windows.Forms.DataGridView();
            this.buttonVrati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaži:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonSve
            // 
            this.radioButtonSve.AutoSize = true;
            this.radioButtonSve.Location = new System.Drawing.Point(113, 34);
            this.radioButtonSve.Name = "radioButtonSve";
            this.radioButtonSve.Size = new System.Drawing.Size(109, 20);
            this.radioButtonSve.TabIndex = 1;
            this.radioButtonSve.TabStop = true;
            this.radioButtonSve.Text = "Sve posudbe";
            this.radioButtonSve.UseVisualStyleBackColor = true;
            this.radioButtonSve.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonSve_MouseClick);
            // 
            // radioButtonTren
            // 
            this.radioButtonTren.AutoSize = true;
            this.radioButtonTren.Location = new System.Drawing.Point(228, 34);
            this.radioButtonTren.Name = "radioButtonTren";
            this.radioButtonTren.Size = new System.Drawing.Size(138, 20);
            this.radioButtonTren.TabIndex = 2;
            this.radioButtonTren.TabStop = true;
            this.radioButtonTren.Text = "Trenutne posudbe";
            this.radioButtonTren.UseVisualStyleBackColor = true;
            this.radioButtonTren.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonTren_MouseClick);
            // 
            // radioButtonProsle
            // 
            this.radioButtonProsle.AutoSize = true;
            this.radioButtonProsle.Location = new System.Drawing.Point(372, 34);
            this.radioButtonProsle.Name = "radioButtonProsle";
            this.radioButtonProsle.Size = new System.Drawing.Size(124, 20);
            this.radioButtonProsle.TabIndex = 3;
            this.radioButtonProsle.TabStop = true;
            this.radioButtonProsle.Text = "Prošle posudbe";
            this.radioButtonProsle.UseVisualStyleBackColor = true;
            this.radioButtonProsle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonProsle_MouseClick);
            // 
            // dgvIspis
            // 
            this.dgvIspis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspis.Location = new System.Drawing.Point(30, 76);
            this.dgvIspis.Name = "dgvIspis";
            this.dgvIspis.RowHeadersWidth = 51;
            this.dgvIspis.RowTemplate.Height = 24;
            this.dgvIspis.Size = new System.Drawing.Size(728, 304);
            this.dgvIspis.TabIndex = 4;
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(637, 397);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(121, 52);
            this.buttonVrati.TabIndex = 5;
            this.buttonVrati.Text = "Vrati";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.buttonVrati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.buttonVrati);
            this.Controls.Add(this.dgvIspis);
            this.Controls.Add(this.radioButtonProsle);
            this.Controls.Add(this.radioButtonTren);
            this.Controls.Add(this.radioButtonSve);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSve;
        private System.Windows.Forms.RadioButton radioButtonTren;
        private System.Windows.Forms.RadioButton radioButtonProsle;
        private System.Windows.Forms.DataGridView dgvIspis;
        private System.Windows.Forms.Button buttonVrati;
    }
}

