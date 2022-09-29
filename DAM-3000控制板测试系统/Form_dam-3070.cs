using Sys;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_dam_3070 : Form
    {

        IntPtr hDevice;               // 设备句柄
        Int32 lDeviceID = 1;             // 设备地址
        Int32[] lADBuffer = new Int32[8];          // 采集数据缓冲区
        Int32 lCOMID = 1;                // 串口
        Int32 lBaud = 3;                 // 波特率
        Boolean bRet = false;
        UInt32 CurrentVal = 10;
        Int32 CurrentFre = 10;
        bool flag_device_inited = false;
        DAM3000M.DAM3000M_PARA_CNT CNTPara0;
        DAM3000M.DAM3000M_PARA_CNT CNTPara1;
       

        [DllImport("msvcrt.dll")]
        public static extern int _getch();
        [DllImport("msvcrt.dll")]
        public static extern int _kbhit();
        public Form_dam_3070()
        {
            InitializeComponent();
        }

        private void Form_dam_3070_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("3070.txt");
                tb_port_numbere.Text = sr.ReadLine();
                tb_baudrate.Text = sr.ReadLine();
                tb_addr.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("3070.txt");
            sw.WriteLine(tb_port_numbere.Text);
            sw.WriteLine(tb_baudrate.Text);
            sw.WriteLine(tb_addr.Text);
            sw.Close();
            MessageBox.Show("保存成功!");
        }

        //初始化设备
        private void btn_init_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false)
            {
                lCOMID = Convert.ToInt16(tb_port_numbere.Text);
                lBaud = Convert.ToInt32(tb_baudrate.Text);
                lDeviceID = Convert.ToInt32(tb_addr.Text);
                hDevice = DAM3000M.DAM3000M_CreateDevice(lCOMID);         // 创建设备

                bRet = DAM3000M.DAM3000M_InitDevice(hDevice, lBaud, DAM3000M.DAM3000M_PARITY_NONE, 500) > 0;   // 初始化设备
                if (!bRet)
                {
                    lb_init_result.Text = "初始化失败！";
                    return;
                }
                else
                {
                    lb_init_result.Text = "初始化成功！";
                    flag_device_inited = true;
                }
            }
        }



        private void btn_data_acq_Click(object sender, EventArgs e)
        {

            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }
            //通道0计数模式
            CNTPara0.WorkMode = DAM3000M.DAM3000M_WORKMODE_CNT;
            CNTPara0.FreqBuildTime = 0;
            CNTPara0.InputMode = DAM3000M.DAM3000M_ISOLATED;
            CNTPara0.InitVal =Convert.ToUInt16(tb_initval0.Text);
            CNTPara0.MaxVal = 4294967295;
            CNTPara0.GateSts = DAM3000M.DAM3000M_GATE_NULL;

            if ((DAM3000M.DAM3000M_SetCounterMode(hDevice, lDeviceID, ref CNTPara0, 0)) != 1)
            {
                toolStripStatusLabel1.Text = "初始化计数器0参数失败!";
                return;
            }
            else {
                toolStripStatusLabel1.Text = "初始化计数器0参数成功!";
            }

            if ((DAM3000M.DAM3000M_StartCounter(hDevice, lDeviceID, 0)) != 1)
            {
                toolStripStatusLabel1.Text = "开始计数0失败!";
                return;
            }
            else {
                toolStripStatusLabel1.Text = "开始计数0成功!";
            }


            //通道1频率数模式
            CNTPara1.WorkMode = DAM3000M.DAM3000M_WORKMODE_FREQ;
            CNTPara1.FreqBuildTime = 1;
            CNTPara1.InputMode = DAM3000M.DAM3000M_ISOLATED;
            CNTPara1.GateSts = DAM3000M.DAM3000M_GATE_NULL;


            if ((DAM3000M.DAM3000M_SetCounterMode(hDevice, lDeviceID, ref CNTPara1, 1)) != 1)
            {
                toolStripStatusLabel1.Text = "初始化计数器1参数失败!";
                return;
            }
            else {
                toolStripStatusLabel1.Text = "初始化计数器1参数成功!";
            }

            if ((DAM3000M.DAM3000M_StartCounter(hDevice, lDeviceID, 1)) != 1)
            {
                toolStripStatusLabel1.Text = "开始计数1失败!";
                return;
            }
            else {
                toolStripStatusLabel1.Text = "开始计数1成功!";
            }

            timer1_Tick(null, null);
            timer1.Interval = Convert.ToInt16(tb_interval.Text) * 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DAM3000M.DAM3000M_GetCounterCurVal(hDevice, lDeviceID, ref CurrentVal, 0);
            Invoke
                  (new EventHandler
                    (delegate
                    {
                        tb_result0.Text = CurrentVal.ToString();
                    }
                    )
                   );

            DAM3000M.DAM3000M_GetFreqCurVal(hDevice, lDeviceID, ref CurrentFre, 1);
            Invoke
                 (new EventHandler
                   (delegate
                   {
                       tb_result1.Text = CurrentFre.ToString();
                   }
                   )
                  );
        }

        private void btn_led0_Click(object sender, EventArgs e)
        {
            DAM3000M.DAM3000M_SetDLedDispChannel(hDevice, lDeviceID, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAM3000M.DAM3000M_SetDLedDispChannel(hDevice, lDeviceID, 1);
        }

        private void Form_dam_3070_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
           try { 
            DAM3000M.DAM3000M_ResetCounter(hDevice, lDeviceID, 0);
            DAM3000M.DAM3000M_StopCounter(hDevice, lDeviceID, 0);
            DAM3000M.DAM3000M_ResetCounter(hDevice, lDeviceID, 1);
            DAM3000M.DAM3000M_StopCounter(hDevice, lDeviceID, 1);
            DAM3000M.DAM3000M_ReleaseDevice(hDevice);
            }
            catch { }
        }
    }
}


