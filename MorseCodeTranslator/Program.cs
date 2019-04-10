using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select what you want to translate:");
                Console.WriteLine("1. Text to Morse");
                Console.WriteLine("2. Morse to Text");
                Console.WriteLine("Q. Quit");
                string selection = Console.ReadLine();
                switch (selection.ToUpper())
                {
                    case "1":
                        TextToMorse();
                        break;
                    case "2":
                        MorseToText();
                        break;
                    case "Q":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("That was not a vlid option, try again:");
                        break;
                }

            }
        }

        private static void MorseToText()
        {
            Console.Clear();
            Console.Write("Enter text to translate: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            string output = MorseCodeTranslator.ToText(input);

            Console.WriteLine(output);
            Console.WriteLine();
        }

        static void TextToMorse()
        {
            Console.Clear();
            Console.Write("Enter text to translate: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }
            string output = MorseCodeTranslator.ToMorse(input);

            Console.WriteLine(output);
            Console.WriteLine();
        }
    }
}
