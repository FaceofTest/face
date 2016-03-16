namespace 人脸1
{
    partial class FormQuery
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuery = new System.Windows.Forms.Label();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.labelQueryAll = new System.Windows.Forms.Label();
            this.buttonConfirmAll = new System.Windows.Forms.Button();
            this.buttonCancelAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "按";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(169, 20);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(155, 21);
            this.textBoxContent.TabIndex = 3;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonQuery.Location = new System.Drawing.Point(249, 68);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 6;
            this.buttonQuery.Text = "查找";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.Location = new System.Drawing.Point(249, 97);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(330, 2);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(2, 114);
            this.label5.TabIndex = 9;
            // 
            // labelQuery
            // 
            this.labelQuery.AutoSize = true;
            this.labelQuery.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelQuery.Location = new System.Drawing.Point(114, 22);
            this.labelQuery.Name = "labelQuery";
            this.labelQuery.Size = new System.Drawing.Size(49, 13);
            this.labelQuery.TabIndex = 18;
            this.labelQuery.Text = "查找：";
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Items.AddRange(new object[] {
            "姓名",
            "身份证号",
            "编号"});
            this.comboBoxCondition.Location = new System.Drawing.Point(39, 19);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(78, 20);
            this.comboBoxCondition.TabIndex = 19;
            // 
            // labelQueryAll
            // 
            this.labelQueryAll.AutoSize = true;
            this.labelQueryAll.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelQueryAll.Location = new System.Drawing.Point(350, 26);
            this.labelQueryAll.Name = "labelQueryAll";
            this.labelQueryAll.Size = new System.Drawing.Size(119, 13);
            this.labelQueryAll.TabIndex = 20;
            this.labelQueryAll.Text = "查看员工全部信息";
            // 
            // buttonConfirmAll
            // 
            this.buttonConfirmAll.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmAll.Location = new System.Drawing.Point(394, 68);
            this.buttonConfirmAll.Name = "buttonConfirmAll";
            this.buttonConfirmAll.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmAll.TabIndex = 21;
            this.buttonConfirmAll.Text = "确定";
            this.buttonConfirmAll.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAll
            // 
            this.buttonCancelAll.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCancelAll.Location = new System.Drawing.Point(394, 97);
            this.buttonCancelAll.Name = "buttonCancelAll";
            this.buttonCancelAll.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAll.TabIndex = 22;
            this.buttonCancelAll.Text = "取消";
            this.buttonCancelAll.UseVisualStyleBackColor = true;
            this.buttonCancelAll.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(588, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // FormQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 314);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancelAll);
            this.Controls.Add(this.buttonConfirmAll);
            this.Controls.Add(this.labelQueryAll);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.labelQuery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.label1);
            this.Name = "FormQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuery;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.Label labelQueryAll;
        private System.Windows.Forms.Button buttonConfirmAll;
        private System.Windows.Forms.Button buttonCancelAll;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}