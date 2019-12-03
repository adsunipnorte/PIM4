namespace PIM3.Desktop
{
    partial class FrmCadFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFinanceiro));
            this.txtvalororiginal = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblvalorig = new System.Windows.Forms.Label();
            this.lblvencimento = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.txtjuros = new System.Windows.Forms.TextBox();
            this.lbljuros = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblplancontas = new System.Windows.Forms.Label();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.cmbplanoconta = new System.Windows.Forms.ComboBox();
            this.cmbcentrocusto = new System.Windows.Forms.ComboBox();
            this.dtpvencimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalorpago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtvalororiginal
            // 
            this.txtvalororiginal.Location = new System.Drawing.Point(178, 151);
            this.txtvalororiginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvalororiginal.Name = "txtvalororiginal";
            this.txtvalororiginal.Size = new System.Drawing.Size(126, 27);
            this.txtvalororiginal.TabIndex = 68;
            this.txtvalororiginal.Tag = "";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(15, 119);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 69;
            this.lbldescricao.Text = "Descrição";
            // 
            // lblvalorig
            // 
            this.lblvalorig.AutoSize = true;
            this.lblvalorig.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorig.Location = new System.Drawing.Point(15, 153);
            this.lblvalorig.Name = "lblvalorig";
            this.lblvalorig.Size = new System.Drawing.Size(107, 19);
            this.lblvalorig.TabIndex = 71;
            this.lblvalorig.Text = "Valor Original";
            // 
            // lblvencimento
            // 
            this.lblvencimento.AutoSize = true;
            this.lblvencimento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvencimento.Location = new System.Drawing.Point(15, 187);
            this.lblvencimento.Name = "lblvencimento";
            this.lblvencimento.Size = new System.Drawing.Size(94, 19);
            this.lblvencimento.TabIndex = 73;
            this.lblvencimento.Text = "Vencimento";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(178, 221);
            this.txtdesconto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(126, 27);
            this.txtdesconto.TabIndex = 74;
            this.txtdesconto.Tag = "";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesconto.Location = new System.Drawing.Point(15, 221);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(78, 19);
            this.lbldesconto.TabIndex = 75;
            this.lbldesconto.Text = "Desconto";
            // 
            // txtjuros
            // 
            this.txtjuros.Location = new System.Drawing.Point(178, 252);
            this.txtjuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtjuros.Name = "txtjuros";
            this.txtjuros.Size = new System.Drawing.Size(126, 27);
            this.txtjuros.TabIndex = 76;
            this.txtjuros.Tag = "";
            // 
            // lbljuros
            // 
            this.lbljuros.AutoSize = true;
            this.lbljuros.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljuros.Location = new System.Drawing.Point(15, 255);
            this.lbljuros.Name = "lbljuros";
            this.lbljuros.Size = new System.Drawing.Size(50, 19);
            this.lbljuros.TabIndex = 77;
            this.lbljuros.Text = "Juros";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(15, 17);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(59, 19);
            this.lblcliente.TabIndex = 81;
            this.lblcliente.Text = "Cliente";
            // 
            // lblplancontas
            // 
            this.lblplancontas.AutoSize = true;
            this.lblplancontas.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplancontas.Location = new System.Drawing.Point(15, 51);
            this.lblplancontas.Name = "lblplancontas";
            this.lblplancontas.Size = new System.Drawing.Size(106, 19);
            this.lblplancontas.TabIndex = 83;
            this.lblplancontas.Text = "Plano Contas";
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
            this.btnlimpar.Location = new System.Drawing.Point(191, 309);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(154, 70);
            this.btnlimpar.TabIndex = 86;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpar.Textcolor = System.Drawing.Color.White;
            this.btnlimpar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
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
            this.btnsair.Location = new System.Drawing.Point(366, 309);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(154, 70);
            this.btnsair.TabIndex = 85;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsair.Textcolor = System.Drawing.Color.White;
            this.btnsair.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click_1);
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
            this.btngravar.Location = new System.Drawing.Point(19, 309);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(154, 70);
            this.btngravar.TabIndex = 84;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Textcolor = System.Drawing.Color.White;
            this.btngravar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 28);
            this.label1.TabIndex = 87;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(136, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 28);
            this.label2.TabIndex = 88;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(136, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 28);
            this.label3.TabIndex = 89;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(136, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 28);
            this.label4.TabIndex = 90;
            this.label4.Text = "*";
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(174, 11);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(273, 27);
            this.cmbcliente.TabIndex = 91;
            this.cmbcliente.Click += new System.EventHandler(this.cmbcliente_Click_1);
            // 
            // cmbplanoconta
            // 
            this.cmbplanoconta.FormattingEnabled = true;
            this.cmbplanoconta.Location = new System.Drawing.Point(174, 46);
            this.cmbplanoconta.Name = "cmbplanoconta";
            this.cmbplanoconta.Size = new System.Drawing.Size(273, 27);
            this.cmbplanoconta.TabIndex = 92;
            this.cmbplanoconta.Click += new System.EventHandler(this.cmbplanoconta_Click);
            // 
            // cmbcentrocusto
            // 
            this.cmbcentrocusto.FormattingEnabled = true;
            this.cmbcentrocusto.Location = new System.Drawing.Point(174, 81);
            this.cmbcentrocusto.Name = "cmbcentrocusto";
            this.cmbcentrocusto.Size = new System.Drawing.Size(273, 27);
            this.cmbcentrocusto.TabIndex = 93;
            this.cmbcentrocusto.Click += new System.EventHandler(this.cmbcentrocusto_Click_1);
            // 
            // dtpvencimento
            // 
            this.dtpvencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimento.Location = new System.Drawing.Point(178, 186);
            this.dtpvencimento.Name = "dtpvencimento";
            this.dtpvencimento.Size = new System.Drawing.Size(126, 27);
            this.dtpvencimento.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 95;
            this.label5.Text = "Centro de custo";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(174, 116);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(273, 27);
            this.txtdescricao.TabIndex = 96;
            this.txtdescricao.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(136, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 28);
            this.label6.TabIndex = 97;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(136, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 28);
            this.label7.TabIndex = 98;
            this.label7.Text = "*";
            // 
            // txtvalorpago
            // 
            this.txtvalorpago.Location = new System.Drawing.Point(394, 169);
            this.txtvalorpago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvalorpago.Name = "txtvalorpago";
            this.txtvalorpago.Size = new System.Drawing.Size(126, 27);
            this.txtvalorpago.TabIndex = 99;
            this.txtvalorpago.Tag = "";
            this.txtvalorpago.Visible = false;
            // 
            // FrmCadFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 408);
            this.Controls.Add(this.txtvalorpago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpvencimento);
            this.Controls.Add(this.cmbcentrocusto);
            this.Controls.Add(this.cmbplanoconta);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.lblplancontas);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtjuros);
            this.Controls.Add(this.lbljuros);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lblvencimento);
            this.Controls.Add(this.lblvalorig);
            this.Controls.Add(this.txtvalororiginal);
            this.Controls.Add(this.lbldescricao);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCadFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro financeiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtvalororiginal;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblvalorig;
        private System.Windows.Forms.Label lblvencimento;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.TextBox txtjuros;
        private System.Windows.Forms.Label lbljuros;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblplancontas;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.ComboBox cmbplanoconta;
        private System.Windows.Forms.ComboBox cmbcentrocusto;
        private System.Windows.Forms.DateTimePicker dtpvencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvalorpago;
    }
}