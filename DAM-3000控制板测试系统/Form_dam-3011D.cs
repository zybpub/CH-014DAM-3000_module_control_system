using Sys;
using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_dam_3011D : Form
    {
        IntPtr hDevice;               // 设备句柄
        Int32 lDeviceID = 1;             // 设备地址
        Int32[] lADBuffer = new Int32[8];          // 采集数据缓冲区
        Int32 lCOMID = 1;                // 串口
        Int32 lBaud = 3;                 // 波特率
        Boolean bRet = false;
      //  UInt32 CurrentVal = 10;
      //  Int32 CurrentFre = 10;

        bool flag_device_inited = false;
        Byte[] pDIPara = new Byte[32];

        DAM3000M.DAM3000M_PARA_DI DI_Para;


        public Form_dam_3011D()
        {
            InitializeComponent();
        }

        private void Form_dam_3011D_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("3011D.txt");
                tb_port_numbere.Text = sr.ReadLine();
                tb_baudrate.Text = sr.ReadLine();
                tb_addr.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("3011D.txt");
            sw.WriteLine(tb_port_numbere.Text);
            sw.WriteLine(tb_baudrate.Text);
            sw.WriteLine(tb_addr.Text);
            sw.Close();
            MessageBox.Show("保存成功!");
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                lCOMID = Convert.ToInt16(tb_port_numbere.Text);
                lBaud = Convert.ToInt32(tb_baudrate.Text);
                lDeviceID = Convert.ToInt32(tb_addr.Text);
                hDevice = Sys.DAM3000M.DAM3000M_CreateDevice(lCOMID);         // 创建设备

                bRet = Sys.DAM3000M.DAM3000M_InitDevice(hDevice, lBaud, DAM3000M.DAM3000M_PARITY_NONE, 500) > 0;   // 初始化设备
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false) {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            pDIPara[0] = DI_Para.DI0 = 0; pDIPara[1] = DI_Para.DI1 = 0;
            pDIPara[2] = DI_Para.DI2 = 0; pDIPara[3] = DI_Para.DI3 = 0;
            pDIPara[4] = DI_Para.DI4 = 0; pDIPara[5] = DI_Para.DI5 = 0;
            pDIPara[6] = DI_Para.DI6 = 0; pDIPara[7] = DI_Para.DI7 = 0;
            pDIPara[8] = DI_Para.DI8 = 0; pDIPara[9] = DI_Para.DI9 = 0;
            pDIPara[10] = DI_Para.DI10 = 0; pDIPara[11] = DI_Para.DI11 = 0;
            pDIPara[12] = DI_Para.DI12 = 0; pDIPara[13] = DI_Para.DI13 = 0;
            pDIPara[14] = DI_Para.DI14 = 0; pDIPara[15] = DI_Para.DI15 = 0;
            pDIPara[16] = DI_Para.DI16 = 0; pDIPara[17] = DI_Para.DI17 = 0;
            pDIPara[18] = DI_Para.DI18 = 0; pDIPara[19] = DI_Para.DI19 = 0;

            pDIPara[20] = DI_Para.DI20 = 0; pDIPara[21] = DI_Para.DI21 = 0;
            pDIPara[22] = DI_Para.DI22 = 0; pDIPara[23] = DI_Para.DI23 = 0;
            pDIPara[24] = DI_Para.DI24 = 0; pDIPara[25] = DI_Para.DI25 = 0;
            pDIPara[26] = DI_Para.DI26 = 0; pDIPara[27] = DI_Para.DI27 = 0;
            pDIPara[28] = DI_Para.DI28 = 0; pDIPara[29] = DI_Para.DI29 = 0;
            pDIPara[30] = DI_Para.DI30 = 0; pDIPara[31] = DI_Para.DI31 = 0;

            for (int index = 0; index < 8; index++)
            {
                bRet = DAM3000M.DAM3000M_SetModeDI(hDevice, lDeviceID, 0, 0, index) > 0;
            }

            bRet = DAM3000M.DAM3000M_GetDeviceDI(hDevice, lDeviceID, ref DI_Para, 8) > 0;


            tb_channel0.Text = DI_Para.DI0.ToString();
            tb_channel1.Text = DI_Para.DI1.ToString();
            tb_channel2.Text = DI_Para.DI2.ToString();
            tb_channel3.Text = DI_Para.DI3.ToString();
            tb_channel4.Text = DI_Para.DI4.ToString();
            tb_channel5.Text = DI_Para.DI5.ToString();
            tb_channel6.Text = DI_Para.DI6.ToString();
            tb_channel7.Text = DI_Para.DI7.ToString();

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bRet = DAM3000M.DAM3000M_GetDeviceDI(hDevice, lDeviceID, ref DI_Para, 8) > 0;


            tb_channel0.Text = DI_Para.DI0.ToString();
            tb_channel1.Text = DI_Para.DI1.ToString();
            tb_channel2.Text = DI_Para.DI2.ToString();
            tb_channel3.Text = DI_Para.DI3.ToString();
            tb_channel4.Text = DI_Para.DI4.ToString();
            tb_channel5.Text = DI_Para.DI5.ToString();
            tb_channel6.Text = DI_Para.DI6.ToString();
            tb_channel7.Text = DI_Para.DI7.ToString();
        }

        private void Form_dam_3011D_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            try
            {
                DAM3000M.DAM3000M_ReleaseDevice(hDevice);
            }
            catch { }
        }
    }
}
