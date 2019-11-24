namespace PIM3.Desktop
{
    partial class Frmpneu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpneu));
            this.txtpesquisar = new JTextBox2.JTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbveiculo = new System.Windows.Forms.RadioButton();
            this.rdbperfil = new System.Windows.Forms.RadioButton();
            this.dgvpneus = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbplaca = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaveiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpneus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtpesquisar.HintText = null;
            this.txtpesquisar.IsPassword = false;
            this.txtpesquisar.Location = new System.Drawing.Point(592, 52);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.txtpesquisar.MaxLength = 50;
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.OnFocusedColor = System.Drawing.Color.White;
            this.txtpesquisar.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtpesquisar.ReadOnly = false;
            this.txtpesquisar.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtpesquisar.Size = new System.Drawing.Size(245, 30);
            this.txtpesquisar.TabIndex = 1020;
            this.txtpesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpesquisar.TextName = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbplaca);
            this.groupBox2.Controls.Add(this.rdbveiculo);
            this.groupBox2.Controls.Add(this.rdbperfil);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(292, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 108);
            this.groupBox2.TabIndex = 1022;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de pesquisa";
            // 
            // rdbveiculo
            // 
            this.rdbveiculo.AutoSize = true;
            this.rdbveiculo.Location = new System.Drawing.Point(16, 67);
            this.rdbveiculo.Name = "rdbveiculo";
            this.rdbveiculo.Size = new System.Drawing.Size(84, 23);
            this.rdbveiculo.TabIndex = 1;
            this.rdbveiculo.TabStop = true;
            this.rdbveiculo.Text = "Veículo";
            this.rdbveiculo.UseVisualStyleBackColor = true;
            this.rdbveiculo.CheckedChanged += new System.EventHandler(this.rdbveiculo_CheckedChanged);
            // 
            // rdbperfil
            // 
            this.rdbperfil.AutoSize = true;
            this.rdbperfil.Location = new System.Drawing.Point(16, 37);
            this.rdbperfil.Name = "rdbperfil";
            this.rdbperfil.Size = new System.Drawing.Size(68, 23);
            this.rdbperfil.TabIndex = 0;
            this.rdbperfil.TabStop = true;
            this.rdbperfil.Text = "Perfil";
            this.rdbperfil.UseVisualStyleBackColor = true;
            this.rdbperfil.CheckedChanged += new System.EventHandler(this.rdbperfil_CheckedChanged);
            // 
            // dgvpneus
            // 
            this.dgvpneus.AllowUserToAddRows = false;
            this.dgvpneus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvpneus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpneus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpneus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpneus.BackgroundColor = System.Drawing.Color.White;
            this.dgvpneus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpneus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvpneus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpneus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvpneus.ColumnHeadersHeight = 50;
            this.dgvpneus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.perfil,
            this.datacompra,
            this.valor,
            this.veiculo,
            this.placaveiculo,
            this.km});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpneus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvpneus.DoubleBuffered = true;
            this.dgvpneus.EnableHeadersVisualStyles = false;
            this.dgvpneus.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvpneus.HeaderForeColor = System.Drawing.Color.White;
            this.dgvpneus.Location = new System.Drawing.Point(15, 139);
            this.dgvpneus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpneus.Name = "dgvpneus";
            this.dgvpneus.ReadOnly = true;
            this.dgvpneus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpneus.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvpneus.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvpneus.RowTemplate.DividerHeight = 1;
            this.dgvpneus.RowTemplate.Height = 40;
            this.dgvpneus.RowTemplate.ReadOnly = true;
            this.dgvpneus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpneus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpneus.Size = new System.Drawing.Size(868, 398);
            this.dgvpneus.TabIndex = 1019;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 108);
            this.groupBox1.TabIndex = 1018;
            this.groupBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 27);
            this.menuStrip1.TabIndex = 1023;
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
            // rdbplaca
            // 
            this.rdbplaca.AutoSize = true;
            this.rdbplaca.Location = new System.Drawing.Point(113, 35);
            this.rdbplaca.Name = "rdbplaca";
            this.rdbplaca.Size = new System.Drawing.Size(71, 23);
            this.rdbplaca.TabIndex = 2;
            this.rdbplaca.TabStop = true;
            this.rdbplaca.Text = "Placa";
            this.rdbplaca.UseVisualStyleBackColor = true;
            this.rdbplaca.CheckedChanged += new System.EventHandler(this.rdbplaca_CheckedChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 19.14069F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // perfil
            // 
            this.perfil.DataPropertyName = "perfil";
            this.perfil.FillWeight = 54.26398F;
            this.perfil.HeaderText = "Perfil";
            this.perfil.Name = "perfil";
            this.perfil.ReadOnly = true;
            // 
            // datacompra
            // 
            this.datacompra.DataPropertyName = "datacompra";
            this.datacompra.FillWeight = 53.01974F;
            this.datacompra.HeaderText = "Data compra";
            this.datacompra.Name = "datacompra";
            this.datacompra.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.FillWeight = 51.94605F;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // veiculo
            // 
            this.veiculo.DataPropertyName = "veiculo";
            this.veiculo.FillWeight = 63.71961F;
            this.veiculo.HeaderText = "Veículo";
            this.veiculo.Name = "veiculo";
            this.veiculo.ReadOnly = true;
            // 
            // placaveiculo
            // 
            this.placaveiculo.DataPropertyName = "placaveiculo";
            this.placaveiculo.FillWeight = 58.49346F;
            this.placaveiculo.HeaderText = "Placa veículo";
            this.placaveiculo.Name = "placaveiculo";
            this.placaveiculo.ReadOnly = true;
            // 
            // km
            // 
            this.km.DataPropertyName = "km";
            this.km.FillWeight = 30.41649F;
            this.km.HeaderText = "KM";
            this.km.Name = "km";
            this.km.ReadOnly = true;
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
            this.btnpesquisar.Location = new System.Drawing.Point(648, 92);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(117, 35);
            this.btnpesquisar.TabIndex = 1021;
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
            // Frmpneu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 547);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dgvpneus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmpneu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de pneu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmpneu_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpneus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JTextBox2.JTextBox txtpesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbveiculo;
        private System.Windows.Forms.RadioButton rdbperfil;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpesquisar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvpneus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rdbplaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaveiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
    }
}