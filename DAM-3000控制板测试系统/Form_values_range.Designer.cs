namespace 控制板测试
{
    partial class Form_values_range
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_t1min = new System.Windows.Forms.TextBox();
            this.tb_t1max = new System.Windows.Forms.TextBox();
            this.tb_t2max = new System.Windows.Forms.TextBox();
            this.tb_t2min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_t3max = new System.Windows.Forms.TextBox();
            this.tb_t3min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_t4max = new System.Windows.Forms.TextBox();
            this.tb_t4min = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_t5max = new System.Windows.Forms.TextBox();
            this.tb_t5min = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_t6max = new System.Windows.Forms.TextBox();
            this.tb_t6min = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pcba_databaseDataSet = new 控制板测试.pcba_databaseDataSet();
            this.产品测量值合格范围TableAdapter = new 控制板测试.pcba_databaseDataSetTableAdapters.产品测量值合格范围TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "T1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最小值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "最大值";
            // 
            // tb_t1min
            // 
            this.tb_t1min.Location = new System.Drawing.Point(115, 63);
            this.tb_t1min.Name = "tb_t1min";
            this.tb_t1min.Size = new System.Drawing.Size(57, 21);
            this.tb_t1min.TabIndex = 3;
            // 
            // tb_t1max
            // 
            this.tb_t1max.Location = new System.Drawing.Point(210, 63);
            this.tb_t1max.Name = "tb_t1max";
            this.tb_t1max.Size = new System.Drawing.Size(57, 21);
            this.tb_t1max.TabIndex = 4;
            // 
            // tb_t2max
            // 
            this.tb_t2max.Location = new System.Drawing.Point(210, 90);
            this.tb_t2max.Name = "tb_t2max";
            this.tb_t2max.Size = new System.Drawing.Size(57, 21);
            this.tb_t2max.TabIndex = 7;
            // 
            // tb_t2min
            // 
            this.tb_t2min.Location = new System.Drawing.Point(115, 90);
            this.tb_t2min.Name = "tb_t2min";
            this.tb_t2min.Size = new System.Drawing.Size(57, 21);
            this.tb_t2min.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "T2";
            // 
            // tb_t3max
            // 
            this.tb_t3max.Location = new System.Drawing.Point(210, 117);
            this.tb_t3max.Name = "tb_t3max";
            this.tb_t3max.Size = new System.Drawing.Size(57, 21);
            this.tb_t3max.TabIndex = 10;
            // 
            // tb_t3min
            // 
            this.tb_t3min.Location = new System.Drawing.Point(115, 117);
            this.tb_t3min.Name = "tb_t3min";
            this.tb_t3min.Size = new System.Drawing.Size(57, 21);
            this.tb_t3min.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "T3";
            // 
            // tb_t4max
            // 
            this.tb_t4max.Location = new System.Drawing.Point(210, 144);
            this.tb_t4max.Name = "tb_t4max";
            this.tb_t4max.Size = new System.Drawing.Size(57, 21);
            this.tb_t4max.TabIndex = 13;
            // 
            // tb_t4min
            // 
            this.tb_t4min.Location = new System.Drawing.Point(115, 144);
            this.tb_t4min.Name = "tb_t4min";
            this.tb_t4min.Size = new System.Drawing.Size(57, 21);
            this.tb_t4min.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "T4";
            // 
            // tb_t5max
            // 
            this.tb_t5max.Location = new System.Drawing.Point(210, 171);
            this.tb_t5max.Name = "tb_t5max";
            this.tb_t5max.Size = new System.Drawing.Size(57, 21);
            this.tb_t5max.TabIndex = 16;
            // 
            // tb_t5min
            // 
            this.tb_t5min.Location = new System.Drawing.Point(115, 171);
            this.tb_t5min.Name = "tb_t5min";
            this.tb_t5min.Size = new System.Drawing.Size(57, 21);
            this.tb_t5min.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "T5";
            // 
            // tb_t6max
            // 
            this.tb_t6max.Location = new System.Drawing.Point(210, 198);
            this.tb_t6max.Name = "tb_t6max";
            this.tb_t6max.Size = new System.Drawing.Size(57, 21);
            this.tb_t6max.TabIndex = 19;
            // 
            // tb_t6min
            // 
            this.tb_t6min.Location = new System.Drawing.Point(115, 198);
            this.tb_t6min.Name = "tb_t6min";
            this.tb_t6min.Size = new System.Drawing.Size(57, 21);
            this.tb_t6min.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "T6";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(153, 234);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(114, 35);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "产品测量值合格范围";
            this.bindingSource1.DataSource = this.pcba_databaseDataSet;
            // 
            // pcba_databaseDataSet
            // 
            this.pcba_databaseDataSet.DataSetName = "pcba_databaseDataSet";
            this.pcba_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 产品测量值合格范围TableAdapter
            // 
            this.产品测量值合格范围TableAdapter.ClearBeforeFill = true;
            // 
            // Form_values_range
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 498);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_t6max);
            this.Controls.Add(this.tb_t6min);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_t5max);
            this.Controls.Add(this.tb_t5min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_t4max);
            this.Controls.Add(this.tb_t4min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_t3max);
            this.Controls.Add(this.tb_t3min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_t2max);
            this.Controls.Add(this.tb_t2min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_t1max);
            this.Controls.Add(this.tb_t1min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_values_range";
            this.Text = "合格范围设置";
            this.Load += new System.EventHandler(this.Form_values_range_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcba_databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_t1min;
        private System.Windows.Forms.TextBox tb_t1max;
        private System.Windows.Forms.TextBox tb_t2max;
        private System.Windows.Forms.TextBox tb_t2min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_t3max;
        private System.Windows.Forms.TextBox tb_t3min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_t4max;
        private System.Windows.Forms.TextBox tb_t4min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_t5max;
        private System.Windows.Forms.TextBox tb_t5min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_t6max;
        private System.Windows.Forms.TextBox tb_t6min;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.BindingSource bindingSource1;
        private pcba_databaseDataSet pcba_databaseDataSet;
        private pcba_databaseDataSetTableAdapters.产品测量值合格范围TableAdapter 产品测量值合格范围TableAdapter;
    }
}