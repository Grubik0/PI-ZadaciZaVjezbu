namespace FiltriranjeTransakcija
{
    partial class Transakcije
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
            this.radioButtonUplate = new System.Windows.Forms.RadioButton();
            this.radioButtonIsplate = new System.Windows.Forms.RadioButton();
            this.radioButtonSve = new System.Windows.Forms.RadioButton();
            this.comboBoxRacuni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonOcisti = new System.Windows.Forms.Button();
            this.dgvIspis = new System.Windows.Forms.DataGridView();
            this.buttonDetalji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUplate);
            this.groupBox1.Controls.Add(this.radioButtonIsplate);
            this.groupBox1.Controls.Add(this.radioButtonSve);
            this.groupBox1.Controls.Add(this.comboBoxRacuni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // radioButtonUplate
            // 
            this.radioButtonUplate.AutoSize = true;
            this.radioButtonUplate.Location = new System.Drawing.Point(261, 60);
            this.radioButtonUplate.Name = "radioButtonUplate";
            this.radioButtonUplate.Size = new System.Drawing.Size(68, 20);
            this.radioButtonUplate.TabIndex = 5;
            this.radioButtonUplate.TabStop = true;
            this.radioButtonUplate.Text = "Uplate";
            this.radioButtonUplate.UseVisualStyleBackColor = true;
            // 
            // radioButtonIsplate
            // 
            this.radioButtonIsplate.AutoSize = true;
            this.radioButtonIsplate.Location = new System.Drawing.Point(187, 60);
            this.radioButtonIsplate.Name = "radioButtonIsplate";
            this.radioButtonIsplate.Size = new System.Drawing.Size(68, 20);
            this.radioButtonIsplate.TabIndex = 4;
            this.radioButtonIsplate.TabStop = true;
            this.radioButtonIsplate.Text = "Isplate";
            this.radioButtonIsplate.UseVisualStyleBackColor = true;
            // 
            // radioButtonSve
            // 
            this.radioButtonSve.AutoSize = true;
            this.radioButtonSve.Location = new System.Drawing.Point(129, 60);
            this.radioButtonSve.Name = "radioButtonSve";
            this.radioButtonSve.Size = new System.Drawing.Size(52, 20);
            this.radioButtonSve.TabIndex = 3;
            this.radioButtonSve.TabStop = true;
            this.radioButtonSve.Text = "Sve";
            this.radioButtonSve.UseVisualStyleBackColor = true;
            // 
            // comboBoxRacuni
            // 
            this.comboBoxRacuni.FormattingEnabled = true;
            this.comboBoxRacuni.Location = new System.Drawing.Point(129, 23);
            this.comboBoxRacuni.Name = "comboBoxRacuni";
            this.comboBoxRacuni.Size = new System.Drawing.Size(200, 24);
            this.comboBoxRacuni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip transakcije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(443, 47);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 55);
            this.buttonFilter.TabIndex = 6;
            this.buttonFilter.Text = "Filtriraj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonOcisti
            // 
            this.buttonOcisti.Location = new System.Drawing.Point(524, 47);
            this.buttonOcisti.Name = "buttonOcisti";
            this.buttonOcisti.Size = new System.Drawing.Size(75, 55);
            this.buttonOcisti.TabIndex = 7;
            this.buttonOcisti.Text = "Očisti";
            this.buttonOcisti.UseVisualStyleBackColor = true;
            this.buttonOcisti.Click += new System.EventHandler(this.buttonOcisti_Click);
            // 
            // dgvIspis
            // 
            this.dgvIspis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspis.Location = new System.Drawing.Point(24, 145);
            this.dgvIspis.Name = "dgvIspis";
            this.dgvIspis.RowHeadersWidth = 51;
            this.dgvIspis.RowTemplate.Height = 24;
            this.dgvIspis.Size = new System.Drawing.Size(575, 240);
            this.dgvIspis.TabIndex = 1;
            // 
            // buttonDetalji
            // 
            this.buttonDetalji.Location = new System.Drawing.Point(477, 404);
            this.buttonDetalji.Name = "buttonDetalji";
            this.buttonDetalji.Size = new System.Drawing.Size(122, 55);
            this.buttonDetalji.TabIndex = 8;
            this.buttonDetalji.Text = "Detalji računa";
            this.buttonDetalji.UseVisualStyleBackColor = true;
            this.buttonDetalji.Click += new System.EventHandler(this.buttonDetalji_Click);
            // 
            // Transakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 491);
            this.Controls.Add(this.buttonDetalji);
            this.Controls.Add(this.buttonOcisti);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dgvIspis);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transakcije";
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.Transakcije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUplate;
        private System.Windows.Forms.RadioButton radioButtonIsplate;
        private System.Windows.Forms.RadioButton radioButtonSve;
        private System.Windows.Forms.ComboBox comboBoxRacuni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonOcisti;
        private System.Windows.Forms.DataGridView dgvIspis;
        private System.Windows.Forms.Button buttonDetalji;
    }
}

