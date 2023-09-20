using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TimesTableQuetions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void numbergame(int maxMultiple, int length) 
            {
                int n1;
                int n2;

                bool again = true;

                int response = 0;
                int answer;
                int score = 0;
                int best = 0;

                while (again)
                {
                    Console.WriteLine("Press any key to play times table game.");
                    Console.ReadKey();

                    Console.Clear();

                    for (int i = 1; i < length; i++)
                    {
                        Random rnd = new Random();
                        n1 = rnd.Next(1, maxMultiple);
                        n2 = rnd.Next(1, maxMultiple);

                        Console.WriteLine("Question: " + i);
                        Console.WriteLine(n1 + " x " + n2 + " =");

                        answer = n1 * n2;

                        try
                        {
                            response = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Thats not a number.");
                        }

                        if (response == answer)
                        {
                            Console.WriteLine("Correct!");
                            score++;
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Incorect.");
                            Console.WriteLine("");
                        }
                    }

                    Console.WriteLine("You scored: " + score + "/10.");
                    if (score > best) { best = score; }
                    Console.WriteLine("Press enter to play again.");

                    var key = Console.ReadKey();

                    if (key.Key != ConsoleKey.Enter)
                    {
                        break;
                    }
                }

                Console.Clear();
                Console.WriteLine("Your best score was: " + best + ".");
                Console.ReadKey();

            }

            numbergame(30, 10);

        }
    }
}
