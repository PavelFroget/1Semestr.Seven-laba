using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 6.
    /// </summary>
    class Word
    {
        private string str1;
        private const string str2 = "Варкалось. Хливкие шорьки.Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.О бойся Бармаглота, сын!Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг";
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="str">Строка.</param>
        public Word(string str)
        {
            this.str1 = str;
        }
        /// <summary>
        /// Конструктор без параметра.
        /// </summary>
        /// <param name="str">Строка.</param>
        public Word() 
        {
            this.str1 = str2; 
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 6.
        /// </summary>
        /// <param name="str">Строка.</param>
        public void String2()
        {
            Console.WriteLine(str1);
            Console.WriteLine("Посчитать количество гласных и согласных букв в строке (отдельно)\n");
            WordVowels(str1);
            WordConsonants(str1);
            Console.WriteLine("Вариант 4\nПосчитать количество знаков препинания в строке");
            WordPreparation(str1);
        }
        /// <summary>
        /// Нахождение количества гласных.
        /// </summary>
        /// <param name="str">Строка.</param>
        private void WordVowels(string str)
        {
            Console.Write("Количество гласных: ");
            char[] vowels = new char[] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
            int count1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j] == str[i])
                    {
                        count1++;
                    }
                }
            }
            Console.WriteLine(count1 + "\n");
        }
        /// <summary>
        /// Нахождение количества согласных.
        /// </summary>
        /// <param name="str">Строка.</param>
        private void WordConsonants(string str)
        {
            Console.Write("Количество согласных: ");
            char[] vowels = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'Й', 'К', 'Л', 'М', 'Н', 'П', 'Р', 'С', 'Т', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ' };
            int count1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j] == str[i])
                    {
                        count1++;
                    }
                }
            }
            Console.WriteLine(count1 + "\n");
        }
        /// <summary>
        /// Нахождение количества знаков препинания.
        /// </summary>
        /// <param name="str">Строка.</param>
        private void WordPreparation(string str)
        {
            Console.Write("Количество знак препинания: ");
            char[] vowels = new char[] { ',', '.', '!', '?', ':', ';', '-' };
            int count1 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j] == str[i])
                    {
                        count1++;
                    }
                }
            }
            Console.WriteLine(count1 + "\n");
        }
        
    }
}
