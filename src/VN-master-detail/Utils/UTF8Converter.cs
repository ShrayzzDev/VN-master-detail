using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class UTF8Converter
    {
        public static string GetUTF8String(string str)
        {
            return Encoding.UTF8.GetString(Encoding.Default.GetBytes(str));
        }
    }
}
