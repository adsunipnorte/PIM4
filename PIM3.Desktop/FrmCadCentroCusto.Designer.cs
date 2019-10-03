namespace PIM3.Desktop
{
    partial class FrmCadCentroCusto
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
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblidcc = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dgvccusto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chksituacao = new Bunifu.Framework.UI.BunifuCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvccusto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnsair.Location = new System.Drawing.Point(429, 390);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 59);
            this.btnsair.TabIndex = 45;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnlimpar.Location = new System.Drawing.Point(312, 390);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 59);
            this.btnlimpar.TabIndex = 44;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncad.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btncad.Location = new System.Drawing.Point(190, 390);
            this.btncad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(94, 59);
            this.btncad.TabIndex = 43;
            this.btncad.Text = "&Gravar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(133, 66);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(273, 27);
            this.txtdescricao.TabIndex = 40;
            this.txtdescricao.Tag = "";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbldescricao.Location = new System.Drawing.Point(32, 70);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 42;
            this.lbldescricao.Text = "Descrição";
            // 
            // lblidcc
            // 
            this.lblidcc.AutoSize = true;
            this.lblidcc.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblidcc.Location = new System.Drawing.Point(32, 21);
            this.lblidcc.Name = "lblidcc";
            this.lblidcc.Size = new System.Drawing.Size(26, 19);
            this.lblidcc.TabIndex = 41;
            this.lblidcc.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(68, 18);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 39;
            this.txtid.TabStop = false;
            // 
            // dgvccusto
            // 
            this.dgvccusto.AllowUserToAddRows = false;
            this.dgvccusto.AllowUserToDeleteRows = false;
            this.dgvccusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvccusto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Situacao});
            this.dgvccusto.Location = new System.Drawing.Point(3, 147);
            this.dgvccusto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvccusto.Name = "dgvccusto";
            this.dgvccusto.RowTemplate.Height = 24;
            this.dgvccusto.Size = new System.Drawing.Size(770, 178);
            this.dgvccusto.TabIndex = 47;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 308;
            // 
            // chksituacao
            // 
            this.chksituacao.AccessibleName = "";
            this.chksituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chksituacao.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chksituacao.Checked = true;
            this.chksituacao.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chksituacao.ForeColor = System.Drawing.Color.White;
            this.chksituacao.Location = new System.Drawing.Point(177, 21);
            this.chksituacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chksituacao.Name = "chksituacao";
            this.chksituacao.Size = new System.Drawing.Size(20, 20);
            this.chksituacao.TabIndex = 48;
            // 
            // FrmCadCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.chksituacao);
            this.Controls.Add(this.dgvccusto);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblidcc);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadCentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de custo";
            this.Load += new System.EventHandler(this.FrmCadCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvccusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblidcc;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridView dgvccusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private Bunifu.Framework.UI.BunifuCheckbox chksituacao;
    }
}