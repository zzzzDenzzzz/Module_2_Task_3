using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. */

namespace Module_2_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            char[] line = Console.ReadLine().ToCharArray();
            char c = 'A';
            for (int i = 0; i < line.Length; i++)
            {
                line[i] += c;
            }
            Console.WriteLine(line);
            for (int i = 0; i < line.Length; i++)
            {
                line[i] -= c;
            }
            Console.WriteLine(line);
        }
    }
}
