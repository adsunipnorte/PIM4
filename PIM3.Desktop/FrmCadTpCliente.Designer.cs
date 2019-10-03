namespace PIM3.Desktop
{
    partial class FrmCadTpCliente
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
            this.lblidcliente = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.chksituacao = new System.Windows.Forms.CheckBox();
            this.dgvtpcliente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtpcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblidcliente.Location = new System.Drawing.Point(25, 30);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(26, 19);
            this.lblidcliente.TabIndex = 7;
            this.lblidcliente.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(61, 26);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 0;
            this.txtid.TabStop = false;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(126, 75);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(273, 27);
            this.txtdescricao.TabIndex = 1;
            this.txtdescricao.Tag = "";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(25, 78);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 9;
            this.lbldescricao.Text = "Descrição";
            // 
            // btnsair
            // 
            this.btnsair.AutoSize = true;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnsair.Location = new System.Drawing.Point(490, 422);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 59);
            this.btnsair.TabIndex = 20;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AutoSize = true;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnlimpar.Location = new System.Drawing.Point(374, 422);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 59);
            this.btnlimpar.TabIndex = 19;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.AutoSize = true;
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncad.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btncad.Location = new System.Drawing.Point(251, 422);
            this.btncad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(94, 59);
            this.btncad.TabIndex = 18;
            this.btncad.Text = "&Gravar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // chksituacao
            // 
            this.chksituacao.AutoSize = true;
            this.chksituacao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.chksituacao.Location = new System.Drawing.Point(173, 26);
            this.chksituacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chksituacao.Name = "chksituacao";
            this.chksituacao.Size = new System.Drawing.Size(66, 23);
            this.chksituacao.TabIndex = 38;
            this.chksituacao.Text = "Ativo";
            this.chksituacao.UseVisualStyleBackColor = true;
            // 
            // dgvtpcliente
            // 
            this.dgvtpcliente.AllowUserToAddRows = false;
            this.dgvtpcliente.AllowUserToDeleteRows = false;
            this.dgvtpcliente.AllowUserToOrderColumns = true;
            this.dgvtpcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtpcliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descricao,
            this.Ativo});
            this.dgvtpcliente.Location = new System.Drawing.Point(29, 145);
            this.dgvtpcliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvtpcliente.Name = "dgvtpcliente";
            this.dgvtpcliente.RowTemplate.Height = 24;
            this.dgvtpcliente.Size = new System.Drawing.Size(770, 200);
            this.dgvtpcliente.TabIndex = 0;
            this.dgvtpcliente.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Nome";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 500;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Situação";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 150;
            // 
            // FrmCadTpCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 555);
            this.Controls.Add(this.dgvtpcliente);
            this.Controls.Add(this.chksituacao);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblidcliente);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadTpCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtpcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.CheckBox chksituacao;
        private System.Windows.Forms.DataGridView dgvtpcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}