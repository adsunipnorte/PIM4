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
            this.lblid = new System.Windows.Forms.Label();
            this.lblkmi = new System.Windows.Forms.Label();
            this.lbldatalocacao = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblveiculo = new System.Windows.Forms.Label();
            this.txtkmi = new System.Windows.Forms.TextBox();
            this.lblcel = new System.Windows.Forms.Label();
            this.lblvdiaria = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblcnh = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblseguro = new System.Windows.Forms.Label();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.cmbveiculo = new System.Windows.Forms.ComboBox();
            this.cmbseguro = new System.Windows.Forms.ComboBox();
            this.mstdatalocacao = new System.Windows.Forms.MaskedTextBox();
            this.mstdatadevolucao = new System.Windows.Forms.MaskedTextBox();
            this.txtdiaria = new System.Windows.Forms.TextBox();
            this.lbldatadevolucao = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // lblkmi
            // 
            this.lblkmi.AutoSize = true;
            this.lblkmi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkmi.Location = new System.Drawing.Point(31, 186);
            this.lblkmi.Name = "lblkmi";
            this.lblkmi.Size = new System.Drawing.Size(33, 19);
            this.lblkmi.TabIndex = 117;
            this.lblkmi.Text = "KM";
            // 
            // lbldatalocacao
            // 
            this.lbldatalocacao.AutoSize = true;
            this.lbldatalocacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatalocacao.Location = new System.Drawing.Point(27, 128);
            this.lbldatalocacao.Name = "lbldatalocacao";
            this.lbldatalocacao.Size = new System.Drawing.Size(111, 19);
            this.lbldatalocacao.TabIndex = 116;
            this.lbldatalocacao.Text = "Data Locação";
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
            // lblveiculo
            // 
            this.lblveiculo.AutoSize = true;
            this.lblveiculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblveiculo.Location = new System.Drawing.Point(27, 62);
            this.lblveiculo.Name = "lblveiculo";
            this.lblveiculo.Size = new System.Drawing.Size(63, 19);
            this.lblveiculo.TabIndex = 1;
            this.lblveiculo.Text = "Veículo";
            // 
            // txtkmi
            // 
            this.txtkmi.Location = new System.Drawing.Point(183, 182);
            this.txtkmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkmi.Name = "txtkmi";
            this.txtkmi.Size = new System.Drawing.Size(143, 27);
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
            // lblvdiaria
            // 
            this.lblvdiaria.AutoSize = true;
            this.lblvdiaria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvdiaria.Location = new System.Drawing.Point(27, 95);
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
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(31, 25);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(59, 19);
            this.lblcliente.TabIndex = 127;
            this.lblcliente.Text = "Cliente";
            // 
            // lblseguro
            // 
            this.lblseguro.AutoSize = true;
            this.lblseguro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseguro.Location = new System.Drawing.Point(31, 221);
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
            this.btnlimpar.Location = new System.Drawing.Point(206, 270);
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
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
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
            this.btnsair.Location = new System.Drawing.Point(380, 270);
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
            this.btngravar.Location = new System.Drawing.Point(31, 270);
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
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 28);
            this.label2.TabIndex = 130;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(89, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 28);
            this.label3.TabIndex = 131;
            this.label3.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(118, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 28);
            this.label7.TabIndex = 135;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(148, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 28);
            this.label8.TabIndex = 136;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(105, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 28);
            this.label9.TabIndex = 137;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(89, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 28);
            this.label10.TabIndex = 138;
            this.label10.Text = "*";
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(183, 17);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(249, 27);
            this.cmbcliente.TabIndex = 139;
            this.cmbcliente.Click += new System.EventHandler(this.cmbcliente_Click);
            // 
            // cmbveiculo
            // 
            this.cmbveiculo.FormattingEnabled = true;
            this.cmbveiculo.Location = new System.Drawing.Point(183, 50);
            this.cmbveiculo.Name = "cmbveiculo";
            this.cmbveiculo.Size = new System.Drawing.Size(249, 27);
            this.cmbveiculo.TabIndex = 140;
            this.cmbveiculo.Click += new System.EventHandler(this.cmbveiculo_Click);
            // 
            // cmbseguro
            // 
            this.cmbseguro.FormattingEnabled = true;
            this.cmbseguro.Location = new System.Drawing.Point(183, 215);
            this.cmbseguro.Name = "cmbseguro";
            this.cmbseguro.Size = new System.Drawing.Size(249, 27);
            this.cmbseguro.TabIndex = 141;
            this.cmbseguro.Click += new System.EventHandler(this.cmbseguro_Click);
            // 
            // mstdatalocacao
            // 
            this.mstdatalocacao.Location = new System.Drawing.Point(183, 116);
            this.mstdatalocacao.Mask = "00/00/0000 00:00";
            this.mstdatalocacao.Name = "mstdatalocacao";
            this.mstdatalocacao.Size = new System.Drawing.Size(143, 27);
            this.mstdatalocacao.TabIndex = 142;
            this.mstdatalocacao.ValidatingType = typeof(System.DateTime);
            // 
            // mstdatadevolucao
            // 
            this.mstdatadevolucao.Location = new System.Drawing.Point(183, 149);
            this.mstdatadevolucao.Mask = "00/00/0000 00:00";
            this.mstdatadevolucao.Name = "mstdatadevolucao";
            this.mstdatadevolucao.Size = new System.Drawing.Size(143, 27);
            this.mstdatadevolucao.TabIndex = 143;
            this.mstdatadevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // txtdiaria
            // 
            this.txtdiaria.Location = new System.Drawing.Point(183, 83);
            this.txtdiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiaria.Name = "txtdiaria";
            this.txtdiaria.Size = new System.Drawing.Size(143, 27);
            this.txtdiaria.TabIndex = 149;
            // 
            // lbldatadevolucao
            // 
            this.lbldatadevolucao.AutoSize = true;
            this.lbldatadevolucao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatadevolucao.Location = new System.Drawing.Point(27, 157);
            this.lbldatadevolucao.Name = "lbldatadevolucao";
            this.lbldatadevolucao.Size = new System.Drawing.Size(124, 19);
            this.lbldatadevolucao.TabIndex = 151;
            this.lbldatadevolucao.Text = "Data Devolução";
            // 
            // FrmCadLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 370);
            this.Controls.Add(this.lbldatadevolucao);
            this.Controls.Add(this.txtdiaria);
            this.Controls.Add(this.mstdatadevolucao);
            this.Controls.Add(this.mstdatalocacao);
            this.Controls.Add(this.cmbseguro);
            this.Controls.Add(this.cmbveiculo);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.lblseguro);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblkmi);
            this.Controls.Add(this.lbldatalocacao);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblveiculo);
            this.Controls.Add(this.txtkmi);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.lblvdiaria);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblcnh);
            this.Controls.Add(this.lblnome);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblkmi;
        private System.Windows.Forms.Label lbldatalocacao;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblveiculo;
        private System.Windows.Forms.TextBox txtkmi;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.Label lblvdiaria;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblcnh;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblseguro;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.ComboBox cmbveiculo;
        private System.Windows.Forms.ComboBox cmbseguro;
        private System.Windows.Forms.MaskedTextBox mstdatalocacao;
        private System.Windows.Forms.MaskedTextBox mstdatadevolucao;
        private System.Windows.Forms.TextBox txtdiaria;
        private System.Windows.Forms.Label lbldatadevolucao;
    }
}