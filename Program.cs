using System;

namespace Bruteforce
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.Title = "Simple Local Bruteforce";
            Console.WriteLine("|--Write a word to bruteforce!--|");
            Console.WriteLine("[-Finished-] All chars found! - Password Found: {0}", BruteForcer());
            for (int i = 0; i < 100; i++)
            Console.ReadKey();

        }
        static string BruteForcer()
        {
            string word = Console.ReadLine();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"/\\.,-|+#*'§$%&()=?´<> ";
            string result = "";
            Console.WriteLine("[+][+] Starting BruteForce...");
            for (int x = 0; x <= word.Length - 1; x++)
            {
                foreach (char ch in chars)
                {
                    char pch = Convert.ToChar(word[x]);
                    if (ch == pch)
                    {
                        Console.WriteLine("[Try] Trying: {0}", ch);
                        Console.WriteLine("[Found] Found char: {0}", ch);
                        result += ch;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("[Try] Still Trying: {0}", ch);

                    }

                }
            }
            return result;
        }
    }
}
