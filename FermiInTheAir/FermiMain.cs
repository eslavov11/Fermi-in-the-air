﻿using System.Threading;
using System;

namespace FermiInTheAir
{
    public class FermiMain
    {
        public static void Main()
        {
            Console.WindowHeight = 40;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;

            FermiInTheAir.Utility.OpeningPage.FrontPageGameName();
            FermiInTheAir.Utility.OpeningPage.OpenPage();
            
            Engine eng = new Engine();
            eng.Run();

        }
    }
}