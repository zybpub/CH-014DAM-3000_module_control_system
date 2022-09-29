using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_settings : Form
    {
        public Form_settings()
        {
            InitializeComponent();
        }

        private void Form_settings_Load(object sender, EventArgs e)
        {

            foreach (string com in System.IO.Ports.SerialPort.GetPortNames()) //自动获取串行口名称
            cmbPortName.Items.Add(com);
            cmbPortName.SelectedIndex = 0;

            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("barcode.txt");
                cmbPortName.Text = sr.ReadLine();
                cmbBauteRate.Text = sr.ReadLine();
                tb_databits.Text = sr.ReadLine();
                tb_stopbit.Text = sr.ReadLine();
                cmb_Verify.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("barcode.txt");
                sw.WriteLine(cmbPortName.Text);
                sw.WriteLine(cmbBauteRate.Text);
                sw.WriteLine(tb_databits.Text);

                sw.WriteLine(tb_stopbit.Text);
                sw.WriteLine(cmb_Verify.Text);
                
                sw.Close();
                MessageBox.Show("保存成功!");
            }
            catch { }
        }

        private void 条码扫描枪_Enter(object sender, EventArgs e)
        {

        }
    }
}
