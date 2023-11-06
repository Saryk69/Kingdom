using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Kingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make a kingdom in traiangle
            // king - 1; Royals - 3; ++2
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Rise of Fallen Kindonm" +
                "\nStart or Exit? -> y/n : ");

            var question = Console.ReadLine();
            if (question == "y")
            {
                int x;
                bool token = false;
                while(!token)
                {
                    
                    if (!token)
                    {
                        Console.Write("How many rows?: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x != null || x < 10)
                        {
                            token = true;
                        }
                        else
                        {
                            Console.WriteLine("There must be less then 10 rows!!" + " Reapet again: ");
                        }

                    }
                    else
                    {

                        Console.WriteLine("Boi");
                    }

                }
                // Console.Write("There must be less then 10 rows!!" +"Reapet again: ");
                //Console.Write("How many rows?: ");
                //int x = Convert.ToInt32(Console.ReadLine());


                Console.Write("How many columns?: ");
                int y = Convert.ToInt32(Console.ReadLine());

                //Game game = new Game(x, y);
            }
            else if (question == "n")
            {
                Console.WriteLine("See you next time.");
                Console.ReadLine();
            }

            
        }
    }

    class Game 
    { 
        public Game(int a, int b) 
        {

            int[,] arr = new int[a, b];

                //How many rowns
            for (int i = 0; i < a; i++)
            {
                // What ???? "Odstepy"
                for (int k = b; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        //  1   1       1 - 1   1       
                        //arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                        arr[i, j] = i + 1;
                        
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
