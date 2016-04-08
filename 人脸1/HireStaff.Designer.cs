namespace 人脸1
{
    partial class HireStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.faceDataDataSet = new 人脸1.FaceDataDataSet();
            this.faceDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFINFORMATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFINFORMATIONTableAdapter = new 人脸1.FaceDataDataSetTableAdapters.STAFFINFORMATIONTableAdapter();
            this.sTAFFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mINZUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHOTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEFAULTDEPTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFINFORMATIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "本部门员工";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTAFFIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewCheckBoxColumn,
            this.mINZUDataGridViewTextBoxColumn,
            this.bIRTHDAYDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.oPHONEDataGridViewTextBoxColumn,
            this.pHOTODataGridViewTextBoxColumn,
            this.dEFAULTDEPTNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTAFFINFORMATIONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(200, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(371, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(200, 302);
            this.dataGridView2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "加入》";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "移去《";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "关闭";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // faceDataDataSet
            // 
            this.faceDataDataSet.DataSetName = "FaceDataDataSet";
            this.faceDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faceDataDataSetBindingSource
            // 
            this.faceDataDataSetBindingSource.DataSource = this.faceDataDataSet;
            this.faceDataDataSetBindingSource.Position = 0;
            // 
            // sTAFFINFORMATIONBindingSource
            // 
            this.sTAFFINFORMATIONBindingSource.DataMember = "STAFFINFORMATION";
            this.sTAFFINFORMATIONBindingSource.DataSource = this.faceDataDataSet;
            // 
            // sTAFFINFORMATIONTableAdapter
            // 
            this.sTAFFINFORMATIONTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFIDDataGridViewTextBoxColumn
            // 
            this.sTAFFIDDataGridViewTextBoxColumn.DataPropertyName = "STAFFID";
            this.sTAFFIDDataGridViewTextBoxColumn.HeaderText = "STAFFID";
            this.sTAFFIDDataGridViewTextBoxColumn.Name = "sTAFFIDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewCheckBoxColumn
            // 
            this.gENDERDataGridViewCheckBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewCheckBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewCheckBoxColumn.Name = "gENDERDataGridViewCheckBoxColumn";
            // 
            // mINZUDataGridViewTextBoxColumn
            // 
            this.mINZUDataGridViewTextBoxColumn.DataPropertyName = "MINZU";
            this.mINZUDataGridViewTextBoxColumn.HeaderText = "MINZU";
            this.mINZUDataGridViewTextBoxColumn.Name = "mINZUDataGridViewTextBoxColumn";
            // 
            // bIRTHDAYDataGridViewTextBoxColumn
            // 
            this.bIRTHDAYDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.HeaderText = "BIRTHDAY";
            this.bIRTHDAYDataGridViewTextBoxColumn.Name = "bIRTHDAYDataGridViewTextBoxColumn";
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            // 
            // oPHONEDataGridViewTextBoxColumn
            // 
            this.oPHONEDataGridViewTextBoxColumn.DataPropertyName = "OPHONE";
            this.oPHONEDataGridViewTextBoxColumn.HeaderText = "OPHONE";
            this.oPHONEDataGridViewTextBoxColumn.Name = "oPHONEDataGridViewTextBoxColumn";
            // 
            // pHOTODataGridViewTextBoxColumn
            // 
            this.pHOTODataGridViewTextBoxColumn.DataPropertyName = "PHOTO";
            this.pHOTODataGridViewTextBoxColumn.HeaderText = "PHOTO";
            this.pHOTODataGridViewTextBoxColumn.Name = "pHOTODataGridViewTextBoxColumn";
            // 
            // dEFAULTDEPTNAMEDataGridViewTextBoxColumn
            // 
            this.dEFAULTDEPTNAMEDataGridViewTextBoxColumn.DataPropertyName = "DEFAULTDEPTNAME";
            this.dEFAULTDEPTNAMEDataGridViewTextBoxColumn.HeaderText = "DEFAULTDEPTNAME";
            this.dEFAULTDEPTNAMEDataGridViewTextBoxColumn.Name = "dEFAULTDEPTNAMEDataGridViewTextBoxColumn";
            // 
            // HireStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 412);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "HireStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录用员工";
            this.Load += new System.EventHandler(this.HireStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFINFORMATIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private FaceDataDataSet faceDataDataSet;
        private System.Windows.Forms.BindingSource faceDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource sTAFFINFORMATIONBindingSource;
        private FaceDataDataSetTableAdapters.STAFFINFORMATIONTableAdapter sTAFFINFORMATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gENDERDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINZUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHOTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEFAULTDEPTNAMEDataGridViewTextBoxColumn;
    }
}