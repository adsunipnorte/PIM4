namespace PIM3.Desktop
{
    partial class FrmCadCentroCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCentroCusto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblidcc = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.chksituacao = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvteste = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteste)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(133, 66);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(273, 27);
            this.txtdescricao.TabIndex = 1;
            this.txtdescricao.Tag = "";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbldescricao.Location = new System.Drawing.Point(32, 70);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 42;
            this.lbldescricao.Text = "Descrição";
            // 
            // lblidcc
            // 
            this.lblidcc.AutoSize = true;
            this.lblidcc.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblidcc.Location = new System.Drawing.Point(32, 21);
            this.lblidcc.Name = "lblidcc";
            this.lblidcc.Size = new System.Drawing.Size(26, 19);
            this.lblidcc.TabIndex = 41;
            this.lblidcc.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(68, 18);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 39;
            this.txtid.TabStop = false;
            // 
            // chksituacao
            // 
            this.chksituacao.AccessibleName = "";
            this.chksituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chksituacao.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chksituacao.Checked = true;
            this.chksituacao.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chksituacao.ForeColor = System.Drawing.Color.White;
            this.chksituacao.Location = new System.Drawing.Point(172, 25);
            this.chksituacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chksituacao.Name = "chksituacao";
            this.chksituacao.Size = new System.Drawing.Size(20, 20);
            this.chksituacao.TabIndex = 48;
            // 
            // btngravar
            // 
            this.btngravar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngravar.BorderRadius = 7;
            this.btngravar.ButtonText = "Gravar";
            this.btngravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngravar.DisabledColor = System.Drawing.Color.Gray;
            this.btngravar.Iconcolor = System.Drawing.Color.Transparent;
            this.btngravar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btngravar.Iconimage")));
            this.btngravar.Iconimage_right = null;
            this.btngravar.Iconimage_right_Selected = null;
            this.btngravar.Iconimage_Selected = null;
            this.btngravar.IconMarginLeft = 0;
            this.btngravar.IconMarginRight = 0;
            this.btngravar.IconRightVisible = true;
            this.btngravar.IconRightZoom = 0D;
            this.btngravar.IconVisible = true;
            this.btngravar.IconZoom = 90D;
            this.btngravar.IsTab = true;
            this.btngravar.Location = new System.Drawing.Point(133, 400);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(154, 70);
            this.btngravar.TabIndex = 2;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Textcolor = System.Drawing.Color.White;
            this.btngravar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Click += new System.EventHandler(this.btnsucesso_Click);
            // 
            // btnsair
            // 
            this.btnsair.Activecolor = System.Drawing.Color.Crimson;
            this.btnsair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsair.BackColor = System.Drawing.Color.Crimson;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.BorderRadius = 7;
            this.btnsair.ButtonText = "Sair";
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsair.DisabledColor = System.Drawing.Color.Gray;
            this.btnsair.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsair.Iconimage = null;
            this.btnsair.Iconimage_right = null;
            this.btnsair.Iconimage_right_Selected = null;
            this.btnsair.Iconimage_Selected = null;
            this.btnsair.IconMarginLeft = 0;
            this.btnsair.IconMarginRight = 10;
            this.btnsair.IconRightVisible = false;
            this.btnsair.IconRightZoom = 0D;
            this.btnsair.IconVisible = false;
            this.btnsair.IconZoom = 90D;
            this.btnsair.IsTab = true;
            this.btnsair.Location = new System.Drawing.Point(482, 399);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(154, 70);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsair.Textcolor = System.Drawing.Color.White;
            this.btnsair.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnsair.Click += new System.EventHandler(this.btnerro_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.BorderRadius = 7;
            this.btnlimpar.ButtonText = "Limpar";
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.DisabledColor = System.Drawing.Color.Gray;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlimpar.Iconimage = null;
            this.btnlimpar.Iconimage_right = null;
            this.btnlimpar.Iconimage_right_Selected = null;
            this.btnlimpar.Iconimage_Selected = null;
            this.btnlimpar.IconMarginLeft = 0;
            this.btnlimpar.IconMarginRight = 10;
            this.btnlimpar.IconRightVisible = false;
            this.btnlimpar.IconRightZoom = 0D;
            this.btnlimpar.IconVisible = false;
            this.btnlimpar.IconZoom = 90D;
            this.btnlimpar.IsTab = true;
            this.btnlimpar.Location = new System.Drawing.Point(308, 399);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(154, 70);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpar.Textcolor = System.Drawing.Color.White;
            this.btnlimpar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
            // 
            // dgvteste
            // 
            this.dgvteste.AllowUserToAddRows = false;
            this.dgvteste.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgvteste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvteste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvteste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvteste.BackgroundColor = System.Drawing.Color.White;
            this.dgvteste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvteste.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvteste.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvteste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvteste.ColumnHeadersHeight = 50;
            this.dgvteste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descricao,
            this.situacao});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvteste.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvteste.DoubleBuffered = true;
            this.dgvteste.EnableHeadersVisualStyles = false;
            this.dgvteste.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dgvteste.HeaderForeColor = System.Drawing.Color.White;
            this.dgvteste.Location = new System.Drawing.Point(12, 145);
            this.dgvteste.Margin = new System.Windows.Forms.Padding(4);
            this.dgvteste.Name = "dgvteste";
            this.dgvteste.ReadOnly = true;
            this.dgvteste.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvteste.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvteste.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvteste.RowTemplate.DividerHeight = 1;
            this.dgvteste.RowTemplate.Height = 40;
            this.dgvteste.RowTemplate.ReadOnly = true;
            this.dgvteste.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvteste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvteste.Size = new System.Drawing.Size(741, 217);
            this.dgvteste.TabIndex = 999;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Tile 1";
            this.bunifuTileButton1.Location = new System.Drawing.Point(518, 21);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(173, 78);
            this.bunifuTileButton1.TabIndex = 50;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dgvteste;
            // 
            // FrmCadCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.dgvteste);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.chksituacao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblidcc);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadCentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de custo";
            this.Load += new System.EventHandler(this.FrmCadCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblidcc;
        private System.Windows.Forms.TextBox txtid;
        private Bunifu.Framework.UI.BunifuCheckbox chksituacao;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvteste;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}