using System;
using System.Collections.Generic;

namespace DevelopmentAndBuildToolsTask1
{
    class Program
    {
        /* 
        Практические задания

        Написать программу, которая принимает из командной строки последовательность символов (строку)
        в качестве аргумента и выводит в консоль максимальное количество неодинаковых 
        последовательных символов в строке.

        Например,
        "123441" > 4
        "ksqaaksqksq" > 7
        "kkkk" > 1
        "sskesler" > 7

        */

        static void Main(string[] args)
        {
            string EnteredText = Console.ReadLine();
            char[] ArrayText = EnteredText.ToCharArray();

            var unequalNumberList = new List <int> ();
            var k = 0;
            unequalNumberList.Add(1);
            

            for (int i = 0; i < ArrayText.Length-1; i++)
            {
                if (ArrayText[i] == ArrayText[i+1])
                {
                    unequalNumberList.Add(1);
                    k += 1;
                    continue;
                }
                unequalNumberList[k] += 1;
                

            }
            unequalNumberList.Sort();
            unequalNumberList.Reverse();
            var maxNumberUnequalChar = unequalNumberList[0];

            Console.WriteLine("Maximum number of unequal consecutive characters: " + maxNumberUnequalChar);

        }
    }
}
