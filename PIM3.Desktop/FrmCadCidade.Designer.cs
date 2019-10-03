namespace PIM3.Desktop
{
    partial class FrmCadCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCidade));
            this.dgvcidade = new System.Windows.Forms.DataGridView();
            this.CodCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.txtnomecid = new System.Windows.Forms.TextBox();
            this.lblnomecid = new System.Windows.Forms.Label();
            this.lblcodcidade = new System.Windows.Forms.Label();
            this.txtcodcidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcidade
            // 
            this.dgvcidade.AllowUserToAddRows = false;
            this.dgvcidade.AllowUserToDeleteRows = false;
            this.dgvcidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCidade,
            this.Nome,
            this.IdEstados});
            this.dgvcidade.Location = new System.Drawing.Point(25, 135);
            this.dgvcidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvcidade.Name = "dgvcidade";
            this.dgvcidade.RowTemplate.Height = 24;
            this.dgvcidade.Size = new System.Drawing.Size(694, 211);
            this.dgvcidade.TabIndex = 76;
            // 
            // CodCidade
            // 
            this.CodCidade.HeaderText = "Código Cidade";
            this.CodCidade.Name = "CodCidade";
            this.CodCidade.ReadOnly = true;
            this.CodCidade.Width = 150;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Cidade";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // IdEstados
            // 
            this.IdEstados.HeaderText = "Estado";
            this.IdEstados.Name = "IdEstados";
            this.IdEstados.ReadOnly = true;
            this.IdEstados.Width = 200;
            // 
            // btnsair
            // 
            this.btnsair.AutoSize = true;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnsair.Location = new System.Drawing.Point(448, 412);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 59);
            this.btnsair.TabIndex = 72;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AutoSize = true;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnlimpar.Location = new System.Drawing.Point(332, 412);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 59);
            this.btnlimpar.TabIndex = 71;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.AutoSize = true;
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncad.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btncad.Location = new System.Drawing.Point(209, 412);
            this.btncad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(94, 59);
            this.btncad.TabIndex = 70;
            this.btncad.Text = "&Gravar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // txtnomecid
            // 
            this.txtnomecid.Location = new System.Drawing.Point(160, 61);
            this.txtnomecid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnomecid.Name = "txtnomecid";
            this.txtnomecid.Size = new System.Drawing.Size(273, 27);
            this.txtnomecid.TabIndex = 69;
            this.txtnomecid.Tag = "";
            // 
            // lblnomecid
            // 
            this.lblnomecid.AutoSize = true;
            this.lblnomecid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecid.Location = new System.Drawing.Point(21, 69);
            this.lblnomecid.Name = "lblnomecid";
            this.lblnomecid.Size = new System.Drawing.Size(84, 19);
            this.lblnomecid.TabIndex = 75;
            this.lblnomecid.Text = "Descrição";
            // 
            // lblcodcidade
            // 
            this.lblcodcidade.AutoSize = true;
            this.lblcodcidade.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblcodcidade.Location = new System.Drawing.Point(21, 19);
            this.lblcodcidade.Name = "lblcodcidade";
            this.lblcodcidade.Size = new System.Drawing.Size(118, 19);
            this.lblcodcidade.TabIndex = 74;
            this.lblcodcidade.Text = "Código Cidade";
            // 
            // txtcodcidade
            // 
            this.txtcodcidade.Location = new System.Drawing.Point(160, 16);
            this.txtcodcidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodcidade.Name = "txtcodcidade";
            this.txtcodcidade.Size = new System.Drawing.Size(164, 27);
            this.txtcodcidade.TabIndex = 77;
            this.txtcodcidade.Tag = "";
            // 
            // FrmCadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 534);
            this.Controls.Add(this.txtcodcidade);
            this.Controls.Add(this.dgvcidade);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtnomecid);
            this.Controls.Add(this.lblnomecid);
            this.Controls.Add(this.lblcodcidade);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadstro de cidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcidade;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.TextBox txtnomecid;
        private System.Windows.Forms.Label lblnomecid;
        private System.Windows.Forms.Label lblcodcidade;
        private System.Windows.Forms.TextBox txtcodcidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstados;
    }
}