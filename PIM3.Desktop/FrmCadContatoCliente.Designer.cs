namespace PIM3.Desktop
{
    partial class FrmCadContatoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadContatoCliente));
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.TextBox();
            this.lblend = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtcompl = new System.Windows.Forms.TextBox();
            this.lblcompl = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.lblcel = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.dgvccusto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbidcliente = new System.Windows.Forms.ComboBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvccusto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblid.Location = new System.Drawing.Point(33, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 88;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(78, 27);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 87;
            this.txtid.TabStop = false;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnome.Location = new System.Drawing.Point(119, 69);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(637, 27);
            this.txtnome.TabIndex = 89;
            this.txtnome.Tag = "";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblnome.Location = new System.Drawing.Point(33, 77);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 19);
            this.lblnome.TabIndex = 90;
            this.lblnome.Text = "Nome";
            // 
            // txtend
            // 
            this.txtend.Location = new System.Drawing.Point(119, 108);
            this.txtend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(531, 27);
            this.txtend.TabIndex = 91;
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblend.Location = new System.Drawing.Point(33, 116);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(80, 19);
            this.lblend.TabIndex = 92;
            this.lblend.Text = "Endereço";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(119, 144);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(90, 27);
            this.txtnumero.TabIndex = 93;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblnumero.Location = new System.Drawing.Point(33, 152);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(66, 19);
            this.lblnumero.TabIndex = 94;
            this.lblnumero.Text = "Número";
            // 
            // txtcompl
            // 
            this.txtcompl.Location = new System.Drawing.Point(353, 144);
            this.txtcompl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcompl.Name = "txtcompl";
            this.txtcompl.Size = new System.Drawing.Size(181, 27);
            this.txtcompl.TabIndex = 95;
            // 
            // lblcompl
            // 
            this.lblcompl.AutoSize = true;
            this.lblcompl.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblcompl.Location = new System.Drawing.Point(228, 152);
            this.lblcompl.Name = "lblcompl";
            this.lblcompl.Size = new System.Drawing.Size(108, 19);
            this.lblcompl.TabIndex = 96;
            this.lblcompl.Text = "Complemento";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(119, 178);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(238, 27);
            this.txtbairro.TabIndex = 97;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblbairro.Location = new System.Drawing.Point(33, 184);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(54, 19);
            this.lblbairro.TabIndex = 98;
            this.lblbairro.Text = "Bairro";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(427, 178);
            this.txtcep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(151, 27);
            this.txtcep.TabIndex = 99;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblcep.Location = new System.Drawing.Point(378, 184);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(43, 19);
            this.lblcep.TabIndex = 100;
            this.lblcep.Text = "CEP";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(119, 213);
            this.txttel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(151, 27);
            this.txttel.TabIndex = 101;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbltel.Location = new System.Drawing.Point(33, 221);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(69, 19);
            this.lbltel.TabIndex = 102;
            this.lbltel.Text = "Telefone";
            // 
            // txtcel
            // 
            this.txtcel.Location = new System.Drawing.Point(353, 218);
            this.txtcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(151, 27);
            this.txtcel.TabIndex = 103;
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblcel.Location = new System.Drawing.Point(286, 221);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(60, 19);
            this.lblcel.TabIndex = 104;
            this.lblcel.Text = "Celular";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(119, 249);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(385, 27);
            this.txtemail.TabIndex = 105;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblemail.Location = new System.Drawing.Point(33, 254);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(55, 19);
            this.lblemail.TabIndex = 106;
            this.lblemail.Text = "E-mail";
            // 
            // dgvccusto
            // 
            this.dgvccusto.AllowUserToAddRows = false;
            this.dgvccusto.AllowUserToDeleteRows = false;
            this.dgvccusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvccusto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.IdClientes});
            this.dgvccusto.Location = new System.Drawing.Point(37, 282);
            this.dgvccusto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvccusto.Name = "dgvccusto";
            this.dgvccusto.RowTemplate.Height = 24;
            this.dgvccusto.Size = new System.Drawing.Size(803, 178);
            this.dgvccusto.TabIndex = 110;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 350;
            // 
            // IdClientes
            // 
            this.IdClientes.HeaderText = "Cliente";
            this.IdClientes.Name = "IdClientes";
            this.IdClientes.ReadOnly = true;
            this.IdClientes.Width = 308;
            // 
            // cmbidcliente
            // 
            this.cmbidcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidcliente.FormattingEnabled = true;
            this.cmbidcliente.Location = new System.Drawing.Point(313, 27);
            this.cmbidcliente.Name = "cmbidcliente";
            this.cmbidcliente.Size = new System.Drawing.Size(121, 27);
            this.cmbidcliente.TabIndex = 111;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblcliente.Location = new System.Drawing.Point(248, 30);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(59, 19);
            this.lblcliente.TabIndex = 112;
            this.lblcliente.Text = "Cliente";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpar.BorderRadius = 7;
            this.btnlimpar.ButtonText = "Limpar";
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.DisabledColor = System.Drawing.Color.Gray;
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlimpar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnlimpar.Iconimage")));
            this.btnlimpar.Iconimage_right = null;
            this.btnlimpar.Iconimage_right_Selected = null;
            this.btnlimpar.Iconimage_Selected = null;
            this.btnlimpar.IconMarginLeft = 0;
            this.btnlimpar.IconMarginRight = 0;
            this.btnlimpar.IconRightVisible = false;
            this.btnlimpar.IconRightZoom = 0D;
            this.btnlimpar.IconVisible = false;
            this.btnlimpar.IconZoom = 90D;
            this.btnlimpar.IsTab = false;
            this.btnlimpar.Location = new System.Drawing.Point(340, 483);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(154, 70);
            this.btnlimpar.TabIndex = 115;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpar.Textcolor = System.Drawing.Color.White;
            this.btnlimpar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            // 
            // btnsair
            // 
            this.btnsair.Activecolor = System.Drawing.Color.Crimson;
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
            this.btnsair.IconMarginRight = 0;
            this.btnsair.IconRightVisible = false;
            this.btnsair.IconRightZoom = 0D;
            this.btnsair.IconVisible = false;
            this.btnsair.IconZoom = 90D;
            this.btnsair.IsTab = false;
            this.btnsair.Location = new System.Drawing.Point(536, 482);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(154, 70);
            this.btnsair.TabIndex = 114;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsair.Textcolor = System.Drawing.Color.White;
            this.btnsair.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnsair.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btngravar
            // 
            this.btngravar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.btngravar.IsTab = false;
            this.btngravar.Location = new System.Drawing.Point(144, 483);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(154, 70);
            this.btngravar.TabIndex = 113;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Textcolor = System.Drawing.Color.White;
            this.btngravar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmCadContatoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.cmbidcliente);
            this.Controls.Add(this.dgvccusto);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.txtcompl);
            this.Controls.Add(this.lblcompl);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCadContatoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contato cliente";
            this.Load += new System.EventHandler(this.FrmContatoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvccusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtcompl;
        private System.Windows.Forms.Label lblcompl;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.DataGridView dgvccusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClientes;
        private System.Windows.Forms.ComboBox cmbidcliente;
        private System.Windows.Forms.Label lblcliente;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
    }
}