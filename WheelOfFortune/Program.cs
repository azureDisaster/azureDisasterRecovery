﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOFClassLib;

namespace WheelOfFortune
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puzzle puzzle = new Puzzle("hello");
            Game game = new Game(); 
            game.Start(); // intializes the game 


            Console.ReadKey();
        }
    }
}
