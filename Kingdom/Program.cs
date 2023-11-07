using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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
            if(question == "y")
            {
                int x = 0 ;
                int y = 0 ;
                bool token = false;
                while(!token)
                {
                    if(!token)
                    {
                        Console.Write("How many levels?: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        
                        if(0 < x && x < 10)
                        {
                            token = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Limit is for 1 - 9 ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Źle");
                    }

                }

                Console.Clear();
                Game game = new Game(x);

                Console.WriteLine("Który rząd usunąć?");
                int cutTree = Convert.ToInt32(Console.ReadLine());

                //Zakoncczenie akcji CutTree
                GamePlay gamePlay = new GamePlay(cutTree);

            }
            else if(question == "n")
            {
                Console.WriteLine("See you next time.");
                Console.ReadLine();
            }         
        }
    }

    class Game 
    {
        public static int[] board;
        public Game(int a) 
        {
            board = new int[a];
            //How many rowns
            for (int i = 0; i < a; i++)
            {
                // What ???? "Odstepy"
                for (int k = a; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0)
                    {
                        board[i] = 1;
                    }
                    else
                    {
                        board[i] = i + 1;             
                    }                    
                    Console.Write(board[i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();     
        }
    }

    class GamePlay : Game
    {
        public GamePlay(int a) : base(a)
        {
            List<int> array = new List<int>(Enumerable.Range(1, 10));
            int arrayCut; 
                Console.Write(Convert.ToInt32(array[a - 1]));
            Game gameCut = new Game(arrayCut([]));


        }

    }

    
}
