using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace WordCount.Models
{
    public class RepeatCounter
    {
        private string _outputPhrase;
        private char[] _specialChars = " ,;:-.".ToCharArray();

        public string CountMatches (string checkWord, string given)
        {
            _outputPhrase = "never";
            if(!ValidWord(checkWord))
            {
                return _outputPhrase;
            }
            if (checkWord == given)
            {
                return "once";
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
                for (int j=0; j<6; j++)
                {
                    if (charWord[i] == _specialChars[j])
                    {
                        _outputPhrase = "Error: input was not a word";
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
