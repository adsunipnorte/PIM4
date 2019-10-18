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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.Button();
            this.txtsenha = new JTextBox2.JTextBox();
            this.txtusuario = new JTextBox2.JTextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(240, 351);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 104;
            this.checkBox1.Text = "Lembrar-me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(395, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 103;
            this.label3.Text = "Esqueci minha senha";
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.txtlogin.FlatAppearance.BorderSize = 0;
            this.txtlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtlogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(241, 378);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(305, 46);
            this.txtlogin.TabIndex = 102;
            this.txtlogin.Text = "ACESSAR";
            this.txtlogin.UseVisualStyleBackColor = false;
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsenha.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtsenha.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtsenha.HintText = "SENHA";
            this.txtsenha.IsPassword = true;
            this.txtsenha.Location = new System.Drawing.Point(241, 298);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtsenha.MaxLength = 32767;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.OnFocusedColor = System.Drawing.Color.White;
            this.txtsenha.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtsenha.ReadOnly = false;
            this.txtsenha.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtsenha.Size = new System.Drawing.Size(305, 46);
            this.txtsenha.TabIndex = 105;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsenha.TextName = "SENHA";
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtusuario.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtusuario.HintText = "USUÁRIO";
            this.txtusuario.IsPassword = false;
            this.txtusuario.Location = new System.Drawing.Point(241, 238);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.OnFocusedColor = System.Drawing.Color.White;
            this.txtusuario.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtusuario.ReadOnly = false;
            this.txtusuario.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtusuario.Size = new System.Drawing.Size(305, 46);
            this.txtusuario.TabIndex = 106;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuario.TextName = "USUÁRIO";
            // 
            // lbllogin
            // 
            this.lbllogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(323, 50);
            this.lbllogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(143, 45);
            this.lbllogin.TabIndex = 100;
            this.lbllogin.Text = "LOGIN";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIM3.Desktop.Properties.Resources.Imagem_fundo_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lbllogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtlogin;
        private JTextBox2.JTextBox txtsenha;
        private JTextBox2.JTextBox txtusuario;
        private System.Windows.Forms.Label lbllogin;
    }
}

