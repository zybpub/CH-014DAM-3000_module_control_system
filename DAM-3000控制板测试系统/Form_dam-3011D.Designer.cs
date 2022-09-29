namespace 控制板测试
{
    partial class Form_dam_3011D
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
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_baudrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_port_numbere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_init = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_channel0 = new System.Windows.Forms.TextBox();
            this.tb_channel1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_channel2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_channel3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_channel4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_channel5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_channel6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_channel7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(343, 40);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 21);
            this.btn_save.TabIndex = 114;
            this.btn_save.Text = "保存配置";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(282, 40);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(38, 21);
            this.tb_addr.TabIndex = 113;
            this.tb_addr.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 112;
            this.label3.Text = "地址：";
            // 
            // tb_baudrate
            // 
            this.tb_baudrate.Location = new System.Drawing.Point(188, 40);
            this.tb_baudrate.Name = "tb_baudrate";
            this.tb_baudrate.Size = new System.Drawing.Size(34, 21);
            this.tb_baudrate.TabIndex = 111;
            this.tb_baudrate.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 110;
            this.label2.Text = "波特率：";
            // 
            // tb_port_numbere
            // 
            this.tb_port_numbere.Location = new System.Drawing.Point(89, 40);
            this.tb_port_numbere.Name = "tb_port_numbere";
            this.tb_port_numbere.Size = new System.Drawing.Size(34, 21);
            this.tb_port_numbere.TabIndex = 109;
            this.tb_port_numbere.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 108;
            this.label1.Text = "串口号：";
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(471, 39);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(95, 23);
            this.btn_init.TabIndex = 107;
            this.btn_init.Text = "初始化设备";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 22);
            this.statusStrip1.TabIndex = 115;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "数据输模块";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 116;
            this.button1.Text = "开始检测";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "输入通道0：";
            // 
            // tb_channel0
            // 
            this.tb_channel0.Location = new System.Drawing.Point(282, 111);
            this.tb_channel0.Name = "tb_channel0";
            this.tb_channel0.Size = new System.Drawing.Size(53, 21);
            this.tb_channel0.TabIndex = 118;
            // 
            // tb_channel1
            // 
            this.tb_channel1.Location = new System.Drawing.Point(282, 144);
            this.tb_channel1.Name = "tb_channel1";
            this.tb_channel1.Size = new System.Drawing.Size(53, 21);
            this.tb_channel1.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 119;
            this.label5.Text = "输入通道1：";
            // 
            // tb_channel2
            // 
            this.tb_channel2.Location = new System.Drawing.Point(282, 177);
            this.tb_channel2.Name = "tb_channel2";
            this.tb_channel2.Size = new System.Drawing.Size(53, 21);
            this.tb_channel2.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 121;
            this.label6.Text = "输入通道2：";
            // 
            // tb_channel3
            // 
            this.tb_channel3.Location = new System.Drawing.Point(282, 210);
            this.tb_channel3.Name = "tb_channel3";
            this.tb_channel3.Size = new System.Drawing.Size(53, 21);
            this.tb_channel3.TabIndex = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 123;
            this.label7.Text = "输入通道3：";
            // 
            // tb_channel4
            // 
            this.tb_channel4.Location = new System.Drawing.Point(282, 243);
            this.tb_channel4.Name = "tb_channel4";
            this.tb_channel4.Size = new System.Drawing.Size(53, 21);
            this.tb_channel4.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 125;
            this.label8.Text = "输入通道4：";
            // 
            // tb_channel5
            // 
            this.tb_channel5.Location = new System.Drawing.Point(282, 276);
            this.tb_channel5.Name = "tb_channel5";
            this.tb_channel5.Size = new System.Drawing.Size(53, 21);
            this.tb_channel5.TabIndex = 128;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 127;
            this.label9.Text = "输入通道5：";
            // 
            // tb_channel6
            // 
            this.tb_channel6.Location = new System.Drawing.Point(282, 309);
            this.tb_channel6.Name = "tb_channel6";
            this.tb_channel6.Size = new System.Drawing.Size(53, 21);
            this.tb_channel6.TabIndex = 130;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 129;
            this.label10.Text = "输入通道6：";
            // 
            // tb_channel7
            // 
            this.tb_channel7.Location = new System.Drawing.Point(282, 342);
            this.tb_channel7.Name = "tb_channel7";
            this.tb_channel7.Size = new System.Drawing.Size(53, 21);
            this.tb_channel7.TabIndex = 132;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 131;
            this.label11.Text = "输入通道7：";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_dam_3011D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 449);
            this.Controls.Add(this.tb_channel7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_channel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_channel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_channel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_channel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_channel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_channel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_channel0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_baudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_port_numbere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_init);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_dam_3011D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dam_3011D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_dam_3011D_FormClosing);
            this.Load += new System.EventHandler(this.Form_dam_3011D_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_port_numbere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_channel0;
        private System.Windows.Forms.TextBox tb_channel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_channel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_channel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_channel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_channel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_channel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_channel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
    }
}