using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
//using System.Windows.Forms;

namespace Sys
{
    public partial class DAM3000M
    {

// ********************* ����������Ĳ����ṹ ****************************
public struct DAM3000M_PARA_DO			// �������������
{
	public Byte DO0;       	// 0ͨ��
	public Byte DO1;       	// 1ͨ��
	public Byte DO2;       	// 2ͨ��
	public Byte DO3;       	// 3ͨ��
	public Byte DO4;       	// 4ͨ��
	public Byte DO5;       	// 5ͨ��
	public Byte DO6;       	// 6ͨ��
	public Byte DO7;       	// 7ͨ��
	public Byte DO8;			// 8ͨ��
	public Byte DO9;			// 9ͨ��
	public Byte DO10;      	// 10ͨ��
	public Byte DO11;      	// 11ͨ��
	public Byte DO12;      	// 12ͨ��
	public Byte DO13;			// 13ͨ��
	public Byte DO14;			// 14ͨ��
	public Byte DO15;			// 15ͨ��
}


// ********************* ����������Ĳ����ṹ *******************************
public struct DAM3000M_PARA_DI		// �������������(1Ϊ�ߵ�ƽ)
{
	public Byte DI0;			// 0ͨ��
	public Byte DI1;			// 1ͨ��
	public Byte DI2;			// 2ͨ��
	public Byte DI3;			// 3ͨ��
	public Byte DI4;			// 4ͨ��
	public Byte DI5;			// 5ͨ��
	public Byte DI6;			// 6ͨ��
	public Byte DI7;			// 7ͨ��
	public Byte DI8;			// 8ͨ��
	public Byte DI9;			// 9ͨ��
	public Byte DI10;			// 10ͨ��
	public Byte DI11;			// 11ͨ��
	public Byte DI12;			// 12ͨ��
	public Byte DI13;			// 13ͨ��
	public Byte DI14;			// 14ͨ��
	public Byte DI15;			// 15ͨ��
	public Byte DI16;			// 16ͨ��
	public Byte DI17;			// 17ͨ��
	public Byte DI18;			// 18ͨ��
	public Byte DI19;			// 19ͨ��
	public Byte DI20;			// 20ͨ��
	public Byte DI21;			// 21ͨ��
	public Byte DI22;			// 22ͨ��
	public Byte DI23;			// 23ͨ��
	public Byte DI24;			// 24ͨ��
	public Byte DI25;			// 25ͨ��
	public Byte DI26;			// 26ͨ��
	public Byte DI27;			// 27ͨ��
	public Byte DI28;			// 28ͨ��
	public Byte DI29;			// 29ͨ��
	public Byte DI30;			// 30ͨ��
	public Byte DI31;			// 31ͨ��
} 

public struct DAM3000M_PARA_LATCH      // �������������(1Ϊ����)
{
	public Byte Latch0;		// 0ͨ��
	public Byte Latch1;        // 1ͨ��
	public Byte Latch2;        // 2ͨ��
	public Byte Latch3;        // 3ͨ��
	public Byte Latch4;        // 4ͨ��
	public Byte Latch5;        // 5ͨ��
	public Byte Latch6;        // 6ͨ��
	public Byte Latch7;        // 7ͨ��
	public Byte Latch8;        // 8ͨ��
	public Byte Latch9;        // 9ͨ��
	public Byte Latch10;       // 10ͨ��
	public Byte Latch11;       // 11ͨ��
	public Byte Latch12;       // 12ͨ��
	public Byte Latch13;       // 13ͨ��
	public Byte Latch14;       // 14ͨ��
	public Byte Latch15;       // 15ͨ��
	public Byte Latch16;       // 16ͨ��
	public Byte Latch17;       // 17ͨ��
	public Byte Latch18;       // 18ͨ��
	public Byte Latch19;       // 19ͨ��
	public Byte Latch20;       // 20ͨ��
	public Byte Latch21;       // 21ͨ��
	public Byte Latch22;       // 22ͨ��
	public Byte Latch23;       // 23ͨ��
	public Byte Latch24;       // 24ͨ��
	public Byte Latch25;       // 25ͨ��
	public Byte Latch26;       // 26ͨ��
	public Byte Latch27;       // 27ͨ��
	public Byte Latch28;       // 28ͨ��
	public Byte Latch29;       // 29ͨ��
	public Byte Latch30;       // 30ͨ��
	public Byte Latch31;       // 31ͨ��
} 


// ****************** ģ��������ͨ�����ýṹ�� *************************
public struct DAM3000M_ADCHANNEL_ARRAY
{
	public Byte bChannel0;		// 1����Ч��0����Ч
	public Byte bChannel1;
	public Byte bChannel2;
	public Byte bChannel3;
	public Byte bChannel4;
	public Byte bChannel5;
	public Byte bChannel6;
	public Byte bChannel7;
}


// ****************** �������������ýṹ�� ******************************
public struct DAM3000M_PARA_CNT			// ���ڸ�ͨ���ļ����������ṹ��
{
	public Int32 WorkMode;			// ������/Ƶ�ʹ���ģʽ
	public Int32 FreqBuildTime;		// ��Ƶ������ʱ��, ��λ: s
	public Int32 InputMode;			// ������/Ƶ�����뷽ʽ	0: �Ǹ���	1: ����
	public UInt32 InitVal;			// ��������ʼֵ
	public UInt32 MaxVal;			// ���������ֵ
	public Int32 GateSts;			// �ż�ֵ״̬(����ģʽ)
} 

public struct DAM3000M_CNT_ALARM
{
	public Int32 AlarmMode;			// ������ʽ	
	public Int32 EnableAlarm0;		// 0ͨ������ʹ��
	public Int32 EnableAlarm1;		// 1ͨ������ʹ��
	public UInt32 Alarm0Val;		// 0ͨ������ֵ
	public UInt32 Alarm1Val;		// 1ͨ������ֵ
	public UInt32 Alarm0HiHiVal;	// 0ͨ��������(Hi-Hi)����ֵ, ������ʽ1��Ч
} 

public struct DAM3000M_PARA_FILTER		// ���ڼ������˲��Ĳ����ṹ��
{
	public Int32 TrigLevelHigh;		// �����ߵ�ƽ(�Ǹ�������)
	public Int32 TrigLevelLow;		// �����͵�ƽ(�Ǹ�������)
	public Int32 MinWidthHigh;		// �ߵ�ƽ��С�����źſ��
	public Int32 MinWidthLow;		// �͵�ƽ��С�����źſ��
	public Int32 bEnableFilter;		// ʹ���˲�
} 
//	DisplayChannel;	// ������ʾͨ��		0��0ͨ������/Ƶ�ʣ�1��1ͨ������/Ƶ��


public struct DAM3000M_CNT_STATUS			// ������Ӳ������״̬�ṹ��
{
	public Int32 WorkMode;			// ������/Ƶ�ʹ���ģʽ*
	public Int32 FreqBuildTime;		// ��Ƶ������ʱ��, ��λ: s*
	public Int32 InputMode;			// ������/Ƶ�����뷽ʽ	0: �Ǹ���	1: ����*
	public Int32 bCNTSts;			// ����/Ƶ������״̬(��ͣ״̬)*
	public Int32 FilterSts;			// ���������˲�״̬*
	public Int32 MinWidthHigh;		// �ߵ�ƽ��С�����źſ��*
	public Int32 MinWidthLow;		// �͵�ƽ��С�����źſ��*
	public Int32 TrigLevelHigh;		// �����ߵ�ƽ(�Ǹ�������)*
	public Int32 TrigLevelLow;		// �����͵�ƽ(�Ǹ�������)*
	public Int32 GateSts;			// �ż�ֵ����״̬(����ģʽ)*
	public UInt32 MaxVal;			// ���������ֵ*
	public UInt32 InitVal;			// ��������ʼֵ*
	public Int32 bOverflowSts;		// ���������״̬*
	public Int32 AlarmMode;			// ������������ʽ*
	public Int32 EnableAlarm0;		// ������0����ʹ��״̬*
	public Int32 EnableAlarm1;		// ������1����ʹ��״̬*
	public UInt32 Alarm0Val;		// 0ͨ������ֵ*
	public UInt32 Alarm1Val;		// 1ͨ������ֵ*
	public UInt32 Alarm1HiHiVal;	// ������ʽ1������(Hi-Hi)����ֵ*
	public Int32 bDO0;				// DO0*
	public Int32 bDO1;				// DO1*
} 


// ****************** �豸������Ϣ�Ľṹ�� ******************************
public struct DAM3000M_DEVICE_INFO
{
	public Int32    DeviceType;		// ģ������ 
	public Int32    TypeSuffix;		// ���ͺ�׺
	public Int32	ModusType;		// M
	public Int32	VesionID;		// �汾��(2�ֽ�)
	public Int32	DeviceID;		// ģ��ID��(SetDeviceInfoʱ��Ϊ�豸����ID)
	public Int32	BaudRate;		// ������
    public Int32 bParity;		// ��У�� żУ�� ��У��(Ŀǰ��֧��3080D)
} 


// ****************** ����ģ�鴫���������Ľṹ�� ******************************
public struct DAM3000M_SENSOR_PARA
{
	public Byte 	SerialNumber;	// ���
	public Byte 	Channel;		// ����ͨ����
	public Byte 	SequenceNumber;	// ͨ����˳���
	public UInt16   Temperature;	// �¶�
	public Byte 	ID0;			// ID��0
	public Byte 	ID1;			// ID��1
	public Byte 	ID2;			// ID��2
	public Byte 	ID3;			// ID��3
	public Byte 	ID4;			// ID��4
	public Byte 	ID5;			// ID��5
	public Byte 	ID6;			// ID��6
	public Byte 	ID7;			// ID��7
	public Byte 	AlarmMark;		// ������־
} 


// ģ������������(��ѹ����) ��DAM3000M_SetModeAD�����е�lMode����ʹ��
public const Int32 DAM3000M_VOLT_N15_P15					=0x01; //  -15��+15mV
public const Int32 DAM3000M_VOLT_N50_P50					=0x02; //  -50��+50mV
public const Int32 DAM3000M_VOLT_N100_P100					=0x03; // -100��+100mV
public const Int32 DAM3000M_VOLT_N150_P150					=0x04; // -150��+150mV
public const Int32 DAM3000M_VOLT_N500_P500					=0x05; // -500��+500mV
public const Int32 DAM3000M_VOLT_N1_P1						=0x06; //   -1��+1V
public const Int32 DAM3000M_VOLT_N25_P25					=0x07; // -2.5��+2.5V
public const Int32 DAM3000M_VOLT_N5_P5						=0x08; //   -5��+5V
public const Int32 DAM3000M_VOLT_N10_P10					=0x09; //  -10��+10V
public const Int32 DAM3000M_VOLT_N0_P5						=0x0D; //    0��+5V
public const Int32 DAM3000M_VOLT_N0_P10					=0x0E; //    0��+10V
public const Int32 DAM3000M_VOLT_N0_P25					=0x0F; //    0��+2.5V
public const Int32 DAM3000M_VOLT_N1_P5						=0x82; //    1��+5V
public const Int32 DAM3000M_VOLT_N30_P30V					=0x83; //  -30��+30V
public const Int32 DAM3000M_VOLT_N0_P30V					=0x84; //    0��+30V

// ģ������������(��������) ��DAM3000M_SetModeAD�����е�lMode����ʹ��
public const Int32 DAM3000M_CUR_N0_P10						=0x00; //   0��10mA
public const Int32 DAM3000M_CUR_N20_P20					=0x0A; // -20��+20mA
public const Int32 DAM3000M_CUR_N0_P20						=0x0B; //   0��20mA
public const Int32 DAM3000M_CUR_N4_P20						=0x0C; //   4��20mA
public const Int32 DAM3000M_CUR_N0_P22						=0x80; //   0��22mA
public const Int32 DAM3000M_CUR_N10_P10A					=0x85; // -10��+10A
public const Int32 DAM3000M_CUR_N0_P10A					=0x86; //   0��+10A

// ģ������������(�ȵ�ż����) ��DAM3000M_SetModeAD�����е�lMode����ʹ��
public const Int32 DAM3000M_TMC_J							=0x10; // J���ȵ�ż   0��1200��
public const Int32 DAM3000M_TMC_K							=0x11; // K���ȵ�ż   0��1300��
public const Int32 DAM3000M_TMC_T							=0x12; // T���ȵ�ż -200��400��
public const Int32 DAM3000M_TMC_E							=0x13; // E���ȵ�ż   0��1000��
public const Int32 DAM3000M_TMC_R							=0x14; // R���ȵ�ż 500��1700��
public const Int32 DAM3000M_TMC_S							=0x15; // S���ȵ�ż 500��1768��
public const Int32 DAM3000M_TMC_B							=0x16; // B���ȵ�ż 500��1800��
public const Int32 DAM3000M_TMC_N							=0x17; // N���ȵ�ż   0��1300��
public const Int32 DAM3000M_TMC_C							=0x18; // C���ȵ�ż   0��2090��
public const Int32 DAM3000M_TMC_WRE						=0x19; // ���5-���26 0��2310��

// ģ������������(�ȵ�������) ��DAM3000M_SetModeAD�����е�lMode����ʹ��
public const Int32 DAM3000M_RTD_PT100_385_N200_P850		=0x20; // Pt100(385)�ȵ��� -200�桫850��
public const Int32 DAM3000M_RTD_PT100_385_N100_P100		=0x21; // Pt100(385)�ȵ��� -100�桫100��
public const Int32 DAM3000M_RTD_PT100_385_N0_P100			=0x22; // Pt100(385)�ȵ���    0�桫100��
public const Int32 DAM3000M_RTD_PT100_385_N0_P200			=0x23; // Pt100(385)�ȵ���    0�桫200��
public const Int32 DAM3000M_RTD_PT100_385_N0_P600			=0x24; // Pt100(385)�ȵ���    0�桫600��
public const Int32 DAM3000M_RTD_PT100_3916_N200_P850		=0x25; // Pt100(3916)�ȵ���-200�桫850��
public const Int32 DAM3000M_RTD_PT100_3916_N100_P100		=0x26; // Pt100(3916)�ȵ���-100�桫100��
public const Int32 DAM3000M_RTD_PT100_3916_N0_P100			=0x27; // Pt100(3916)�ȵ���   0�桫100��
public const Int32 DAM3000M_RTD_PT100_3916_N0_P200			=0x28; // Pt100(3916)�ȵ���   0�桫200��
public const Int32 DAM3000M_RTD_PT100_3916_N0_P600			=0x29; // Pt100(3916)�ȵ���   0�桫600��
public const Int32 DAM3000M_RTD_PT1000						=0x30; // Pt1000�ȵ���     -200�桫850��
public const Int32 DAM3000M_RTD_CU50						=0x40; // Cu50�ȵ���        -50�桫150��
public const Int32 DAM3000M_RTD_CU100						=0x41; // Cu100�ȵ���       -50�桫150��
public const Int32 DAM3000M_RTD_BA1						=0x42; // BA1�ȵ���        -200�桫650��
public const Int32 DAM3000M_RTD_BA2						=0x43; // BA2�ȵ���        -200�桫650��
public const Int32 DAM3000M_RTD_G53						=0x44; // G53�ȵ���         -50�桫150��
public const Int32 DAM3000M_RTD_Ni50						=0x45; // Ni50�ȵ���        100��
public const Int32 DAM3000M_RTD_Ni508						=0x46; // Ni508�ȵ���         0�桫100��
public const Int32 DAM3000M_RTD_Ni1000						=0x47; // Ni1000�ȵ���      -60�桫160��

// ģ�������б������	��DAM3000M_SetModeDA�����еĲ��� lType ʹ��
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

// DI������ʽ ��DAM3000M_SetDeviceMode�����е�lMode����ʹ��
public const Int32 DAM3000M_DI_MODE_DI						=0x00; // DI��ʽ
public const Int32 DAM3000M_DI_MODE_COUNT					=0x01; // ������ʽ
public const Int32 DAM3000M_DI_MODE_LATCH					=0x02; // ���淽ʽ

// DI������ʽ ��DAM3000M_SetDeviceMode�����е�lEdgeMode����ʹ��
public const Int32 DAM3000M_DIR_FALLING					=0x00; // �½���
public const Int32 DAM3000M_DIR_RISING						=0x01; // ������

//########################## ������ ###################################
// ģ��Ĺ���ģʽ ��DAM3000M_SetDevWorkMode�����е�lMode����ʹ��
public const Int32 DAM3000M_WORKMODE_CNT					=0x00; // ������
public const Int32 DAM3000M_WORKMODE_FREQ					=0x01; // Ƶ����

// ������/Ƶ�ʵ����뷽ʽ ��DAM3000M_PARA_CNT�ṹ���е�lInputMode����ʹ��
public const Int32 DAM3000M_UNISOLATED						=0x00; // �Ǹ���
public const Int32 DAM3000M_ISOLATED						=0x01; // ����

// �ż�ֵ״̬ ��DAM3000M_PARA_CNT�ṹ���е�GateSts����ʹ��
public const Int32 DAM3000M_GATE_LOW						=0x00; // �ż�ֵΪ�͵�ƽ
public const Int32 DAM3000M_GATE_HIGH						=0x01; // �ż�ֵΪ�ߵ�ƽ
public const Int32 DAM3000M_GATE_NULL						=0x02; // �ż�ֵ��Ч

// ������ʽ ��DAM3000M_CNT_ALARM�ṹ���е�AlarmMode����ʹ��
public const Int32 CNT_ALARM_MODE0							=0x00; // ������ʽ0	0ͨ��-1ͨ������
public const Int32 CNT_ALARM_MODE1							=0x01; // ������ʽ1	0ͨ������ / ������

// ������ʽ0ʹ�� ��DAM3000M_CNT_ALARM�ṹ���е�EnableAlarm0 �� EnableAlarm1����ʹ��
public const Int32 CNT_ALAMODE0_DISABLE					=0x00; // ������ʽ0��ֹ����
public const Int32 CNT_ALAMODE0_ENABLE						=0x01; // ������ʽ0������

// ������ʽ1ʹ�� ��DAM3000M_CNT_ALARM�ṹ���е�EnableAlarm0����ʹ��
public const Int32 CNT_ALAMODE1_DISABLE					=0x00; // ������ʽ1 ������0 ��ֹ����
public const Int32 CNT_ALAMODE1_INSTANT					=0x01; // ������ʽ1 ������0 ˲�䱨������
public const Int32 CNT_ALAMODE1_LATCH						=0x02; // ������ʽ1 ������0 ������������

// �˲�״̬ʹ�� ��DAM3000M_PARA_FILTER�ṹ���е�bEnableFilter����ʹ��
public const Int32 DAM3000M_FILTER_DISABLE					=0x00; // ��ֹ�˲�
public const Int32 DAM3000M_FILTER_ENABLE					=0x01; // �����˲�
//-----------------------------------------------------

//########################## ���� ###################################
public const Int32 DAM3000M_GET_I_RMS						=0x00; // ��õ�����Чֵ
public const Int32 DAM3000M_GET_V_RMS						=0x01; // ��õ�ѹ��Чֵ
public const Int32 DAM3000M_GET_POWER						=0x02; // ����й�����
public const Int32 DAM3000M_GET_VAR						=0x03; // ����޹�����
public const Int32 DAM3000M_GET_VA							=0x04; // ������ڹ���
public const Int32 DAM3000M_GET_WATTHR						=0x05; // ��������й����
public const Int32 DAM3000M_GET_RWATTHR					=0x06; // ��÷����й����
public const Int32 DAM3000M_GET_VARHR						=0x07; // ��������޹����
public const Int32 DAM3000M_GET_RVARHR						=0x08; // ��÷����޹����
public const Int32 DAM3000M_GET_PF							=0x09; // ��ù�������
public const Int32 DAM3000M_GET_FREQ						=0x0A; // ��������ź�Ƶ��
public const Int32 DAM3000M_GET_VAWATTHR					=0x0B; // ��õ��
public const Int32 DAM3000M_GET_PHVOLTAGE					=0x0C; // ������ѹ


// ���Ա�С����λ��  ��DAM3000M_SetDecimalPoint��DAM3000M_GetDecimalPoint��ʹ��###################################

public const Int32 DAM3000M_DECPOINT_ABit					=0x00; // С�����ڸ�λ
public const Int32 DAM3000M_DECPOINT_Ten					=0x01; // С������ʮλ
public const Int32 DAM3000M_DECPOINT_Hundred				=0x02; // С�����ڰ�λ
public const Int32 DAM3000M_DECPOINT_Thousand				=0x03; // С������ǧλ
public const Int32 DAM3000M_DECPOINT_NULL					=0x04; // ��С����


// ���ں�(�Դ�����) ��DAM3000M_CreateDeviceʹ�ã��ɸ���������Ҫ����
public const Int32 DAM3000M_COM1							=0x01; // COM1
public const Int32 DAM3000M_COM2							=0x02; // COM2
public const Int32 DAM3000M_COM3							=0x03; // COM3
public const Int32 DAM3000M_COM4							=0x04; // COM4
public const Int32 DAM3000M_COM5							=0x05; // COM5

// ������ѡ�� ��DAM3000M_SetDeviceInfo��DAM3000M_GetDeviceInfo�е�PDAM3000M_DEVICE_INFOʹ��
public const Int32 DAM3000M_BAUD_1200						=0x00;
public const Int32 DAM3000M_BAUD_2400						=0x01;
public const Int32 DAM3000M_BAUD_4800						=0x02;
public const Int32 DAM3000M_BAUD_9600						=0x03;
public const Int32 DAM3000M_BAUD_19200						=0x04;
public const Int32 DAM3000M_BAUD_38400						=0x05;
public const Int32 DAM3000M_BAUD_57600						=0x06;
        public const Int32 DAM3000M_BAUD_115200 = 0x07;

