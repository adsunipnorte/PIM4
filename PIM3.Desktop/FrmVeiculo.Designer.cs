namespace PIM3.Desktop
{
    partial class FrmVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtpesquisar = new JTextBox2.JTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtpveiculo = new System.Windows.Forms.RadioButton();
            this.rdbmontadora = new System.Windows.Forms.RadioButton();
            this.rdbmodelo = new System.Windows.Forms.RadioButton();
            this.rdbplaca = new System.Windows.Forms.RadioButton();
            this.btnpesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvveiculo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOVEICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvveiculo)).BeginInit();
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
            this.txtpesquisar.Location = new System.Drawing.Point(675, 49);
            this.txtpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.txtpesquisar.MaxLength = 50;
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.OnFocusedColor = System.Drawing.Color.White;
            this.txtpesquisar.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtpesquisar.ReadOnly = false;
            this.txtpesquisar.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtpesquisar.Size = new System.Drawing.Size(245, 30);
            this.txtpesquisar.TabIndex = 1013;
            this.txtpesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpesquisar.TextName = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtpveiculo);
            this.groupBox2.Controls.Add(this.rdbmontadora);
            this.groupBox2.Controls.Add(this.rdbmodelo);
            this.groupBox2.Controls.Add(this.rdbplaca);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(277, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 101);
            this.groupBox2.TabIndex = 1015;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de pesquisa";
            // 
            // rdbtpveiculo
            // 
            this.rdbtpveiculo.AutoSize = true;
            this.rdbtpveiculo.Location = new System.Drawing.Point(163, 57);
            this.rdbtpveiculo.Name = "rdbtpveiculo";
            this.rdbtpveiculo.Size = new System.Drawing.Size(116, 23);
            this.rdbtpveiculo.TabIndex = 4;
            this.rdbtpveiculo.TabStop = true;
            this.rdbtpveiculo.Text = "Tipo veículo";
            this.rdbtpveiculo.UseVisualStyleBackColor = true;
            this.rdbtpveiculo.CheckedChanged += new System.EventHandler(this.rdbtpveiculo_CheckedChanged);
            // 
            // rdbmontadora
            // 
            this.rdbmontadora.AutoSize = true;
            this.rdbmontadora.Location = new System.Drawing.Point(16, 57);
            this.rdbmontadora.Name = "rdbmontadora";
            this.rdbmontadora.Size = new System.Drawing.Size(107, 23);
            this.rdbmontadora.TabIndex = 3;
            this.rdbmontadora.TabStop = true;
            this.rdbmontadora.Text = "Montadora";
            this.rdbmontadora.UseVisualStyleBackColor = true;
            this.rdbmontadora.CheckedChanged += new System.EventHandler(this.rdbmontadora_CheckedChanged);
            // 
            // rdbmodelo
            // 
            this.rdbmodelo.AutoSize = true;
            this.rdbmodelo.Location = new System.Drawing.Point(163, 22);
            this.rdbmodelo.Name = "rdbmodelo";
            this.rdbmodelo.Size = new System.Drawing.Size(82, 23);
            this.rdbmodelo.TabIndex = 2;
            this.rdbmodelo.TabStop = true;
            this.rdbmodelo.Text = "Modelo";
            this.rdbmodelo.UseVisualStyleBackColor = true;
            this.rdbmodelo.CheckedChanged += new System.EventHandler(this.rdbmodelo_CheckedChanged);
            // 
            // rdbplaca
            // 
            this.rdbplaca.AutoSize = true;
            this.rdbplaca.Location = new System.Drawing.Point(16, 26);
            this.rdbplaca.Name = "rdbplaca";
            this.rdbplaca.Size = new System.Drawing.Size(71, 23);
            this.rdbplaca.TabIndex = 0;
            this.rdbplaca.TabStop = true;
            this.rdbplaca.Text = "Placa";
            this.rdbplaca.UseVisualStyleBackColor = true;
            this.rdbplaca.CheckedChanged += new System.EventHandler(this.rdbplaca_CheckedChanged);
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
            this.btnpesquisar.Location = new System.Drawing.Point(736, 91);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(117, 35);
            this.btnpesquisar.TabIndex = 1014;
            this.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dgvveiculo
            // 
            this.dgvveiculo.AllowUserToAddRows = false;
            this.dgvveiculo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvveiculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvveiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvveiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvveiculo.BackgroundColor = System.Drawing.Color.White;
            this.dgvveiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvveiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvveiculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvveiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvveiculo.ColumnHeadersHeight = 50;
            this.dgvveiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.montadora,
            this.modelo,
            this.TIPOVEICULO});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvveiculo.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvveiculo.DoubleBuffered = true;
            this.dgvveiculo.EnableHeadersVisualStyles = false;
            this.dgvveiculo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvveiculo.HeaderForeColor = System.Drawing.Color.White;
            this.dgvveiculo.Location = new System.Drawing.Point(13, 145);
            this.dgvveiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvveiculo.Name = "dgvveiculo";
            this.dgvveiculo.ReadOnly = true;
            this.dgvveiculo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvveiculo.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvveiculo.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvveiculo.RowTemplate.DividerHeight = 1;
            this.dgvveiculo.RowTemplate.Height = 40;
            this.dgvveiculo.RowTemplate.ReadOnly = true;
            this.dgvveiculo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvveiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvveiculo.Size = new System.Drawing.Size(969, 369);
            this.dgvveiculo.TabIndex = 1012;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btnalt);
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 108);
            this.groupBox1.TabIndex = 1011;
            this.groupBox1.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Location = new System.Drawing.Point(170, 23);
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
            this.btnalt.Location = new System.Drawing.Point(87, 23);
            this.btnalt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(72, 76);
            this.btnalt.TabIndex = 4;
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnovo.BackgroundImage")));
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(9, 23);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(72, 76);
            this.btnnovo.TabIndex = 3;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 27);
            this.menuStrip1.TabIndex = 1016;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.sairToolStripMenuItem.Text = "&Sair";
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            // 
            // montadora
            // 
            this.montadora.DataPropertyName = "montadora";
            this.montadora.HeaderText = "Montadora";
            this.montadora.Name = "montadora";
            this.montadora.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // TIPOVEICULO
            // 
            this.TIPOVEICULO.DataPropertyName = "tipoveiculo";
            this.TIPOVEICULO.HeaderText = "Tipo veículo";
            this.TIPOVEICULO.Name = "TIPOVEICULO";
            this.TIPOVEICULO.ReadOnly = true;
            // 
            // FrmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 480);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dgvveiculo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVeiculo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Veículo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvveiculo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JTextBox2.JTextBox txtpesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbplaca;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpesquisar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvveiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbtpveiculo;
        private System.Windows.Forms.RadioButton rdbmontadora;
        private System.Windows.Forms.RadioButton rdbmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn montadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOVEICULO;
    }
}