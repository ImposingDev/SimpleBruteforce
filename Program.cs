using System;

namespace Bruteforce
{
    class Program
    {
 
        static void Main(string[] args)
        {
            //Set Title
            Console.Title = "Simple Local Bruteforce";
            Console.WriteLine("|--Write a word to bruteforce!--|");
            //Start the Bruteforce
            Console.WriteLine("[-Finished-] All chars found! - Password Found: {0}", BruteForcer());
            for (int i = 0; i < 100; i++)
            //for not automatically closing
            Console.ReadKey();

        }
        static string BruteForcer()
        {
            //read the word
            string word = Console.ReadLine();
            //all chars
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"/\\.,-|+#*'§$%&()=?´<> ";
            string result = "";
            
            Console.WriteLine("[WORKING] Starting BruteForce...");
            //BRUTEFORCE
            for (int x = 0; x <= word.Length - 1; x++)
            {
                foreach (char ch in chars)
                {
                    char pch = Convert.ToChar(word[x]);
                    if (ch == pch)
                    {
                        //if match
                        Console.WriteLine("[Try] Trying: {0}", ch);
                        Console.WriteLine("[Found] Found char: {0}", ch);
                        result += ch;
                        break;
                    }
                    else
                    {
                        //if not matched
                        Console.WriteLine("[Try] Still Trying: {0}", ch);

                    }

                }
            }
            //result
            return result;
        }
    }
}
