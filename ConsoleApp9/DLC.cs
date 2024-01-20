using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    static class DLC
    {
        public static bool Exit()
        {
            bool Exit = false;
            bool vNumber = false;
            while (vNumber == false)
            {
                Console.Write("Вы хотите выйти? Если да впишите букву _д_ если нет нажмите _н_: ");
                string exit = Console.ReadLine();
                if (exit == "д")
                {
                    vNumber = true;
                    Exit = true;
                }
                else if (exit != "д" && exit != "н")
                {
                    Console.WriteLine("Ошибка, попробуйте ещё раз");
                }
                else if (exit == "н")
                {
                    vNumber = true;
                    Exit = false;
                }
            }
            Console.WriteLine("\n");
            return Exit;
        }
        public static void Print()
        {
            Console.WriteLine("Пекшев Павел Андреевич 6102 - 09.03.01D\n");
        }
    }
}
