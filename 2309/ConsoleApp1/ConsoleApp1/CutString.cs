using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CutString
    {
        public static string CuutString(string? text,int min_value)
        {   
            if(text.Length > min_value)
            {
                return text[min_value..];
            }
            else
            {
                return null;
            }
        }
    }
}
