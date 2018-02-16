# Word Counter
##an app written in C# MVC that takes an input word and given string and checks the string for the number of appearances of that word.

###Specifications:

* There must be at least one character in the input word
** Input: "","The quick brown fox jumps over the lazy dog"
** Output: "Error: please input a word to compare"

* The input 'word' cannot contain any (spaces, commas, semi-colons, colons, dashes, or periods)
** Input: "a cat" , "I saw a cat"
** Output: "Error: input was not a word"

* If the given string does not contain the exact word the app should find no matches
** Input: "cat", "Cat"
** Output: "never"

* If the given string is exactly the same as the word the app should count it.
** Input: "cat", "cat"
** Output: "once"

* If the given string includes the characters of the word, but with other non-(space, comma, semi-colon, colon, dash, or period) characters immediately adjacent, that should not be counted as a match
** Input: "cat", "cats"
** Output: "never"

* If the given string includes the exact characters of the word either adjacent only to (spaces, commas, semi-colons, colons, dashes, or periods) or to the beginning or end of the string, they should be counted
** Input: "cat", "A cat slept."
** Output: "once"

* If the given string includes the word more than once, they should be counted each time
** Input: "cat", "cat cat"
** Output: "twice"

** Input: "cat", "cat cat cat"
** Output: "thrice"

** Input: "cat", "cat cat cat cat"
** Output: "4 times"

* All of the above should work together
** Input: "cat", "Cat cats cat scat scatter cats cat's cat- car cat"
** Output: "thrice"
