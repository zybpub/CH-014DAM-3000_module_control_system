namespace 控制板测试
{
    partial class Form_dam_3070
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dam_3070));
            this.label7 = new System.Windows.Forms.Label();
            this.tb_interval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_result0 = new System.Windows.Forms.TextBox();
            this.tb_result1 = new System.Windows.Forms.TextBox();
            this.btn_data_acq = new System.Windows.Forms.Button();
            this.lb_init_result = new System.Windows.Forms.Label();
            this.btn_init = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_baudrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_port_numbere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_initval0 = new System.Windows.Forms.TextBox();
            this.btn_led0 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 86;
            this.label7.Text = "秒";
            // 
            // tb_interval
            // 
            this.tb_interval.Location = new System.Drawing.Point(557, 457);
            this.tb_interval.Name = "tb_interval";
            this.tb_interval.Size = new System.Drawing.Size(47, 21);
            this.tb_interval.TabIndex = 85;
            this.tb_interval.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 84;
            this.label6.Text = "采集间隔时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 69;
            this.label8.Text = "通道模式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 68;
            this.label5.Text = "波特率";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 129);
            this.textBox2.TabIndex = 67;
            this.textBox2.Text = " 0: 1200 bps\r\n 1: 2400 bps\r\n 2: 4800 bps\r\n 3: 9600 bps\r\n 4: 19200 bps\r\n 5: 38400 " +
    "bps\r\n 6: 57600 bps\r\n 7: 115200 bps";
            // 
            // tb_result0
            // 
            this.tb_result0.Location = new System.Drawing.Point(547, 112);
            this.tb_result0.Name = "tb_result0";
            this.tb_result0.Size = new System.Drawing.Size(104, 21);
            this.tb_result0.TabIndex = 59;
            // 
            // tb_result1
            // 
            this.tb_result1.Location = new System.Drawing.Point(547, 154);
            this.tb_result1.Name = "tb_result1";
            this.tb_result1.Size = new System.Drawing.Size(104, 21);
            this.tb_result1.TabIndex = 60;
            // 
            // btn_data_acq
            // 
            this.btn_data_acq.Location = new System.Drawing.Point(557, 81);
            this.btn_data_acq.Name = "btn_data_acq";
            this.btn_data_acq.Size = new System.Drawing.Size(94, 20);
            this.btn_data_acq.TabIndex = 58;
            this.btn_data_acq.Text = "采集数据";
            this.btn_data_acq.UseVisualStyleBackColor = true;
            this.btn_data_acq.Click += new System.EventHandler(this.btn_data_acq_Click);
            // 
            // lb_init_result
            // 
            this.lb_init_result.AutoSize = true;
            this.lb_init_result.Location = new System.Drawing.Point(550, 48);
            this.lb_init_result.Name = "lb_init_result";
            this.lb_init_result.Size = new System.Drawing.Size(0, 12);
            this.lb_init_result.TabIndex = 54;
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(441, 20);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(95, 23);
            this.btn_init.TabIndex = 53;
            this.btn_init.Text = "初始化设备";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(332, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 21);
            this.btn_save.TabIndex = 97;
            this.btn_save.Text = "保存配置";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(271, 21);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(38, 21);
            this.tb_addr.TabIndex = 96;
            this.tb_addr.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 95;
            this.label3.Text = "地址：";
            // 
            // tb_baudrate
            // 
            this.tb_baudrate.Location = new System.Drawing.Point(177, 21);
            this.tb_baudrate.Name = "tb_baudrate";
            this.tb_baudrate.Size = new System.Drawing.Size(34, 21);
            this.tb_baudrate.TabIndex = 94;
            this.tb_baudrate.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 93;
            this.label2.Text = "波特率：";
            // 
            // tb_port_numbere
            // 
            this.tb_port_numbere.Location = new System.Drawing.Point(78, 21);
            this.tb_port_numbere.Name = "tb_port_numbere";
            this.tb_port_numbere.Size = new System.Drawing.Size(34, 21);
            this.tb_port_numbere.TabIndex = 92;
            this.tb_port_numbere.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 91;
            this.label1.Text = "串口号：";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(205, 101);
            this.tb_code.Multiline = true;
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(125, 129);
            this.tb_code.TabIndex = 98;
            this.tb_code.Text = "50:COUNTER\r\n51:FREQUENCY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 99;
            this.label10.Text = "计数器初值：";
            // 
            // tb_initval0
            // 
            this.tb_initval0.Location = new System.Drawing.Point(441, 112);
            this.tb_initval0.Name = "tb_initval0";
            this.tb_initval0.Size = new System.Drawing.Size(82, 21);
            this.tb_initval0.TabIndex = 102;
            this.tb_initval0.Text = "100";
            // 
            // btn_led0
            // 
            this.btn_led0.Location = new System.Drawing.Point(421, 286);
            this.btn_led0.Name = "btn_led0";
            this.btn_led0.Size = new System.Drawing.Size(90, 32);
            this.btn_led0.TabIndex = 104;
            this.btn_led0.Text = "通道0";
            this.btn_led0.UseVisualStyleBackColor = true;
            this.btn_led0.Click += new System.EventHandler(this.btn_led0_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 105;
            this.label12.Text = "LED显示通道：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 106;
            this.button1.Text = "通道1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "计数频率模块";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 108;
            this.label4.Text = "频率：";
            // 
            // Form_dam_3070
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_led0);
            this.Controls.Add(this.tb_initval0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_baudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_port_numbere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_interval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_result0);
            this.Controls.Add(this.tb_result1);
            this.Controls.Add(this.btn_data_acq);
            this.Controls.Add(this.lb_init_result);
            this.Controls.Add(this.btn_init);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_dam_3070";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dam_3070";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_dam_3070_FormClosing);
            this.Load += new System.EventHandler(this.Form_dam_3070_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_interval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tb_result0;
        private System.Windows.Forms.TextBox tb_result1;
        private System.Windows.Forms.Button btn_data_acq;
        private System.Windows.Forms.Label lb_init_result;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_port_numbere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_initval0;
        private System.Windows.Forms.Button btn_led0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
    }
}