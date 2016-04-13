namespace 人脸1
{
    partial class CheckReport
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
            this.CHECKDATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new 人脸1.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CHECKDATATableAdapter = new 人脸1.DataSet1TableAdapters.CHECKDATATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CHECKDATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CHECKDATABindingSource
            // 
            this.CHECKDATABindingSource.DataMember = "CHECKDATA";
            this.CHECKDATABindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CHECKDATABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "人脸1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 322);
            this.reportViewer1.TabIndex = 0;
            // 
            // CHECKDATATableAdapter
            // 
            this.CHECKDATATableAdapter.ClearBeforeFill = true;
            // 
            // CheckReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 322);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CheckReport";
            this.Text = "员工考勤记录报表";
            this.Load += new System.EventHandler(this.baobiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHECKDATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHECKDATABindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.CHECKDATATableAdapter CHECKDATATableAdapter;
    }
}