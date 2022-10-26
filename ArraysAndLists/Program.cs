﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create an int Array and populate numbers 1-10
            var evens = new List<int>();
            var odds = new List<int>();
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            foreach(int i in nums)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }
            foreach (int i in evens)
            {
                Console.WriteLine($"{i} is even-steven.");
            }
            foreach (int i in odds)
            {
                Console.WriteLine($"{i} is an odd looking number.");
            }
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
