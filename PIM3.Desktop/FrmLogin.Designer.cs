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
            this.btnsair = new System.Windows.Forms.Button();
            this.txtusuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblusuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblsenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtsenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(118, 208);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(141, 56);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(279, 208);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(141, 56);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
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
            this.lblusuario.Size = new System.Drawing.Size(76, 23);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Arial", 12F);
            this.lblsenha.Location = new System.Drawing.Point(139, 129);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(65, 23);
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
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 347);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnsair);
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
        private System.Windows.Forms.Button btnsair;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtusuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblusuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblsenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsenha;
    }
}

