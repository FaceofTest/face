namespace 人脸1
{
    partial class LeaveSetReport
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
            this.DataSet２ = new 人脸1.DataSet２();
            this.LEAVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LEAVETableAdapter = new 人脸1.DataSet２TableAdapters.LEAVETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet２)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEAVEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LEAVEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "人脸1.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet２
            // 
            this.DataSet２.DataSetName = "DataSet２";
            this.DataSet２.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LEAVEBindingSource
            // 
            this.LEAVEBindingSource.DataMember = "LEAVE";
            this.LEAVEBindingSource.DataSource = this.DataSet２;
            // 
            // LEAVETableAdapter
            // 
            this.LEAVETableAdapter.ClearBeforeFill = true;
            // 
            // LeaveSetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 367);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LeaveSetReport";
            this.Text = "公出/请假统计报表";
            this.Load += new System.EventHandler(this.LeaveSetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet２)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LEAVEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LEAVEBindingSource;
        private DataSet２ DataSet２;
        private DataSet２TableAdapters.LEAVETableAdapter LEAVETableAdapter;
    }
}