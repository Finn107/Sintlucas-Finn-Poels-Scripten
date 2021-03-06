using System;

namespace DiceGame_Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Concept
            Dobbelsteen spel maken
            Regels voorgelezen in console
            Dubbele dobbelsteen
            3 rondes, degene die het hoogste getal heeft (bij elkaar opgeteld) wint!
            Eind Concept */


            /* Regels 
            Max 4 spelers.
            2 Dobbelstenen waarvan elk 6 kanten heeft (1 t/m 6)
            3 rondes, degene die het hoogste getal heeft (bij elkaar opgeteld) wint!
            Eind Regels */


            /* Pseudocode
              
            ints...
            
            random rnt 

            Write Do you want to play? Type [y/n] to play or close the game. 
              als antwoord = y speel de game af
               anders als antwoord = n sluit het spel af.
                    anders Write [y/n] to play or close the game. 
            Write Regels
            Write You can play with 1-4 persons in 1 game. With how many are you?
            Als antwoord = 1 
            Okay, your going to be playing against a bot! Have fun!

            functie spel met bot
            {
            random numer kiezen...
            Write You rolled...
            Write The bot rolled...
            Wie heeft meer gerolled?
            Write ... Heeft deze ronde gewonnen!
            Speel score af
            Repeat t/m ronde 3
            Winnaar bekendmaken!
            Totale scores laten zien
            }

            functie spel met 2 spelers
            {
            random numer kiezen...
            Write Player 1 rolled...
            Write Player 2 rolled...
            Wie heeft meer gerolled?
            Write Player ... Heeft deze ronde gewonnen!
            Speel score af
            Repeat t/m ronde 3
            Winnaar bekendmaken!
            Totale scores laten zien
            }

            functie spel met 3 spelers
            {
            random numer kiezen...
            Write Player 1 rolled...
            Write Player 2 rolled...
            Write Player 3 rolled...
            Wie heeft meer gerolled?
            Write Player ... Heeft deze ronde gewonnen!
            Speel score af
            Repeat t/m ronde 3
            Winnaar bekendmaken!
            Totale scores laten zien
            }

            functie spel met 4 spelers
            {
            random numer kiezen...
            Write Player 1 rolled...
            Write Player 2 rolled...
            Write Player 3 rolled...
            Write Player 4 rolled...
            Wie heeft meer gerolled?
            Write Player ... Heeft deze ronde gewonnen!
            Speel score af
            Repeat t/m ronde 3
            Winnaar bekendmaken!
            Totale scores laten zien
            }

            ErrorMessage {
            Write 
            }

            Eind Pseudocode */


            /* Code */

            string numberofplayers;
            string yesorno;

            int botrnd;
            int botrnd1;
            int botrnd2;
            int botPoints = 0;

            string player1;
            int player1rnd;
            int player1rnd1;
            int player1rnd2;
            int player1Points = 0;

            string player2;
            int player2rnd;
            int player2rnd1;
            int player2rnd2;
            int player2Points = 0;

            string player3;
            int player3rnd;
            int player3rnd1;
            int player3rnd2;
            int player3Points = 0;

            string player4;
            int player4rnd;
            int player4rnd1;
            int player4rnd2;
            int player4Points = 0;


            Console.WriteLine("Do you want to play? Type [y/n] to play or close the game. ");
            yesorno = Console.ReadLine();

            if (yesorno == "y")
            {
                Rules();
                Console.WriteLine("How many including you want to play this game?");
                numberofplayers = Console.ReadLine();

                if (numberofplayers == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter your name player 1.");
                    player1 = Console.ReadLine();
                    Random random = new Random();

                    for (int i = 0; i < 3; i++)
                    {
                        // Game

                        Intro();

                        player1rnd1 = random.Next(1, 13);
                        player1rnd2 = random.Next(1, 13);
                        player1rnd = player1rnd1 + player1rnd2;

                        botrnd1 = random.Next(1, 13);
                        botrnd2 = random.Next(1, 13);
                        botrnd = botrnd1 + botrnd2;

                        DiceRollPlayer1();

                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();

                        DiceRollBot();
                        WieWintBot();
                    }

                    if (player1Points > botPoints)
                    {
                        Console.WriteLine("Congrats " + player1 + "! You have won the best of three!");
                    }
                    else if (player1Points < botPoints)
                    {
                        Console.WriteLine("Better luck next time " + player1 + "!");
                    }
                }


                if (numberofplayers == "2")
                {

                    Console.WriteLine();
                    Console.WriteLine("Please enter your name player 1.");
                    player1 = Console.ReadLine();

                    Console.WriteLine("Please enter your name player 2.");
                    player2 = Console.ReadLine();

                    player3 = ("0");
                    player3rnd = (0);

                    player4 = ("0");
                    player4rnd = (0);

                    Random random = new Random();

                    for (int i = 0; i < 3; i++)
                    {
                        // Game

                        Intro();

                        player1rnd1 = random.Next(1, 13);
                        player1rnd2 = random.Next(1, 13);
                        player1rnd = player1rnd1 + player1rnd2;

                        player2rnd1 = random.Next(1, 13);
                        player2rnd2 = random.Next(1, 13);
                        player2rnd = player2rnd1 + player2rnd2;

                        DiceRollPlayer1();

                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine();

                        DiceRollPlayer2();

                        WieWintDezeRonde();
                    }
                    WieWint();
                }

                if (numberofplayers == "3")
                {
                    {

                        Console.WriteLine();
                        Console.WriteLine("Please enter your name player 1.");
                        player1 = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your name player 2.");
                        player2 = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your name player 3.");
                        player3 = Console.ReadLine();
                        Console.WriteLine();

                        player4 = ("0");
                        player4rnd = (0);

                        Random random = new Random();

                        for (int i = 0; i < 3; i++)
                        {
                            // Game

                            Intro();

                            player1rnd1 = random.Next(1, 13);
                            player1rnd2 = random.Next(1, 13);
                            player1rnd = player1rnd1 + player1rnd2;

                            player2rnd1 = random.Next(1, 13);
                            player2rnd2 = random.Next(1, 13);
                            player2rnd = player2rnd1 + player2rnd2;

                            player3rnd1 = random.Next(1, 13);
                            player3rnd2 = random.Next(1, 13);
                            player3rnd = player3rnd1 + player3rnd2;

                            DiceRollPlayer1();

                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine();

                            DiceRollPlayer2();

                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine();

                            DiceRollPlayer3();
                            System.Threading.Thread.Sleep(750);


                            WieWintDezeRonde();
                        }
                        WieWint();
                    }
                }


                if (numberofplayers == "4")
                {
                    {

                        Console.WriteLine();
                        Console.WriteLine("Please enter your name player 1.");
                        player1 = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your name player 2.");
                        player2 = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your name player 3.");
                        player3 = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Please enter your name player 4.");
                        player4 = Console.ReadLine();
                        Console.WriteLine();

                        Random random = new Random();

                        for (int i = 0; i < 3; i++)
                        {
                            // Game

                            Intro();

                            player1rnd1 = random.Next(1, 13);
                            player1rnd2 = random.Next(1, 13);
                            player1rnd = player1rnd1 + player1rnd2;

                            player2rnd1 = random.Next(1, 13);
                            player2rnd2 = random.Next(1, 13);
                            player2rnd = player2rnd1 + player2rnd2;

                            player3rnd1 = random.Next(1, 13);
                            player3rnd2 = random.Next(1, 13);
                            player3rnd = player3rnd1 + player3rnd2;

                            player4rnd1 = random.Next(1, 13);
                            player4rnd2 = random.Next(1, 13);
                            player4rnd = player4rnd1 + player4rnd2;

                            DiceRollPlayer1();

                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine();

                            DiceRollPlayer2();

                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine();

                            DiceRollPlayer3();

                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine();

                            DiceRollPlayer4();

                            WieWintDezeRonde();

                    }
                        WieWint();
                    }
            }

            if (yesorno == "n")
            {
                Console.Clear();
            }

            void Intro()
            {
                Console.WriteLine();
                Console.WriteLine("Press any button to roll the dices");
                Console.ReadKey();
                Console.WriteLine();
            }

            void DiceRollBot()
            {
                Console.WriteLine("The bot rolled with dice 1 a " + botrnd1);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine("The bot rolled with dice 2 a " + botrnd2);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine("The bot rolls a total of " + botrnd);
                System.Threading.Thread.Sleep(750);
            }

            void DiceRollPlayer1()
            {
                Console.WriteLine(player1 + " with dice 1 rolls " + player1rnd1);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player1 + " with dice 2 rolls " + player1rnd2);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player1 + " rolls a total of " + player1rnd);
            }

            void DiceRollPlayer2()
            {
                Console.WriteLine(player2 + " with dice 1 rolls " + player2rnd1);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player2 + " with dice 2 rolls " + player2rnd2);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player2 + " rolls a total of " + player2rnd);
            }

            void DiceRollPlayer3()
            {
                Console.WriteLine(player3 + " with dice 1 rolls " + player3rnd1);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player3 + " with dice 2 rolls " + player3rnd2);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player3 + " rolls a total of " + player3rnd);
            }

            void DiceRollPlayer4()
            {
                Console.WriteLine(player4 + " with dice 1 rolls " + player4rnd1);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player4 + " with dice 2 rolls " + player4rnd2);
                System.Threading.Thread.Sleep(1750);
                Console.WriteLine(player4 + " rolls a total of " + player4rnd);
            }

            void WieWintBot()
            {

                if (player1rnd > botrnd)
                {
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1500);
                    player1Points++;
                    Console.WriteLine(player1 + " wins this round!");
                }
                else if (player1rnd < botrnd)
                {
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1500);
                    botPoints++;
                    Console.WriteLine("The bot wins this round!");
                }
                else
                {
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Wow! Its a tie!");
                }
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("The score is now - " + player1 + " : " + player1Points + ". - The bot : " + botPoints + ".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine();
            }

            void WieWint()
            {
                    if (player1Points > player2Points)
                    {
                        if (player1Points > player3Points)
                        {
                            if (player1Points > player4Points)
                            {
                                Console.WriteLine("Congrats " + player1 + " You have won the best of three!");
                            }
                        }
                    }
                    if (player2Points > player1Points)
                    {
                        if (player2Points > player3Points)
                        {
                            if (player2Points > player4Points)
                            {
                                Console.WriteLine("Congrats " + player2 + " You have won the best of three!");
                            }
                        }
                    }
                    if (player3Points > player1Points)
                    {
                        if (player3Points > player2Points)
                        {
                            if (player3Points > player4Points)
                            {
                                Console.WriteLine("Congrats " + player3 + " You have won the best of three!");
                            }
                        }
                    }
                    if (player4Points > player1Points)
                    {
                        if (player4Points > player2Points)
                        {
                            if (player4Points > player3Points)
                            {
                                Console.WriteLine("Congrats " + player4 + " You have won the best of three!");
                            }
                        }
                    }
                }

            void WieWintDezeRonde()
            {
                if (player1rnd > player2rnd)
                {
                    if (player1rnd > player3rnd)
                    {
                        if (player1rnd > player4rnd)
                        {
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1500);
                            player1Points++;
                            Console.WriteLine(player1 + " wins this round!");
                        }
                    }
                }
                if (player2rnd > player1rnd)
                {
                    if (player2rnd > player3rnd)
                    {
                        if (player2rnd > player4rnd)
                        {
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1500);
                            player2Points++;
                            Console.WriteLine(player2 + " wins this round!");
                        }
                    }
                }
                if (player3rnd > player1rnd)
                {
                    if (player3rnd > player2rnd)
                    {
                        if (player3rnd > player4rnd)
                        {
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1500);
                            player3Points++;
                            Console.WriteLine(player3 + " wins this round!");
                        }
                    }
                }
                if (player4rnd > player1rnd)
                {
                    if (player4rnd > player2rnd)
                    {
                        if (player4rnd > player3rnd)
                        {
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(1500);
                            player4Points++;
                            Console.WriteLine(player4 + " wins this round!");
                        }
                    }
                }
                System.Threading.Thread.Sleep(1500);
                    if (numberofplayers == "2")
                    {
                        Console.WriteLine("The score is now - " + player1 + " : " + player1Points + ". - " + player2 + " : " + player2Points + ".");
                    }
                    if (numberofplayers == "3")
                    {
                        Console.WriteLine("The score is now - " + player1 + " : " + player1Points + ". - " + player2 + " : " + player2Points + ". - " + player3 + " : " + player3Points + ".");
                    }
                    if (numberofplayers == "4")
                    {
                        Console.WriteLine("The score is now - " + player1 + " : " + player1Points + ". - " + player2 + " : " + player2Points + ". - " + player3 + " : " + player3Points + ". - " + player4 + " : " + player4Points + ".");
                    }
                    System.Threading.Thread.Sleep(500);
                Console.WriteLine();
            }
        }

            void Rules()
            {
                // Rules
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("Rule 1: You can have between 1 and 4 players, more than 4 would not be logical.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Rule 2: Theres 2 dices wich each has 6 different sides (1 t / m 6)");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Rule 3: 3 rounds, the one with the highest total number at the end wins!");
                System.Threading.Thread.Sleep(2500);

                Console.WriteLine();
            }
        }
        /* Eind Code */
    }
}