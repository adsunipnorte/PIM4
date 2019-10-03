namespace PIM3.Desktop
{
    partial class FrmCadUsuario
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.chksituacao = new System.Windows.Forms.CheckBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.lblpuser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbpuser = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblid.Location = new System.Drawing.Point(29, 27);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(65, 23);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 8;
            this.txtid.TabStop = false;
            // 
            // chksituacao
            // 
            this.chksituacao.AutoSize = true;
            this.chksituacao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.chksituacao.Location = new System.Drawing.Point(176, 27);
            this.chksituacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chksituacao.Name = "chksituacao";
            this.chksituacao.Size = new System.Drawing.Size(66, 23);
            this.chksituacao.TabIndex = 39;
            this.chksituacao.Text = "Ativo";
            this.chksituacao.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(133, 73);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(273, 27);
            this.txtnome.TabIndex = 1;
            this.txtnome.Tag = "";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(29, 73);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 19);
            this.lblnome.TabIndex = 41;
            this.lblnome.Text = "Nome";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(133, 105);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(273, 27);
            this.txtlogin.TabIndex = 2;
            this.txtlogin.Tag = "";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(29, 105);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(49, 19);
            this.lbllogin.TabIndex = 43;
            this.lbllogin.Text = "Login";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(492, 105);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(142, 27);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.Tag = "";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(430, 108);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(56, 19);
            this.lblsenha.TabIndex = 45;
            this.lblsenha.Text = "Senha";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(133, 145);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(273, 27);
            this.txtemail.TabIndex = 4;
            this.txtemail.Tag = "";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(31, 148);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(49, 19);
            this.lblemail.TabIndex = 47;
            this.lblemail.Text = "Email";
            // 
            // btnsair
            // 
            this.btnsair.AutoSize = true;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnsair.Location = new System.Drawing.Point(508, 437);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 59);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AutoSize = true;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnlimpar.Location = new System.Drawing.Point(392, 437);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 59);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.AutoSize = true;
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncad.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btncad.Location = new System.Drawing.Point(269, 437);
            this.btncad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(94, 59);
            this.btncad.TabIndex = 5;
            this.btncad.Text = "&Gravar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // lblpuser
            // 
            this.lblpuser.AutoSize = true;
            this.lblpuser.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuser.Location = new System.Drawing.Point(378, 31);
            this.lblpuser.Name = "lblpuser";
            this.lblpuser.Size = new System.Drawing.Size(108, 19);
            this.lblpuser.TabIndex = 52;
            this.lblpuser.Text = "Perfil Usuário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Login,
            this.Situacao});
            this.dataGridView1.Location = new System.Drawing.Point(33, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 211);
            this.dataGridView1.TabIndex = 57;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 260;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 260;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 115;
            // 
            // cmbpuser
            // 
            this.cmbpuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpuser.FormattingEnabled = true;
            this.cmbpuser.Location = new System.Drawing.Point(492, 25);
            this.cmbpuser.Name = "cmbpuser";
            this.cmbpuser.Size = new System.Drawing.Size(142, 27);
            this.cmbpuser.TabIndex = 58;
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 555);
            this.Controls.Add(this.cmbpuser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblpuser);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.chksituacao);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.CheckBox chksituacao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label lblpuser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.ComboBox cmbpuser;
    }
}