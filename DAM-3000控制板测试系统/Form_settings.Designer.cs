namespace 控制板测试
{
    partial class Form_settings
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
            this.条码扫描枪 = new System.Windows.Forms.GroupBox();
            this.tb_stopbit = new System.Windows.Forms.TextBox();
            this.tb_databits = new System.Windows.Forms.TextBox();
            this.cmb_Verify = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBauteRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.条码扫描枪.SuspendLayout();
            this.SuspendLayout();
            // 
            // 条码扫描枪
            // 
            this.条码扫描枪.Controls.Add(this.tb_stopbit);
            this.条码扫描枪.Controls.Add(this.tb_databits);
            this.条码扫描枪.Controls.Add(this.cmb_Verify);
            this.条码扫描枪.Controls.Add(this.label5);
            this.条码扫描枪.Controls.Add(this.label4);
            this.条码扫描枪.Controls.Add(this.label3);
            this.条码扫描枪.Controls.Add(this.cmbBauteRate);
            this.条码扫描枪.Controls.Add(this.label2);
            this.条码扫描枪.Controls.Add(this.cmbPortName);
            this.条码扫描枪.Controls.Add(this.label1);
            this.条码扫描枪.Location = new System.Drawing.Point(23, 33);
            this.条码扫描枪.Name = "条码扫描枪";
            this.条码扫描枪.Size = new System.Drawing.Size(311, 239);
            this.条码扫描枪.TabIndex = 1;
            this.条码扫描枪.TabStop = false;
            this.条码扫描枪.Text = "条码扫描枪";
            this.条码扫描枪.Enter += new System.EventHandler(this.条码扫描枪_Enter);
            // 
            // tb_stopbit
            // 
            this.tb_stopbit.Location = new System.Drawing.Point(114, 148);
            this.tb_stopbit.Name = "tb_stopbit";
            this.tb_stopbit.Size = new System.Drawing.Size(76, 21);
            this.tb_stopbit.TabIndex = 9;
            this.tb_stopbit.Text = "1";
            // 
            // tb_databits
            // 
            this.tb_databits.Location = new System.Drawing.Point(114, 115);
            this.tb_databits.Name = "tb_databits";
            this.tb_databits.Size = new System.Drawing.Size(76, 21);
            this.tb_databits.TabIndex = 8;
            this.tb_databits.Text = "8";
            // 
            // cmb_Verify
            // 
            this.cmb_Verify.FormattingEnabled = true;
            this.cmb_Verify.Items.AddRange(new object[] {
            "无校验",
            "奇校验",
            "偶校验"});
            this.cmb_Verify.Location = new System.Drawing.Point(121, 189);
            this.cmb_Verify.Name = "cmb_Verify";
            this.cmb_Verify.Size = new System.Drawing.Size(101, 20);
            this.cmb_Verify.TabIndex = 7;
            this.cmb_Verify.Text = "无校验";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "校验方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "停止位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位：";
            // 
            // cmbBauteRate
            // 
            this.cmbBauteRate.FormattingEnabled = true;
            this.cmbBauteRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBauteRate.Location = new System.Drawing.Point(110, 75);
            this.cmbBauteRate.Name = "cmbBauteRate";
            this.cmbBauteRate.Size = new System.Drawing.Size(101, 20);
            this.cmbBauteRate.TabIndex = 3;
            this.cmbBauteRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率：";
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(113, 31);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(135, 20);
            this.cmbPortName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.条码扫描枪);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_settings";
            this.Load += new System.EventHandler(this.Form_settings_Load);
            this.条码扫描枪.ResumeLayout(false);
            this.条码扫描枪.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 条码扫描枪;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_stopbit;
        private System.Windows.Forms.TextBox tb_databits;
        private System.Windows.Forms.ComboBox cmb_Verify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBauteRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}