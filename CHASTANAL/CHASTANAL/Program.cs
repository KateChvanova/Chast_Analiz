using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHASTANAL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> text = new List<char>();

            Console.WriteLine("Ведите текст для чистотного анализа: ");
            string input = Console.ReadLine();
            text.AddRange(input);

            int countAllBukva = 0;
            Dictionary<char, int> CountsBukv = new Dictionary<char, int>()
            {
                ['а'] = 0,
                ['б'] = 0,
                ['в'] = 0,
                ['г'] = 0,
                ['д'] = 0,
                ['е'] = 0,
                ['ё'] = 0,
                ['ж'] = 0,
                ['з'] = 0,
                ['и'] = 0,
                ['й'] = 0,
                ['к'] = 0,
                ['л'] = 0,
                ['м'] = 0,
                ['н'] = 0,
                ['о'] = 0,
                ['п'] = 0,
                ['р'] = 0,
                ['с'] = 0,
                ['т'] = 0,
                ['у'] = 0,
                ['ф'] = 0,
                ['х'] = 0,
                ['ц'] = 0,
                ['ч'] = 0,
                ['ш'] = 0,
                ['щ'] = 0,
                ['ъ'] = 0,
                ['ы'] = 0,
                ['ь'] = 0,
                ['э'] = 0,
                ['ю'] = 0,
                ['я'] = 0,
            };

            foreach (char bukva in text)
            {
                if (IsRussianBukva(char.ToLower(bukva)))
                {
                    countAllBukva++;
                    CountsBukv[char.ToLower(bukva)]++;
                }
            }

            //Вывод частоты
            foreach (var bukva in CountsBukv.Keys)
            {
                if (CountsBukv[bukva] != 0)
                {
                    Console.WriteLine("Частота буквы " + bukva + " = " + Math.Round(Chastota(countAllBukva, CountsBukv[bukva]), 2).ToString() + "%");
                }
            }

            Console.ReadLine();
        }

        static bool IsRussianBukva(char bukva)
        {
            char[] rus = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й',
                'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            foreach (var item in rus)
            {
                if (item == char.ToLower(bukva)) return true;
            }
            return false;
        }
        static double Chastota(int allBukvs, int bukva)
        {
            return (double)bukva / (double)allBukvs * 100.0;
        }
    }
}
