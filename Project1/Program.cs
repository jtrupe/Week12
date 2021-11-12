/// Week 12 Project 1
///
/// @author: Julian Trupe
/// Date:  November 11, 2021
///
/// Problem Statement: Rewrite provided code to move class definitions in separate Alien.cs file
//
/// Overall Plan:
/// 1) Create Alien class in seperate Alien.cs file
/// 2) Create properties name(get/set), health(get/set), atk
/// 3) By using atk property for attack power, we may write one GetDamage() method in the Alien class rather than in each derived class
/// 4) Create SnakeAlien, OgreAlien, MarshmallowMan derived classes
/// 5) Create AlienPack class which contains Alien[] aliens and method CalculateDamage()
/// 6) In the main method create one of each derived alien type, and calculate their damage
/// 7) Print damage message to the console

using System;
using Project1;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encountered Aliens!");
            SnakeAlien snek = new SnakeAlien("mr snek", 50);
            OgreAlien ogre1 = new OgreAlien("quasimodo", 150);
            MarshmallowMan mallow = new MarshmallowMan("Mr Stay Puff", 250);
            AlienPack alienHorde = new AlienPack(3);
            alienHorde.AddAlien(snek, 0);
            alienHorde.AddAlien(ogre1, 1);
            alienHorde.AddAlien(mallow, 2);
            Console.WriteLine("Alien Horde deals " + alienHorde.CalculateDamage() + " damage");
        }

    }
}
