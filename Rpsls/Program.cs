using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameType = Program.firstCall();
            int playerOneWins = 0;
            int playerTwoWins = 0;

            if (gameType == "c")
            {
                while(playerOneWins != 2 && playerTwoWins != 2)
                {
                    int winner = Program.computerGame();
                    if (winner == 1)
                    {
                        playerOneWins += 1;
                    }
                    if (winner == 2)
                    {
                        playerTwoWins += 1;
                    }
                }
            }
            else if (gameType == "p")
            {
                while (playerOneWins != 2 && playerTwoWins != 2)
                {
                    int winner = Program.playerGame();
                    if (winner == 1)
                    {
                        playerOneWins += 1;
                    }
                    if (winner == 2)
                    {
                        playerTwoWins += 1;
                    }

                }

            }

            string winningPlayer = "";
            if (playerOneWins == 2)
            {
                winningPlayer = "1";
            }
            else
            {
                winningPlayer = "2";
            }
            string winnerLine = "Player "+winningPlayer+" is the ultimate winner!";



            Console.WriteLine(winnerLine);
            Console.WriteLine("Play again? [y]es or [n]o?");
            if (Console.ReadLine() == "y")
            {
               Program.Main(null);
            }
        }

        static int computerGame()
        {
            string[] options = new string[] { "rock", "paper", "scissors", "lizard", "spock" };

            Console.WriteLine("Choose your weapon: Rock, Paper, Scissors, Lizard, Spock.");
            string playerOneChoice = Console.ReadLine();

            Random random = new Random();
            string playerTwoChoice = options[random.Next(0, 5)];

            string[] choices = new string[] { playerOneChoice, playerTwoChoice };

            string winner = checkWinner(choices);
            Console.WriteLine(winner);
            if (winner.Contains("1"))
            {
                return 1;
            }
            else if (winner.Contains("2"))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        static int playerGame()
        {
            Console.WriteLine("Player 1, Choose your weapon: Rock, Paper, Scissors, Lizard, Spock.");
            string playerOneChoice = Console.ReadLine();
            Console.WriteLine("Player 2, Choose your weapon: Rock, Paper, Scissors, Lizard, Spock.");
            string playerTwoChoice = Console.ReadLine();

            string[] choices = new string[] { playerOneChoice, playerTwoChoice };

            string winner = checkWinner(choices);
            Console.WriteLine(winner);
            if (winner.Contains("1"))
            {
                return 1;
            }
            else if (winner.Contains("2"))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        static string firstCall()
        {
            Console.WriteLine("Welcome, Do you want to play vs [c]omputer or [p]layer 2");
            string response = Console.ReadLine();

            if (response == "c")
            {
                // computer
                Console.WriteLine("Goodluck.");
                return response;
            }
            else if (response == "p")
            {
                // player
                Console.WriteLine();
                return response;
            }
            else
            {
                Console.WriteLine("Whoops, bad attempt to play the game, try again" );
                firstCall();
                // bad response
            }
            return "";
        }

        static string checkWinner(string[] args)
        {

            // args == [player1 choice, player2 choice]
            // args[0] == Player 1's choice
            // args[1] == Player 2's choice

            string playerOneChoice = args[0].ToLower();
            string playerTwoChoice = args[1].ToLower();

            switch (playerOneChoice)
            {
                case "rock":
                    {
                        if (playerTwoChoice == "scissors" || playerTwoChoice == "lizard")
                        {
                            return "Player 1 Wins "+playerOneChoice+" beats "+playerTwoChoice;
                        }
                        else if (playerTwoChoice == "paper" || playerTwoChoice == "spock")
                        {
                            return "Player 2 Wins "+playerTwoChoice+" beats "+playerOneChoice;
                        }
                        else
                        {
                            return "Tie game";
                        }
                    }
                case "paper":
                    {
                        if (playerTwoChoice == "rock" || playerTwoChoice == "spock")
                        {
                            return "Player 1 Wins " + playerOneChoice + " beats " + playerTwoChoice;
                        }

                        else if (playerTwoChoice == "scissors" || playerTwoChoice == "lizard")
                        {
                            return "Player 2 Wins " + playerTwoChoice + " beats " + playerOneChoice;
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                case "scissors":
                    {
                        if (playerTwoChoice == "paper" || playerTwoChoice == "lizard")
                        {
                            return "Player 1 Wins " + playerOneChoice + " beats " + playerTwoChoice;
                        }
                        else if (playerTwoChoice == "rock" || playerTwoChoice == "spock")
                        {
                            return "Player 2 Wins " + playerTwoChoice + " beats " + playerOneChoice;
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                case "lizard":
                    {
                        if (playerTwoChoice == "spock" || playerTwoChoice == "paper")
                        {
                            return "Player 1 Wins " + playerOneChoice + " beats " + playerTwoChoice;
                        }
                        else if (playerTwoChoice == "scissors" || playerTwoChoice == "rock")
                        {
                            return "Player 2 Wins " + playerTwoChoice + " beats " + playerOneChoice;
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                case "spock":
                    {
                        if (playerTwoChoice == "rock" || playerTwoChoice == "scissors")
                        {
                            return "Player 1 Wins " + playerOneChoice + " beats " + playerTwoChoice;
                        }
                        else if (playerTwoChoice == "lizard" || args[1] == "paper")
                        {
                            return "Player 2 Wins " + playerTwoChoice + " beats " + playerOneChoice;
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                default: return "sorry...ERROR.";

            }


        }
    }
}