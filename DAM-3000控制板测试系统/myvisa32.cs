using System;

namespace 控制板测试
{
    class myvisa32
    {

        public static string cmdsend(string device,string cmd)
        {
            string cDEVICE_INSTR = device;
            Int32 viError;
            Int32 viDefRm;
            Int32 viSession;
            Int32 retCnt;
            Int32 i;

            String strIdn;

            byte[] byteReadBuf;

            viError = visa32.viOpenDefaultRM(out viDefRm);

            viError = visa32.viOpen(viDefRm, cDEVICE_INSTR, 0, 5000, out viSession);

            visa32.viPrintf(viSession, cmd);

            byteReadBuf = new byte[128];

            visa32.viRead(viSession, byteReadBuf, 128, out retCnt);

            strIdn = "";
            for (i = 0; i < retCnt; i++)
            {
                strIdn = strIdn + Convert.ToChar(byteReadBuf[i]);
            }
           


            visa32.viClose(viSession);
            visa32.viClose(viDefRm);
            return strIdn;
        }
    }



}
