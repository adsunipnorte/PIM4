namespace PIM3.Desktop
{
    partial class FrmCadLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadLocacao));
            this.mskdtdevol = new System.Windows.Forms.MaskedTextBox();
            this.mskdtloc = new System.Windows.Forms.MaskedTextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblkmf = new System.Windows.Forms.Label();
            this.lblkmi = new System.Windows.Forms.Label();
            this.lbldias = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lbldtdev = new System.Windows.Forms.Label();
            this.txtdiaria = new System.Windows.Forms.TextBox();
            this.lblplaca = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lblveiculo = new System.Windows.Forms.Label();
            this.txtkmi = new System.Windows.Forms.TextBox();
            this.lblcel = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.lbldtini = new System.Windows.Forms.Label();
            this.lblvdiaria = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtkmf = new System.Windows.Forms.TextBox();
            this.lblcnh = new System.Windows.Forms.Label();
            this.txtveiculo = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblseguro = new System.Windows.Forms.Label();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // mskdtdevol
            // 
            this.mskdtdevol.Location = new System.Drawing.Point(189, 223);
            this.mskdtdevol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskdtdevol.Mask = "00/00/0000 90:00";
            this.mskdtdevol.Name = "mskdtdevol";
            this.mskdtdevol.Size = new System.Drawing.Size(124, 27);
            this.mskdtdevol.TabIndex = 5;
            this.mskdtdevol.ValidatingType = typeof(System.DateTime);
            // 
            // mskdtloc
            // 
            this.mskdtloc.Location = new System.Drawing.Point(189, 186);
            this.mskdtloc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskdtloc.Mask = "00/00/0000 90:00";
            this.mskdtloc.Name = "mskdtloc";
            this.mskdtloc.Size = new System.Drawing.Size(124, 27);
            this.mskdtloc.TabIndex = 4;
            this.mskdtloc.ValidatingType = typeof(System.DateTime);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(-65, 108);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 122;
            this.lblid.Text = "ID";
            // 
            // lblkmf
            // 
            this.lblkmf.AutoSize = true;
            this.lblkmf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkmf.Location = new System.Drawing.Point(33, 366);
            this.lblkmf.Name = "lblkmf";
            this.lblkmf.Size = new System.Drawing.Size(73, 19);
            this.lblkmf.TabIndex = 118;
            this.lblkmf.Text = "KM Final";
            // 
            // lblkmi
            // 
            this.lblkmi.AutoSize = true;
            this.lblkmi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkmi.Location = new System.Drawing.Point(33, 328);
            this.lblkmi.Name = "lblkmi";
            this.lblkmi.Size = new System.Drawing.Size(81, 19);
            this.lblkmi.TabIndex = 117;
            this.lblkmi.Text = "KM Inicial";
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldias.Location = new System.Drawing.Point(37, 294);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(72, 19);
            this.lbldias.TabIndex = 116;
            this.lbldias.Text = "Qtd Dias";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbairro.Location = new System.Drawing.Point(-65, 232);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(54, 19);
            this.lblbairro.TabIndex = 115;
            this.lblbairro.Text = "Bairro";
            // 
            // lbldtdev
            // 
            this.lbldtdev.AutoSize = true;
            this.lbldtdev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtdev.Location = new System.Drawing.Point(33, 227);
            this.lbldtdev.Name = "lbldtdev";
            this.lbldtdev.Size = new System.Drawing.Size(124, 19);
            this.lbldtdev.TabIndex = 114;
            this.lbldtdev.Text = "Data Devolução";
            // 
            // txtdiaria
            // 
            this.txtdiaria.Location = new System.Drawing.Point(189, 261);
            this.txtdiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiaria.Name = "txtdiaria";
            this.txtdiaria.Size = new System.Drawing.Size(124, 27);
            this.txtdiaria.TabIndex = 6;
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.Location = new System.Drawing.Point(33, 151);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(50, 19);
            this.lblplaca.TabIndex = 113;
            this.lblplaca.Text = "Placa";
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(123, 148);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(191, 27);
            this.txtplaca.TabIndex = 3;
            // 
            // lblveiculo
            // 
            this.lblveiculo.AutoSize = true;
            this.lblveiculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblveiculo.Location = new System.Drawing.Point(33, 115);
            this.lblveiculo.Name = "lblveiculo";
            this.lblveiculo.Size = new System.Drawing.Size(63, 19);
            this.lblveiculo.TabIndex = 1;
            this.lblveiculo.Text = "Veículo";
            // 
            // txtkmi
            // 
            this.txtkmi.Location = new System.Drawing.Point(189, 328);
            this.txtkmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkmi.Name = "txtkmi";
            this.txtkmi.Size = new System.Drawing.Size(124, 27);
            this.txtkmi.TabIndex = 8;
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcel.Location = new System.Drawing.Point(-65, 366);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(60, 19);
            this.lblcel.TabIndex = 111;
            this.lblcel.Text = "Celular";
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(189, 294);
            this.txtdias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(124, 27);
            this.txtdias.TabIndex = 7;
            // 
            // lbldtini
            // 
            this.lbldtini.AutoSize = true;
            this.lbldtini.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtini.Location = new System.Drawing.Point(32, 185);
            this.lbldtini.Name = "lbldtini";
            this.lbldtini.Size = new System.Drawing.Size(111, 19);
            this.lbldtini.TabIndex = 109;
            this.lbldtini.Text = "Data Locação";
            // 
            // lblvdiaria
            // 
            this.lblvdiaria.AutoSize = true;
            this.lblvdiaria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvdiaria.Location = new System.Drawing.Point(33, 261);
            this.lblvdiaria.Name = "lblvdiaria";
            this.lblvdiaria.Size = new System.Drawing.Size(95, 19);
            this.lblvdiaria.TabIndex = 108;
            this.lblvdiaria.Text = "Valor Diária";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(-65, 265);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(42, 19);
            this.lblcpf.TabIndex = 107;
            this.lblcpf.Text = "CPF";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(84, 36);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 105;
            this.txtid.TabStop = false;
            // 
            // txtkmf
            // 
            this.txtkmf.Location = new System.Drawing.Point(189, 366);
            this.txtkmf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkmf.Name = "txtkmf";
            this.txtkmf.Size = new System.Drawing.Size(124, 27);
            this.txtkmf.TabIndex = 9;
            // 
            // lblcnh
            // 
            this.lblcnh.AutoSize = true;
            this.lblcnh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnh.Location = new System.Drawing.Point(-65, 404);
            this.lblcnh.Name = "lblcnh";
            this.lblcnh.Size = new System.Drawing.Size(43, 19);
            this.lblcnh.TabIndex = 106;
            this.lblcnh.Text = "CNH";
            // 
            // txtveiculo
            // 
            this.txtveiculo.Location = new System.Drawing.Point(123, 112);
            this.txtveiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtveiculo.Name = "txtveiculo";
            this.txtveiculo.Size = new System.Drawing.Size(535, 27);
            this.txtveiculo.TabIndex = 2;
            this.txtveiculo.Tag = "";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(-65, 154);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 19);
            this.lblnome.TabIndex = 104;
            this.lblnome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 123;
            this.label1.Text = "ID";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(37, 78);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(59, 19);
            this.lblcliente.TabIndex = 127;
            this.lblcliente.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(120, 75);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(537, 27);
            this.txtcliente.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 403);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 27);
            this.textBox1.TabIndex = 10;
            // 
            // lblseguro
            // 
            this.lblseguro.AutoSize = true;
            this.lblseguro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseguro.Location = new System.Drawing.Point(37, 403);
            this.lblseguro.Name = "lblseguro";
            this.lblseguro.Size = new System.Drawing.Size(62, 19);
            this.lblseguro.TabIndex = 129;
            this.lblseguro.Text = "Seguro";
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
            this.btnlimpar.Iconimage = null;
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
            this.btnlimpar.Location = new System.Drawing.Point(264, 498);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(154, 70);
            this.btnlimpar.TabIndex = 12;
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
            this.btnsair.Location = new System.Drawing.Point(438, 498);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(154, 70);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsair.Textcolor = System.Drawing.Color.White;
            this.btnsair.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
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
            this.btngravar.Location = new System.Drawing.Point(89, 498);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(154, 70);
            this.btngravar.TabIndex = 11;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Textcolor = System.Drawing.Color.White;
            this.btngravar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmCadLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblseguro);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskdtdevol);
            this.Controls.Add(this.mskdtloc);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblkmf);
            this.Controls.Add(this.lblkmi);
            this.Controls.Add(this.lbldias);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lbldtdev);
            this.Controls.Add(this.txtdiaria);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.lblveiculo);
            this.Controls.Add(this.txtkmi);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.lbldtini);
            this.Controls.Add(this.lblvdiaria);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtkmf);
            this.Controls.Add(this.lblcnh);
            this.Controls.Add(this.txtveiculo);
            this.Controls.Add(this.lblnome);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCadLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de locação";
            this.Load += new System.EventHandler(this.FrmCadLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdtdevol;
        private System.Windows.Forms.MaskedTextBox mskdtloc;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblkmf;
        private System.Windows.Forms.Label lblkmi;
        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lbldtdev;
        private System.Windows.Forms.TextBox txtdiaria;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lblveiculo;
        private System.Windows.Forms.TextBox txtkmi;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label lbldtini;
        private System.Windows.Forms.Label lblvdiaria;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtkmf;
        private System.Windows.Forms.Label lblcnh;
        private System.Windows.Forms.TextBox txtveiculo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblseguro;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
    }
}