using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
//using System.Windows.Forms;

namespace Sys
{
    public partial class DAM3000M
    {

// ********************* 开关量输出的参数结构 ****************************
public struct DAM3000M_PARA_DO			// 数字量输出参数
{
	public Byte DO0;       	// 0通道
	public Byte DO1;       	// 1通道
	public Byte DO2;       	// 2通道
	public Byte DO3;       	// 3通道
	public Byte DO4;       	// 4通道
	public Byte DO5;       	// 5通道
	public Byte DO6;       	// 6通道
	public Byte DO7;       	// 7通道
	public Byte DO8;			// 8通道
	public Byte DO9;			// 9通道
	public Byte DO10;      	// 10通道
	public Byte DO11;      	// 11通道
	public Byte DO12;      	// 12通道
	public Byte DO13;			// 13通道
	public Byte DO14;			// 14通道
	public Byte DO15;			// 15通道
}


// ********************* 开关量输入的参数结构 *******************************
public struct DAM3000M_PARA_DI		// 数字量输入参数(1为高电平)
{
	public Byte DI0;			// 0通道
	public Byte DI1;			// 1通道
	public Byte DI2;			// 2通道
	public Byte DI3;			// 3通道
	public Byte DI4;			// 4通道
	public Byte DI5;			// 5通道
	public Byte DI6;			// 6通道
	public Byte DI7;			// 7通道
	public Byte DI8;			// 8通道
	public Byte DI9;			// 9通道
	public Byte DI10;			// 10通道
	public Byte DI11;			// 11通道
	public Byte DI12;			// 12通道
	public Byte DI13;			// 13通道
	public Byte DI14;			// 14通道
	public Byte DI15;			// 15通道
	public Byte DI16;			// 16通道
	public Byte DI17;			// 17通道
	public Byte DI18;			// 18通道
	public Byte DI19;			// 19通道
	public Byte DI20;			// 20通道
	public Byte DI21;			// 21通道
	public Byte DI22;			// 22通道
	public Byte DI23;			// 23通道
	public Byte DI24;			// 24通道
	public Byte DI25;			// 25通道
	public Byte DI26;			// 26通道
	public Byte DI27;			// 27通道
	public Byte DI28;			// 28通道
	public Byte DI29;			// 29通道
	public Byte DI30;			// 30通道
	public Byte DI31;			// 31通道
} 

public struct DAM3000M_PARA_LATCH      // 数字量锁存参数(1为锁存)
{
	public Byte Latch0;		// 0通道
	public Byte Latch1;        // 1通道
	public Byte Latch2;        // 2通道
	public Byte Latch3;        // 3通道
	public Byte Latch4;        // 4通道
	public Byte Latch5;        // 5通道
	public Byte Latch6;        // 6通道
	public Byte Latch7;        // 7通道
	public Byte Latch8;        // 8通道
	public Byte Latch9;        // 9通道
	public Byte Latch10;       // 10通道
	public Byte Latch11;       // 11通道
	public Byte Latch12;       // 12通道
	public Byte Latch13;       // 13通道
	public Byte Latch14;       // 14通道
	public Byte Latch15;       // 15通道
	public Byte Latch16;       // 16通道
	public Byte Latch17;       // 17通道
	public Byte Latch18;       // 18通道
	public Byte Latch19;       // 19通道
	public Byte Latch20;       // 20通道
	public Byte Latch21;       // 21通道
	public Byte Latch22;       // 22通道
	public Byte Latch23;       // 23通道
	public Byte Latch24;       // 24通道
	public Byte Latch25;       // 25通道
	public Byte Latch26;       // 26通道
	public Byte Latch27;       // 27通道
	public Byte Latch28;       // 28通道
	public Byte Latch29;       // 29通道
	public Byte Latch30;       // 30通道
	public Byte Latch31;       // 31通道
} 


// ****************** 模拟量输入通道配置结构体 *************************
public struct DAM3000M_ADCHANNEL_ARRAY
{
	public Byte bChannel0;		// 1，有效；0，无效
	public Byte bChannel1;
	public Byte bChannel2;
	public Byte bChannel3;
	public Byte bChannel4;
	public Byte bChannel5;
	public Byte bChannel6;
	public Byte bChannel7;
}


// ****************** 计数器参数配置结构体 ******************************
public struct DAM3000M_PARA_CNT			// 基于各通道的计数器参数结构体
{
	public Int32 WorkMode;			// 计数器/频率工作模式
	public Int32 FreqBuildTime;		// 测频器建立时间, 单位: s
	public Int32 InputMode;			// 计数器/频率输入方式	0: 非隔离	1: 隔离
	public UInt32 InitVal;			// 计数器初始值
	public UInt32 MaxVal;			// 计数器最大值
	public Int32 GateSts;			// 门槛值状态(计数模式)
} 

public struct DAM3000M_CNT_ALARM
{
	public Int32 AlarmMode;			// 报警方式	
	public Int32 EnableAlarm0;		// 0通道报警使能
	public Int32 EnableAlarm1;		// 1通道报警使能
	public UInt32 Alarm0Val;		// 0通道报警值
	public UInt32 Alarm1Val;		// 1通道报警值
	public UInt32 Alarm0HiHiVal;	// 0通道上上限(Hi-Hi)报警值, 报警方式1有效
} 

public struct DAM3000M_PARA_FILTER		// 用于计数器滤波的参数结构体
{
	public Int32 TrigLevelHigh;		// 触发高电平(非隔离输入)
	public Int32 TrigLevelLow;		// 触发低电平(非隔离输入)
	public Int32 MinWidthHigh;		// 高电平最小输入信号宽度
	public Int32 MinWidthLow;		// 低电平最小输入信号宽度
	public Int32 bEnableFilter;		// 使能滤波
} 
//	DisplayChannel;	// 设置显示通道		0：0通道计数/频率，1：1通道计数/频率


public struct DAM3000M_CNT_STATUS			// 计数器硬件参数状态结构体
{
	public Int32 WorkMode;			// 计数器/频率工作模式*
	public Int32 FreqBuildTime;		// 测频器建立时间, 单位: s*
	public Int32 InputMode;			// 计数器/频率输入方式	0: 非隔离	1: 隔离*
	public Int32 bCNTSts;			// 计数/频率器的状态(起停状态)*
	public Int32 FilterSts;			// 计数器的滤波状态*
	public Int32 MinWidthHigh;		// 高电平最小输入信号宽度*
	public Int32 MinWidthLow;		// 低电平最小输入信号宽度*
	public Int32 TrigLevelHigh;		// 触发高电平(非隔离输入)*
	public Int32 TrigLevelLow;		// 触发低电平(非隔离输入)*
	public Int32 GateSts;			// 门槛值设置状态(计数模式)*
	public UInt32 MaxVal;			// 计数器最大值*
	public UInt32 InitVal;			// 计数器初始值*
	public Int32 bOverflowSts;		// 计数器溢出状态*
	public Int32 AlarmMode;			// 计数器报警方式*
	public Int32 EnableAlarm0;		// 计数器0报警使能状态*
	public Int32 EnableAlarm1;		// 计数器1报警使能状态*
	public UInt32 Alarm0Val;		// 0通道报警值*
	public UInt32 Alarm1Val;		// 1通道报警值*
	public UInt32 Alarm1HiHiVal;	// 报警方式1上上限(Hi-Hi)报警值*
	public Int32 bDO0;				// DO0*
	public Int32 bDO1;				// DO1*
} 


// ****************** 设备基本信息的结构体 ******************************
public struct DAM3000M_DEVICE_INFO
{
	public Int32    DeviceType;		// 模块类型 
	public Int32    TypeSuffix;		// 类型后缀
	public Int32	ModusType;		// M
	public Int32	VesionID;		// 版本号(2字节)
	public Int32	DeviceID;		// 模块ID号(SetDeviceInfo时，为设备的新ID)
	public Int32	BaudRate;		// 波特率
    public Int32 bParity;		// 无校验 偶校验 奇校验(目前仅支持3080D)
} 


// ****************** 测温模块传感器参数的结构体 ******************************
public struct DAM3000M_SENSOR_PARA
{
	public Byte 	SerialNumber;	// 编号
	public Byte 	Channel;		// 所在通道号
	public Byte 	SequenceNumber;	// 通道内顺序号
	public UInt16   Temperature;	// 温度
	public Byte 	ID0;			// ID号0
	public Byte 	ID1;			// ID号1
	public Byte 	ID2;			// ID号2
	public Byte 	ID3;			// ID号3
	public Byte 	ID4;			// ID号4
	public Byte 	ID5;			// ID号5
	public Byte 	ID6;			// ID号6
	public Byte 	ID7;			// ID号7
	public Byte 	AlarmMark;		// 报警标志
} 


// 模拟量输入类型(电压类型) 供DAM3000M_SetModeAD函数中的lMode参数使用
public const Int32 DAM3000M_VOLT_N15_P15					=0x01; //  -15～+15mV
public const Int32 DAM3000M_VOLT_N50_P50					=0x02; //  -50～+50mV
public const Int32 DAM3000M_VOLT_N100_P100					=0x03; // -100～+100mV
public const Int32 DAM3000M_VOLT_N150_P150					=0x04; // -150～+150mV
public const Int32 DAM3000M_VOLT_N500_P500					=0x05; // -500～+500mV
public const Int32 DAM3000M_VOLT_N1_P1						=0x06; //   -1～+1V
public const Int32 DAM3000M_VOLT_N25_P25					=0x07; // -2.5～+2.5V
public const Int32 DAM3000M_VOLT_N5_P5						=0x08; //   -5～+5V
public const Int32 DAM3000M_VOLT_N10_P10					=0x09; //  -10～+10V
public const Int32 DAM3000M_VOLT_N0_P5						=0x0D; //    0～+5V
public const Int32 DAM3000M_VOLT_N0_P10					=0x0E; //    0～+10V
public const Int32 DAM3000M_VOLT_N0_P25					=0x0F; //    0～+2.5V
public const Int32 DAM3000M_VOLT_N1_P5						=0x82; //    1～+5V
public const Int32 DAM3000M_VOLT_N30_P30V					=0x83; //  -30～+30V
public const Int32 DAM3000M_VOLT_N0_P30V					=0x84; //    0～+30V

// 模拟量输入类型(电流类型) 供DAM3000M_SetModeAD函数中的lMode参数使用
public const Int32 DAM3000M_CUR_N0_P10						=0x00; //   0～10mA
public const Int32 DAM3000M_CUR_N20_P20					=0x0A; // -20～+20mA
public const Int32 DAM3000M_CUR_N0_P20						=0x0B; //   0～20mA
public const Int32 DAM3000M_CUR_N4_P20						=0x0C; //   4～20mA
public const Int32 DAM3000M_CUR_N0_P22						=0x80; //   0～22mA
public const Int32 DAM3000M_CUR_N10_P10A					=0x85; // -10～+10A
public const Int32 DAM3000M_CUR_N0_P10A					=0x86; //   0～+10A

// 模拟量输入类型(热电偶类型) 供DAM3000M_SetModeAD函数中的lMode参数使用
public const Int32 DAM3000M_TMC_J							=0x10; // J型热电偶   0～1200℃
public const Int32 DAM3000M_TMC_K							=0x11; // K型热电偶   0～1300℃
public const Int32 DAM3000M_TMC_T							=0x12; // T型热电偶 -200～400℃
public const Int32 DAM3000M_TMC_E							=0x13; // E型热电偶   0～1000℃
public const Int32 DAM3000M_TMC_R							=0x14; // R型热电偶 500～1700℃
public const Int32 DAM3000M_TMC_S							=0x15; // S型热电偶 500～1768℃
public const Int32 DAM3000M_TMC_B							=0x16; // B型热电偶 500～1800℃
public const Int32 DAM3000M_TMC_N							=0x17; // N型热电偶   0～1300℃
public const Int32 DAM3000M_TMC_C							=0x18; // C型热电偶   0～2090℃
public const Int32 DAM3000M_TMC_WRE						=0x19; // 钨铼5-钨铼26 0～2310℃

// 模拟量输入类型(热电阻类型) 供DAM3000M_SetModeAD函数中的lMode参数使用
public const Int32 DAM3000M_RTD_PT100_385_N200_P850		=0x20; // Pt100(385)热电阻 -200℃～850℃
public const Int32 DAM3000M_RTD_PT100_385_N100_P100		=0x21; // Pt100(385)热电阻 -100℃～100℃
public const Int32 DAM3000M_RTD_PT100_385_N0_P100			=0x22; // Pt100(385)热电阻    0℃～100℃
public const Int32 DAM3000M_RTD_PT100_385_N0_P200			=0x23; // Pt100(385)热电阻    0℃～200℃
public const Int32 DAM3000M_RTD_PT100_385_N0_P600			=0x24; // Pt100(385)热电阻    0℃～600℃
public const Int32 DAM3000M_RTD_PT100_3916_N200_P850		=0x25; // Pt100(3916)热电阻-200℃～850℃
public const Int32 DAM3000M_RTD_PT100_3916_N100_P100		=0x26; // Pt100(3916)热电阻-100℃～100℃
public const Int32 DAM3000M_RTD_PT100_3916_N0_P100			=0x27; // Pt100(3916)热电阻   0℃～100℃
public const Int32 DAM3000M_RTD_PT100_3916_N0_P200			=0x28; // Pt100(3916)热电阻   0℃～200℃
public const Int32 DAM3000M_RTD_PT100_3916_N0_P600			=0x29; // Pt100(3916)热电阻   0℃～600℃
public const Int32 DAM3000M_RTD_PT1000						=0x30; // Pt1000热电阻     -200℃～850℃
public const Int32 DAM3000M_RTD_CU50						=0x40; // Cu50热电阻        -50℃～150℃
public const Int32 DAM3000M_RTD_CU100						=0x41; // Cu100热电阻       -50℃～150℃
public const Int32 DAM3000M_RTD_BA1						=0x42; // BA1热电阻        -200℃～650℃
public const Int32 DAM3000M_RTD_BA2						=0x43; // BA2热电阻        -200℃～650℃
public const Int32 DAM3000M_RTD_G53						=0x44; // G53热电阻         -50℃～150℃
public const Int32 DAM3000M_RTD_Ni50						=0x45; // Ni50热电阻        100℃
public const Int32 DAM3000M_RTD_Ni508						=0x46; // Ni508热电阻         0℃～100℃
public const Int32 DAM3000M_RTD_Ni1000						=0x47; // Ni1000热电阻      -60℃～160℃

// 模块量输出斜率类型	供DAM3000M_SetModeDA函数中的参数 lType 使用
public const Int32 DAM3000M_SLOPE_IMMEDIATE				=0x00; // Immediate
public const Int32 DAM3000M_SLOPE_POINT125					=0x01; // 0.125 mA/S
public const Int32 DAM3000M_SLOPE_POINT25					=0x02; // 0.25  mA/S
public const Int32 DAM3000M_SLOPE_POINT5					=0x03; // 0.5  mA/S
public const Int32 DAM3000M_SLOPE_1						=0x04; // 1.0  mA/S
public const Int32 DAM3000M_SLOPE_2						=0x05; // 2.0  mA/S
public const Int32 DAM3000M_SLOPE_4						=0x06; // 4.0  mA/S
public const Int32 DAM3000M_SLOPE_8						=0x07; // 8.0  mA/S
public const Int32 DAM3000M_SLOPE_16						=0x08; // 16.0  mA/S
public const Int32 DAM3000M_SLOPE_32						=0x09; // 32.0  mA/S
public const Int32 DAM3000M_SLOPE_64						=0x0A; // 64.0  mA/S
public const Int32 DAM3000M_SLOPE_128						=0x0B; // 128.0  mA/S
public const Int32 DAM3000M_SLOPE_256						=0x0C; // 256.0  mA/S
public const Int32 DAM3000M_SLOPE_512						=0x0D; // 512.0  mA/S
public const Int32 DAM3000M_SLOPE_1024						=0x0E; // 1024.0  mA/S
public const Int32 DAM3000M_SLOPE_2048						=0x0F; // 2048.0  mA/S

// DI计数方式 供DAM3000M_SetDeviceMode函数中的lMode参数使用
public const Int32 DAM3000M_DI_MODE_DI						=0x00; // DI方式
public const Int32 DAM3000M_DI_MODE_COUNT					=0x01; // 计数方式
public const Int32 DAM3000M_DI_MODE_LATCH					=0x02; // 锁存方式

// DI计数方式 供DAM3000M_SetDeviceMode函数中的lEdgeMode参数使用
public const Int32 DAM3000M_DIR_FALLING					=0x00; // 下降沿
public const Int32 DAM3000M_DIR_RISING						=0x01; // 上升沿

//########################## 计数器 ###################################
// 模块的工作模式 供DAM3000M_SetDevWorkMode函数中的lMode参数使用
public const Int32 DAM3000M_WORKMODE_CNT					=0x00; // 计数器
public const Int32 DAM3000M_WORKMODE_FREQ					=0x01; // 频率器

// 计数器/频率的输入方式 供DAM3000M_PARA_CNT结构体中的lInputMode参数使用
public const Int32 DAM3000M_UNISOLATED						=0x00; // 非隔离
public const Int32 DAM3000M_ISOLATED						=0x01; // 隔离

// 门槛值状态 供DAM3000M_PARA_CNT结构体中的GateSts参数使用
public const Int32 DAM3000M_GATE_LOW						=0x00; // 门槛值为低电平
public const Int32 DAM3000M_GATE_HIGH						=0x01; // 门槛值为高电平
public const Int32 DAM3000M_GATE_NULL						=0x02; // 门槛值无效

// 报警方式 供DAM3000M_CNT_ALARM结构体中的AlarmMode参数使用
public const Int32 CNT_ALARM_MODE0							=0x00; // 报警方式0	0通道-1通道上限
public const Int32 CNT_ALARM_MODE1							=0x01; // 报警方式1	0通道上限 / 上上限

// 报警方式0使能 供DAM3000M_CNT_ALARM结构体中的EnableAlarm0 和 EnableAlarm1参数使用
public const Int32 CNT_ALAMODE0_DISABLE					=0x00; // 报警方式0禁止报警
public const Int32 CNT_ALAMODE0_ENABLE						=0x01; // 报警方式0允许报警

// 报警方式1使能 供DAM3000M_CNT_ALARM结构体中的EnableAlarm0参数使用
public const Int32 CNT_ALAMODE1_DISABLE					=0x00; // 报警方式1 计数器0 禁止报警
public const Int32 CNT_ALAMODE1_INSTANT					=0x01; // 报警方式1 计数器0 瞬间报警允许
public const Int32 CNT_ALAMODE1_LATCH						=0x02; // 报警方式1 计数器0 闭锁报警允许

// 滤波状态使能 供DAM3000M_PARA_FILTER结构体中的bEnableFilter参数使用
public const Int32 DAM3000M_FILTER_DISABLE					=0x00; // 禁止滤波
public const Int32 DAM3000M_FILTER_ENABLE					=0x01; // 允许滤波
//-----------------------------------------------------

//########################## 电量 ###################################
public const Int32 DAM3000M_GET_I_RMS						=0x00; // 获得电流有效值
public const Int32 DAM3000M_GET_V_RMS						=0x01; // 获得电压有效值
public const Int32 DAM3000M_GET_POWER						=0x02; // 获得有功功率
public const Int32 DAM3000M_GET_VAR						=0x03; // 获得无功功率
public const Int32 DAM3000M_GET_VA							=0x04; // 获得视在功率
public const Int32 DAM3000M_GET_WATTHR						=0x05; // 获得正相有功电度
public const Int32 DAM3000M_GET_RWATTHR					=0x06; // 获得反相有功电度
public const Int32 DAM3000M_GET_VARHR						=0x07; // 获得正相无功电度
public const Int32 DAM3000M_GET_RVARHR						=0x08; // 获得反相无功电度
public const Int32 DAM3000M_GET_PF							=0x09; // 获得功率因数
public const Int32 DAM3000M_GET_FREQ						=0x0A; // 获得输入信号频率
public const Int32 DAM3000M_GET_VAWATTHR					=0x0B; // 获得电度
public const Int32 DAM3000M_GET_PHVOLTAGE					=0x0C; // 获得相电压


// 数显表小数点位置  供DAM3000M_SetDecimalPoint和DAM3000M_GetDecimalPoint中使用###################################

public const Int32 DAM3000M_DECPOINT_ABit					=0x00; // 小数点在个位
public const Int32 DAM3000M_DECPOINT_Ten					=0x01; // 小数点在十位
public const Int32 DAM3000M_DECPOINT_Hundred				=0x02; // 小数点在百位
public const Int32 DAM3000M_DECPOINT_Thousand				=0x03; // 小数点在千位
public const Int32 DAM3000M_DECPOINT_NULL					=0x04; // 无小数点


// 串口号(以此类推) 供DAM3000M_CreateDevice使用，可根据自身需要扩充
public const Int32 DAM3000M_COM1							=0x01; // COM1
public const Int32 DAM3000M_COM2							=0x02; // COM2
public const Int32 DAM3000M_COM3							=0x03; // COM3
public const Int32 DAM3000M_COM4							=0x04; // COM4
public const Int32 DAM3000M_COM5							=0x05; // COM5

// 波特率选择 供DAM3000M_SetDeviceInfo和DAM3000M_GetDeviceInfo中的PDAM3000M_DEVICE_INFO使用
public const Int32 DAM3000M_BAUD_1200						=0x00;
public const Int32 DAM3000M_BAUD_2400						=0x01;
public const Int32 DAM3000M_BAUD_4800						=0x02;
public const Int32 DAM3000M_BAUD_9600						=0x03;
public const Int32 DAM3000M_BAUD_19200						=0x04;
public const Int32 DAM3000M_BAUD_38400						=0x05;
public const Int32 DAM3000M_BAUD_57600						=0x06;
        public const Int32 DAM3000M_BAUD_115200 = 0x07;

