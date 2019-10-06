namespace PIM3.Desktop
{
    partial class FrmCadCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCidade));
            this.dgvcidade = new System.Windows.Forms.DataGridView();
            this.CodCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnomecid = new System.Windows.Forms.TextBox();
            this.lblnomecid = new System.Windows.Forms.Label();
            this.lblcodcidade = new System.Windows.Forms.Label();
            this.txtcodcidade = new System.Windows.Forms.TextBox();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcidade
            // 
            this.dgvcidade.AllowUserToAddRows = false;
            this.dgvcidade.AllowUserToDeleteRows = false;
            this.dgvcidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCidade,
            this.Nome,
            this.IdEstados});
            this.dgvcidade.Location = new System.Drawing.Point(25, 135);
            this.dgvcidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvcidade.Name = "dgvcidade";
            this.dgvcidade.RowTemplate.Height = 24;
            this.dgvcidade.Size = new System.Drawing.Size(694, 211);
            this.dgvcidade.TabIndex = 76;
            // 
            // CodCidade
            // 
            this.CodCidade.HeaderText = "Código Cidade";
            this.CodCidade.Name = "CodCidade";
            this.CodCidade.ReadOnly = true;
            this.CodCidade.Width = 150;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Cidade";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // IdEstados
            // 
            this.IdEstados.HeaderText = "Estado";
            this.IdEstados.Name = "IdEstados";
            this.IdEstados.ReadOnly = true;
            this.IdEstados.Width = 200;
            // 
            // txtnomecid
            // 
            this.txtnomecid.Location = new System.Drawing.Point(160, 61);
            this.txtnomecid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnomecid.Name = "txtnomecid";
            this.txtnomecid.Size = new System.Drawing.Size(273, 27);
            this.txtnomecid.TabIndex = 69;
            this.txtnomecid.Tag = "";
            // 
            // lblnomecid
            // 
            this.lblnomecid.AutoSize = true;
            this.lblnomecid.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecid.Location = new System.Drawing.Point(21, 69);
            this.lblnomecid.Name = "lblnomecid";
            this.lblnomecid.Size = new System.Drawing.Size(84, 19);
            this.lblnomecid.TabIndex = 75;
            this.lblnomecid.Text = "Descrição";
            // 
            // lblcodcidade
            // 
            this.lblcodcidade.AutoSize = true;
            this.lblcodcidade.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblcodcidade.Location = new System.Drawing.Point(21, 19);
            this.lblcodcidade.Name = "lblcodcidade";
            this.lblcodcidade.Size = new System.Drawing.Size(118, 19);
            this.lblcodcidade.TabIndex = 74;
            this.lblcodcidade.Text = "Código Cidade";
            // 
            // txtcodcidade
            // 
            this.txtcodcidade.Location = new System.Drawing.Point(160, 16);
            this.txtcodcidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodcidade.Name = "txtcodcidade";
            this.txtcodcidade.Size = new System.Drawing.Size(164, 27);
            this.txtcodcidade.TabIndex = 77;
            this.txtcodcidade.Tag = "";
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
            this.btnlimpar.Location = new System.Drawing.Point(279, 394);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(154, 70);
            this.btnlimpar.TabIndex = 80;
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
            this.btnsair.Location = new System.Drawing.Point(465, 394);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(154, 70);
            this.btnsair.TabIndex = 79;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsair.Textcolor = System.Drawing.Color.White;
            this.btnsair.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnsair.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.btngravar.Location = new System.Drawing.Point(98, 394);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(154, 70);
            this.btngravar.TabIndex = 78;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Textcolor = System.Drawing.Color.White;
            this.btngravar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmCadCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 534);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.txtcodcidade);
            this.Controls.Add(this.dgvcidade);
            this.Controls.Add(this.txtnomecid);
            this.Controls.Add(this.lblnomecid);
            this.Controls.Add(this.lblcodcidade);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadstro de cidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcidade;
        private System.Windows.Forms.TextBox txtnomecid;
        private System.Windows.Forms.Label lblnomecid;
        private System.Windows.Forms.Label lblcodcidade;
        private System.Windows.Forms.TextBox txtcodcidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstados;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
    }
}