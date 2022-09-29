namespace 控制板测试
{
    partial class Form_product_settings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.产品BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcba_databaseDataSet = new 控制板测试.pcba_databaseDataSet();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.产品TableAdapter = new 控制板测试.pcba_databaseDataSetTableAdapters.产品TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pcba_databaseDataSet1 = new 控制板测试.pcba_databaseDataSet();
            this.系统设置TableAdapter = new 控制板测试.pcba_databaseDataSetTableAdapters.系统设置TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_require = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需求方DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_require = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.产品BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.名称DataGridViewTextBoxColumn,
            this.型号DataGridViewTextBoxColumn,
            this.需求方DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.产品BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(491, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // 产品BindingSource
            // 
            this.产品BindingSource.DataMember = "产品";
            this.产品BindingSource.DataSource = this.pcba_databaseDataSet;
            // 
            // pcba_databaseDataSet
            // 
            this.pcba_databaseDataSet.DataSetName = "pcba_databaseDataSet";
            this.pcba_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(285, 214);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(67, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "设置为当前生产产品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_status
            // 
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(53, 17);
            this.lb_status.Text = "产品设置";
            // 
            // 产品TableAdapter
            // 
            this.产品TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "系统设置";
            this.bindingSource1.DataSource = this.pcba_databaseDataSet1;
            // 
            // pcba_databaseDataSet1
            // 
            this.pcba_databaseDataSet1.DataSetName = "pcba_databaseDataSet";
            this.pcba_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 系统设置TableAdapter
            // 
            this.系统设置TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "名称";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(749, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 7;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(749, 90);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 21);
            this.tb_type.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "型号";
            // 
            // tb_require
            // 
            this.tb_require.Location = new System.Drawing.Point(749, 135);
            this.tb_require.Name = "tb_require";
            this.tb_require.Size = new System.Drawing.Size(100, 21);
            this.tb_require.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "需求方";
            // 
            // btn_save2
            // 
            this.btn_save2.Location = new System.Drawing.Point(780, 174);
            this.btn_save2.Name = "btn_save2";
            this.btn_save2.Size = new System.Drawing.Size(68, 33);
            this.btn_save2.TabIndex = 12;
            this.btn_save2.Text = "添加";
            this.btn_save2.UseVisualStyleBackColor = true;
            this.btn_save2.Click += new System.EventHandler(this.btn_save2_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // 名称DataGridViewTextBoxColumn
            // 
            this.名称DataGridViewTextBoxColumn.DataPropertyName = "名称";
            this.名称DataGridViewTextBoxColumn.HeaderText = "名称";
            this.名称DataGridViewTextBoxColumn.Name = "名称DataGridViewTextBoxColumn";
            // 
            // 型号DataGridViewTextBoxColumn
            // 
            this.型号DataGridViewTextBoxColumn.DataPropertyName = "型号";
            this.型号DataGridViewTextBoxColumn.HeaderText = "型号";
            this.型号DataGridViewTextBoxColumn.Name = "型号DataGridViewTextBoxColumn";
            // 
            // 需求方DataGridViewTextBoxColumn
            // 
            this.需求方DataGridViewTextBoxColumn.DataPropertyName = "需求方";
            this.需求方DataGridViewTextBoxColumn.HeaderText = "需求方";
            this.需求方DataGridViewTextBoxColumn.Name = "需求方DataGridViewTextBoxColumn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "名称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "型号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "需求方";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "当前生产产品：";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(113, 297);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(17, 12);
            this.lb_id.TabIndex = 18;
            this.lb_id.Text = "id";
            // 
            // lb_require
            // 
            this.lb_require.AutoSize = true;
            this.lb_require.Location = new System.Drawing.Point(113, 378);
            this.lb_require.Name = "lb_require";
            this.lb_require.Size = new System.Drawing.Size(41, 12);
            this.lb_require.TabIndex = 17;
            this.lb_require.Text = "需求方";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(113, 350);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(29, 12);
            this.lb_type.TabIndex = 16;
            this.lb_type.Text = "型号";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(113, 324);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(29, 12);
            this.lb_name.TabIndex = 15;
            this.lb_name.Text = "名称";
            // 
            // Form_product_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 494);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_require);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_save2);
            this.Controls.Add(this.tb_require);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form_product_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品设置";
            this.Load += new System.EventHandler(this.Form_product_settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.产品BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private pcba_databaseDataSet pcba_databaseDataSet;
        private System.Windows.Forms.BindingSource 产品BindingSource;
        private pcba_databaseDataSetTableAdapters.产品TableAdapter 产品TableAdapter;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pcba_databaseDataSet pcba_databaseDataSet1;
        private pcba_databaseDataSetTableAdapters.系统设置TableAdapter 系统设置TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_require;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 需求方DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_require;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_name;
    }
}