        // 波特率选择 供DAM3000M_SetDeviceInfo和DAM3000M_GetDeviceInfo中的PDAM3000M_DEVICE_INFO(bParity)使用
        public const Int32 DAM3000M_PARITY_NONE = 0x00;
        public const Int32 DAM3000M_PARITY_EVEN = 0x01;
        public const Int32 DAM3000M_PARITY_ODD = 0x02;

                
        public const Int32 DAM3000M_DEFAULT_TIMEOUT              =   -1;
        //####################### 设备对象管理函数 #################################	
        [DllImport("DAM3000M_64.DLL")]
	    public static extern IntPtr DAM3000M_CreateDevice(Int32 lPortNum);		// 创建设备对象
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_InitDevice(						// 初始与模块之间的通信参数
									                        IntPtr	hDevice,	// 设备对象句柄
									                        Int32    lBaud,		// 波特率
                                                            Int32   lParity,	// 校验方式
									                        Int32    lTimeOut );// 超时时间，主要用于接收数据，如果为-1 则使用默认超时时间
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_ReleaseDevice(IntPtr hDevice);		// 释放设备对象 

    //################################### 模块信息取得/修改函数 ############################
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetDeviceInfo(						                // 读取模块信息(类型、地址、波特率、校验)
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_DEVICE_INFO pInfo);	// 设备信息
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetDeviceInfo(						                // 修改模块信息(地址、波特率、校验)
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_DEVICE_INFO Info);		// 设备信息
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetDevLastError(					                // 获得最后一个错误
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID);					// 模块地址
                        		
