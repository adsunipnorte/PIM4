namespace PIM3.Desktop
{
    partial class FrmFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanceiro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkfitro = new System.Windows.Forms.CheckBox();
            this.cmbfiltro = new System.Windows.Forms.ComboBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvpesqfinanceiro = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valororig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesqfinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkfitro);
            this.groupBox1.Controls.Add(this.cmbfiltro);
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 108);
            this.groupBox1.TabIndex = 2;
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
            this.btnsair.Location = new System.Drawing.Point(241, 19);
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
            this.toolTip1.SetToolTip(this.btnalt, "Alterar Lançamento");
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
            this.toolTip1.SetToolTip(this.btnnovo, "Novo Lançamento");
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
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
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
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
            // dgvpesqfinanceiro
            // 
            this.dgvpesqfinanceiro.AllowUserToAddRows = false;
            this.dgvpesqfinanceiro.AllowUserToDeleteRows = false;
            this.dgvpesqfinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesqfinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idclientes,
            this.descricao,
            this.valororig,
            this.vencimento});
            this.dgvpesqfinanceiro.Location = new System.Drawing.Point(12, 172);
            this.dgvpesqfinanceiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvpesqfinanceiro.Name = "dgvpesqfinanceiro";
            this.dgvpesqfinanceiro.ReadOnly = true;
            this.dgvpesqfinanceiro.RowTemplate.Height = 24;
            this.dgvpesqfinanceiro.Size = new System.Drawing.Size(794, 255);
            this.dgvpesqfinanceiro.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idclientes
            // 
            this.idclientes.HeaderText = "Cliente";
            this.idclientes.Name = "idclientes";
            this.idclientes.ReadOnly = true;
            this.idclientes.Width = 250;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 200;
            // 
            // valororig
            // 
            this.valororig.HeaderText = "Valor";
            this.valororig.Name = "valororig";
            this.valororig.ReadOnly = true;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            // 
            // FrmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.dgvpesqfinanceiro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta financeiro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesqfinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvpesqfinanceiro;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.CheckBox chkfitro;
        private System.Windows.Forms.ComboBox cmbfiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valororig;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
    }
}