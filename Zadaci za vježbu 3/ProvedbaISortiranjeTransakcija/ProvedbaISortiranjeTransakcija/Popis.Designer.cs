namespace ProvedbaISortiranjeTransakcija
{
    partial class Popis
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
            this.dgvPopis = new System.Windows.Forms.DataGridView();
            this.buttonStorno = new System.Windows.Forms.Button();
            this.buttonProvedi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopis
            // 
            this.dgvPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopis.Location = new System.Drawing.Point(20, 12);
            this.dgvPopis.Name = "dgvPopis";
            this.dgvPopis.RowHeadersWidth = 51;
            this.dgvPopis.RowTemplate.Height = 24;
            this.dgvPopis.Size = new System.Drawing.Size(743, 373);
            this.dgvPopis.TabIndex = 0;
            // 
            // buttonStorno
            // 
            this.buttonStorno.Location = new System.Drawing.Point(430, 403);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(151, 49);
            this.buttonStorno.TabIndex = 1;
            this.buttonStorno.Text = "Storniraj transakciju";
            this.buttonStorno.UseVisualStyleBackColor = true;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // buttonProvedi
            // 
            this.buttonProvedi.Location = new System.Drawing.Point(612, 403);
            this.buttonProvedi.Name = "buttonProvedi";
            this.buttonProvedi.Size = new System.Drawing.Size(151, 49);
            this.buttonProvedi.TabIndex = 2;
            this.buttonProvedi.Text = "Provedi transakciju";
            this.buttonProvedi.UseVisualStyleBackColor = true;
            this.buttonProvedi.Click += new System.EventHandler(this.buttonProvedi_Click);
            // 
            // Popis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.buttonProvedi);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.dgvPopis);
            this.Name = "Popis";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopis;
        private System.Windows.Forms.Button buttonStorno;
        private System.Windows.Forms.Button buttonProvedi;
    }
}

