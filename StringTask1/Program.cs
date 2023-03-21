using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Въведете стрингове разделени със (space): ");
            string[] strings = Console.ReadLine().Split(' ').ToArray();
            string string1 = strings[0];
            string string2 = strings[1];
            int[] sumCharCode = new int[Math.Max(string1.Length, string2.Length)];
            int len = Math.Min(string1.Length, string2.Length);
            for (int i = 0; i < len; i++)
            {
                sumCharCode[i] = (int)string1[i] * (int)string2[i];
            }
            for (int j = len; j < sumCharCode.Length; j++)
            {
                if (string1.Length > string2.Length)
                {
                    sumCharCode[j] = (int)string1[j];
                }
                else
                {
                    sumCharCode[j] = (int)string2[j];
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(string.Join(" ", sumCharCode));
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
