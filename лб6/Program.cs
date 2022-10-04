using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace лб6
{
    class Program
    {
        static int IndexOf(string phrase, int startIndex, char[] separators, out char currentSeparator)
        {
            currentSeparator = ' ';
            for (var i = startIndex; i < phrase.Length; i++)
            {
                for (var j = 0; j < separators.Length; j++)
                {
                    if (phrase[i] == separators[j])
                    {
                        currentSeparator = separators[j];
                        return i;
                    }
                }
            }
            return -1;
        }

        static string WordsReverse(string phrase)
        {
            var phraseLength = phrase.Length;
            var retValue = new char[phraseLength];
            var wordStartIndex = 0;

            while (wordStartIndex < phraseLength)
            {
                var separatorIndex = IndexOf(phrase, wordStartIndex, new[] { ' ', ',', '.' }, out char currentSeparator);
                if (separatorIndex == -1)
                {
                    separatorIndex = phrase.Length;
                }
                else
                {
                    retValue[separatorIndex] = currentSeparator;
                }

                var currentIndex = wordStartIndex;
                for (var i = separatorIndex - 1; i >= wordStartIndex; i--)
                {
                    retValue[currentIndex] = phrase[i];
                    currentIndex++;
                }

                wordStartIndex = separatorIndex + 1;
            }

            return new string(retValue);
        }

        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            Console.WriteLine(WordsReverse(text));
            Console.ReadKey();
        }
    }
}
