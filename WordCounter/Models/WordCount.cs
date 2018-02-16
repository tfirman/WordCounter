using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace WordCount.Models
{
    public class RepeatCounter
    {
        private string _outputPhrase;

        public string CountMatches (string checkWord, string given)
        {
            _outputPhrase = "The quick brown fox jumps over the lazy dog";
            if(!ValidWord(checkWord))
            {
                return _outputPhrase;
            }
            return _outputPhrase;
        }

        public bool ValidWord (string word)
        {
            if (word == "")
                {
                    _outputPhrase = "Error: please input a word to compare";
                    return false;
                }
            char[] charWord = word.ToCharArray();
            for (int i=0; i<charWord.Length; i++)
            {
                if (charWord[i] == ' ')
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
                if (charWord[i] == ',')
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
                if (charWord[i] == ';')
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
                if (charWord[i] == ':')
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
                if (charWord[i] == '-')
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
                if (charWord[i] == '.')
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
            }
            return true;
        }
    }
}
