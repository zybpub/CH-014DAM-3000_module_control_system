using System;

namespace 控制板测试
{
    class Crc
    {

        ///C#串口通讯CRC校验码计算类
        ///      
        /// 
        /// CS校验(累加和)
        public static string CSCheck(string str)
        {
            if (str.Length == 0) return "";
            else str = str.Trim();
            byte[] sss = ToBytes(str);
            int n = 0;
            for (int i = 0; i < sss.Length; i++)
            {
                n += sss[i];
                if (n > 255) n = n - 256;
            }
            return ToHex(n);
        }
        /// <summary>
        /// AB CD 12 3B     转换为字节数组
        /// </summary>
        /// <param name="hex">十六进制字符串</param>
        /// <returns></returns>
        public static byte[] ToBytes(string hex)
        {
            string[] temp = hex.Split(' ');
            byte[] b = new byte[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Length > 0)
                    b[i] = Convert.ToByte(temp[i], 16);
            }

            return b;
        }

        /// <summary>
        /// 转换为符合本程序的十六进制格式
        /// </summary>
        /// <param name="var">1 2 3 等。</param>
        /// <returns>返回十六进制字符串，如果是1-9的话，前面带零</returns>
        /// <example>例如: 5  ="05"  12 ="0C" 无论何时，都是两位数。  </example>
        public static string ToHex(int var)
        {
            int cs = var;
            string tmp = "";
            if (cs == 0) { tmp = "00"; }
            while (cs > 0)
            {
                int ys;
                cs = Math.DivRem(cs, 256, out ys);
                tmp = tmp.Insert(0, string.Format(" {0}", Right("00" + Convert.ToString(ys, 16), 2).ToUpper()));
            }
            return tmp.Trim();
        }

