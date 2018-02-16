# Word Counter

####an app that counts the number of times a word occurs in a phrase.

#### By Tim Firman

## Description

_When the app is run, the local home page becomes a form that asks for a word and a phrase to evaluate.  The app verifies the word then checks the phrase to count the number of times the word occurs.  If the characters of the word occur but are adjacent to letters or symbols other than ( ,;:-.) characters that is not counted.  When a button is pressed, the user is shown a page that tells them the number of occurances of the word in the phrase._

##Specifications:

* There must be at least one character in the input word
** Input: "","The quick brown fox jumps over the lazy dog"
** Output: "Error: please input a word to compare"

* The input 'word' cannot contain any (spaces, commas, semi-colons, colons, dashes, or periods)
** Input: "a cat" , "I saw a cat"
** Output: "Error: input was not a word"

* If the given string is exactly the same as the word the app should count it.
** Input: "cat", "cat"
** Output: "once"

* If the given string does not contain the exact word the app should find no matches
** Input: "cat", "Cat"
** Output: "never"

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
** Input: "cat", "Cat cats cat scat scatter cats cat's cat; car cat"
** Output: "thrice"

## Setup/Installation Requirements

_This software is a C# web server, and would need the obj and bin directories restored (dotnet restore) and built and run.  The latest version of this software is available at https://github.com/tfirman/WordCounter_

## Known Bugs

None Known

## Technologies Used

_This is a MVC C# server, using Razor and styled with Bootstrap._

### License

Copyright (c) 2018 **_Tim Firman_**

This software is licensed under the GPL license.
