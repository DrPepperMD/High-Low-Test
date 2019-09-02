/*
    The High-Low game that is based of the card game by the same name.
    Copyright (C) 2019  DrPepperMD

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.

    Richard Stallman uwu
 */

using System;

namespace high_low
{
    class Program
    {
        static int gain;
        static int bettingamount;
        static int player;
        static int wageramount;
        static int correctguesses;
        static int incorrectguesses;

        static void Main(string[] args)
        {
            Console.Title = "High-Low Game";

            Console.WriteLine("High-Low Game...\n");
            Console.WriteLine("Please Choose A User Name: ");

            Console.ReadLine();
            Console.Clear();

            Wager();
        }

        static void Wager()
        {
            Console.WriteLine("Please Choose How Many Chips You Want...");

            Console.WriteLine("1 = 1000 chips - Very Hard");

            Console.WriteLine("2 = 2000 chips");

            Console.WriteLine("3 = 3000 chips - Normal");

            Console.WriteLine("4 = 4000 chips");

            Console.WriteLine("5 = 5000 chips - Very Easy");

            ConsoleKey wagerselector;
            do
            {
                wagerselector = Console.ReadKey(true).Key;
                switch (wagerselector)
                {
                    case ConsoleKey.D1:
                        wageramount = 1000;
                        Playmode();
                        break;

                    case ConsoleKey.D2:
                        wageramount = 2000;
                        Playmode();
                        break;

                    case ConsoleKey.D3:
                        wageramount = 3000;
                        Playmode();
                        break;

                    case ConsoleKey.D4:
                        wageramount = 4000;
                        Playmode();
                        break;

                    case ConsoleKey.D5:
                        wageramount = 5000;
                        Playmode();
                        break;
                }
            } while (wagerselector != ConsoleKey.D1 && wagerselector != ConsoleKey.D2 && wagerselector != ConsoleKey.D3 && wagerselector != ConsoleKey.D4 && wagerselector != ConsoleKey.D);
        }

        static void Playmode()
        {
            Console.Clear();
            
            Console.WriteLine("How Many Players Do You Want?");

            Console.WriteLine("S = SinglePlayer - Only You And The Dealer");

            Console.WriteLine("M = MultiPlayer - You, Three Others And The Dealer");

            ConsoleKey playercount;
            do
            {
                playercount = Console.ReadKey(true).Key;
                switch (playercount)
                {
                    case ConsoleKey.S:
                        player = 1;
                        GameSinglePlayer();
                        break;

                    case ConsoleKey.M:
                        player = 2;
                        GameMultiPlayer();
                        break;
                }
            } while (playercount != ConsoleKey.S && playercount != ConsoleKey.M);
        }

        static void GameSinglePlayer()
        {
            Console.Clear();

            Console.Write("How Much Do You Want To Bet This Round?: ");
            wageramount = Convert.ToInt32(Console.ReadLine());

            Console.Clear();



            Console.WriteLine("##############################");
            Console.WriteLine("|Your Bet: {0}", bettingamount);
            Console.WriteLine("|Your Chips: {0}", wageramount);
            Console.WriteLine("|Correct Guesses: {0}", correctguesses);
            Console.WriteLine("|Incorrect Guesses: {0}", incorrectguesses);
            Console.WriteLine("##############################");
        }


        static void GameMultiPlayer()
        {
            string[] names = new string[6];
            names[0] = "iop";
            names[1] = "bnm";
            names[2] = "asd";
            names[3] = "wet";
            names[4] = "sdf";
            names[5] = "xcv";
        }
    }
}
