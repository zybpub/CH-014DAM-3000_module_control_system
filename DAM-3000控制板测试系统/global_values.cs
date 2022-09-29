using System;
using System.Collections.Generic;
using System.Text;

namespace 控制板测试
{
    class global_values
    {
        private static int p产品id=0;
        public static int 产品id
        {
            get
            {
                return p产品id;
            }

            set
            {
                p产品id = value;
            }
        }

        private static string p当前测试班组 = "";
        public static string 当前测试班组
        {
            get
            {
                return p当前测试班组;
            }

            set
            {
                p当前测试班组 = value;
            }
        }

        private static string p当前测试人 = "";
        public static string 当前测试人
        {
            get
            {
                return p当前测试人;
            }

            set
            {
                p当前测试人 = value;
            }
        }

    }


}
