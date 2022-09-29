namespace 控制板测试
{
    partial class Form_test_data
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pcba_databaseDataSet = new 控制板测试.pcba_databaseDataSet();
            this.产品测试数据TableAdapter = new 控制板测试.pcba_databaseDataSetTableAdapters.产品测试数据TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.条形码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t6resultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.合格判定1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.测试时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.测试人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.测试班组DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "测试数据";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.产品idDataGridViewTextBoxColumn,
            this.条形码DataGridViewTextBoxColumn,
            this.编号DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.t1resultDataGridViewCheckBoxColumn,
            this.t2DataGridViewTextBoxColumn,
            this.t2resultDataGridViewCheckBoxColumn,
            this.t3DataGridViewTextBoxColumn,
            this.t3resultDataGridViewCheckBoxColumn,
            this.t4DataGridViewTextBoxColumn,
            this.t4resultDataGridViewCheckBoxColumn,
            this.t5DataGridViewTextBoxColumn,
            this.t5resultDataGridViewCheckBoxColumn,
            this.t6DataGridViewTextBoxColumn,
            this.t6resultDataGridViewCheckBoxColumn,
            this.合格判定1DataGridViewCheckBoxColumn,
            this.测试时间DataGridViewTextBoxColumn,
            this.测试人DataGridViewTextBoxColumn,
            this.测试班组DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(33, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(929, 528);
            this.dataGridView2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "备注：打勾表示合格";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(826, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "导出电子表格";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(666, 584);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(61, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "产品测试数据";
            this.bindingSource1.DataSource = this.pcba_databaseDataSet;
            // 
            // pcba_databaseDataSet
            // 
            this.pcba_databaseDataSet.DataSetName = "pcba_databaseDataSet";
            this.pcba_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 产品测试数据TableAdapter
            // 
            this.产品测试数据TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // 产品idDataGridViewTextBoxColumn
            // 
            this.产品idDataGridViewTextBoxColumn.DataPropertyName = "产品id";
            this.产品idDataGridViewTextBoxColumn.HeaderText = "产品id";
            this.产品idDataGridViewTextBoxColumn.Name = "产品idDataGridViewTextBoxColumn";
            // 
            // 条形码DataGridViewTextBoxColumn
            // 
            this.条形码DataGridViewTextBoxColumn.DataPropertyName = "条形码";
            this.条形码DataGridViewTextBoxColumn.HeaderText = "条形码";
            this.条形码DataGridViewTextBoxColumn.Name = "条形码DataGridViewTextBoxColumn";
            // 
            // 编号DataGridViewTextBoxColumn
            // 
            this.编号DataGridViewTextBoxColumn.DataPropertyName = "编号";
            this.编号DataGridViewTextBoxColumn.HeaderText = "编号";
            this.编号DataGridViewTextBoxColumn.Name = "编号DataGridViewTextBoxColumn";
            // 
            // t1DataGridViewTextBoxColumn
            // 
            this.t1DataGridViewTextBoxColumn.DataPropertyName = "t1";
            this.t1DataGridViewTextBoxColumn.HeaderText = "t1";
            this.t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            // 
            // t1resultDataGridViewCheckBoxColumn
            // 
            this.t1resultDataGridViewCheckBoxColumn.DataPropertyName = "t1result";
            this.t1resultDataGridViewCheckBoxColumn.HeaderText = "t1result";
            this.t1resultDataGridViewCheckBoxColumn.Name = "t1resultDataGridViewCheckBoxColumn";
            // 
            // t2DataGridViewTextBoxColumn
            // 
            this.t2DataGridViewTextBoxColumn.DataPropertyName = "t2";
            this.t2DataGridViewTextBoxColumn.HeaderText = "t2";
            this.t2DataGridViewTextBoxColumn.Name = "t2DataGridViewTextBoxColumn";
            // 
            // t2resultDataGridViewCheckBoxColumn
            // 
            this.t2resultDataGridViewCheckBoxColumn.DataPropertyName = "t2result";
            this.t2resultDataGridViewCheckBoxColumn.HeaderText = "t2result";
            this.t2resultDataGridViewCheckBoxColumn.Name = "t2resultDataGridViewCheckBoxColumn";
            // 
            // t3DataGridViewTextBoxColumn
            // 
            this.t3DataGridViewTextBoxColumn.DataPropertyName = "t3";
            this.t3DataGridViewTextBoxColumn.HeaderText = "t3";
            this.t3DataGridViewTextBoxColumn.Name = "t3DataGridViewTextBoxColumn";
            // 
            // t3resultDataGridViewCheckBoxColumn
            // 
            this.t3resultDataGridViewCheckBoxColumn.DataPropertyName = "t3result";
            this.t3resultDataGridViewCheckBoxColumn.HeaderText = "t3result";
            this.t3resultDataGridViewCheckBoxColumn.Name = "t3resultDataGridViewCheckBoxColumn";
            // 
            // t4DataGridViewTextBoxColumn
            // 
            this.t4DataGridViewTextBoxColumn.DataPropertyName = "t4";
            this.t4DataGridViewTextBoxColumn.HeaderText = "t4";
            this.t4DataGridViewTextBoxColumn.Name = "t4DataGridViewTextBoxColumn";
            // 
            // t4resultDataGridViewCheckBoxColumn
            // 
            this.t4resultDataGridViewCheckBoxColumn.DataPropertyName = "t4result";
            this.t4resultDataGridViewCheckBoxColumn.HeaderText = "t4result";
            this.t4resultDataGridViewCheckBoxColumn.Name = "t4resultDataGridViewCheckBoxColumn";
            // 
            // t5DataGridViewTextBoxColumn
            // 
            this.t5DataGridViewTextBoxColumn.DataPropertyName = "t5";
            this.t5DataGridViewTextBoxColumn.HeaderText = "t5";
            this.t5DataGridViewTextBoxColumn.Name = "t5DataGridViewTextBoxColumn";
            // 
            // t5resultDataGridViewCheckBoxColumn
            // 
            this.t5resultDataGridViewCheckBoxColumn.DataPropertyName = "t5result";
            this.t5resultDataGridViewCheckBoxColumn.HeaderText = "t5result";
            this.t5resultDataGridViewCheckBoxColumn.Name = "t5resultDataGridViewCheckBoxColumn";
            // 
            // t6DataGridViewTextBoxColumn
            // 
            this.t6DataGridViewTextBoxColumn.DataPropertyName = "t6";
            this.t6DataGridViewTextBoxColumn.HeaderText = "t6";
            this.t6DataGridViewTextBoxColumn.Name = "t6DataGridViewTextBoxColumn";
            // 
            // t6resultDataGridViewCheckBoxColumn
            // 
            this.t6resultDataGridViewCheckBoxColumn.DataPropertyName = "t6result";
            this.t6resultDataGridViewCheckBoxColumn.HeaderText = "t6result";
            this.t6resultDataGridViewCheckBoxColumn.Name = "t6resultDataGridViewCheckBoxColumn";
            // 
            // 合格判定1DataGridViewCheckBoxColumn
            // 
            this.合格判定1DataGridViewCheckBoxColumn.DataPropertyName = "合格判定1";
            this.合格判定1DataGridViewCheckBoxColumn.HeaderText = "合格判定1";
            this.合格判定1DataGridViewCheckBoxColumn.Name = "合格判定1DataGridViewCheckBoxColumn";
            // 
            // 测试时间DataGridViewTextBoxColumn
            // 
            this.测试时间DataGridViewTextBoxColumn.DataPropertyName = "测试时间";
            this.测试时间DataGridViewTextBoxColumn.HeaderText = "测试时间";
            this.测试时间DataGridViewTextBoxColumn.Name = "测试时间DataGridViewTextBoxColumn";
            // 
            // 测试人DataGridViewTextBoxColumn
            // 
            this.测试人DataGridViewTextBoxColumn.DataPropertyName = "测试人";
            this.测试人DataGridViewTextBoxColumn.HeaderText = "测试人";
            this.测试人DataGridViewTextBoxColumn.Name = "测试人DataGridViewTextBoxColumn";
            // 
            // 测试班组DataGridViewTextBoxColumn
            // 
            this.测试班组DataGridViewTextBoxColumn.DataPropertyName = "测试班组";
            this.测试班组DataGridViewTextBoxColumn.HeaderText = "测试班组";
            this.测试班组DataGridViewTextBoxColumn.Name = "测试班组DataGridViewTextBoxColumn";
            // 
            // Form_test_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 618);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Name = "Form_test_data";
            this.Text = "测试数据";
            this.Load += new System.EventHandler(this.Form_test_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pcba_databaseDataSet pcba_databaseDataSet;
        private pcba_databaseDataSetTableAdapters.产品测试数据TableAdapter 产品测试数据TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 条形码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t1resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t2resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t3resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t4resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t5resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t6resultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 合格判定1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 测试时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 测试人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 测试班组DataGridViewTextBoxColumn;
    }
}