	    //####################### AD数据读取函数 ###################################	
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_ReadDeviceAD(						                // 读取AD模拟量输入 
									                        IntPtr	hDevice,					// 设备对象句柄	
									                        Int32	lDeviceID,					// 模块地址
									                        Int32[]	lpADBuffer,				    // 接收AD数据的用户缓冲区 注意:lpADBuffer最好大于等于lLastChannel - lFirstChannel +1
									                        Int32    lBufferSize,        		// 数组lpADBuffer[]的大小
									                        Int32	lFirstChannel ,			    // 首通道
									                        Int32	lLastChannel );			    // 末通道
        [DllImport("DAM3000M_64.DLL")]               		
	    public static extern Int32 	DAM3000M_GetModeAD(							                // 获得模拟量输入模式 
									                        IntPtr	hDevice,					// 设备对象句柄	
									                        Int32	lDeviceID,					// 模块地址
                                                            ref Int32 lpMode,                   // AD模式
                                                            Int32 lChannel);				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetModeAD(							                // 设置AD输入模式 
									                        IntPtr	hDevice,					// 设备对象句柄	
									                        Int32	lDeviceID,					// 模块地址
                                                            Int32   lMode,                      // 通道号
                                                            Int32 lChannel);					// AD通道号 
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32  DAM3000M_GetGroundingAD(					                // 获得通道接地模式(只对可软件配置单/双端输入模块有效)
									                        IntPtr	hDevice,					// 设备对象句柄	
									                        Int32	lDeviceID,					// 模块地址
									                        ref Int32 lpGrounding,				// AD通道接地模式
									                        Int32	lChannel);				    // 通道号
	    [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetGroundingAD(					                // 设置通道接地模式(只对可软件配置单/双端输入模块有效)
									                        IntPtr	hDevice,					// 设备对象句柄	
									                        Int32	lDeviceID,					// 模块地址
									                        Int32	lGrounding,					// AD通道接地模式
									                        Int32	lChannel );				    // 通道号

        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetLowLimitVal(					                // 获得模拟量输入报警下限值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        Int32[]	lLowLimit,				    // 下限报警值
									                        Int32    lFirstChannel ,			// 首通道号
									                        Int32	lLastChannel );			    // 末通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_GetHighLimitVal(					                // 获得模拟量输入报警上限值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        Int32[]	lHighLimit,				    // 上限报警值
									                        Int32    lFirstChannel ,			// 首通道号
									                        Int32	lLastChannel );			    // 末通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_SetLowLimitVal(						            // 设置下限报警值
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,					// 模块地址
									                        Int32[]	lLowVal,					// 下限报警值
									                        Int32    lFirstChannel,			    // 首通道号
									                        Int32	lLastChannel );			    // 末通道号
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32  DAM3000M_SetHighLimitVal(					                // 设置上限报警值
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,					// 模块地址
									                        Int32[]	lHighVal,					// 上限报警值
									                        Int32    lFirstChannel,			    // 首通道号
									                        Int32	lLastChannel );			    // 末通道号
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32   DAM3000M_GetAlarmPulse(						            // 获得报警的电平
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        ref Int32	lpAlarmVal,				// 报警电平,0:低电平, 1:高电平
									                        Int32	lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]               	
	    public static extern Int32   DAM3000M_SetAlarmPulse(						            // 设置模拟量输入报警电平
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        Int32	lAlarmVal,					// 报警电平,0:低电平, 1:高电平	
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetAlarmSts(						                // 获得报警状态
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        ref Int32	lpAlarmSts,				// 报警状态
									                        Int32	lChannel );				    // 读取通道
        [DllImport("DAM3000M_64.DLL")]
	    //####################### DA数据读取函数 ###################################
	    public static extern Int32 	DAM3000M_GetDeviceDAVal(					                // 回读DA输出值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpDAValue,          	// DA输出当前值
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_WriteDeviceDA(						                // 设定单通道DA
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lDAData,					// DA输出值
									                        Int32	lChannel );      		    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetOutPutRangeDA(					                // 读取模拟量输出量程
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpRange,				// 输出量程
									                        Int32	lChannel);				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetOutPutRangeDA(					                // 设置模拟量输出量程
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lRange,						// 输出量程
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]                	
	    public static extern Int32 	DAM3000M_GetPowerOnValueDA(					                // 获得DA上电值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpPowerOnVal,       	// 上电值
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetPowerOnValueDA(					                // 设置DA上电值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lPowerOnVal,				// 上电值
									                        Int32	lChannel);				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetSafeValueDA(					                // 获得DA安全值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpSafeVal,				// 安全值
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetSafeValueDA(					                // 设置DA安全值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lSafeVal,					// 安全值
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 DAM3000M_GetSlopeDA(						                    // 读模拟量输出斜率
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpSlopeType,			// 输出斜率类型
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]                	
	    public static extern Int32 	DAM3000M_SetSlopeDA(						                // 修改模拟量输出斜率
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lSlopeType,					// 输出斜率类型
									                        Int32	lChannel );				    // 通道号

	    //####################### DI输入输出操作函数 ##############################
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 DAM3000M_GetModeDI(							                // 设置数字量输入的工作模式
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32[]	lMode,						// 输入的工作模式,0:DI模式,1:计数方式,2:锁存方式
									                        Int32[]	lEdgeMode,					// 边沿方式,0:低电平,1:高电平
									                        Int32	lFirstChannel,              // 首通道
                                                            Int32	lLastChannel);			    // 末通道 
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 DAM3000M_SetModeDI(							                // 设置数字量输入的工作模式
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lMode,						// 输入的工作模式,0:DI模式,1:计数方式,2:锁存方式
									                        Int32	lEdgeMode,					// 边沿方式,0:低电平,1:高电平
									                        Int32	lChannel);				    // 通道号

        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetDeviceDI(						                // 读取开关量输入 
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_DI pDIPara,		// DI值
                                                            Int32 lBufferSize);                 // 通道大小
        [DllImport("DAM3000M_64.DLL")]                		
	    public static extern Int32 	DAM3000M_StartDeviceDI(						                // 启动DI计数
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]                		
	    public static extern Int32 	DAM3000M_StopDeviceDI(						                // 停止DI计数
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32   DAM3000M_GetCNTDI(							                // 读取DI计数器值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpCounterValue,     	// 范围(0~65535)
									                        Int32	lFirstChannel,              // 首通道
                                                            Int32	lLastChannel);              // 末通道				    
        
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetCNTDI(							                // 设置DI计数器初始值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lInitValue,					// 计数初值
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_StartLatch(						                // 启动锁存
									                        IntPtr	 hDevice,					// 设备句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lChannel );				// 通道号
	    [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_StopLatch(							                // 停止锁存      
									                        IntPtr	 hDevice,					// 设备句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetLatchStatus(					                // 读锁存状态
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lLatchType,					// 锁存类型，分为上升沿和下降沿锁存
                                                            ref DAM3000M_PARA_LATCH pLatchStatus,	// 通道大小
                                                            Int32   lBufferSize);
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32  DAM3000M_ClearCNTVal(						                // 清除计数值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_ClearLatchStatus(					                // 清除锁存状态
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lChannel );				    // 通道号
                        			
	    //####################### DO数字量输出函数 ###################################	
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetDeviceDO(						                // 回读开关量输出
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                       ref DAM3000M_PARA_DO pDOPara);		// 当前DO输出值
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetDeviceDO(						                // 设置DO开关量输出值 
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Byte[]	byDOSts,					// 设置DO输出值
									                        Int32    lFirstChannel,				// 首通道号
									                        Int32	lLastChannel);				// 末通道号
							                       
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetPowerOnValueDO(					            // 获取DO上电初始值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_DO pPowerOnPara);	// 上电值 
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetPowerOnValueDO(					                // 设置DO上电初始值 
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_DO PowerOnPara);	// 上电值
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetSafeValueDO(					                // 读DO安全值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_DO pDOSafePara);	// 安全值
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetSafeValueDO(					                // 设置安全值
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_DO DOSafePara);	// 安全值

	    //#############################  计数器  ###################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_SetCounterMode(						            // 对各个计数器进行参数设置
									                        IntPtr   hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_CNT pCNTPara,		// 基于各通道的计数器参数
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_InitCounterAlarm(					                // 初始化报警的工作模式
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        ref DAM3000M_CNT_ALARM pCNTAlarm);	// 报警参数设置
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_SetCounterAlarmMode(				                // 设置计数器报警方式
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lAlarmMode);				// 报警方式
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_GetCounterSts(						                // 获得计数器设备硬件参数状态
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        ref DAM3000M_CNT_STATUS pStsCNT,	// 返回值
									                        Int32	 lChannel);				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_StartCounter(						                // 启动计数器计数
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_StopCounter(						                // 停止计数器计数
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetCounterCurVal(					                // 取得计数器当前值
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32     lDeviceID,				// 设备地址
									                        ref UInt32    pCNTVal,				// 计数值
									                        Int32     lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetFreqCurVal(						            // 取得频率器当前值
									                        IntPtr   hDevice,					// 设备对象句柄
									                        Int32     lDeviceID,				// 设备地址
									                        ref Int32    pFreqVal,				// 频率值
									                        Int32     lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_ResetCounter(						                // 计数器复位
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_InitCounterFilter(					            // 初始化滤波
									                        IntPtr   hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        ref DAM3000M_PARA_FILTER pFilter,	// 滤波参数
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_EnableFilter(						                // 使能滤波状态
									                        IntPtr   hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 bEnable,					// 使能滤波
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetCounterAlarmSts(				                // 获得DO及报警状态
									                        IntPtr   hDevice,					// 设备对象句柄
									                        Int32     lDeviceID,				// 设备地址
									                        ref Int32    plEnableAlarm,			// 计数器报警状态
									                        ref Int32    pbDO,					// DO
									                        Int32	 lChannel );				// 通道号
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 DAM3000M_SetCounterDO(						// 设置DO
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Byte[]	byDOSts,					// DO
									                        Int32   lFirstChannel,				// 首通道号
									                        Int32	lLastChannel);				// 末通道号
        [DllImport("DAM3000M_64.DLL")]									
        public static extern Int32 	DAM3000M_ClearAlarmSts(						                // 清报警方式1报警输出
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID);					// 设备地址
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 	DAM3000M_GetLEDCounterCH(					                // 取得计数器LED显示通道
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	plChannel);             // 通道号
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 	DAM3000M_SetLEDCounterCH(					                // 设置计数器LED显示通道
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lChannel);					// 通道号

	    //#############################  电量模块  ###################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEnergyVal(						                // 获得电量值
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32[]	 lValue,					// 电量值
									                        Int32	 lAanlogType,				// 模拟量类型
									                        Int32	 lFirstChannel ,			// 首通道
									                        Int32	 lLastChannel );			// 末通道
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_ClrEnergyReg(						                // 清能量寄存器
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lChannel );				// 通道
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEnergyPerLSB(					                // 获得能量单位
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        ref Int32	 lpEnergyPerLSB);		// 能量单位
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetEnergyPerLSB(					                // 设置能量单位
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
									                        Int32	 lEnergyPerLSB);			// 能量单位
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetInputRange(						            // 获得输入量程
									                        IntPtr	 hDevice,					// 设备对象句柄
									                        Int32	 lDeviceID,					// 设备地址
                                                            ref Int32	 lpInputRangeV,			// 电压输入量程
									                        ref Int32	 lpInputRangeI);    	// 电流输入量程			
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetInputRange(						            // 设置输入量程
									                        IntPtr	hDevice,					// 设备对象句
									                        Int32	lDeviceID,					// 设备地址
									                        Int32	lInputRangeV,				// 电压输入量程
									                        Int32	lInputRangeI);				// 电流输入量程
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEvrmTemp(						                // 获得环境温度
									                        IntPtr	hDevice,					// 设备对象句
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpEvrmTemp,				// 温度
									                        Int32	lChannel );				    // 通道号
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEvrmHum(						                // 获得环境湿度
									                        IntPtr	hDevice,					// 设备对象句
									                        Int32	lDeviceID,					// 设备地址
									                        ref Int32	lpEvrmHum,				// 湿度		
									                        Int32	lChannel );				    // 通道号


	    //##################################### 看门狗 ################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_HostIsOK(IntPtr hDevice);			                // 下位机无返回信息
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_EnableWatchdog(					                // 打开主看门狗(先设置超时间隔，再使能看门狗)
									                        IntPtr	hDevice,	                // 设备对象句柄
									                        Int32	lDeviceID);	                // 模块地址
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_CloseWatchdog(					                // 禁止看门狗工作
									                        IntPtr	hDevice,	                // 设备对象句柄
									                        Int32	lDeviceID);	                // 模块地址
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetWatchdogStatus(					            // 读取主看门狗的状态(S = 1, Host is down; S = 0 OK)
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        ref Int32	lpWatchdogStatus);		// 看门狗状态
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_ResetWatchdogStatus(				                // Func: 复位主看门狗的状态(S = 0)
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID);					// 模块地址
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetWatchdogTimeoutVal(				            // 取得看门狗设置的时间间隔
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        ref Int32	lpInterval);			// 时间间隔
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetWatchdogTimeoutVal(				            // 设置看门狗设置的时间间隔
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        Int32	lInterval);					// 时间间隔

	    // ##################################### DIGIT LED 设置函数 #################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetDLedMode(						                // 获得显示模式请求
									                        IntPtr hDevice,						// 设备对象句柄
									                        Int32   lDeviceID,					// 模块地址
									                        ref Int32  lpDispMode);				// 显示模式 =0x00：温度格式,=0x01:欧姆值
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetDLedMode(						                // 修改显示模式请求
									                        IntPtr hDevice,						// 设备对象句柄
									                        Int32   lDeviceID,					// 模块地址
									                        Int32   lDispMode);					// 显示模式 =0x01：温度格式,=0x02:欧姆值
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetDLedDispChannel(				                // 获得LED显示通道号
									                        IntPtr hDevice,						// 设备对象句柄
									                        Int32   lDeviceID,					// 模块地址
									                        ref Int32  lpChannel);				// 通道号,lpChannel = =0xff:主机控制显示
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetDLedDispChannel(				                // 设置LED显示通道号
									                        IntPtr hDevice,						// 设备对象句柄
									                        Int32   lDeviceID,					// 模块地址
									                        Int32   lChannel );				    // 通道号,lpChannel = =0xff:主机控制显示
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32   DAM3000M_SetDLedValue(						                // 主机控制显示值
									                        IntPtr hDevice,						// 设备对象句柄
									                        Int32   lDeviceID,					// 模块地址
									                        String strWriteBuf,				    // 显示的字符串
									                        Int32   llength);					// 数据长度
        //####################### 输入输出任意二进制字符 ###########################
	    [DllImport("DAM3000M_64.DLL")]	
        public static extern Int32	DAM3000M_WriteDeviceChar(					                // 直接写设备
									                        IntPtr	hDevice,					// 设备对象句柄
									                        ref String	strWriteBuf,		    // 写的数据
									                        Int32	llength,					// 数据长度
									                        Int32	timeout );			        // 超时范围(mS)
	    [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	DAM3000M_ReadDeviceChar(					                // 直接读设备
									                        IntPtr	hDevice,					// 设备对象句柄
									                        ref String	strReadBuf,		    	// 读取的数据
									                        Int32	llength,					// 数据长度
									                        Int32	timeout );			        // 超时范围(mS)
											   

        //###########################　模块信息确认函数  #################################
	    [DllImport("DAM3000M_64.DLL")]	
        public static extern Int32 InitCheckInfo(
									                        IntPtr	hDevice, 
									                        Int32	lDeviceID, 
									                        UInt32	dwNum);
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	ReadCheckInfo(
									                        IntPtr	hDevice, 
									                        Int32	lDeviceID, 
									                        Int32	lIndex, 
									                        ref Byte byEncrypt);

//####################################### 辅助函数 ####################################
	    [DllImport("DAM3000M_64.DLL")]	
        public static extern Int32  DAM3000M_AdjustSlopeVal(					                // 微调当前补偿斜率
									                        IntPtr  hDevice,					// 设备对象句柄
									                        Int32    lDeviceID,   				// 模块地址
									                        Int32    lAdjustVal,	            // 微调值
									                        Int32    lChannel);					// 通道号
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32  DAM3000M_StoreSlopeVal(						                // 设置当前值为输出补偿斜率
	    								                    IntPtr  hDevice,					// 设备对象句柄
									                        Int32    lDeviceID,   				// 模块地址
									                        Int32    lChannel);					// 通道号
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32  DAM3000M_SetFaultSlopeVal(					                // 设定补偿斜率为默认值
									                        IntPtr  hDevice,					// 设备对象句柄
									                        Int32    lDeviceID,   				// 模块地址
									                        Int32    lChannel);					// 通道号	=0xFF为所有通道恢复
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32 DAM3000M_SetZeroRepair(						                // 设置零点偏移补偿
									                        IntPtr	hDevice,					// 设备对象句柄
									                        Int32	lDeviceID,					// 模块地址
									                        Int32	lZeroRepair,				// 零点值
									                        Int32	lChannel);					// 通道号
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32 DAM3000M_SetDevTestMode(					                    // 设置模块进入测试模式
									                        IntPtr  hDevice,					// 设备对象句柄
									                        Int32    lDeviceID);			    // 模块地址
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32 DAM3000M_ResetModule(						                // 模块软复位
									                        IntPtr  hDevice,					// 设备对象句柄
									                        Int32    lDeviceID); 				// 模块地址
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	DAM3000M_GetEnvironmentTemp(				                // 取得环境温度(为取热电偶值作准备)
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,
									                        ref Single	lpETemprt);
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	DAM3000M_SetAdjustTemp(				                        // 取得环境温度(为取热电偶值作准备)
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,
									                        Byte	lETemprt);
       

    //####################################### 测温操作函数 ####################################
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadMeasuringValue(				// 读取测量值 
									IntPtr  hDevice,					// 设备对象句柄	
									Int32	lDeviceID,					// 模块地址
									UInt16[]	lpADBuffer);				// 接收数据的用户缓冲区128
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_TempResetModule(					// 复位测温模块 
									IntPtr  hDevice,					// 设备对象句柄	
									Int32	lDeviceID);					// 模块地址
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_SetSensorSerialNumber(				// 修改传感器编号
									IntPtr  hDevice,					// 设备对象句柄
									Int32	lDeviceID,					// 设备地址
									Byte	bChannel,					// 通道号
									Byte	bSequenceNumber,			// 通道内顺序号
									Byte    bNewNumber,					// 新编号
									Boolean	bAuto);						// 是否自动编号  FALSE手动编号 TURE自动编号(通道号 通道内顺序号 新编号 参数不起作用)
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_GetSensorPara(						// 读取传感器参数
									IntPtr  hDevice,					// 设备对象句柄
									Int32	lDeviceID,					// 设备地址
									DAM3000M_SENSOR_PARA []pInfo);	// 传感器参数





//####################################### Modus 基本功能操作函数 ####################################
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadCoils(							// 读继电器状态
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	bCoilsFlag);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadDiscretes(						// 读开关量输入
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	bDIState);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadMultiRegs(						// 读保持寄存器
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	buf);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadInputRegs(						// 读输入寄存器
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	buf);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_WriteCoil(							// 设置单个继电器
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									Byte	status);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_WriteSingleReg(					// 设置单个保持寄存器
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									Int32	addr, 
									Int16   val);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ForceMultiCoils(					// 设置多个继电器
									IntPtr  hDevice, 
									Int32	lDeviceID,
                                    Int32   addr,
                                    Int32   len, 
									Byte[]	bDOState);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_WriteMultiRegs(					// 设置多个保持寄存器
									IntPtr  hDevice, 
									Int32	lDeviceID,
                                    Int32   addr,
                                    Int32   len, 
									Byte[]	buf);





	//####################################### 数码管显示 ####################################
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_DisplayData(					// 单显部分 显示数据
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
									UInt16	wData);					// 数据
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_DisplaySpecialSymbols(			// 单显部分 特殊符号
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    UInt16 wSymbols);				// 符号
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadData(						// 单显部分 读数据
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    ref UInt16 pwData);				// 数据
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadSpecialSymbols(			// 单显部分 读特殊符号
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    ref UInt16 pwSymbols);				// 符号
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32   DAM3000M_DisplayDataSymbols(			// 混显部分 显示数据及特殊符号
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    UInt16 wData,					// 数据
                                    UInt16 wSymbols);				// 符号
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadDataSymbols(				// 混显部分 读数据及特殊符号
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    ref UInt16 pwData,					// 数据
                                    ref UInt16 pwSymbols);				// 符号
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_SetDecimalPoint(				// 设置小数点位置
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    Int32 lDecimalPoint);			// 小数点位置
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_GetDecimalPoint(				// 读取小数点位置
									IntPtr  hDevice,				// 设备对象句柄
									Int32	lDeviceID,				// 模块地址
                                    ref Int32 plDecimalPoint);		// 小数点位置



    }
}
