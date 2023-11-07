using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
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
                GamePlatforme gamePlatforme = new GamePlatforme(x);
                // End of creatPlatform


                ///Początek akcji CutTree
                Console.Write("\nKtóry rząd usunąć? - ");
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

    class GamePlatforme
    {
        public static int[] board;
        public GamePlatforme(int a) 
        {
            board = new int[a];
            //How many rowns {x}
            for (int i = 0; i < a; i++)
            {
                //How many columns "Odstepy" {y}
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
        }
    }

    class GamePlay : GamePlatforme
    {
        //              CutTree pod spodem
        public GamePlay(int a) : base(a)
        {
            Console.Clear();
            //In this list will be the whole Tree("Platform") <after> cuting the platform in the specific location like: {3}
            List<int> arrayTreeCut = new List<int>(Enumerable.Range(1, 9));

            GamePlatforme arrayTree = new GamePlatforme(a);
            

            foreach (int numer in arrayTree)
            {
                if (arrayTree[a - 1] != numer)
                {
                    
                }

            }
            //How many rowns {x}
            for (int i = 0; i < a; i++)
                {
                    //How many columns "Odstepy" {y}
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







        }

    }

    
}
