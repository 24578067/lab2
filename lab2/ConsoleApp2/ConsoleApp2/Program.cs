using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Main()
        {
            string author = "Автор: Торгонин Павел";
            Console.WriteLine(author);
            Console.WriteLine(MyDll.Minimum(1, 45));
            Console.WriteLine(MyDll.NumberToWords(777));

            Console.ReadLine();
        }
    }
}