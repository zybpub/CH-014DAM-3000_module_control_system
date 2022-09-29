using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_multimeter : Form
    {
        public Form_multimeter()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
          tb_received.Text+=  myvisa32.cmdsend(tb_addr.Text.Trim(), tb_cmd.Text.Trim()+"\n")+"\r\n";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), "*IDN?\n") + "\r\n";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_received.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), "*RST\n") + "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), "SYSTem:BEEPer;\n") + "\r\n";
        }
    }
}
