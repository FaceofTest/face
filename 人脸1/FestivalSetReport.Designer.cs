namespace 人脸1
{
    partial class FestivalSetReport
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
            this.FESTIVALSETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FaceDataDataSet = new 人脸1.FaceDataDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FESTIVALSETTableAdapter = new 人脸1.FaceDataDataSetTableAdapters.FESTIVALSETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FESTIVALSETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FESTIVALSETBindingSource
            // 
            this.FESTIVALSETBindingSource.DataMember = "FESTIVALSET";
            this.FESTIVALSETBindingSource.DataSource = this.FaceDataDataSet;
            // 
            // FaceDataDataSet
            // 
            this.FaceDataDataSet.DataSetName = "FaceDataDataSet";
            this.FaceDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FESTIVALSETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "人脸1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(610, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // FESTIVALSETTableAdapter
            // 
            this.FESTIVALSETTableAdapter.ClearBeforeFill = true;
            // 
            // FestivalSetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FestivalSetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "节日维护总报表";
            this.Load += new System.EventHandler(this.FestivalSetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FESTIVALSETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FESTIVALSETBindingSource;
        private FaceDataDataSet FaceDataDataSet;
        private FaceDataDataSetTableAdapters.FESTIVALSETTableAdapter FESTIVALSETTableAdapter;
    }
}