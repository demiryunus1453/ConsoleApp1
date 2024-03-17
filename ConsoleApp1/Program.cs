using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 20;
            var result = Add3(ref x, y);
            Console.WriteLine(result); // toplam degeri ne olur.
            Console.WriteLine(x); // x in degeri ne olur.
            Console.ReadLine();
        }

        static int Add3(ref int x , int y)  // Geriye değer döndüren bir method dur bu.Burda değer tipi referans tip olarak göstermek 
        {
                                                                                                                
        x = 30;
        return x + y;   

        }
    }
}
