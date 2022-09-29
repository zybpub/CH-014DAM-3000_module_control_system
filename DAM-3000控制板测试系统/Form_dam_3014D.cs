using Sys;
using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_dam_3014D : Form
    {

        IntPtr hDevice;               // 设备句柄
        Int32 lDeviceID = 1;             // 设备地址
        Int32[] lADBuffer = new Int32[8];          // 采集数据缓冲区
        Int32 lCOMID = 1;                // 串口
        Int32 lBaud = 3;                 // 波特率
        Boolean bRet = false;
        bool flag_device_inited = false;

        public Form_dam_3014D()
        {
            InitializeComponent();
        }

        private void Form_dam_3014D_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("3014D.txt");
                tb_port_numbere.Text = sr.ReadLine();
                tb_baudrate.Text = sr.ReadLine();
                tb_addr.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("3014D.txt");
            sw.WriteLine(tb_port_numbere.Text);
            sw.WriteLine(tb_baudrate.Text);
            sw.WriteLine(tb_addr.Text);
            sw.Close();
            MessageBox.Show("保存成功!");
            }
            catch { }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                try
                {
                    lCOMID = Convert.ToInt16(tb_port_numbere.Text);
                    lBaud = Convert.ToInt32(tb_baudrate.Text);
                    lDeviceID = Convert.ToInt32(tb_addr.Text);
                    hDevice = Sys.DAM3000M.DAM3000M_CreateDevice(lCOMID);         // 创建设备

                    bRet = DAM3000M.DAM3000M_InitDevice(hDevice, lBaud, DAM3000M.DAM3000M_PARITY_NONE, 500) > 0;   // 初始化设备
                    if (!bRet)
                    {
                        toolStripStatusLabel1.Text = "初始化失败！";
                        return;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "初始化成功！";
                        flag_device_inited = true;
                    }
                }
                catch
                {

                }
            }
        }

        private void Form_dam_3014D_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DAM3000M.DAM3000M_ReleaseDevice(hDevice);
            }
            catch
            {

            }
        }

        Byte[] bDOSts = new Byte[16];
        UInt16 wDOValue;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }

            try
            {
                wDOValue = Convert.ToUInt16(tb_dovalue.Text);
                bDOSts[0] = Convert.ToByte((wDOValue & 0X1) >> 0);
                bDOSts[1] = Convert.ToByte((wDOValue & 0X2) >> 1);
                bDOSts[2] = Convert.ToByte((wDOValue & 0X4) >> 2);
                bDOSts[3] = Convert.ToByte((wDOValue & 0X8) >> 3);
                bDOSts[4] = Convert.ToByte((wDOValue & 0X10) >> 4);
                bDOSts[5] = Convert.ToByte((wDOValue & 0X20) >> 5);
                bDOSts[6] = Convert.ToByte((wDOValue & 0X40) >> 6);
                bDOSts[7] = Convert.ToByte((wDOValue & 0X80) >> 7);
                bDOSts[8] = Convert.ToByte((wDOValue & 0X100) >> 8);
                bDOSts[9] = Convert.ToByte((wDOValue & 0X200) >> 9);
                bDOSts[10] = Convert.ToByte((wDOValue & 0X400) >> 10);
                bDOSts[11] = Convert.ToByte((wDOValue & 0X800) >> 11);
                bDOSts[12] = Convert.ToByte((wDOValue & 0X1000) >> 12);
                bDOSts[13] = Convert.ToByte((wDOValue & 0X2000) >> 13);
                bDOSts[14] = Convert.ToByte((wDOValue & 0X4000) >> 14);
                bDOSts[15] = Convert.ToByte((wDOValue & 0X8000) >> 15);


                DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
            }
            catch
            {

               
            }  
         
        }

        private void btn_open0_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[0] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close0_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[0] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open1_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[1] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open2_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[2] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open3_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[3] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open4_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[4] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open5_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[5] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open6_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[6] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open7_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[7] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_open8_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[8] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[1] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[2] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close3_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[3] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close4_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[4] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close5_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[5] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close6_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[6] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close7_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[7] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void btn_close8_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[8] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[9] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[10] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[11] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[12] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[13] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[14] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[15] = 1;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[9] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[10] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[11] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[12] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[13] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[14] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            bDOSts[15] = 0;
            DAM3000M.DAM3000M_SetDeviceDO(hDevice, lDeviceID, bDOSts, 0, 15);
        }
    }
}
