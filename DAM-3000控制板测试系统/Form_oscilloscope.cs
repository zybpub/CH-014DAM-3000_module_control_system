using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_oscilloscope : Form
    {
        public Form_oscilloscope()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), tb_cmd.Text.Trim()+"\n") + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), "*IDN?\n") + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), "*RST\n") + "\r\n";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_received.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), ":BEEP:ACTion\n") + "\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), ":RUN\n") + "\r\n";
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tb_received.Text += myvisa32.cmdsend(tb_addr.Text.Trim(), ":STOP\n") + "\r\n";
        }
    }
}