        //字节数组转16进制字符串
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }


        /// <summary>  
        /// 16进制字符串转换成字节数组  
        /// </summary>  
        /// <param name="s"></param>  
        /// <returns></returns>  
        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            }
            return buffer;
        }


        public static int GetKey(byte[] data)
        {
            int count = data.Length;
            byte[] buf = new byte[data.Length + 2];
            data.CopyTo(buf, 0);
            int ptr = 0;
            int i = 0;
            int crc = 0;
            byte crc1, crc2, crc3;
            crc1 = buf[ptr++];
            crc2 = buf[ptr++];
            buf[count] = 0;
            buf[count + 1] = 0;
            while (--count >= 0)
            {
                crc3 = buf[ptr++];
                for (i = 0; i < 8; i++)
                {
                    if (((crc1 & 0x80) >> 7) == 1)//判断crc1高位是否为1
                    {
                        crc1 = (byte)(crc1 << 1); //移出高位
                        if (((crc2 & 0x80) >> 7) == 1)//判断crc2高位是否为1
                        {
                            crc1 = (byte)(crc1 | 0x01);//crc1低位由0变1
                        }
                        crc2 = (byte)(crc2 << 1);//crc2移出高位
                        if (((crc3 & 0x80) >> 7) == 1) //判断crc3高位是否为1
                        {
                            crc2 = (byte)(crc2 | 0x01); //crc2低位由0变1
                        }
                        crc3 = (byte)(crc3 << 1);//crc3移出高位
                        crc1 = (byte)(crc1 ^ 0x10);
                        crc2 = (byte)(crc2 ^ 0x21);
                    }
                    else
                    {
                        crc1 = (byte)(crc1 << 1); //移出高位
                        if (((crc2 & 0x80) >> 7) == 1)//判断crc2高位是否为1
                        {
                            crc1 = (byte)(crc1 | 0x01);//crc1低位由0变1
                        }
                        crc2 = (byte)(crc2 << 1);//crc2移出高位
                        if (((crc3 & 0x80) >> 7) == 1) //判断crc3高位是否为1
                        {
                            crc2 = (byte)(crc2 | 0x01); //crc2低位由0变1
                        }
                        crc3 = (byte)(crc3 << 1);//crc3移出高位
                    }
                }
            }
            crc = (int)((crc1 << 8) + crc2);
            return crc;
        }


        ///CRC校验
        public static string CRCCheck(string val)
        {
            val = val.TrimEnd(' ');
            string[] spva = val.Split(' ');
            byte[] bufData = new byte[spva.Length + 2];
            bufData = ToBytesCRC(val);
            ushort CRC = 0xffff;
            ushort POLYNOMIAL = 0xa001;
            for (int i = 0; i < bufData.Length - 2; i++)
            {
                CRC ^= bufData[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((CRC & 0x0001) != 0)
                    {
                        CRC >>= 1;
                        CRC ^= POLYNOMIAL;
                    }
                    else
                    {
                        CRC >>= 1;
                    }
                }
            }
            return ToHex(System.BitConverter.GetBytes(CRC));
        }


        /// <summary>
        /// 例如把如下字符串转换成字节数组
        /// AA AA AA AA 0A 00 68 00 06 03 04 54 21 28 22 E5 F3 16 BB BB BB BB   转换为字节数组
        /// </summary>
        /// <param name="hex">十六进制字符串</param>
        /// <returns></returns>
        public static byte[] ToBytesCRC(string hex)
        {
            string[] temp = hex.Split(' ');
            byte[] b = new byte[temp.Length + 2];

            for (int i = 0; i < temp.Length; i++)
            {
                b[i] = Convert.ToByte(temp[i], 16);
            }

            return b;
        }

        /// <summary>
        /// 将字节数据转换为十六进制字符串，中间用 “ ”分割 如：AA AA AA AA 0A 00 68 00 06 03 04 54 21 28 22 E5 F3 16 BB BB BB BB
        /// </summary>
        /// <param name="vars">要转换的字节数组</param>
        /// <returns></returns>
        public static String ToHex(byte[] vars)
        {
            return BitConverter.ToString(vars).Replace('-', ' ').Trim();
        }


      
     
        
        public static string Right(string str, int Length)
        {
            if ((Length <= 0) || (str == null))
            {
                return "";
            }
            int length = str.Length;
            if (Length >= length)
            {
                return str;
            }
            return str.Substring(length - Length, Length);
        }
        ///  LRC校验(LRC错误校验用于ASCII模式)


        /// <summary>
        /// 取模FF(255)
        /// 取反+1
        /// </summary>
        /// <param name="writeUncheck"></param>
        /// <returns></returns>
        public static string LRCheck(string writeUncheck)
        {
            char[] hexArray = new char[writeUncheck.Length];
            hexArray = writeUncheck.ToCharArray();
            int decNum = 0, decNumMSB = 0, decNumLSB = 0;
            int decByte, decByteTotal = 0;

            bool msb = true;

            for (int t = 0; t <= hexArray.GetUpperBound(0); t++)
            {
                if ((hexArray[t] >= 48) && (hexArray[t] <= 57))

                    decNum = (hexArray[t] - 48);

                else if ((hexArray[t] >= 65) & (hexArray[t] <= 70))
                    decNum = 10 + (hexArray[t] - 65);

                if (msb)
                {
                    decNumMSB = decNum * 16;
                    msb = false;
                }
                else
                {
                    decNumLSB = decNum;
                    msb = true;
                }
                if (msb)
                {
                    decByte = decNumMSB + decNumLSB;
                    decByteTotal += decByte;
                }
            }

            decByteTotal = (255 - decByteTotal) + 1;
            decByteTotal = decByteTotal & 255;

            int a, b = 0;

            string hexByte = "", hexTotal = "";
            double i;

            for (i = 0; decByteTotal > 0; i++)
            {
                b = Convert.ToInt32(System.Math.Pow(16.0, i));
                a = decByteTotal % 16;
                decByteTotal /= 16;
                if (a <= 9)
                    hexByte = a.ToString();
                else
                {
                    switch (a)
                    {
                        case 10:
                            hexByte = "A";
                            break;
                        case 11:
                            hexByte = "B";
                            break;
                        case 12:
                            hexByte = "C";
                            break;
                        case 13:
                            hexByte = "D";
                            break;
                        case 14:
                            hexByte = "E";
                            break;
                        case 15:
                            hexByte = "F";
                            break;
                    }
                }
                hexTotal = String.Concat(hexByte, hexTotal);
            }
            return hexTotal;
        }

        public string LRCheck(byte[] code)
        {
            int sum = 0;
            foreach (byte b in code)
            {
                sum += b;
            }
            sum = sum % 255;//取模FF(255)
            sum = ~sum + 1;//取反+1
            string lrc = Convert.ToString(sum, 16);
            return lrc;
        }
    }
  
}
