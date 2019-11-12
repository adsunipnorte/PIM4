namespace PIM3.Desktop
{
    partial class FrmRelusuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.efleetDataSet = new PIM3.Desktop.efleetDataSet();
            this.tb_usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_usuariosTableAdapter = new PIM3.Desktop.efleetDataSetTableAdapters.tb_usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.efleetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_usuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PIM3.Desktop.RelUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(930, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // efleetDataSet
            // 
            this.efleetDataSet.DataSetName = "efleetDataSet";
            this.efleetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_usuariosBindingSource
            // 
            this.tb_usuariosBindingSource.DataMember = "tb_usuarios";
            this.tb_usuariosBindingSource.DataSource = this.efleetDataSet;
            // 
            // tb_usuariosTableAdapter
            // 
            this.tb_usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelusuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório usuários";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.efleetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_usuariosBindingSource;
        private efleetDataSet efleetDataSet;
        private efleetDataSetTableAdapters.tb_usuariosTableAdapter tb_usuariosTableAdapter;
    }
}