        // ������ѡ�� ��DAM3000M_SetDeviceInfo��DAM3000M_GetDeviceInfo�е�PDAM3000M_DEVICE_INFO(bParity)ʹ��
        public const Int32 DAM3000M_PARITY_NONE = 0x00;
        public const Int32 DAM3000M_PARITY_EVEN = 0x01;
        public const Int32 DAM3000M_PARITY_ODD = 0x02;

                
        public const Int32 DAM3000M_DEFAULT_TIMEOUT              =   -1;
        //####################### �豸��������� #################################	
        [DllImport("DAM3000M_64.DLL")]
	    public static extern IntPtr DAM3000M_CreateDevice(Int32 lPortNum);		// �����豸����
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_InitDevice(						// ��ʼ��ģ��֮���ͨ�Ų���
									                        IntPtr	hDevice,	// �豸������
									                        Int32    lBaud,		// ������
                                                            Int32   lParity,	// У�鷽ʽ
									                        Int32    lTimeOut );// ��ʱʱ�䣬��Ҫ���ڽ������ݣ����Ϊ-1 ��ʹ��Ĭ�ϳ�ʱʱ��
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_ReleaseDevice(IntPtr hDevice);		// �ͷ��豸���� 

    //################################### ģ����Ϣȡ��/�޸ĺ��� ############################
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetDeviceInfo(						                // ��ȡģ����Ϣ(���͡���ַ�������ʡ�У��)
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_DEVICE_INFO pInfo);	// �豸��Ϣ
         [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetDeviceInfo(						                // �޸�ģ����Ϣ(��ַ�������ʡ�У��)
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_DEVICE_INFO Info);		// �豸��Ϣ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetDevLastError(					                // ������һ������
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID);					// ģ���ַ
                        		
