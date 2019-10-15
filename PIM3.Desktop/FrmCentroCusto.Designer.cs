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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbpesqcentrocusto = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblpesquisar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkpesquisar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvestados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestados)).BeginInit();
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
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.groupBox1.Controls.Add(this.cmbpesqcentrocusto);
            this.groupBox1.Controls.Add(this.lblpesquisar);
            this.groupBox1.Controls.Add(this.chkpesquisar);
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btncalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Red;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Magenta;
            this.bunifuMaterialTextbox1.HintText = "bbbbbbbbbbbb";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(494, 17);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(171, 33);
            this.bunifuMaterialTextbox1.TabIndex = 9;
            this.bunifuMaterialTextbox1.Text = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.bunifuMaterialTextbox1, "aaaaaaaaaaa");
            // 
            // cmbpesqcentrocusto
            // 
            this.cmbpesqcentrocusto.BackColor = System.Drawing.Color.Transparent;
            this.cmbpesqcentrocusto.BorderRadius = 3;
            this.cmbpesqcentrocusto.DisabledColor = System.Drawing.Color.Gray;
            this.cmbpesqcentrocusto.ForeColor = System.Drawing.Color.White;
            this.cmbpesqcentrocusto.Items = new string[0];
            this.cmbpesqcentrocusto.Location = new System.Drawing.Point(494, 64);
            this.cmbpesqcentrocusto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbpesqcentrocusto.Name = "cmbpesqcentrocusto";
            this.cmbpesqcentrocusto.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbpesqcentrocusto.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbpesqcentrocusto.selectedIndex = -1;
            this.cmbpesqcentrocusto.Size = new System.Drawing.Size(171, 29);
            this.cmbpesqcentrocusto.TabIndex = 8;
            this.cmbpesqcentrocusto.Visible = false;
            // 
            // lblpesquisar
            // 
            this.lblpesquisar.AutoSize = true;
            this.lblpesquisar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpesquisar.Location = new System.Drawing.Point(380, 44);
            this.lblpesquisar.Name = "lblpesquisar";
            this.lblpesquisar.Size = new System.Drawing.Size(91, 19);
            this.lblpesquisar.TabIndex = 7;
            this.lblpesquisar.Text = "Pesquisar";
            // 
            // chkpesquisar
            // 
            this.chkpesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkpesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkpesquisar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkpesquisar.Checked = false;
            this.chkpesquisar.CheckedOnColor = System.Drawing.Color.LimeGreen;
            this.chkpesquisar.ForeColor = System.Drawing.Color.White;
            this.chkpesquisar.Location = new System.Drawing.Point(353, 44);
            this.chkpesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkpesquisar.Name = "chkpesquisar";
            this.chkpesquisar.Size = new System.Drawing.Size(20, 20);
            this.chkpesquisar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.chkpesquisar, "jjjj");
            this.chkpesquisar.OnChange += new System.EventHandler(this.chkpesquisar_OnChange);
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(241, 17);
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
            this.btncalt.Location = new System.Drawing.Point(139, 19);
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
            this.btnnovo.Location = new System.Drawing.Point(34, 19);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(72, 76);
            this.btnnovo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnnovo, "Novo Centro de Custo");
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dgvestados
            // 
            this.dgvestados.AllowUserToAddRows = false;
            this.dgvestados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvestados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvestados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvestados.BackgroundColor = System.Drawing.Color.White;
            this.dgvestados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvestados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvestados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvestados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvestados.ColumnHeadersHeight = 50;
            this.dgvestados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvestados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvestados.DoubleBuffered = true;
            this.dgvestados.EnableHeadersVisualStyles = false;
            this.dgvestados.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvestados.HeaderForeColor = System.Drawing.Color.White;
            this.dgvestados.Location = new System.Drawing.Point(15, 160);
            this.dgvestados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvestados.Name = "dgvestados";
            this.dgvestados.ReadOnly = true;
            this.dgvestados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvestados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvestados.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvestados.RowTemplate.DividerHeight = 1;
            this.dgvestados.RowTemplate.Height = 40;
            this.dgvestados.RowTemplate.ReadOnly = true;
            this.dgvestados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvestados.Size = new System.Drawing.Size(754, 369);
            this.dgvestados.TabIndex = 1001;
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
            // FrmCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.dgvestados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCentroCusto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de centro de custo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestados)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvestados;
        private Bunifu.Framework.UI.BunifuCheckbox chkpesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.Framework.UI.BunifuDropdown cmbpesqcentrocusto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblpesquisar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}