namespace PIM3.Desktop
{
    partial class FrmCadManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadManutencao));
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmbtpmanut = new System.Windows.Forms.ComboBox();
            this.lbltpmanut = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.lblveiculo = new System.Windows.Forms.Label();
            this.txtveiculo = new System.Windows.Forms.TextBox();
            this.lblplacaveiculo = new System.Windows.Forms.Label();
            this.txtplacaveiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblid.Location = new System.Drawing.Point(43, 34);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 69;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(79, 30);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 68;
            this.txtid.TabStop = false;
            // 
            // cmbtpmanut
            // 
            this.cmbtpmanut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtpmanut.FormattingEnabled = true;
            this.cmbtpmanut.Location = new System.Drawing.Point(395, 34);
            this.cmbtpmanut.Name = "cmbtpmanut";
            this.cmbtpmanut.Size = new System.Drawing.Size(121, 27);
            this.cmbtpmanut.TabIndex = 70;
            // 
            // lbltpmanut
            // 
            this.lbltpmanut.AutoSize = true;
            this.lbltpmanut.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbltpmanut.Location = new System.Drawing.Point(210, 38);
            this.lbltpmanut.Name = "lbltpmanut";
            this.lbltpmanut.Size = new System.Drawing.Size(156, 19);
            this.lbltpmanut.TabIndex = 71;
            this.lbltpmanut.Text = "Tipo de Manutenção";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(161, 85);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(355, 27);
            this.txtdescricao.TabIndex = 72;
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbldescricao.Location = new System.Drawing.Point(43, 88);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 73;
            this.lbldescricao.Text = "Descrição";
            // 
            // btnsair
            // 
            this.btnsair.AutoSize = true;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnsair.Location = new System.Drawing.Point(456, 389);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(94, 59);
            this.btnsair.TabIndex = 76;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AutoSize = true;
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnlimpar.Location = new System.Drawing.Point(340, 389);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 59);
            this.btnlimpar.TabIndex = 75;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btncad
            // 
            this.btncad.AutoSize = true;
            this.btncad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncad.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btncad.Location = new System.Drawing.Point(217, 389);
            this.btncad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(94, 59);
            this.btncad.TabIndex = 74;
            this.btncad.Text = "&Gravar";
            this.btncad.UseVisualStyleBackColor = true;
            // 
            // lblveiculo
            // 
            this.lblveiculo.AutoSize = true;
            this.lblveiculo.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblveiculo.Location = new System.Drawing.Point(43, 134);
            this.lblveiculo.Name = "lblveiculo";
            this.lblveiculo.Size = new System.Drawing.Size(63, 19);
            this.lblveiculo.TabIndex = 78;
            this.lblveiculo.Text = "Veículo";
            // 
            // txtveiculo
            // 
            this.txtveiculo.Location = new System.Drawing.Point(161, 131);
            this.txtveiculo.Name = "txtveiculo";
            this.txtveiculo.Size = new System.Drawing.Size(355, 27);
            this.txtveiculo.TabIndex = 77;
            // 
            // lblplacaveiculo
            // 
            this.lblplacaveiculo.AutoSize = true;
            this.lblplacaveiculo.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblplacaveiculo.Location = new System.Drawing.Point(43, 167);
            this.lblplacaveiculo.Name = "lblplacaveiculo";
            this.lblplacaveiculo.Size = new System.Drawing.Size(106, 19);
            this.lblplacaveiculo.TabIndex = 80;
            this.lblplacaveiculo.Text = "Placa veículo";
            // 
            // txtplacaveiculo
            // 
            this.txtplacaveiculo.Location = new System.Drawing.Point(161, 164);
            this.txtplacaveiculo.Name = "txtplacaveiculo";
            this.txtplacaveiculo.Size = new System.Drawing.Size(355, 27);
            this.txtplacaveiculo.TabIndex = 79;
            // 
            // FrmCadManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.lblplacaveiculo);
            this.Controls.Add(this.txtplacaveiculo);
            this.Controls.Add(this.lblveiculo);
            this.Controls.Add(this.txtveiculo);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbltpmanut);
            this.Controls.Add(this.cmbtpmanut);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadManutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de manutenção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbtpmanut;
        private System.Windows.Forms.Label lbltpmanut;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label lblveiculo;
        private System.Windows.Forms.TextBox txtveiculo;
        private System.Windows.Forms.Label lblplacaveiculo;
        private System.Windows.Forms.TextBox txtplacaveiculo;
    }
}