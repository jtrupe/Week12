/// Week 12 Lab 1
///
/// @author: Julian Trupe
/// Date:  November 11, 2021
///
/// Problem Statement: Create a phone lookup program using a Dictionary
//
/// Overall Plan:
/// 1) Create PhoneBook class with only property Dictionary (name, number), add, get and remove methods, no additional constructor
/// 2) In the main method create new PhoneBook object
/// 3) Add 2 phone numbers
/// 4) Print one of the numbers to the console
/// 5) Delete the other number

using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook myNumbers = new PhoneBook();
            Console.WriteLine("Let's play with the phone book");
            myNumbers.addNumber("Julian", "7609176229");
            myNumbers.addNumber("Ingrid", "7609439764");
            Console.WriteLine(myNumbers.getNumber("Julian"));
            myNumbers.deleteNumber("Ing");
            myNumbers.deleteNumber("Ingrid");
        }

        public class PhoneBook
        {
            Dictionary<string, string> PhoneNumber = new Dictionary<string, string>();

            public void addNumber(string name, string num)
            {
                PhoneNumber.Add(name, num);
            }
            public string getNumber(string name)
            {
                if (PhoneNumber.ContainsKey(name))
                {
                    return PhoneNumber[name];
                }
                else
                {
                    Console.WriteLine("No phone number found");
                    return " ";
                }
            }
            public void deleteNumber(string name)
            {
                if (PhoneNumber.ContainsKey(name))
                {
                    Console.WriteLine("Deleting number for " + name);
                    PhoneNumber.Remove(name);
                }
                else
                {
                    Console.WriteLine("No phone number found");
                }
            }
        }
    }
}
