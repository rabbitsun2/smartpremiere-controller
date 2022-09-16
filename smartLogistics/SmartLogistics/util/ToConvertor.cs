/*
 * Created Date: 2022-08-04 (Thu)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ToConvertor
 * Filename: ToConvertor.cs
 * Description:
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.util
{
    internal class ToConvertor
    {
        public static string ByteToString(byte[] strByte)
        {
            string str = Encoding.Default.GetString(strByte);
            return str;
        }

        public static byte[] StringToByte(string str)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            return StrByte;
        }

    }
}
