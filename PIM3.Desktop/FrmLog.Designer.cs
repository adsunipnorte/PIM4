namespace PIM3.Desktop
{
    partial class FrmLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.mskdata = new System.Windows.Forms.MaskedTextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Descricao,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(34, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 211);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 300;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 115;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(138, 67);
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
            this.lbldescricao.Location = new System.Drawing.Point(33, 72);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 75;
            this.lbldescricao.Text = "Descrição";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblid.Location = new System.Drawing.Point(30, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 74;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(66, 16);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 68;
            this.txtid.TabStop = false;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(145, 23);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(43, 19);
            this.lbldata.TabIndex = 78;
            this.lbldata.Text = "Data";
            // 
            // mskdata
            // 
            this.mskdata.Location = new System.Drawing.Point(194, 15);
            this.mskdata.Mask = "00/00/0000 90:00";
            this.mskdata.Name = "mskdata";
            this.mskdata.Size = new System.Drawing.Size(100, 27);
            this.mskdata.TabIndex = 3;
            this.mskdata.ValidatingType = typeof(System.DateTime);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(319, 22);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(65, 19);
            this.lblusuario.TabIndex = 79;
            this.lblusuario.Text = "Usuário";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(407, 15);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 27);
            this.txtusuario.TabIndex = 80;
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.mskdata);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log de usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.MaskedTextBox mskdata;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.TextBox txtusuario;
    }
}