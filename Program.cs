using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleIguess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var list = new List<string> { "mxcro", "teeth", "adxeu", "fxver" };
            int test = random.Next(list.Count);
            string word=(string)list[test];
            word = word.ToLower();
            int guesses=0;
            List<char> inw = new List<char>();
            //List<char> notin = new List<char>();
            //string word = "testss";
            while(guesses<=6)
            {

                Console.WriteLine("Please enter Valid 5 letter Word.");
                string user = Console.ReadLine();
                user = user.ToLower();
                if (user.Length > 5 || user.Length < 5)
                {
                    Console.WriteLine("To many letters or to Few letters.");
                    Main(args);
                }
                if (guesses >= 6 && word != user)
                {
                    Console.WriteLine("Failure");
                    Console.ReadLine();
                    return;
                }
                else if (word == user)
                {
                    Console.WriteLine("WINNER");
                    Console.ReadLine();
                    return;
                }
                for (int i = 0; i < word.Length; i++)
                    if (word[i] == user[i])
                        Console.WriteLine("{word[i]} In right place.", word[i]);
                foreach (char letter in user)
                {
                    if (word.Contains(letter))
                    {
                        inw.Add(letter);
                        Console.WriteLine(letter + " Is In the Word.");
                    }
                    //else if (word.Contains(letter) != true)
                    //{
                    //    notin.Add(letter);
                    //    Console.WriteLine(letter + " Is NOT In the Word.");
                    //}
                    
                
                }
                guesses = guesses + 1;
            }
            
            Console.ReadLine();

        }
    }
}
