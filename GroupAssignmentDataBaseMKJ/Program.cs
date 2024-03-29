﻿using System;


namespace GroupAssignmentDataBaseMKJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosenCategory = Shop.Handler.Categories();
            Console.WriteLine(chosenCategory);

            int chosenproduct = Shop.Handler.ShowAndPickProduct(chosenCategory);
            Console.WriteLine(chosenproduct);
        }

        /// <summary>
        /// Reads the input and gets the Correct number for the menu.
        /// </summary>
        /// <param name="maxNum">The maximum number.</param>
        /// <returns>an int</returns>
        public static int MenuReader(int maxNum)
        {
            int num = 0;
            bool correctInput = false;
            while (!correctInput)
            {
                if (Int32.TryParse(Console.ReadLine(), out num))
                {
                    if(num <= maxNum && num > 0)
                    {
                        correctInput = true;
                    }
                    else
                        Console.WriteLine("Incorrect Input");
                }
                else
                    Console.WriteLine("Incorrect Input");
            }
            return num;
        }

    }
}
