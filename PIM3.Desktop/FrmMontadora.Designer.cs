namespace PIM3.Desktop
{
    partial class FrmMontadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMontadora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvmontadora = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtpesquisar = new JTextBox2.JTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbsituacao = new System.Windows.Forms.RadioButton();
            this.rdbdescricao = new System.Windows.Forms.RadioButton();
            this.btnpesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmontadora)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(782, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.sairToolStripMenuItem1});
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
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(132, 26);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(8, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 108);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(168, 19);
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
            this.btnalt.Location = new System.Drawing.Point(88, 19);
            this.btnalt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(72, 76);
            this.btnalt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnalt, "Alterar montadora");
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnovo.BackgroundImage")));
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(10, 19);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(72, 76);
            this.btnnovo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnnovo, "Nova montadora");
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dgvmontadora
            // 
            this.dgvmontadora.AllowUserToAddRows = false;
            this.dgvmontadora.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvmontadora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmontadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmontadora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmontadora.BackgroundColor = System.Drawing.Color.White;
            this.dgvmontadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmontadora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvmontadora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmontadora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmontadora.ColumnHeadersHeight = 50;
            this.dgvmontadora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.situacao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmontadora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvmontadora.DoubleBuffered = true;
            this.dgvmontadora.EnableHeadersVisualStyles = false;
            this.dgvmontadora.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvmontadora.HeaderForeColor = System.Drawing.Color.White;
            this.dgvmontadora.Location = new System.Drawing.Point(8, 144);
            this.dgvmontadora.Margin = new System.Windows.Forms.Padding(4);
            this.dgvmontadora.Name = "dgvmontadora";
            this.dgvmontadora.ReadOnly = true;
            this.dgvmontadora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmontadora.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvmontadora.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvmontadora.RowTemplate.DividerHeight = 1;
            this.dgvmontadora.RowTemplate.Height = 40;
            this.dgvmontadora.RowTemplate.ReadOnly = true;
            this.dgvmontadora.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmontadora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmontadora.Size = new System.Drawing.Size(756, 398);
            this.dgvmontadora.TabIndex = 1013;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.HintText = null;
            this.txtpesquisar.IsPassword = false;
            this.txtpesquisar.Location = new System.Drawing.Point(461, 61);
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
            this.groupBox2.Controls.Add(this.rdbsituacao);
            this.groupBox2.Controls.Add(this.rdbdescricao);
            this.groupBox2.Location = new System.Drawing.Point(266, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 108);
            this.groupBox2.TabIndex = 1026;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de pesquisa";
            // 
            // rdbsituacao
            // 
            this.rdbsituacao.AutoSize = true;
            this.rdbsituacao.Location = new System.Drawing.Point(16, 67);
            this.rdbsituacao.Name = "rdbsituacao";
            this.rdbsituacao.Size = new System.Drawing.Size(94, 23);
            this.rdbsituacao.TabIndex = 1;
            this.rdbsituacao.TabStop = true;
            this.rdbsituacao.Text = "Situação";
            this.rdbsituacao.UseVisualStyleBackColor = true;
            this.rdbsituacao.CheckedChanged += new System.EventHandler(this.rdbsituacao_CheckedChanged);
            // 
            // rdbdescricao
            // 
            this.rdbdescricao.AutoSize = true;
            this.rdbdescricao.Location = new System.Drawing.Point(16, 37);
            this.rdbdescricao.Name = "rdbdescricao";
            this.rdbdescricao.Size = new System.Drawing.Size(105, 23);
            this.rdbdescricao.TabIndex = 0;
            this.rdbdescricao.TabStop = true;
            this.rdbdescricao.Text = "Descrição";
            this.rdbdescricao.UseVisualStyleBackColor = true;
            this.rdbdescricao.CheckedChanged += new System.EventHandler(this.rdbdescricao_CheckedChanged);
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
            this.btnpesquisar.Location = new System.Drawing.Point(529, 101);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(117, 35);
            this.btnpesquisar.TabIndex = 1025;
            this.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 60F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // FrmMontadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dgvmontadora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMontadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de montadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMontadora_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmontadora)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvmontadora;
        private JTextBox2.JTextBox txtpesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbsituacao;
        private System.Windows.Forms.RadioButton rdbdescricao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}