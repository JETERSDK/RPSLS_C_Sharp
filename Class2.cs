using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
            int scorePlayer = 0;
            int scoreCPU = 0;
            }


            while (scorePlayer < 3 && scoreCPU < 3)
            {

            }

            Console.WriteLine("Choose between ROCK, PAPER, SCISSORS, LIZARD and SPOCK:    ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            randomInt rnd = new randomInt();

            randomInt = rnd.Next(1, 6);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Cosole.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK") ;
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "PAPER") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "LIZARD") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SPOCK") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }

                    break;
                case 2:
                    inputCPU = "PAPER";
                    Cosole.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER") ;
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "LIZARD") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SPOCK") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                case 3:
                    inputCPU = "SCISSORS";
                    Cosole.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS") ;
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "LIZARD") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SPOCK") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                case 4:
                    inputCPU = "LIZARD";
                    Cosole.WriteLine("Computer chose LIZARD");
                    if (inputPlayer == "LIZARD") ;
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SPOCK") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                case 5:
                    inputCPU = "SPOCK";
                    Cosole.WriteLine("Computer chose SPOCK");
                    if (inputPlayer == "SPOCK") ;
                    {
                        Console.WriteLine("DRAW!!\n\n");
                    }
                    else if (inputPlayer == "ROCK") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "PAPER") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS") ;
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "LIZARD") ;
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                    }
                default:
                    Console.WriteLine("INVALID ENTRY!")
                    break;
            }

        }
        if (scorePlayer == 3)
        {
            Console.WriteLine("PLAYER WON!");
        }
        else if ("scoreCPU == 3")
        {
            Console.WriteLine("CPU WON!");
        }
        else
        {
    
        }
        Console.WriteLine("Do you want to play again?(y/n)");
        string loop = Console.ReadLine();
        if (loop == "y")
        {
             playAgain = true;
        }
        else if (loop == "n")
        {
             playAgain = false;
        }
        else
        { 

        }
    
                
                
}
}