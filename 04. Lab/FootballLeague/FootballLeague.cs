﻿using System;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main()
        {
            string line = Console.ReadLine();
            while(line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}
