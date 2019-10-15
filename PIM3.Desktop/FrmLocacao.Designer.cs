namespace PIM3.Desktop
{
    partial class FrmLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocacao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkfitro = new System.Windows.Forms.CheckBox();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.dgvpesqlocacao = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idveiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaveiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesqlocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.novaToolStripMenuItem.Text = "&Nova";
            this.novaToolStripMenuItem.Click += new System.EventHandler(this.novaToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.alterarToolStripMenuItem.Text = "&Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(51, 23);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkfitro);
            this.groupBox1.Controls.Add(this.cmbfiltro);
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chkfitro
            // 
            this.chkfitro.AutoSize = true;
            this.chkfitro.Location = new System.Drawing.Point(394, 27);
            this.chkfitro.Name = "chkfitro";
            this.chkfitro.Size = new System.Drawing.Size(67, 23);
            this.chkfitro.TabIndex = 7;
            this.chkfitro.Text = "Filtro";
            this.chkfitro.UseVisualStyleBackColor = true;
            this.chkfitro.CheckedChanged += new System.EventHandler(this.chkfitro_CheckedChanged);
            // 
            // cmbfiltro
            // 
            this.cmbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltro.FormattingEnabled = true;
            this.cmbfiltro.Location = new System.Drawing.Point(492, 23);
            this.cmbfiltro.Name = "cmbfiltro";
            this.cmbfiltro.Size = new System.Drawing.Size(130, 27);
            this.cmbfiltro.TabIndex = 6;
            this.cmbfiltro.Visible = false;
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(240, 19);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(72, 76);
            this.btnsair.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnsair, "Sair");
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnalt
            // 
            this.btnalt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnalt.BackgroundImage")));
            this.btnalt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalt.Location = new System.Drawing.Point(139, 19);
            this.btnalt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(72, 76);
            this.btnalt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnalt, "Alterar locação");
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnovo.BackgroundImage")));
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(34, 19);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(72, 76);
            this.btnnovo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnnovo, "Nova locação");
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dgvpesqlocacao
            // 
            this.dgvpesqlocacao.AllowUserToAddRows = false;
            this.dgvpesqlocacao.AllowUserToDeleteRows = false;
            this.dgvpesqlocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesqlocacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idveiculo,
            this.placaveiculo,
            this.valordiaria});
            this.dgvpesqlocacao.Location = new System.Drawing.Point(12, 169);
            this.dgvpesqlocacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpesqlocacao.Name = "dgvpesqlocacao";
            this.dgvpesqlocacao.ReadOnly = true;
            this.dgvpesqlocacao.RowTemplate.Height = 24;
            this.dgvpesqlocacao.Size = new System.Drawing.Size(642, 255);
            this.dgvpesqlocacao.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idveiculo
            // 
            this.idveiculo.HeaderText = "Veículo";
            this.idveiculo.Name = "idveiculo";
            this.idveiculo.ReadOnly = true;
            this.idveiculo.Width = 300;
            // 
            // placaveiculo
            // 
            this.placaveiculo.HeaderText = "Placa";
            this.placaveiculo.Name = "placaveiculo";
            this.placaveiculo.ReadOnly = true;
            // 
            // valordiaria
            // 
            this.valordiaria.HeaderText = "Diária";
            this.valordiaria.Name = "valordiaria";
            this.valordiaria.ReadOnly = true;
            // 
            // FrmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.dgvpesqlocacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de locação";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesqlocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkfitro;
        private System.Windows.Forms.ComboBox cmbfiltro;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.DataGridView dgvpesqlocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idveiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaveiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordiaria;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}