	    //####################### AD���ݶ�ȡ���� ###################################	
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_ReadDeviceAD(						                // ��ȡADģ�������� 
									                        IntPtr	hDevice,					// �豸������	
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32[]	lpADBuffer,				    // ����AD���ݵ��û������� ע��:lpADBuffer��ô��ڵ���lLastChannel - lFirstChannel +1
									                        Int32    lBufferSize,        		// ����lpADBuffer[]�Ĵ�С
									                        Int32	lFirstChannel ,			    // ��ͨ��
									                        Int32	lLastChannel );			    // ĩͨ��
        [DllImport("DAM3000M_64.DLL")]               		
	    public static extern Int32 	DAM3000M_GetModeAD(							                // ���ģ��������ģʽ 
									                        IntPtr	hDevice,					// �豸������	
									                        Int32	lDeviceID,					// ģ���ַ
                                                            ref Int32 lpMode,                   // ADģʽ
                                                            Int32 lChannel);				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetModeAD(							                // ����AD����ģʽ 
									                        IntPtr	hDevice,					// �豸������	
									                        Int32	lDeviceID,					// ģ���ַ
                                                            Int32   lMode,                      // ͨ����
                                                            Int32 lChannel);					// ADͨ���� 
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32  DAM3000M_GetGroundingAD(					                // ���ͨ���ӵ�ģʽ(ֻ�Կ�������õ�/˫������ģ����Ч)
									                        IntPtr	hDevice,					// �豸������	
									                        Int32	lDeviceID,					// ģ���ַ
									                        ref Int32 lpGrounding,				// ADͨ���ӵ�ģʽ
									                        Int32	lChannel);				    // ͨ����
	    [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetGroundingAD(					                // ����ͨ���ӵ�ģʽ(ֻ�Կ�������õ�/˫������ģ����Ч)
									                        IntPtr	hDevice,					// �豸������	
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32	lGrounding,					// ADͨ���ӵ�ģʽ
									                        Int32	lChannel );				    // ͨ����

        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetLowLimitVal(					                // ���ģ�������뱨������ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32[]	lLowLimit,				    // ���ޱ���ֵ
									                        Int32    lFirstChannel ,			// ��ͨ����
									                        Int32	lLastChannel );			    // ĩͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_GetHighLimitVal(					                // ���ģ�������뱨������ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32[]	lHighLimit,				    // ���ޱ���ֵ
									                        Int32    lFirstChannel ,			// ��ͨ����
									                        Int32	lLastChannel );			    // ĩͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_SetLowLimitVal(						            // �������ޱ���ֵ
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32[]	lLowVal,					// ���ޱ���ֵ
									                        Int32    lFirstChannel,			    // ��ͨ����
									                        Int32	lLastChannel );			    // ĩͨ����
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32  DAM3000M_SetHighLimitVal(					                // �������ޱ���ֵ
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32[]	lHighVal,					// ���ޱ���ֵ
									                        Int32    lFirstChannel,			    // ��ͨ����
									                        Int32	lLastChannel );			    // ĩͨ����
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32   DAM3000M_GetAlarmPulse(						            // ��ñ����ĵ�ƽ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        ref Int32	lpAlarmVal,				// ������ƽ,0:�͵�ƽ, 1:�ߵ�ƽ
									                        Int32	lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]               	
	    public static extern Int32   DAM3000M_SetAlarmPulse(						            // ����ģ�������뱨����ƽ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32	lAlarmVal,					// ������ƽ,0:�͵�ƽ, 1:�ߵ�ƽ	
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetAlarmSts(						                // ��ñ���״̬
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        ref Int32	lpAlarmSts,				// ����״̬
									                        Int32	lChannel );				    // ��ȡͨ��
        [DllImport("DAM3000M_64.DLL")]
	    //####################### DA���ݶ�ȡ���� ###################################
	    public static extern Int32 	DAM3000M_GetDeviceDAVal(					                // �ض�DA���ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpDAValue,          	// DA�����ǰֵ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_WriteDeviceDA(						                // �趨��ͨ��DA
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lDAData,					// DA���ֵ
									                        Int32	lChannel );      		    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetOutPutRangeDA(					                // ��ȡģ�����������
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpRange,				// �������
									                        Int32	lChannel);				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetOutPutRangeDA(					                // ����ģ�����������
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lRange,						// �������
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]                	
	    public static extern Int32 	DAM3000M_GetPowerOnValueDA(					                // ���DA�ϵ�ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpPowerOnVal,       	// �ϵ�ֵ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetPowerOnValueDA(					                // ����DA�ϵ�ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lPowerOnVal,				// �ϵ�ֵ
									                        Int32	lChannel);				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetSafeValueDA(					                // ���DA��ȫֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpSafeVal,				// ��ȫֵ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetSafeValueDA(					                // ����DA��ȫֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lSafeVal,					// ��ȫֵ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 DAM3000M_GetSlopeDA(						                    // ��ģ�������б��
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpSlopeType,			// ���б������
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]                	
	    public static extern Int32 	DAM3000M_SetSlopeDA(						                // �޸�ģ�������б��
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lSlopeType,					// ���б������
									                        Int32	lChannel );				    // ͨ����

	    //####################### DI��������������� ##############################
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 DAM3000M_GetModeDI(							                // ��������������Ĺ���ģʽ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32[]	lMode,						// ����Ĺ���ģʽ,0:DIģʽ,1:������ʽ,2:���淽ʽ
									                        Int32[]	lEdgeMode,					// ���ط�ʽ,0:�͵�ƽ,1:�ߵ�ƽ
									                        Int32	lFirstChannel,              // ��ͨ��
                                                            Int32	lLastChannel);			    // ĩͨ�� 
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 DAM3000M_SetModeDI(							                // ��������������Ĺ���ģʽ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lMode,						// ����Ĺ���ģʽ,0:DIģʽ,1:������ʽ,2:���淽ʽ
									                        Int32	lEdgeMode,					// ���ط�ʽ,0:�͵�ƽ,1:�ߵ�ƽ
									                        Int32	lChannel);				    // ͨ����

        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetDeviceDI(						                // ��ȡ���������� 
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_DI pDIPara,		// DIֵ
                                                            Int32 lBufferSize);                 // ͨ����С
        [DllImport("DAM3000M_64.DLL")]                		
	    public static extern Int32 	DAM3000M_StartDeviceDI(						                // ����DI����
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]                		
	    public static extern Int32 	DAM3000M_StopDeviceDI(						                // ֹͣDI����
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32   DAM3000M_GetCNTDI(							                // ��ȡDI������ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpCounterValue,     	// ��Χ(0~65535)
									                        Int32	lFirstChannel,              // ��ͨ��
                                                            Int32	lLastChannel);              // ĩͨ��				    
        
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetCNTDI(							                // ����DI��������ʼֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lInitValue,					// ������ֵ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_StartLatch(						                // ��������
									                        IntPtr	 hDevice,					// �豸���
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lChannel );				// ͨ����
	    [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_StopLatch(							                // ֹͣ����      
									                        IntPtr	 hDevice,					// �豸���
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetLatchStatus(					                // ������״̬
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lLatchType,					// �������ͣ���Ϊ�����غ��½�������
                                                            ref DAM3000M_PARA_LATCH pLatchStatus,	// ͨ����С
                                                            Int32   lBufferSize);
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32  DAM3000M_ClearCNTVal(						                // �������ֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_ClearLatchStatus(					                // �������״̬
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lChannel );				    // ͨ����
                        			
	    //####################### DO������������� ###################################	
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_GetDeviceDO(						                // �ض����������
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                       ref DAM3000M_PARA_DO pDOPara);		// ��ǰDO���ֵ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetDeviceDO(						                // ����DO���������ֵ 
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Byte[]	byDOSts,					// ����DO���ֵ
									                        Int32    lFirstChannel,				// ��ͨ����
									                        Int32	lLastChannel);				// ĩͨ����
							                       
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetPowerOnValueDO(					            // ��ȡDO�ϵ��ʼֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_DO pPowerOnPara);	// �ϵ�ֵ 
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_SetPowerOnValueDO(					                // ����DO�ϵ��ʼֵ 
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_DO PowerOnPara);	// �ϵ�ֵ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetSafeValueDO(					                // ��DO��ȫֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_DO pDOSafePara);	// ��ȫֵ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetSafeValueDO(					                // ���ð�ȫֵ
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_DO DOSafePara);	// ��ȫֵ

	    //#############################  ������  ###################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_SetCounterMode(						            // �Ը������������в�������
									                        IntPtr   hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_CNT pCNTPara,		// ���ڸ�ͨ���ļ���������
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_InitCounterAlarm(					                // ��ʼ�������Ĺ���ģʽ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        ref DAM3000M_CNT_ALARM pCNTAlarm);	// ������������
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_SetCounterAlarmMode(				                // ���ü�����������ʽ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lAlarmMode);				// ������ʽ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32  DAM3000M_GetCounterSts(						                // ��ü������豸Ӳ������״̬
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        ref DAM3000M_CNT_STATUS pStsCNT,	// ����ֵ
									                        Int32	 lChannel);				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_StartCounter(						                // ��������������
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_StopCounter(						                // ֹͣ����������
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetCounterCurVal(					                // ȡ�ü�������ǰֵ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32     lDeviceID,				// �豸��ַ
									                        ref UInt32    pCNTVal,				// ����ֵ
									                        Int32     lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetFreqCurVal(						            // ȡ��Ƶ������ǰֵ
									                        IntPtr   hDevice,					// �豸������
									                        Int32     lDeviceID,				// �豸��ַ
									                        ref Int32    pFreqVal,				// Ƶ��ֵ
									                        Int32     lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32 	DAM3000M_ResetCounter(						                // ��������λ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_InitCounterFilter(					            // ��ʼ���˲�
									                        IntPtr   hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        ref DAM3000M_PARA_FILTER pFilter,	// �˲�����
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_EnableFilter(						                // ʹ���˲�״̬
									                        IntPtr   hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 bEnable,					// ʹ���˲�
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetCounterAlarmSts(				                // ���DO������״̬
									                        IntPtr   hDevice,					// �豸������
									                        Int32     lDeviceID,				// �豸��ַ
									                        ref Int32    plEnableAlarm,			// ����������״̬
									                        ref Int32    pbDO,					// DO
									                        Int32	 lChannel );				// ͨ����
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 DAM3000M_SetCounterDO(						// ����DO
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Byte[]	byDOSts,					// DO
									                        Int32   lFirstChannel,				// ��ͨ����
									                        Int32	lLastChannel);				// ĩͨ����
        [DllImport("DAM3000M_64.DLL")]									
        public static extern Int32 	DAM3000M_ClearAlarmSts(						                // �屨����ʽ1�������
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID);					// �豸��ַ
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 	DAM3000M_GetLEDCounterCH(					                // ȡ�ü�����LED��ʾͨ��
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	plChannel);             // ͨ����
        [DllImport("DAM3000M_64.DLL")]
        public static extern Int32 	DAM3000M_SetLEDCounterCH(					                // ���ü�����LED��ʾͨ��
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lChannel);					// ͨ����

	    //#############################  ����ģ��  ###################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEnergyVal(						                // ��õ���ֵ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32[]	 lValue,					// ����ֵ
									                        Int32	 lAanlogType,				// ģ��������
									                        Int32	 lFirstChannel ,			// ��ͨ��
									                        Int32	 lLastChannel );			// ĩͨ��
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_ClrEnergyReg(						                // �������Ĵ���
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lChannel );				// ͨ��
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEnergyPerLSB(					                // ���������λ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        ref Int32	 lpEnergyPerLSB);		// ������λ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetEnergyPerLSB(					                // ����������λ
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
									                        Int32	 lEnergyPerLSB);			// ������λ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetInputRange(						            // �����������
									                        IntPtr	 hDevice,					// �豸������
									                        Int32	 lDeviceID,					// �豸��ַ
                                                            ref Int32	 lpInputRangeV,			// ��ѹ��������
									                        ref Int32	 lpInputRangeI);    	// ������������			
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetInputRange(						            // ������������
									                        IntPtr	hDevice,					// �豸�����
									                        Int32	lDeviceID,					// �豸��ַ
									                        Int32	lInputRangeV,				// ��ѹ��������
									                        Int32	lInputRangeI);				// ������������
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEvrmTemp(						                // ��û����¶�
									                        IntPtr	hDevice,					// �豸�����
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpEvrmTemp,				// �¶�
									                        Int32	lChannel );				    // ͨ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetEvrmHum(						                // ��û���ʪ��
									                        IntPtr	hDevice,					// �豸�����
									                        Int32	lDeviceID,					// �豸��ַ
									                        ref Int32	lpEvrmHum,				// ʪ��		
									                        Int32	lChannel );				    // ͨ����


	    //##################################### ���Ź� ################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_HostIsOK(IntPtr hDevice);			                // ��λ���޷�����Ϣ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_EnableWatchdog(					                // �������Ź�(�����ó�ʱ�������ʹ�ܿ��Ź�)
									                        IntPtr	hDevice,	                // �豸������
									                        Int32	lDeviceID);	                // ģ���ַ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_CloseWatchdog(					                // ��ֹ���Ź�����
									                        IntPtr	hDevice,	                // �豸������
									                        Int32	lDeviceID);	                // ģ���ַ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetWatchdogStatus(					            // ��ȡ�����Ź���״̬(S = 1, Host is down; S = 0 OK)
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        ref Int32	lpWatchdogStatus);		// ���Ź�״̬
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_ResetWatchdogStatus(				                // Func: ��λ�����Ź���״̬(S = 0)
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID);					// ģ���ַ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetWatchdogTimeoutVal(				            // ȡ�ÿ��Ź����õ�ʱ����
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        ref Int32	lpInterval);			// ʱ����
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetWatchdogTimeoutVal(				            // ���ÿ��Ź����õ�ʱ����
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32	lInterval);					// ʱ����

	    // ##################################### DIGIT LED ���ú��� #################################
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetDLedMode(						                // �����ʾģʽ����
									                        IntPtr hDevice,						// �豸������
									                        Int32   lDeviceID,					// ģ���ַ
									                        ref Int32  lpDispMode);				// ��ʾģʽ =0x00���¶ȸ�ʽ,=0x01:ŷķֵ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetDLedMode(						                // �޸���ʾģʽ����
									                        IntPtr hDevice,						// �豸������
									                        Int32   lDeviceID,					// ģ���ַ
									                        Int32   lDispMode);					// ��ʾģʽ =0x01���¶ȸ�ʽ,=0x02:ŷķֵ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_GetDLedDispChannel(				                // ���LED��ʾͨ����
									                        IntPtr hDevice,						// �豸������
									                        Int32   lDeviceID,					// ģ���ַ
									                        ref Int32  lpChannel);				// ͨ����,lpChannel = =0xff:����������ʾ
        [DllImport("DAM3000M_64.DLL")]
	    public static extern Int32   DAM3000M_SetDLedDispChannel(				                // ����LED��ʾͨ����
									                        IntPtr hDevice,						// �豸������
									                        Int32   lDeviceID,					// ģ���ַ
									                        Int32   lChannel );				    // ͨ����,lpChannel = =0xff:����������ʾ
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32   DAM3000M_SetDLedValue(						                // ����������ʾֵ
									                        IntPtr hDevice,						// �豸������
									                        Int32   lDeviceID,					// ģ���ַ
									                        String strWriteBuf,				    // ��ʾ���ַ���
									                        Int32   llength);					// ���ݳ���
        //####################### �����������������ַ� ###########################
	    [DllImport("DAM3000M_64.DLL")]	
        public static extern Int32	DAM3000M_WriteDeviceChar(					                // ֱ��д�豸
									                        IntPtr	hDevice,					// �豸������
									                        ref String	strWriteBuf,		    // д������
									                        Int32	llength,					// ���ݳ���
									                        Int32	timeout );			        // ��ʱ��Χ(mS)
	    [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	DAM3000M_ReadDeviceChar(					                // ֱ�Ӷ��豸
									                        IntPtr	hDevice,					// �豸������
									                        ref String	strReadBuf,		    	// ��ȡ������
									                        Int32	llength,					// ���ݳ���
									                        Int32	timeout );			        // ��ʱ��Χ(mS)
											   

        //###########################��ģ����Ϣȷ�Ϻ���  #################################
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

//####################################### �������� ####################################
	    [DllImport("DAM3000M_64.DLL")]	
        public static extern Int32  DAM3000M_AdjustSlopeVal(					                // ΢����ǰ����б��
									                        IntPtr  hDevice,					// �豸������
									                        Int32    lDeviceID,   				// ģ���ַ
									                        Int32    lAdjustVal,	            // ΢��ֵ
									                        Int32    lChannel);					// ͨ����
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32  DAM3000M_StoreSlopeVal(						                // ���õ�ǰֵΪ�������б��
	    								                    IntPtr  hDevice,					// �豸������
									                        Int32    lDeviceID,   				// ģ���ַ
									                        Int32    lChannel);					// ͨ����
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32  DAM3000M_SetFaultSlopeVal(					                // �趨����б��ΪĬ��ֵ
									                        IntPtr  hDevice,					// �豸������
									                        Int32    lDeviceID,   				// ģ���ַ
									                        Int32    lChannel);					// ͨ����	=0xFFΪ����ͨ���ָ�
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32 DAM3000M_SetZeroRepair(						                // �������ƫ�Ʋ���
									                        IntPtr	hDevice,					// �豸������
									                        Int32	lDeviceID,					// ģ���ַ
									                        Int32	lZeroRepair,				// ���ֵ
									                        Int32	lChannel);					// ͨ����
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32 DAM3000M_SetDevTestMode(					                    // ����ģ��������ģʽ
									                        IntPtr  hDevice,					// �豸������
									                        Int32    lDeviceID);			    // ģ���ַ
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32 DAM3000M_ResetModule(						                // ģ����λ
									                        IntPtr  hDevice,					// �豸������
									                        Int32    lDeviceID); 				// ģ���ַ
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	DAM3000M_GetEnvironmentTemp(				                // ȡ�û����¶�(Ϊȡ�ȵ�żֵ��׼��)
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,
									                        ref Single	lpETemprt);
        [DllImport("DAM3000M_64.DLL")]	
	    public static extern Int32	DAM3000M_SetAdjustTemp(				                        // ȡ�û����¶�(Ϊȡ�ȵ�żֵ��׼��)
									                        IntPtr	hDevice,
									                        Int32	lDeviceID,
									                        Byte	lETemprt);
       

    //####################################### ���²������� ####################################
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadMeasuringValue(				// ��ȡ����ֵ 
									IntPtr  hDevice,					// �豸������	
									Int32	lDeviceID,					// ģ���ַ
									UInt16[]	lpADBuffer);				// �������ݵ��û�������128
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_TempResetModule(					// ��λ����ģ�� 
									IntPtr  hDevice,					// �豸������	
									Int32	lDeviceID);					// ģ���ַ
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_SetSensorSerialNumber(				// �޸Ĵ��������
									IntPtr  hDevice,					// �豸������
									Int32	lDeviceID,					// �豸��ַ
									Byte	bChannel,					// ͨ����
									Byte	bSequenceNumber,			// ͨ����˳���
									Byte    bNewNumber,					// �±��
									Boolean	bAuto);						// �Ƿ��Զ����  FALSE�ֶ���� TURE�Զ����(ͨ���� ͨ����˳��� �±�� ������������)
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_GetSensorPara(						// ��ȡ����������
									IntPtr  hDevice,					// �豸������
									Int32	lDeviceID,					// �豸��ַ
									DAM3000M_SENSOR_PARA []pInfo);	// ����������





//####################################### Modus �������ܲ������� ####################################
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadCoils(							// ���̵���״̬
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	bCoilsFlag);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadDiscretes(						// ������������
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	bDIState);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadMultiRegs(						// �����ּĴ���
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	buf);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadInputRegs(						// ������Ĵ���
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									int		len, 
									Byte[]	buf);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_WriteCoil(							// ���õ����̵���
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									int		addr, 
									Byte	status);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_WriteSingleReg(					// ���õ������ּĴ���
									IntPtr  hDevice, 
									Int32	lDeviceID, 
									Int32	addr, 
									Int16   val);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ForceMultiCoils(					// ���ö���̵���
									IntPtr  hDevice, 
									Int32	lDeviceID,
                                    Int32   addr,
                                    Int32   len, 
									Byte[]	bDOState);
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_WriteMultiRegs(					// ���ö�����ּĴ���
									IntPtr  hDevice, 
									Int32	lDeviceID,
                                    Int32   addr,
                                    Int32   len, 
									Byte[]	buf);





	//####################################### �������ʾ ####################################
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_DisplayData(					// ���Բ��� ��ʾ����
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
									UInt16	wData);					// ����
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_DisplaySpecialSymbols(			// ���Բ��� �������
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    UInt16 wSymbols);				// ����
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadData(						// ���Բ��� ������
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    ref UInt16 pwData);				// ����
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadSpecialSymbols(			// ���Բ��� ���������
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    ref UInt16 pwSymbols);				// ����
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32   DAM3000M_DisplayDataSymbols(			// ���Բ��� ��ʾ���ݼ��������
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    UInt16 wData,					// ����
                                    UInt16 wSymbols);				// ����
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_ReadDataSymbols(				// ���Բ��� �����ݼ��������
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    ref UInt16 pwData,					// ����
                                    ref UInt16 pwSymbols);				// ����
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_SetDecimalPoint(				// ����С����λ��
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    Int32 lDecimalPoint);			// С����λ��
        
        [DllImport("DAM3000M_64.DLL")]	
	public static extern Int32 	DAM3000M_GetDecimalPoint(				// ��ȡС����λ��
									IntPtr  hDevice,				// �豸������
									Int32	lDeviceID,				// ģ���ַ
                                    ref Int32 plDecimalPoint);		// С����λ��



    }
}
