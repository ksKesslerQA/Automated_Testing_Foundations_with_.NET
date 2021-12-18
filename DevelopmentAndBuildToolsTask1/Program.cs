using System;

namespace DevelopmentAndBuildToolsTask1
{
    class Program
    {
        /* 
        Практические задания

Написать программу, которая принимает из командной строки последовательность символов (строку)
        в качестве аргумента и выводит в консоль максимальное количество неодинаковых 
        последовательных символов в строке
        */

        static void Main(string[] args)
        {
            string EnteredText = Console.ReadLine();
            char[] ArrayText = EnteredText.ToCharArray();
            var maxNumberUnequalChar = 1;

            for (int i = 0; i < ArrayText.Length-1; i++)
            {
                if (ArrayText[i] != ArrayText[i+1])
                {
                   maxNumberUnequalChar += 1;
                }

            }
            Console.WriteLine("Maximum number of unequal consecutive characters: " + maxNumberUnequalChar);

        }
    }
}
