using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Author: Meer Zaheen Nazmul
 * Student ID: 300522487
 * 
 * Date: July 17,2016
 * Description: This program simulates the rolling of two dice and displaying how many times
 * each result was rolled.
 *  
 * Version: 0.0.1
 */
namespace DiceSim
{
    /**
     * The Maim method for our driver class program
     * @class: program
     */
    class Program
    {
        /**
         * The Main method for our driver class program
         * 
         * @constructor:Main
         * @param {string[]}args
         */
        static void Main(string[] args)
        {
            //instance variables+++++++++++++++++++++++++++++++

            ///Object Of Class Random
            Random random = new Random();
            ///First die
            int firstDie = 0;
            ///Second die
            int secondDie = 0;
            ///Sum of FirstDie and SecondDie
            int sum;
            ///New List 
            List<int> Rolls = new List<int>();
            ///# of times the app should roll
            int rollCount = 36000;
            int[] tallyDimension = new int[36000];

            for (int index = 0; index < rollCount; index++)
            {
                firstDie = random.Next(1, 7);  //Random Rolls from 1 - 6
                secondDie = random.Next(1, 7); //Random Rolls from 1 - 6
                ///Sum of the two values
                sum = firstDie + secondDie;
                ///the number of times each possible sum appears               
                tallyDimension[sum]++;
            }
            Console.WriteLine("Roll #  | # of times rolled | ");
            Console.WriteLine("-----------------------------");
            for (int index = 2; index < 13; index++)
            {

                Console.WriteLine("{0, 5}   | {1, 10}        |", index, tallyDimension[index]);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

        }

    }
}
