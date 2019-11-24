namespace PIM3.Desktop
{
    partial class FrmPecas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPecas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvpecas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtpesquisar = new JTextBox2.JTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbestoquemax = new System.Windows.Forms.RadioButton();
            this.rdbestoquemin = new System.Windows.Forms.RadioButton();
            this.rdbpeca = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquemin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoquemax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msktxtpesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnpesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpecas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(957, 27);
            this.menuStrip1.TabIndex = 0;
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
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.novoToolStripMenuItem.Text = "&Novo";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.alterarToolStripMenuItem.Text = "&Alterar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(51, 23);
            this.sairToolStripMenuItem1.Text = "&Sair";
            // 
            // dgvpecas
            // 
            this.dgvpecas.AllowUserToAddRows = false;
            this.dgvpecas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvpecas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpecas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpecas.BackgroundColor = System.Drawing.Color.White;
            this.dgvpecas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpecas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvpecas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpecas.ColumnHeadersHeight = 50;
            this.dgvpecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.estoquemin,
            this.estoquemax,
            this.quantidade,
            this.custo,
            this.custoant});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpecas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpecas.DoubleBuffered = true;
            this.dgvpecas.EnableHeadersVisualStyles = false;
            this.dgvpecas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvpecas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvpecas.Location = new System.Drawing.Point(13, 145);
            this.dgvpecas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpecas.Name = "dgvpecas";
            this.dgvpecas.ReadOnly = true;
            this.dgvpecas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpecas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpecas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvpecas.RowTemplate.DividerHeight = 1;
            this.dgvpecas.RowTemplate.Height = 40;
            this.dgvpecas.RowTemplate.ReadOnly = true;
            this.dgvpecas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpecas.Size = new System.Drawing.Size(931, 398);
            this.dgvpecas.TabIndex = 1020;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.HintText = null;
            this.txtpesquisar.IsPassword = false;
            this.txtpesquisar.Location = new System.Drawing.Point(589, 58);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.txtpesquisar.MaxLength = 50;
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.OnFocusedColor = System.Drawing.Color.White;
            this.txtpesquisar.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtpesquisar.ReadOnly = false;
            this.txtpesquisar.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtpesquisar.Size = new System.Drawing.Size(245, 30);
            this.txtpesquisar.TabIndex = 1024;
            this.txtpesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpesquisar.TextName = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbestoquemax);
            this.groupBox2.Controls.Add(this.rdbestoquemin);
            this.groupBox2.Controls.Add(this.rdbpeca);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(289, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 108);
            this.groupBox2.TabIndex = 1026;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de pesquisa";
            // 
            // rdbestoquemax
            // 
            this.rdbestoquemax.AutoSize = true;
            this.rdbestoquemax.Location = new System.Drawing.Point(113, 35);
            this.rdbestoquemax.Name = "rdbestoquemax";
            this.rdbestoquemax.Size = new System.Drawing.Size(149, 23);
            this.rdbestoquemax.TabIndex = 2;
            this.rdbestoquemax.TabStop = true;
            this.rdbestoquemax.Text = "Estoque Máximo";
            this.rdbestoquemax.UseVisualStyleBackColor = true;
            this.rdbestoquemax.CheckedChanged += new System.EventHandler(this.rdbestoquemax_CheckedChanged);
            // 
            // rdbestoquemin
            // 
            this.rdbestoquemin.AutoSize = true;
            this.rdbestoquemin.Location = new System.Drawing.Point(52, 68);
            this.rdbestoquemin.Name = "rdbestoquemin";
            this.rdbestoquemin.Size = new System.Drawing.Size(147, 23);
            this.rdbestoquemin.TabIndex = 1;
            this.rdbestoquemin.TabStop = true;
            this.rdbestoquemin.Text = "Estoque Mínimo";
            this.rdbestoquemin.UseVisualStyleBackColor = true;
            this.rdbestoquemin.CheckedChanged += new System.EventHandler(this.rdbestoquemin_CheckedChanged);
            // 
            // rdbpeca
            // 
            this.rdbpeca.AutoSize = true;
            this.rdbpeca.Location = new System.Drawing.Point(16, 37);
            this.rdbpeca.Name = "rdbpeca";
            this.rdbpeca.Size = new System.Drawing.Size(68, 23);
            this.rdbpeca.TabIndex = 0;
            this.rdbpeca.TabStop = true;
            this.rdbpeca.Text = "Peça";
            this.rdbpeca.UseVisualStyleBackColor = true;
            this.rdbpeca.CheckedChanged += new System.EventHandler(this.rdbpeca_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 108);
            this.groupBox1.TabIndex = 1023;
            this.groupBox1.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 19.14069F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.FillWeight = 54.26398F;
            this.descricao.HeaderText = "Peça";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // estoquemin
            // 
            this.estoquemin.DataPropertyName = "estoquemin";
            this.estoquemin.FillWeight = 53.01974F;
            this.estoquemin.HeaderText = "Estoque Mínimo";
            this.estoquemin.Name = "estoquemin";
            this.estoquemin.ReadOnly = true;
            // 
            // estoquemax
            // 
            this.estoquemax.DataPropertyName = "estoquemax";
            this.estoquemax.FillWeight = 51.94605F;
            this.estoquemax.HeaderText = "Estoque Máximo";
            this.estoquemax.Name = "estoquemax";
            this.estoquemax.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.FillWeight = 63.71961F;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // custo
            // 
            this.custo.DataPropertyName = "custo";
            this.custo.FillWeight = 58.49346F;
            this.custo.HeaderText = "Custo Atual";
            this.custo.Name = "custo";
            this.custo.ReadOnly = true;
            // 
            // custoant
            // 
            this.custoant.DataPropertyName = "custoant";
            this.custoant.FillWeight = 30.41649F;
            this.custoant.HeaderText = "Custo Anterior";
            this.custoant.Name = "custoant";
            this.custoant.ReadOnly = true;
            // 
            // msktxtpesquisa
            // 
            this.msktxtpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktxtpesquisa.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.msktxtpesquisa.ForeColor = System.Drawing.Color.Gray;
            this.msktxtpesquisa.Location = new System.Drawing.Point(589, 18);
            this.msktxtpesquisa.Margin = new System.Windows.Forms.Padding(5);
            this.msktxtpesquisa.Name = "msktxtpesquisa";
            this.msktxtpesquisa.Size = new System.Drawing.Size(245, 30);
            this.msktxtpesquisa.TabIndex = 1027;
            this.msktxtpesquisa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtpesquisa.Visible = false;
            this.msktxtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msktxtpesquisa_KeyPress);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.ActiveBorderThickness = 1;
            this.btnpesquisar.ActiveCornerRadius = 20;
            this.btnpesquisar.ActiveFillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpesquisar.ActiveForecolor = System.Drawing.Color.White;
            this.btnpesquisar.ActiveLineColor = System.Drawing.Color.White;
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnpesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.BackgroundImage")));
            this.btnpesquisar.ButtonText = "Pesquisar";
            this.btnpesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnpesquisar.IdleBorderThickness = 1;
            this.btnpesquisar.IdleCornerRadius = 20;
            this.btnpesquisar.IdleFillColor = System.Drawing.Color.White;
            this.btnpesquisar.IdleForecolor = System.Drawing.Color.Black;
            this.btnpesquisar.IdleLineColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(645, 98);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(117, 35);
            this.btnpesquisar.TabIndex = 1025;
            this.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(175, 19);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(72, 76);
            this.btnsair.TabIndex = 5;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnalt
            // 
            this.btnalt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnalt.BackgroundImage")));
            this.btnalt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalt.Location = new System.Drawing.Point(92, 19);
            this.btnalt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(72, 76);
            this.btnalt.TabIndex = 4;
            this.btnalt.UseVisualStyleBackColor = true;
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnovo.BackgroundImage")));
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(9, 19);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(72, 76);
            this.btnnovo.TabIndex = 3;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // FrmPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 520);
            this.Controls.Add(this.msktxtpesquisa);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvpecas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de peças";
            this.Load += new System.EventHandler(this.FrmPecas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPecas_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpecas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvpecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoquemin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoquemax;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoant;
        private JTextBox2.JTextBox txtpesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbestoquemax;
        private System.Windows.Forms.RadioButton rdbestoquemin;
        private System.Windows.Forms.RadioButton rdbpeca;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.MaskedTextBox msktxtpesquisa;
    }
}