﻿namespace PIM3.Desktop
{
    partial class FrmCadTpVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadTpVeiculo));
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.btnlimpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(128, 35);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(273, 27);
            this.txtdescricao.TabIndex = 60;
            this.txtdescricao.Tag = "";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(23, 40);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(84, 19);
            this.lbldescricao.TabIndex = 66;
            this.lbldescricao.Text = "Descrição";
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
            this.btnlimpar.Location = new System.Drawing.Point(202, 108);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpar.OnHovercolor = System.Drawing.Color.Black;
            this.btnlimpar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlimpar.selected = false;
            this.btnlimpar.Size = new System.Drawing.Size(154, 70);
            this.btnlimpar.TabIndex = 142;
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
            this.btnsair.Location = new System.Drawing.Point(377, 108);
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
            this.btngravar.Location = new System.Drawing.Point(27, 108);
            this.btngravar.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.btngravar.Name = "btngravar";
            this.btngravar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngravar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btngravar.selected = false;
            this.btngravar.Size = new System.Drawing.Size(154, 70);
            this.btngravar.TabIndex = 140;
            this.btngravar.Text = "Gravar";
            this.btngravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngravar.Textcolor = System.Drawing.Color.White;
            this.btngravar.TextFont = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(101, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 28);
            this.label1.TabIndex = 143;
            this.label1.Text = "*";
            // 
            // FrmCadTpVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCadTpVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lbldescricao;
        private Bunifu.Framework.UI.BunifuFlatButton btnlimpar;
        private Bunifu.Framework.UI.BunifuFlatButton btnsair;
        private Bunifu.Framework.UI.BunifuFlatButton btngravar;
        private System.Windows.Forms.Label label1;
    }
}