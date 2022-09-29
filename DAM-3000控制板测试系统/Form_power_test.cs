using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_power_test : Form
    {
        public Form_power_test()
        {
            InitializeComponent();
            this.Height = 450;
        }

        private void power_test_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("IT6833.txt");
                tb_port_numbere.Text = sr.ReadLine();
                tb_baudrate.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)    //当前为打开，则进行关闭处理
                {
                    serialPort1.Close();
                    btn_start.Text = "&O打开端口";
                    toolStripStatusLabel1.Text = "端口已关闭";
                }
                else     //当前为关闭，则进行打开处理
                {

                    btn_start.Text = "&C关闭端口";
                    toolStripStatusLabel1.Text = "端口已打开";
                    serialPort1.PortName = tb_port_numbere.Text;
                    serialPort1.Open();
                }
            }
            catch (Exception er)
            {
                toolStripStatusLabel1.Text = "端口打开失败！" + er.Message;

            }

        }

        private void btn_poweron_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                string str_power_on = "AA 09 21 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 D5";
                byte[] byte_power_on = Crc.HexStringToByteArray(str_power_on);
                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }
        private void btn_poweroff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen==true)
            {
                string str_power_on = "AA 09 21 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 D4";
                byte[] byte_power_on = Crc.HexStringToByteArray(str_power_on);
                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }

        private void btn_panel_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {

                string str_power_on = "AA 09 20 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 D3";

                byte[] byte_power_on = Crc.HexStringToByteArray(str_power_on);

                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }

        private void btn_remote_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                
                string str_power_on = "AA 09 20 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 D4";

                byte[] byte_power_on = Crc.HexStringToByteArray(str_power_on);

                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
           else
            {
                MessageBox.Show("请先打开端口!");
            }
        }

        private void btn_cmd_send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {

                lb_crc.Text = Crc.CSCheck(tb_str.Text);
                string str_com = tb_str.Text.Trim() + " " + Crc.CSCheck(tb_str.Text);

                byte[] byte_power_on = Crc.HexStringToByteArray(str_com);

                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }

        private void power_test_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)    //当前为打开，则进行关闭处理
            {
                serialPort1.Close();
            }
        }

        byte[] buffer = new Byte[26];   //创建缓冲区


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Invoke
             (new EventHandler
               (delegate
               {
                   serialPort1.Read(buffer, 0, 26);
                   tb_received.Text += Crc.byteToHexStr(buffer);
                   string result = tb_received.Text.Substring(6, 1);

                   tb_received.Text += result;
                   switch (result)
                   {
                       case "9":
                           tb_received.Text += "(校验和出错)\r\n";
                           break;
                       case "A":
                           tb_received.Text += "(参数错误)\r\n";
                           break;
                       case "B":
                           tb_received.Text += "(命令不能被执行)\r\n";
                           break;
                       case "C":
                           tb_received.Text += "(命令无效)\r\n";
                           break;
                       case "8":
                           tb_received.Text += "(正确执行)\r\n";
                           break;


                   }
               }
               )
              );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Height == 700)
                this.Height = 450;
            else this.Height = 700;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_received.Clear();
        }

        private void btn_33_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                

                string cmd = "AA 09 23 E4 0C 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

                cmd += " " + Crc.CSCheck(cmd);

               // cmd += " " + "C6";

                byte[] byte_power_on = Crc.HexStringToByteArray(cmd);

                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {

                string cmd = "AA 09 23 88 13 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

                cmd += " " + Crc.CSCheck(cmd);

                //cmd += " " + "71";

                byte[] byte_power_on = Crc.HexStringToByteArray(cmd);

                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                // 1200=
                string cmd = "AA 09 23 E0 2E 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

                cmd += " " + Crc.CSCheck(cmd);

                byte[] byte_power_on = Crc.HexStringToByteArray(cmd);

                serialPort1.Write(byte_power_on, 0, byte_power_on.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }

        private void btn_vol_set_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                string cmd = "AA 09 23 "+ decimal2hex((Convert.ToDouble(tb_vol.Text) * 1000).ToString()) 
                    + " 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ";
                cmd += Crc.CSCheck(cmd);
                lb_crc.Text = cmd;
                byte[] bytes_tosend = Crc.HexStringToByteArray(cmd);
                serialPort1.Write(bytes_tosend, 0, bytes_tosend.Length);
            }
            else
            {
                MessageBox.Show("请先打开端口!");
            }
        }


        public string decimal2hex(string str)
        {
          char[] hex=   (Convert.ToInt16(str)).ToString("X8").ToCharArray();
            return hex[6].ToString() + hex[7].ToString()+" "
                 + hex[4].ToString() + hex[5].ToString() + " "
                 + hex[2].ToString() + hex[3].ToString() + " "
                 + hex[0].ToString() + hex[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = decimal2hex((Convert.ToDecimal(tb_vol.Text) * 100).ToString())+ " 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ";
           cmd += Crc.CSCheck(cmd);
            lb_crc.Text = cmd;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("IT6833.txt");
            sw.WriteLine(tb_port_numbere.Text);
            sw.WriteLine(tb_baudrate.Text);
            sw.Close();
            MessageBox.Show("保存成功!");
        }
    }
}

