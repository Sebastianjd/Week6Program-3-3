//Sebastian Diaz
//MAR 2

using System;
using System.Collections.Generic;

namespace Week6Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Write a program and continuously ask the user to enter different names, until the user presses Enter.
            //Depending on the number of names provided, display a message based on a pattern. 
            FacebookPost();

            //Problem 2: Write a program that asks the user to enter a sentence.
            //Display each unique letter in the sentence, and how many times each one appeared.
            SentenceDecipher();
        }

        static void FacebookPost()
        {
            List<string> names = new List<string>();
            string input;
            int num;

            do
            {
                Console.Write("Enter a name or press \"Enter\" to quit: ");
                input = Console.ReadLine();
                names.Add(input);
            } while (input != "");

            num = (names.Count - 1);

            if (num == 0)
            {

            }
            else if (num == 1)
            {
                Console.WriteLine("\n" + names[0] + " likes your post.");
            }
            else if (num == 2)
            {
                Console.WriteLine("\n" + names[0] + " and " + names[1] + " like your post.");
            }
            else if (num == 3)
            {
                Console.WriteLine("\n" + names[0] + ", " + names[1] + " and " + (num - 2) + " other like your post.");
            }
            else
            {
                Console.WriteLine("\n" + names[0] + ", " + names[1] + " and " + (num - 2) + " others like your post.");
            }
        }

        static void SentenceDecipher()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string sentence = "";

            Console.WriteLine("\nEnter a sentence: ");
            sentence = Console.ReadLine();

            foreach(char i in sentence)
            {
                if (i == ' ')
                {

                }
                else if (letters.ContainsKey(i))
                {
                    letters[i] += 1;
                }
                else
                {
                    letters.Add(i, 1);
                }
            }

            foreach(KeyValuePair<char, int> kvp in letters)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }   
}
