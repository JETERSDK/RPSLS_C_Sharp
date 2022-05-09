using System;

namespace RPSLS
{
    class Program
{
    static void Main(string[] args)
    {
            string inputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("Choose between ROCK, PAPER, SCISSORS, LIZARD and SPOCK:    ");
            inputPlayer = Console.ReadLine();

            randomInt rnd = new randomInt();

            randomInt = rnd.Next(1,6);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    break;
                case 2:
                    inputCPU = "PAPER";
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    break;
                case 4:
                    inputCPU = "LIZARD";
                    break;
                case 5:
                    inputCPU = "SPOCK";
                    break;
                default:
                    break;
            }

    }
    
                
                
}
}