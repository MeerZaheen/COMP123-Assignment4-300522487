using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline;
/* 
 * Author: Meer Zaheen Nazmul
 * Student ID: 300522487
 * 
 * Date: July 17,2016
 * Description: This program assigns seats on each flight for the Airline's only plane.
 *  
 * Version: 0.0.1
 */

namespace Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            //Private Menu Method+++++++++++++++++++++++++++++++++++++++++++++++++++++
            /**
             * The Main method for our driver class program
             * 
             * @constructor:Main
             * @param {string[]}args
             */
            int selection = 0;
            while (selection != 3)
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.WriteLine("+ Airline_Reservations_System +");
                Console.WriteLine("+                             +");
                Console.WriteLine("+      1. First Class         +");
                Console.WriteLine("+      2. Economy Class       +");
                Console.WriteLine("+      3. Exit                +");
                Console.WriteLine("+                             +");
                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                    Console.WriteLine(error.Message);
                }

                switch (selection)
                {
                    case 1:
                        ConditionalFirstClass();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        EconomyClass();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorrect entry - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }
            }
        }
        // PRIVATE INSTANCE+++++++++++++++++++++++++++++++++++++++++
        List<String> _seatGuru = new List<string>();
        List<String> seatSelected = new List<string>();

        // PUBLIC INSTANCE+++++++++++++++++++++++++++++++++++++++++
        public static void AirlineSystem()
        {
            List<String> seatGuru = new List<string>();
            List<String> seatSelected = new List<string>();
            // list of First and Enonomy Seatings options
            seatGuru.Add("First Class Seat 1");
            seatGuru.Add("First Class Seat 2");
            seatGuru.Add("First Class Seat 3");
            seatGuru.Add("First Class Seat 4");
            seatGuru.Add("First Class Seat 5");
            seatGuru.Add("Economy Class Seat 6");
            seatGuru.Add("Economy Class Seat 7");
            seatGuru.Add("Economy Class Seat 8");
            seatGuru.Add("Economy Class Seat 9");
            seatGuru.Add("Economy Class Seat 10");
        }
        // PUBLIC METHODS +++++++++++++++++++++

        public void ConditionalFirstClass()
        {
            int seat = 0;
            while (seat < 5)
            {
                if (seatGuru[seat] == 0)
                {
                    seatSelected.Add(seatGuru[seat]);
                    seatGuru.RemoveAt(seat);
                    this.print();
                    break;
                }
                else {
                    Console.WriteLine("First class is fully booked");
                }
                seat++;
            }
        }
        public void print()
        {
            Console.WriteLine("Congratulations! Your Seat is Booked");
        }
    }
 }

