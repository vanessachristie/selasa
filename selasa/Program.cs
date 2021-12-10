using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input Kalimat".ToUpper());
            var input = Console.ReadLine().ToUpper();
            while (input.Length <= 3)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG!");
                Console.Write("Input Kalimat: ");
                input = Console.ReadLine().ToUpper();
            }
            Console.Write("Input Kata".ToUpper());
            var input2 = Console.ReadLine().ToUpper();
            while (input2.Length <= 1)
            {
                Console.WriteLine("HURUF PADA KATA KURANG PANJANG!");
                Console.Write("Input Kata: ");
                input2 = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("statistik huruf:".ToUpper());

            char[] kata = input.ToCharArray();
            var lala = new List<char>();
            Array.Sort(kata);





        }
    }
}




