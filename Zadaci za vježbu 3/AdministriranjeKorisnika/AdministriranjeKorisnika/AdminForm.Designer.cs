namespace AdministriranjeKorisnika
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usersRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_a = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users:";
            // 
            // usersRepositoryBindingSource
            // 
            this.usersRepositoryBindingSource.DataSource = typeof(AutentifikacijaLib.UsersRepository);
            // 
            // btn_a
            // 
            this.btn_a.Location = new System.Drawing.Point(67, 296);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(137, 48);
            this.btn_a.TabIndex = 2;
            this.btn_a.Text = "Activate";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(226, 296);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(137, 48);
            this.btn_d.TabIndex = 3;
            this.btn_d.Text = "Deactivate";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(50, 49);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 24;
            this.dgv_users.Size = new System.Drawing.Size(994, 214);
            this.dgv_users.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 450);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.usersRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usersRepositoryBindingSource;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.DataGridView dgv_users;
    }
}