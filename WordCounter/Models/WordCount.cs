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
            int matches = 0;
            _outputPhrase = "never";
            if(!ValidWord(checkWord))
            {
                return _outputPhrase;
            }
            char[] charWord = checkWord.ToCharArray();
            char[] charGiven = given.ToCharArray();
            if (charWord.Length <= charGiven.Length)
            {
                for (int i = 0; i <= charGiven.Length - charWord.Length; i++)
                {
                    if (charGiven[i] == charWord[0])
                    {
                        if (i != 0)
                        {
                            if (!IsSpecialChar(charGiven[i-1]))
                            {
                                continue;
                            }
                        }
                        bool notSame = false;
                        for (int j = 1; j <= charWord.Length - 1; j++)
                        {
                            if (charGiven[i+j] != charWord[j])
                            {
                                notSame = true;
                            }
                        }
                        if (notSame)
                        {
                            continue;
                        }
                        if (i + charWord.Length != charGiven.Length)
                        {
                            if (!IsSpecialChar(charGiven[i + charWord.Length]))
                            {
                                continue;
                            }
                        }
                        matches++;
                    }

                }
            }
            if (matches == 1)
            {
                _outputPhrase = "once";
            } else if (matches == 2)
            {
                _outputPhrase = "twice";
            } else if (matches == 3)
            {
                _outputPhrase = "thrice";
            } else if (matches >= 3)
            {
                _outputPhrase = matches.ToString() + " times";
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
                if(IsSpecialChar(charWord[i]))
                {
                    _outputPhrase = "Error: input was not a word";
                    return false;
                }
            }
            return true;
        }

        public bool IsSpecialChar (char ch)
        {
            for (int j=0; j<6; j++)
            {
                if (ch == _specialChars[j])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
