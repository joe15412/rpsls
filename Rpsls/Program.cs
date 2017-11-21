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
            Console.WriteLineusing System;
            ("Welcome, Do you want to play vs computer or player 2");
            Console.ReadLine("");


            string[] options = new string[] { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }

        static string checkWinner(string[] args)
        {

            // args == [player1 choice, player2 choice]
            // args[0] == Player 1's choice
            // args[1] == Player 2's choice

            switch (args[0])
            {
                case "Rock":
                    {
                        if (args[1] == "Scissors" || args[1] == "Lizard")
                        {
                            return "Player 1 Wins";
                        }
                        else if (args[1] == "Paper" || args[1] == "Spock")
                        {
                            return "Player 2 Wins";
                        }
                        else
                        {
                            return "Tie game";
                        }
                    }
                case "Paper":
                    {
                        if (args[1] == "Rock" || args[1] == "Spock")
                        {
                            return "Player 1 Wins";
                        }

                        else if (args[1] == "Scissors" || args[1] == "Lizard")
                        {
                            return "Player 2 Wins";
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                case "Scissors":
                    {
                        if (args[1] == "Paper" || args[1] == "Lizard")
                        {
                            return "Player 1 Wins";
                        }
                        else if (args[1] == "Rock" || args[1] == "Spock")
                        {
                            return "Player 2 Wins";
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                case "Lizard":
                    {
                        if (args[1] == "Spock" || args[1] == "Paper")
                        {
                            return "Player 1 Wins";
                        }
                        else if (args[1] == "Scissors" || args[1] == "Rock")
                        {
                            return "Player 2 Wins";
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }
                case "Spock":
                    {
                        if (args[1] == "Rock" || args[1] == "Scissors")
                        {
                            return "Player 1 Wins";
                        }
                        else if (args[1] == "Lizard" || args[1] == "Paper")
                        {
                            return "Plater 2 Wins";
                        }
                        else
                        {
                            return "Tie Game";
                        }
                    }

            }


        }
    }
}