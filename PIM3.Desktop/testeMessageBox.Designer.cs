namespace PIM3.Desktop
{
    partial class testeMessageBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testeMessageBox));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icone = new System.Windows.Forms.PictureBox();
            this.atrasoIcone = new System.Windows.Forms.Timer(this.components);
            this.btnsucesso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblregistroinserido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icone)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.bunifuFormFadeTransition1_TransitionEnd);
            // 
            // icone
            // 
            this.icone.Enabled = false;
            this.icone.Image = ((System.Drawing.Image)(resources.GetObject("icone.Image")));
            this.icone.Location = new System.Drawing.Point(12, 12);
            this.icone.Name = "icone";
            this.icone.Size = new System.Drawing.Size(523, 260);
            this.icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icone.TabIndex = 0;
            this.icone.TabStop = false;
            // 
            // atrasoIcone
            // 
            this.atrasoIcone.Enabled = true;
            this.atrasoIcone.Interval = 5000;
            this.atrasoIcone.Tick += new System.EventHandler(this.atrasoIcone_Tick);
            // 
            // btnsucesso
            // 
            this.btnsucesso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsucesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnsucesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsucesso.BorderRadius = 5;
            this.btnsucesso.ButtonText = "Sair";
            this.btnsucesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsucesso.DisabledColor = System.Drawing.Color.Gray;
            this.btnsucesso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsucesso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsucesso.Iconimage")));
            this.btnsucesso.Iconimage_right = null;
            this.btnsucesso.Iconimage_right_Selected = null;
            this.btnsucesso.Iconimage_Selected = null;
            this.btnsucesso.IconMarginLeft = 0;
            this.btnsucesso.IconMarginRight = 0;
            this.btnsucesso.IconRightVisible = true;
            this.btnsucesso.IconRightZoom = 0D;
            this.btnsucesso.IconVisible = false;
            this.btnsucesso.IconZoom = 90D;
            this.btnsucesso.IsTab = false;
            this.btnsucesso.Location = new System.Drawing.Point(194, 279);
            this.btnsucesso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsucesso.Name = "btnsucesso";
            this.btnsucesso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnsucesso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(210)))), ((int)(((byte)(63)))));
            this.btnsucesso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsucesso.selected = false;
            this.btnsucesso.Size = new System.Drawing.Size(149, 59);
            this.btnsucesso.TabIndex = 1;
            this.btnsucesso.Text = "Sair";
            this.btnsucesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsucesso.Textcolor = System.Drawing.Color.White;
            this.btnsucesso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsucesso.Visible = false;
            this.btnsucesso.Click += new System.EventHandler(this.btnsucesso_Click);
            // 
            // lblregistroinserido
            // 
            this.lblregistroinserido.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistroinserido.ForeColor = System.Drawing.Color.Gray;
            this.lblregistroinserido.Location = new System.Drawing.Point(7, 235);
            this.lblregistroinserido.Name = "lblregistroinserido";
            this.lblregistroinserido.Size = new System.Drawing.Size(523, 37);
            this.lblregistroinserido.TabIndex = 2;
            this.lblregistroinserido.Text = "Registro inserido com sucesso";
            this.lblregistroinserido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testeMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 367);
            this.Controls.Add(this.lblregistroinserido);
            this.Controls.Add(this.btnsucesso);
            this.Controls.Add(this.icone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "testeMessageBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "testeMessageBox";
            this.Load += new System.EventHandler(this.testeMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox icone;
        private System.Windows.Forms.Timer atrasoIcone;
        private Bunifu.Framework.UI.BunifuFlatButton btnsucesso;
        private System.Windows.Forms.Label lblregistroinserido;
    }
}