namespace PIM3.Desktop
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtusuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblusuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblsenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtsenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnentrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(232, -5);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(141, 56);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Visible = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtusuario.ForeColor = System.Drawing.Color.Transparent;
            this.txtusuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtusuario.HintText = "";
            this.txtusuario.isPassword = false;
            this.txtusuario.LineFocusedColor = System.Drawing.Color.White;
            this.txtusuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtusuario.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtusuario.LineThickness = 3;
            this.txtusuario.Location = new System.Drawing.Point(232, 59);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(188, 33);
            this.txtusuario.TabIndex = 5;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Arial", 12F);
            this.lblusuario.Location = new System.Drawing.Point(139, 69);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(62, 18);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial", 12F);
            this.lblsenha.Location = new System.Drawing.Point(139, 129);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(53, 18);
            this.lblsenha.TabIndex = 7;
            this.lblsenha.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsenha.ForeColor = System.Drawing.Color.Transparent;
            this.txtsenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtsenha.HintText = "";
            this.txtsenha.isPassword = false;
            this.txtsenha.LineFocusedColor = System.Drawing.Color.White;
            this.txtsenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtsenha.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtsenha.LineThickness = 3;
            this.txtsenha.Location = new System.Drawing.Point(232, 119);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(188, 33);
            this.txtsenha.TabIndex = 8;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnsair.IconMarginRight = 10;
            this.btnsair.IconRightVisible = false;
            this.btnsair.IconRightZoom = 0D;
            this.btnsair.IconVisible = false;
            this.btnsair.IconZoom = 90D;
            this.btnsair.IsTab = false;
            this.btnsair.Location = new System.Drawing.Point(306, 208);
            this.btnsair.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.btnsair.Name = "btnsair";
            this.btnsair.Normalcolor = System.Drawing.Color.Crimson;
            this.btnsair.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.btnsair.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsair.selected = false;
            this.btnsair.Size = new System.Drawing.Size(154, 70);
            this.btnsair.TabIndex = 141;
            this.btnsair.Text = "Sair";
            this.btnsair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsair.Textcolor = System.Drawing.Color.White;
            this.btnsair.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.btnsair.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnentrar.BorderRadius = 7;
            this.btnentrar.ButtonText = "Acessar";
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnentrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnentrar.Iconimage = null;
            this.btnentrar.Iconimage_right = null;
            this.btnentrar.Iconimage_right_Selected = null;
            this.btnentrar.Iconimage_Selected = null;
            this.btnentrar.IconMarginLeft = 0;
            this.btnentrar.IconMarginRight = 10;
            this.btnentrar.IconRightVisible = false;
            this.btnentrar.IconRightZoom = 0D;
            this.btnentrar.IconVisible = false;
            this.btnentrar.IconZoom = 90D;
            this.btnentrar.IsTab = false;
            this.btnentrar.Location = new System.Drawing.Point(129, 208);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnentrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnentrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnentrar.selected = false;
            this.btnentrar.Size = new System.Drawing.Size(154, 70);
            this.btnentrar.TabIndex = 140;
            this.btnentrar.Text = "Acessar";
            this.btnentrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnentrar.Textcolor = System.Drawing.Color.White;
            this.btnentrar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 347);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnlogin);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtusuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblusuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblsenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsenha;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btnentrar;
    }
}

