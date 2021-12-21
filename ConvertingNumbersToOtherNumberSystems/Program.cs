using System;
using System.Collections.Generic;

namespace Converting_numbers_to_other_number_systems
{
    class Program
    {
        /*
        Написать программу, принимающую из командной строки целое число в десятичной системе,
        и основание новой системы счисления (от 2 до 20), вывести в консоль преобразованное
        в эту систему исходное число.
        */

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! Enter any number in decimal system to convert it:");
            var decimalNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter foundation of a new number system (from 2 to 16):");
            int foundation = Convert.ToInt32(Console.ReadLine());


             //var decimalNumber = 765;
             //int foundation = 16;

            var reversedList = new List<int>();


            while (decimalNumber != 0)
            {
                var a = decimalNumber % foundation;
                decimalNumber = decimalNumber / foundation;
                reversedList.Add(a);
            }
            

            if (decimalNumber == 0)
            {
                reversedList.Add(0);
            }
            


            reversedList.Reverse();


            Console.WriteLine("Result in new system:");
            foreach (var i in reversedList)
            {
                if( i < 10)
                {
                    Console.Write(i);
                    continue;
                }
                
                if (i == 10)
                {
                    Console.Write("A");
                    continue;
                }
                if (i == 11)
                {
                    Console.Write("B");
                    continue;
                }
                if (i == 12)
                {
                    Console.Write("C");
                    continue;
                }
                if (i == 13)
                {
                    Console.Write("D");
                    continue;
                }
                if (i == 14)
                {
                    Console.Write("E");
                    continue;
                }
                if (i == 15)
                {
                    Console.Write("F");
                }



                /*
            Console.WriteLine("Hello! Enter any number in decimal system:");
            var decimalNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter foundation of a new number system (from 2 to 10):");
            int foundation = Convert.ToInt32(Console.ReadLine());
            

          //  var decimalNumber = 5;
          //  int foundation = 8;

            var reversedList = new List<int> ();


            while (decimalNumber != 0)
            {
                var a = decimalNumber % foundation;
                decimalNumber = decimalNumber / foundation;
                reversedList.Add(a);
            }

            if (decimalNumber > foundation)
            {
                reversedList.Add(1);
            }
            reversedList.Add(0);

            reversedList.Reverse();
            

            Console.WriteLine("Result in new system:");
            foreach (var i in reversedList)
            {
                Console.Write(i);
            }
            
            
            */
    }
}
    }
}
