namespace PIM3.Desktop
{
    partial class FrmCadSeguro
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtseguro = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.rtxtobs = new System.Windows.Forms.RichTextBox();
            this.btnsaircli = new System.Windows.Forms.Button();
            this.btnlimparcli = new System.Windows.Forms.Button();
            this.btncadcli = new System.Windows.Forms.Button();
            this.lblobs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblid.Location = new System.Drawing.Point(24, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 125;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Yellow;
            this.txtid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtid.Location = new System.Drawing.Point(142, 27);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(62, 27);
            this.txtid.TabIndex = 124;
            this.txtid.TabStop = false;
            // 
            // txtseguro
            // 
            this.txtseguro.Location = new System.Drawing.Point(142, 67);
            this.txtseguro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtseguro.Name = "txtseguro";
            this.txtseguro.Size = new System.Drawing.Size(537, 27);
            this.txtseguro.TabIndex = 1;
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lbldescricao.Location = new System.Drawing.Point(24, 70);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 129;
            this.lbldescricao.Text = "Descrição";
            // 
            // rtxtobs
            // 
            this.rtxtobs.Location = new System.Drawing.Point(28, 142);
            this.rtxtobs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtobs.Name = "rtxtobs";
            this.rtxtobs.Size = new System.Drawing.Size(651, 174);
            this.rtxtobs.TabIndex = 130;
            this.rtxtobs.Text = "";
            // 
            // btnsaircli
            // 
            this.btnsaircli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaircli.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnsaircli.Location = new System.Drawing.Point(443, 398);
            this.btnsaircli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsaircli.Name = "btnsaircli";
            this.btnsaircli.Size = new System.Drawing.Size(94, 59);
            this.btnsaircli.TabIndex = 133;
            this.btnsaircli.Text = "&Sair";
            this.btnsaircli.UseVisualStyleBackColor = true;
            this.btnsaircli.Click += new System.EventHandler(this.btnsaircli_Click);
            // 
            // btnlimparcli
            // 
            this.btnlimparcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimparcli.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnlimparcli.Location = new System.Drawing.Point(325, 398);
            this.btnlimparcli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimparcli.Name = "btnlimparcli";
            this.btnlimparcli.Size = new System.Drawing.Size(94, 59);
            this.btnlimparcli.TabIndex = 132;
            this.btnlimparcli.Text = "&Limpar";
            this.btnlimparcli.UseVisualStyleBackColor = true;
            // 
            // btncadcli
            // 
            this.btncadcli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncadcli.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btncadcli.Location = new System.Drawing.Point(205, 398);
            this.btncadcli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncadcli.Name = "btncadcli";
            this.btncadcli.Size = new System.Drawing.Size(94, 59);
            this.btncadcli.TabIndex = 131;
            this.btncadcli.Text = "&Gravar";
            this.btncadcli.UseVisualStyleBackColor = true;
            // 
            // lblobs
            // 
            this.lblobs.AutoSize = true;
            this.lblobs.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblobs.Location = new System.Drawing.Point(24, 119);
            this.lblobs.Name = "lblobs";
            this.lblobs.Size = new System.Drawing.Size(96, 19);
            this.lblobs.TabIndex = 134;
            this.lblobs.Text = "Observação";
            // 
            // FrmCadSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.lblobs);
            this.Controls.Add(this.btnsaircli);
            this.Controls.Add(this.btnlimparcli);
            this.Controls.Add(this.btncadcli);
            this.Controls.Add(this.rtxtobs);
            this.Controls.Add(this.txtseguro);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadSeguro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de seguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtseguro;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.RichTextBox rtxtobs;
        private System.Windows.Forms.Button btnsaircli;
        private System.Windows.Forms.Button btnlimparcli;
        private System.Windows.Forms.Button btncadcli;
        private System.Windows.Forms.Label lblobs;
    }
}