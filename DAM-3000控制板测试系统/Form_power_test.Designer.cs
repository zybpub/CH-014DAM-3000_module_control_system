namespace 控制板测试
{
    partial class Form_power_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_power_test));
            this.btn_start = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_poweron = new System.Windows.Forms.Button();
            this.btn_poweroff = new System.Windows.Forms.Button();
            this.tb_str = new System.Windows.Forms.TextBox();
            this.btn_panel = new System.Windows.Forms.Button();
            this.btn_remote = new System.Windows.Forms.Button();
            this.btn_cmd_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_received = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_crc = new System.Windows.Forms.Label();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_33 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vol = new System.Windows.Forms.TextBox();
            this.btn_vol_set = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_baudrate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_port_numbere = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(435, 16);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(81, 22);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "打开端口";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_poweron
            // 
            this.btn_poweron.Location = new System.Drawing.Point(41, 74);
            this.btn_poweron.Name = "btn_poweron";
            this.btn_poweron.Size = new System.Drawing.Size(65, 34);
            this.btn_poweron.TabIndex = 2;
            this.btn_poweron.Text = "电源开";
            this.btn_poweron.UseVisualStyleBackColor = true;
            this.btn_poweron.Click += new System.EventHandler(this.btn_poweron_Click);
            // 
            // btn_poweroff
            // 
            this.btn_poweroff.Location = new System.Drawing.Point(114, 74);
            this.btn_poweroff.Name = "btn_poweroff";
            this.btn_poweroff.Size = new System.Drawing.Size(61, 34);
            this.btn_poweroff.TabIndex = 3;
            this.btn_poweroff.Text = "电源关";
            this.btn_poweroff.UseVisualStyleBackColor = true;
            this.btn_poweroff.Click += new System.EventHandler(this.btn_poweroff_Click);
            // 
            // tb_str
            // 
            this.tb_str.Location = new System.Drawing.Point(38, 120);
            this.tb_str.Name = "tb_str";
            this.tb_str.Size = new System.Drawing.Size(486, 21);
            this.tb_str.TabIndex = 6;
            this.tb_str.Text = "AA 09 21 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";
            // 
            // btn_panel
            // 
            this.btn_panel.Location = new System.Drawing.Point(634, 15);
            this.btn_panel.Name = "btn_panel";
            this.btn_panel.Size = new System.Drawing.Size(75, 23);
            this.btn_panel.TabIndex = 9;
            this.btn_panel.Text = "面板操作";
            this.btn_panel.UseVisualStyleBackColor = true;
            this.btn_panel.Click += new System.EventHandler(this.btn_panel_Click);
            // 
            // btn_remote
            // 
            this.btn_remote.Location = new System.Drawing.Point(534, 15);
            this.btn_remote.Name = "btn_remote";
            this.btn_remote.Size = new System.Drawing.Size(75, 23);
            this.btn_remote.TabIndex = 10;
            this.btn_remote.Text = "远程操作";
            this.btn_remote.UseVisualStyleBackColor = true;
            this.btn_remote.Click += new System.EventHandler(this.btn_remote_Click);
            // 
            // btn_cmd_send
            // 
            this.btn_cmd_send.Location = new System.Drawing.Point(38, 158);
            this.btn_cmd_send.Name = "btn_cmd_send";
            this.btn_cmd_send.Size = new System.Drawing.Size(68, 27);
            this.btn_cmd_send.TabIndex = 12;
            this.btn_cmd_send.Text = "发送指令";
            this.btn_cmd_send.UseVisualStyleBackColor = true;
            this.btn_cmd_send.Click += new System.EventHandler(this.btn_cmd_send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "在进行控制之前先打开端口，执行远程操作，再进行控制。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "接收数据";
            // 
            // tb_received
            // 
            this.tb_received.Location = new System.Drawing.Point(41, 231);
            this.tb_received.Multiline = true;
            this.tb_received.Name = "tb_received";
            this.tb_received.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_received.Size = new System.Drawing.Size(482, 126);
            this.tb_received.TabIndex = 15;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(435, 208);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(87, 23);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "清除接收数据";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "\r\n ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 419);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(477, 230);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "显示指令参考";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_crc
            // 
            this.lb_crc.AutoSize = true;
            this.lb_crc.Location = new System.Drawing.Point(112, 165);
            this.lb_crc.Name = "lb_crc";
            this.lb_crc.Size = new System.Drawing.Size(53, 12);
            this.lb_crc.TabIndex = 20;
            this.lb_crc.Text = "校验码：";
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(238, 79);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(56, 29);
            this.btn_5.TabIndex = 21;
            this.btn_5.Text = "5V";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_33
            // 
            this.btn_33.Location = new System.Drawing.Point(181, 80);
            this.btn_33.Name = "btn_33";
            this.btn_33.Size = new System.Drawing.Size(51, 26);
            this.btn_33.TabIndex = 22;
            this.btn_33.Text = "3.3V";
            this.btn_33.UseVisualStyleBackColor = true;
            this.btn_33.Click += new System.EventHandler(this.btn_33_Click);
            // 
            // btn_12
            // 
            this.btn_12.Location = new System.Drawing.Point(299, 79);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(51, 26);
            this.btn_12.TabIndex = 23;
            this.btn_12.Text = "12V";
            this.btn_12.UseVisualStyleBackColor = true;
            this.btn_12.Click += new System.EventHandler(this.btn_12_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "自定义：";
            // 
            // tb_vol
            // 
            this.tb_vol.Location = new System.Drawing.Point(425, 82);
            this.tb_vol.Name = "tb_vol";
            this.tb_vol.Size = new System.Drawing.Size(41, 21);
            this.tb_vol.TabIndex = 26;
            this.tb_vol.Text = "10";
            // 
            // btn_vol_set
            // 
            this.btn_vol_set.Location = new System.Drawing.Point(472, 79);
            this.btn_vol_set.Name = "btn_vol_set";
            this.btn_vol_set.Size = new System.Drawing.Size(44, 25);
            this.btn_vol_set.TabIndex = 27;
            this.btn_vol_set.Text = "确定";
            this.btn_vol_set.UseVisualStyleBackColor = true;
            this.btn_vol_set.Click += new System.EventHandler(this.btn_vol_set_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(346, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 21);
            this.btn_save.TabIndex = 104;
            this.btn_save.Text = "保存配置";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_baudrate
            // 
            this.tb_baudrate.Location = new System.Drawing.Point(191, 16);
            this.tb_baudrate.Name = "tb_baudrate";
            this.tb_baudrate.Size = new System.Drawing.Size(34, 21);
            this.tb_baudrate.TabIndex = 101;
            this.tb_baudrate.Text = "9600";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 100;
            this.label8.Text = "波特率：";
            // 
            // tb_port_numbere
            // 
            this.tb_port_numbere.Location = new System.Drawing.Point(92, 16);
            this.tb_port_numbere.Name = "tb_port_numbere";
            this.tb_port_numbere.Size = new System.Drawing.Size(34, 21);
            this.tb_port_numbere.TabIndex = 99;
            this.tb_port_numbere.Text = "COM4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 98;
            this.label9.Text = "串口号：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 22);
            this.statusStrip1.TabIndex = 105;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form_power_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 686);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_baudrate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_port_numbere);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_vol_set);
            this.Controls.Add(this.tb_vol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_33);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.lb_crc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_received);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cmd_send);
            this.Controls.Add(this.btn_remote);
            this.Controls.Add(this.btn_panel);
            this.Controls.Add(this.tb_str);
            this.Controls.Add(this.btn_poweroff);
            this.Controls.Add(this.btn_poweron);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_power_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "直流电源测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.power_test_FormClosing);
            this.Load += new System.EventHandler(this.power_test_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_poweron;
        private System.Windows.Forms.Button btn_poweroff;
        private System.Windows.Forms.TextBox tb_str;
        private System.Windows.Forms.Button btn_panel;
        private System.Windows.Forms.Button btn_remote;
        private System.Windows.Forms.Button btn_cmd_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_received;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_crc;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_33;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vol;
        private System.Windows.Forms.Button btn_vol_set;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_baudrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_port_numbere;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}