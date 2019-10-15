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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCentroCusto));
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblidcc = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.chksituacao = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.chksituacao.Location = new System.Drawing.Point(153, 21);
            this.chksituacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btngravar.Location = new System.Drawing.Point(68, 179);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(137, 59);
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
            this.btnsair.Location = new System.Drawing.Point(417, 178);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(137, 59);
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
            this.btnlimpar.Location = new System.Drawing.Point(243, 178);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(137, 59);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpar.Textcolor = System.Drawing.Color.White;
            this.btnlimpar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click_1);
            // 
            // FrmCadCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(622, 315);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.chksituacao);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblidcc);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCadCentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de custo";
            this.Load += new System.EventHandler(this.FrmCadCentroCusto_Load);
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
        
    }
}