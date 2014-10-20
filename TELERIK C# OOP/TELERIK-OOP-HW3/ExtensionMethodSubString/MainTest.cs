using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSubString
{
    class MainTest
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("abcdefghijklmnop");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sb.GetSubstring(1, 5).ToString());
            Console.WriteLine(sb.GetSubstring(5));
        }
        
    }
}
