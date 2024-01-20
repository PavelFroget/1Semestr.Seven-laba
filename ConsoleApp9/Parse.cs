using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    static class Parse
    {
        public static int Parses(string str)
        {
            int a = 0;
            bool twoNumber = false;
            Console.WriteLine(str);
            while (twoNumber == false)
            {
                twoNumber = int.TryParse(Console.ReadLine(), out a);
                if (twoNumber == false)
                {
                    Console.WriteLine("Ошибка, попробуйте ещё раз");
                }
            }
            return a;
        }
    }
}
