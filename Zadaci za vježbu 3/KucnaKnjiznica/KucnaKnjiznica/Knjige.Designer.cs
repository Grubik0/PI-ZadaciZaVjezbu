namespace KucnaKnjiznica
{
    partial class Knjige
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
            this.dgvDostupno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPosudba = new System.Windows.Forms.DataGridView();
            this.buttonPosudi = new System.Windows.Forms.Button();
            this.buttonVrati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudba)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostupne knjige";
            // 
            // dgvDostupno
            // 
            this.dgvDostupno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupno.Location = new System.Drawing.Point(31, 61);
            this.dgvDostupno.Name = "dgvDostupno";
            this.dgvDostupno.RowHeadersWidth = 51;
            this.dgvDostupno.RowTemplate.Height = 24;
            this.dgvDostupno.Size = new System.Drawing.Size(346, 239);
            this.dgvDostupno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Knjige na posudbi";
            // 
            // dgvPosudba
            // 
            this.dgvPosudba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudba.Location = new System.Drawing.Point(405, 61);
            this.dgvPosudba.Name = "dgvPosudba";
            this.dgvPosudba.RowHeadersWidth = 51;
            this.dgvPosudba.RowTemplate.Height = 24;
            this.dgvPosudba.Size = new System.Drawing.Size(346, 239);
            this.dgvPosudba.TabIndex = 3;
            // 
            // buttonPosudi
            // 
            this.buttonPosudi.Location = new System.Drawing.Point(262, 306);
            this.buttonPosudi.Name = "buttonPosudi";
            this.buttonPosudi.Size = new System.Drawing.Size(115, 40);
            this.buttonPosudi.TabIndex = 4;
            this.buttonPosudi.Text = "Posudi";
            this.buttonPosudi.UseVisualStyleBackColor = true;
            this.buttonPosudi.Click += new System.EventHandler(this.buttonPosudi_Click);
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(636, 306);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(115, 40);
            this.buttonVrati.TabIndex = 5;
            this.buttonVrati.Text = "Vrati";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.buttonVrati_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVrati);
            this.Controls.Add(this.buttonPosudi);
            this.Controls.Add(this.dgvPosudba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDostupno);
            this.Controls.Add(this.label1);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDostupno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPosudba;
        private System.Windows.Forms.Button buttonPosudi;
        private System.Windows.Forms.Button buttonVrati;
    }
}

