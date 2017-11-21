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
            Console.WriteLine("Welcome, Do you want to play vs computer or player 2");
            Console.ReadLine();

            string[] options = new string[] { "rock", "paper", "scissors", "lizard", "spock" };

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
                            return "Player 1 Wins";
                        }
                        else if (playerTwoChoice == "paper" || playerTwoChoice == "spock")
                        {
                            return "Player 2 Wins";
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
                            return "Player 1 Wins";
                        }

                        else if (playerTwoChoice == "scissors" || playerTwoChoice == "lizard")
                        {
                            return "Player 2 Wins";
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
                            return "Player 1 Wins";
                        }
                        else if (playerTwoChoice == "rock" || playerTwoChoice == "spock")
                        {
                            return "Player 2 Wins";
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
                            return "Player 1 Wins";
                        }
                        else if (playerTwoChoice == "scissors" || playerTwoChoice == "rock")
                        {
                            return "Player 2 Wins";
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
                            return "Player 1 Wins";
                        }
                        else if (playerTwoChoice == "lizard" || args[1] == "paper")
                        {
                            return "Plater 2 Wins";
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                default: return "Unhandled case, sorry ERROR ERROR Joe Raleigh.";

            }


        }
    }
}