using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    static class MorseCodeTranslator
    {
        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
        {
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };

        private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

        static MorseCodeTranslator()
        {
            foreach (KeyValuePair<char, string> code in _textToMorse)
            {
                _morseToText.Add(code.Value, code.Key);
            }
        }


        public static string ToMorse(string input)
        {
            List<string> output = new List<string>(input.Length);
            foreach (char charachter in input.ToUpper())
            {
                try
                {
                    string morseCode = _textToMorse[charachter];
                    output.Add(morseCode);
                }
                catch (KeyNotFoundException)
                {
                    output.Add("!");
                }
            
            }

            return string.Join(" ", output);
        }

        public static string ToText(string input)
        {
            string[] morseArray = input.Split(' ');
            char[] output = new char[morseArray.Length];
            for (int i = 0; i < morseArray.Length; i++)
            {
                try
                {
                    char character = _morseToText[morseArray[i]];
                    output[i] = character;
                }
                catch (KeyNotFoundException)
                {
                    output[i] = '!';
                }

            }
            string s = new string(output);

            return s;
        }
    }
}
