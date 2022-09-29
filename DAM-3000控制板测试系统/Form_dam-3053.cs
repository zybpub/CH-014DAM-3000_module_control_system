using Sys;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 控制板测试
{

    public partial class Form_dam_3053 : Form
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();
        [DllImport("msvcrt.dll")]
        public static extern int _kbhit();
        public Form_dam_3053()
        {
            InitializeComponent();
        }

        IntPtr hDevice;               // 设备句柄
        Int32 lDeviceID = 0;             // 设备地址
        Int32[] lADBuffer = new Int32[8];          // 采集数据缓冲区
        Int32 lCOMID = 1;                // 串口
        Int32 lBaud = 3;                 // 波特率
        Boolean bRet = false;
        Int32 lMode;
       // Int32 lChannel;

        bool flag_device_inited = false;
        bool flag_mode_set = false;
        private void Form_dam_3053_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("3053.txt");
                tb_port_numbere.Text = sr.ReadLine();
                tb_baudrate.Text = sr.ReadLine();
                tb_addr.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("3053.txt");
            sw.WriteLine(tb_port_numbere.Text);
            sw.WriteLine(tb_baudrate.Text);
            sw.WriteLine(tb_addr.Text);
            sw.Close();
            MessageBox.Show("保存成功!");
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false) { 
            //1
            lCOMID = Convert.ToInt16(tb_port_numbere.Text);
            //2
            lBaud = Convert.ToInt32(tb_baudrate.Text);
            //3
            lDeviceID = Convert.ToInt32(tb_addr.Text);
            //4
            hDevice = DAM3000M.DAM3000M_CreateDevice(lCOMID);         // 创建设备

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
                mode_read();
            }
            }
        }



        private void mode_read()
        {
            if (flag_device_inited == false) btn_init_Click(null, null);

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 0);
            tb_mode0.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 1);
            tb_mode1.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 2);
            tb_mode2.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 3);
            tb_mode3.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 4);
            tb_mode4.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 5);
            tb_mode5.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 6);
            tb_mode6.Text = lMode.ToString();

            DAM3000M.DAM3000M_GetModeAD(hDevice, lDeviceID, ref lMode, 7);
            tb_mode7.Text = lMode.ToString();
        }

        private void btn_data_acq_Click(object sender, EventArgs e)
        {

            //if (flag_mode_set == false) mode_set();
            if (flag_device_inited == false)
            {
                btn_init_Click(null, null);
                if (toolStripStatusLabel1.Text == "初始化失败！")
                {
                    return;
                }
            }

            timer1_Tick(null, null);
            timer1.Interval = Convert.ToInt16(tb_interval.Text) * 1000;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
             bRet = DAM3000M.DAM3000M_ReadDeviceAD(hDevice, lDeviceID, lADBuffer, 8, 0, 7) > 0;   // 采集数据
            if (bRet)
            {
                Invoke
                      (new EventHandler
                        (delegate
                        {
                            UInt16 Lsb0 = ((UInt16)lADBuffer[0]);
                            UInt16 Lsb1 = ((UInt16)lADBuffer[1]);
                            UInt16 Lsb2 = ((UInt16)lADBuffer[2]);
                            UInt16 Lsb3 = ((UInt16)lADBuffer[3]);
                            UInt16 Lsb4 = ((UInt16)lADBuffer[4]);
                            UInt16 Lsb5 = ((UInt16)lADBuffer[5]);
                            UInt16 Lsb6 = ((UInt16)lADBuffer[6]);
                            UInt16 Lsb7 = ((UInt16)lADBuffer[7]);
                            tb_result0.Text = (((float)Lsb0 / 0xFFFF) * 20 - 10).ToString();
                            tb_result1.Text = (((float)Lsb1 / 0xFFFF) * 20 - 10).ToString();
                            tb_result2.Text = (((float)Lsb2 / 0xFFFF) * 20 - 10).ToString();
                            tb_result3.Text = (((float)Lsb3 / 0xFFFF) * 20 - 10).ToString();
                            tb_result4.Text = (((float)Lsb4 / 0xFFFF) * 20 - 10).ToString();
                            tb_result5.Text = (((float)Lsb5 / 0xFFFF) * 60 - 30).ToString();
                            tb_result6.Text = (((float)Lsb6 / 0xFFFF) * 20 - 10).ToString();
                            tb_result7.Text = (((float)Lsb7 / 0xFFFF) * 20 - 10).ToString();
                        }
                        )
                       );
            }
        }

        private void Form_dam_3053_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            if (hDevice!=null)
            {
                try
                {
                    DAM3000M.DAM3000M_ReleaseDevice(hDevice);

                }
                catch { }
                
            }
        }

        private void btn_mode_set_Click(object sender, EventArgs e)
        {
            if (tb_mode0.Text.Trim() == "" || tb_mode1.Text.Trim() == "" || tb_mode2.Text.Trim() == "" || tb_mode3.Text.Trim() == ""
                || tb_mode4.Text.Trim() == "" || tb_mode5.Text.Trim() == "" || tb_mode6.Text.Trim() == "" || tb_mode7.Text.Trim() == "")
            {
                MessageBox.Show("模式不能设置为空，可以先读取原设置值！");
                return;
            }
            mode_set();
            MessageBox.Show("设置完成！");
        }

        private void mode_set()
        {
            if (flag_device_inited == false) btn_init_Click(null, null);

            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode0.Text), 0);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode1.Text), 1);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode2.Text), 2);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode3.Text), 3);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode4.Text), 4);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode5.Text), 5);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode6.Text), 6);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode7.Text), 7);
            flag_mode_set = true;
        }
        private void btn_mode_read_Click(object sender, EventArgs e)
        {
            mode_read();
            MessageBox.Show("读取完成！");
        }

        private void btn_mode_all_Click(object sender, EventArgs e)
        {
            if (flag_device_inited == false) btn_init_Click(null, null);

            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 0);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 1);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 2);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 3);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 4);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 5);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 6);
            DAM3000M.DAM3000M_SetModeAD(hDevice, lDeviceID, Convert.ToInt32(tb_mode_all.Text), 7);
        }
     
    }
}


