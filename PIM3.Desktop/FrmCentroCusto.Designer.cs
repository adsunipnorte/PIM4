namespace PIM3.Desktop
{
    partial class FrmCentroCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCentroCusto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnpesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvcentrocusto = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdescricao = new System.Windows.Forms.RadioButton();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.txtpesquisar = new JTextBox2.JTextBox();
            this.msktxtpesquisa = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcentrocusto)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(782, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.sairToolStripMenuItem1});
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
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
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
            this.groupBox1.Controls.Add(this.btncalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(224, 17);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(72, 76);
            this.btnsair.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnsair, "Sair");
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncalt
            // 
            this.btncalt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncalt.BackgroundImage")));
            this.btncalt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncalt.Location = new System.Drawing.Point(122, 19);
            this.btncalt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncalt.Name = "btncalt";
            this.btncalt.Size = new System.Drawing.Size(72, 76);
            this.btncalt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btncalt, "Alterar Centro de Custo");
            this.btncalt.UseVisualStyleBackColor = true;
            this.btncalt.Click += new System.EventHandler(this.btncalt_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnovo.BackgroundImage")));
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(17, 19);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(72, 76);
            this.btnnovo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnnovo, "Novo Centro de Custo");
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.ActiveBorderThickness = 1;
            this.btnpesquisar.ActiveCornerRadius = 20;
            this.btnpesquisar.ActiveFillColor = System.Drawing.Color.SeaGreen;
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
            this.btnpesquisar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnpesquisar.IdleLineColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(598, 109);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(117, 35);
            this.btnpesquisar.TabIndex = 10;
            this.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dgvcentrocusto
            // 
            this.dgvcentrocusto.AllowUserToAddRows = false;
            this.dgvcentrocusto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvcentrocusto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvcentrocusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcentrocusto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcentrocusto.BackgroundColor = System.Drawing.Color.White;
            this.dgvcentrocusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcentrocusto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcentrocusto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcentrocusto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvcentrocusto.ColumnHeadersHeight = 50;
            this.dgvcentrocusto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcentrocusto.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvcentrocusto.DoubleBuffered = true;
            this.dgvcentrocusto.EnableHeadersVisualStyles = false;
            this.dgvcentrocusto.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvcentrocusto.HeaderForeColor = System.Drawing.Color.White;
            this.dgvcentrocusto.Location = new System.Drawing.Point(15, 160);
            this.dgvcentrocusto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvcentrocusto.Name = "dgvcentrocusto";
            this.dgvcentrocusto.ReadOnly = true;
            this.dgvcentrocusto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcentrocusto.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcentrocusto.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvcentrocusto.RowTemplate.DividerHeight = 1;
            this.dgvcentrocusto.RowTemplate.Height = 40;
            this.dgvcentrocusto.RowTemplate.ReadOnly = true;
            this.dgvcentrocusto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcentrocusto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcentrocusto.Size = new System.Drawing.Size(754, 369);
            this.dgvcentrocusto.TabIndex = 1001;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "situacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdescricao);
            this.groupBox2.Controls.Add(this.rdbid);
            this.groupBox2.Location = new System.Drawing.Point(350, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 100);
            this.groupBox2.TabIndex = 1002;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de pesquisa";
            // 
            // rdbdescricao
            // 
            this.rdbdescricao.AutoSize = true;
            this.rdbdescricao.Location = new System.Drawing.Point(16, 56);
            this.rdbdescricao.Name = "rdbdescricao";
            this.rdbdescricao.Size = new System.Drawing.Size(105, 23);
            this.rdbdescricao.TabIndex = 1;
            this.rdbdescricao.TabStop = true;
            this.rdbdescricao.Text = "Descrição";
            this.rdbdescricao.UseVisualStyleBackColor = true;
            this.rdbdescricao.CheckedChanged += new System.EventHandler(this.rdbdescricao_CheckedChanged);
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(16, 26);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(47, 23);
            this.rdbid.TabIndex = 0;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "ID";
            this.rdbid.UseVisualStyleBackColor = true;
            this.rdbid.CheckedChanged += new System.EventHandler(this.rdbid_CheckedChanged);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.HintText = null;
            this.txtpesquisar.IsPassword = false;
            this.txtpesquisar.Location = new System.Drawing.Point(546, 59);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.txtpesquisar.MaxLength = 32767;
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.OnFocusedColor = System.Drawing.Color.White;
            this.txtpesquisar.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtpesquisar.ReadOnly = false;
            this.txtpesquisar.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtpesquisar.Size = new System.Drawing.Size(213, 30);
            this.txtpesquisar.TabIndex = 1;
            this.txtpesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpesquisar.TextName = "";
            this.txtpesquisar.Load += new System.EventHandler(this.txtpesquisar_Load);
            // 
            // msktxtpesquisa
            // 
            this.msktxtpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktxtpesquisa.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.msktxtpesquisa.ForeColor = System.Drawing.Color.Gray;
            this.msktxtpesquisa.Location = new System.Drawing.Point(546, 59);
            this.msktxtpesquisa.Margin = new System.Windows.Forms.Padding(5);
            this.msktxtpesquisa.Name = "msktxtpesquisa";
            this.msktxtpesquisa.Size = new System.Drawing.Size(213, 30);
            this.msktxtpesquisa.TabIndex = 1003;
            this.msktxtpesquisa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.msktxtpesquisa.Visible = false;
            this.msktxtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // FrmCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.msktxtpesquisa);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvcentrocusto);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCentroCusto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de centro de custo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCentroCusto_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcentrocusto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvcentrocusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbdescricao;
        private System.Windows.Forms.RadioButton rdbid;
        private JTextBox2.JTextBox txtpesquisar;
        private System.Windows.Forms.MaskedTextBox msktxtpesquisa;
    }
}