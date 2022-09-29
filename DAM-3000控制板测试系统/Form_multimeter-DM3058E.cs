using System;
using System.Windows.Forms;

namespace 控制板测试
{
    public partial class Form_DM3058E : Form
    {
        string addr = "USB0::0x1AB1::0x09C4::DM3R190900246::INSTR";
        string meas_type = ":MEASure:VOLTage:DC ?\n"; //默认测直流
        public Form_DM3058E()
        {
            InitializeComponent();
        }

        /*   表 3-4 直流电压量程及其分辨率
            参数  量程 分辨率
            0  200 mV  100 nV
            1  2 V  1 μV
            2  20 V  10 μV
            3  200 V  100 μV
            4  1000 V  1 mV
            MIN  200 mV  100 nV
            MAX  1000 V  1 mV
            DEF  20 V  10 μV
            */
        private void button23_Click(object sender, EventArgs e) //DV 20mV
        {
            myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC 0\n");
            meas_type = ":MEASure:VOLTage:DC?\n";
        }

        private void button5_Click(object sender, EventArgs e) //DV 2V
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC 1\n");
            meas_type = ":MEASure:VOLTage:DC?\n";
        }
        private void button7_Click(object sender, EventArgs e) //DV 20V
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC 2\n");
            meas_type = ":MEASure:VOLTage:DC ?\n";
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC ?\n");
        }
        private void button8_Click(object sender, EventArgs e) //DV 200V
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC 3\n");
            meas_type = ":MEASure:VOLTage:DC?\n";
        }

        private void button9_Click(object sender, EventArgs e) //DV 1000V
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC 4\n");
            meas_type = ":MEASure:VOLTage:DC?\n";
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            // timer1.Enabled = true;
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:DC ?\n");
        }



        /*
            表 3-5 交流电压量程
            参数  量程
            0  200 mV
            1  2 V
            2  20 V
            3  200 V
            4  750 V
            MIN  200 mV
            MAX  750 V
            DEF  20 V
           
            */
        private void button28_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:AC 0\n");
            meas_type = ":MEASure:VOLTage:AC?\n";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:AC 1\n");
            meas_type = ":MEASure:VOLTage:AC?\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:AC 2\n");
            meas_type = ":MEASure:VOLTage:AC?\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:AC 3\n");
            meas_type = ":MEASure:VOLTage:AC?\n";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:VOLTage:AC 4\n");
            meas_type = ":MEASure:VOLTage:AC?\n";
        }

        /*
                表 3-9 电容量程
                参数  量程
                0  2 nF
                1  20 nF
                2  200 nF
                3  2 μF
                4  200 μF
                5  10000 μF
                MIN  2 nF
                MAX  10000 μF
                DEF  200 nF
            */
        private void button34_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CAPacitance 0\n");
            meas_type = ":MEASure:CAPacitance ?\n";
           
        }
        private void button35_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CAPacitance 1\n");
            meas_type = ":MEASure:CAPacitance ?\n";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CAPacitance 2\n");
            meas_type = ":MEASure:CAPacitance ?\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CAPacitance 3\n");
            meas_type = ":MEASure:CAPacitance ?\n";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CAPacitance 4\n");
            meas_type = ":MEASure:CAPacitance ?\n";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CAPacitance 5\n");
            meas_type = ":MEASure:CAPacitance ?\n";
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( myvisa32.cmdsend(addr, ":MEASure?\n") == "TRUE")
            {
                tb_result.Text = myvisa32.cmdsend(addr, meas_type);
            }
            count++;
            tb_result.Text =count.ToString()+ myvisa32.cmdsend(addr, meas_type);
        }

        private void btn_manu_Click(object sender, EventArgs e)
        {
            myvisa32.cmdsend(addr, ":MEASure MANU\n");
            
        }

        private void btn_auto_Click(object sender, EventArgs e)
        {
            myvisa32.cmdsend(addr, ":MEASure AUTO\n");
        }

 

        /*

            表 3-6 直流电流量程及对应分辨率
            参数  电 流 挡  分辨率
            0  200 μA  1 nA
            1  2 mA  10 nA
            2  20 mA  100 nA
            3  200 mA  1 μA
            4  2 A  10 μA

        */
        private void button15_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:DC 0\n");
            meas_type = ":MEASure:CURRent:DC?\n";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:DC 1\n");
            meas_type = ":MEASure:CURRent:DC?\n";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:DC 2\n");
            meas_type = ":MEASure:CURRent:DC?\n";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:DC 3\n");
            meas_type = ":MEASure:CURRent:DC?\n";
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:DC 4\n");
            meas_type = ":MEASure:CURRent:DC?\n";
        }

        /*
            表 3-7 交流电流量程
            参数  量程
            0  20 mA
            1  200 mA
            2  2 A
            3  10 A
            MIN  20 mA
            MAX  10 A
            DEF  200 mA
            */
        private void button20_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:AC 0\n");
            meas_type = ":MEASure:CURRent:AC?\n";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:AC 1\n");
            meas_type = ":MEASure:CURRent:AC?\n";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:AC 2\n");
            meas_type = ":MEASure:CURRent:AC?\n";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:CURRent:AC 3\n");
            meas_type = ":MEASure:CURRent:AC?\n";
        }

        /*
            表 3-8 二线电阻测量量程
            参数  量程
            0  200 Ω
            1  2 kΩ
            2  20 kΩ
            3  200 kΩ
            4  1 MΩ
            5  10 MΩ
            6  100 MΩ
            MAX  100 MΩ
            MIN  200 Ω
            DEF  200 kΩ
            */
        private void button25_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 0\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 1\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 2\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 3\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 4\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 5\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure: RESistance 6\n");
            meas_type = ":MEASure: RESistance?\n";
        }

        /*
         频率测量范围：   20Hz~1MHz 参数同交流测量
           
            表 3-5 交流电压量程
            参数  量程
            0  200 mV
            1  2 V
            2  20 V
            3  200 V
            4  750 V
            MIN  200 mV
            MAX  750 V
            DEF  20 V
           
            */

        private void button40_Click(object sender, EventArgs e)
        {

            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:FREQuency 0\n");
            meas_type = ":MEASure:FREQuency?\n";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:FREQuency 1\n");
            meas_type = ":MEASure:FREQuency?\n";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:FREQuency 2\n");
            meas_type = ":MEASure:FREQuency?\n";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:FREQuency 3\n");
            meas_type = ":MEASure:FREQuency?\n";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:FREQuency 4\n");
            meas_type = ":MEASure:FREQuency?\n";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            myvisa32.cmdsend(addr, ":MEASure: CONTinuity 1000\n");
            meas_type = ":MEASure:CONTinuity?\n";

        }
        private void button18_Click(object sender, EventArgs e)
        {
            tb_result.Text = myvisa32.cmdsend(addr, ":MEASure:DIODe ?\n");
            meas_type = ":MEASure:DIODe?\n";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("dm3058e.txt");
                sw.WriteLine(tb_addr.Text);
                sw.Close();
                MessageBox.Show("保存成功!");
            }
            catch { }
        }

        private void Form_DM3058E_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("dm3058e.txt");
                tb_addr.Text = sr.ReadLine();
                sr.Close();
            }
            catch { }
        }
    }
}