/*
0: 0～10mA 
1:  -15～+15mV
2: -50～+50mV
3: -100～+100mV
4: -150～+150m
5: -500～+500mV
6: -1～+1V
7: -2.5～+2.5V
8: -5～+5V
9: -10～+10V
D: 0～+5V
E: 0～+10V
F:  0～+2.5V
A: -20～+20mA
B: 0～20mA
C: 4～20mA
80: 0～22mA
10: J型热电偶   0～1200℃
11: K型热电偶   0～1300℃
12: T型热电偶-200～400℃
13: E型热电偶   0～1000℃
14: R型热电偶 500～1700℃
15: S型热电偶 500～1768℃
16: B型热电偶 500～1800℃
17: N型热电偶   0～1300℃
18: C型热电偶   0～2090℃
19: 钨铼5-钨铼26 0～2310℃
20: Pt100(385)热电阻 -200℃～850℃
21: Pt100(385)热电阻 -100℃～100℃
22: Pt100(385)热电阻    0℃～100℃
23: Pt100(385)热电阻    0℃～200℃
24: Pt100(385)热电阻    0℃～600℃
25: Pt100(3916)热电阻-200℃～850℃
26: Pt100(3916)热电阻-100℃～100℃
27: Pt100(3916)热电阻   0℃～100℃
28: Pt100(3916)热电阻   0℃～200℃
29: Pt100(3916)热电阻   0℃～600℃
30:  Pt1000热电阻     -200℃～850℃
40: Cu50热电阻        -50℃～150℃
41: Cu100热电阻       -50℃～150℃
42: BA1热电阻        -200℃～650℃
43: BA2热电阻        -200℃～650℃
44: G53热电阻         -50℃～150℃
45: Ni50热电阻        100℃
46: Ni508热电阻         0℃～100℃
47: Ni1000热电阻      -60℃～160℃


83:-30~30V
84:0-30V
85:-10A~10A
86:0~10A

*/
