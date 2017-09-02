using System;

namespace Bruteforce
{
    class Program
    {
           //Main
        static void Main(string[] args)
        {
            //Display Title
            Console.Title = "Simple Local Bruteforce";
            //Title colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|--Write a word to bruteforce!--|");
            //Choosing text colour
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[-Finished-] All chars found! - Password Found: {0}",BruteForcer());
            for (int i = 0; i < 100; i++)
            Console.ReadKey();

        }
        static string BruteForcer()
        {
            
            string word = Console.ReadLine();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"/\\.,-|+#*'§$%&()=?´<> ";
            string result = "";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[Start] Starting BruteForce...");
            for (int x = 0; x <= word.Length - 1; x++)
            {
                foreach (char ch in chars)
                {
                    char pch = Convert.ToChar(word[x]);
                    if (ch == pch)
                    {
                        // found char
                        //color correct
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[Found] Found char: {0}", ch);
                        result += ch;
                        break;
                    }
                    else
                    {
                        //color not correct
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[Try] Still Trying: {0}", ch);

                    }

                }
            }
            return result;
        }
    }
}
