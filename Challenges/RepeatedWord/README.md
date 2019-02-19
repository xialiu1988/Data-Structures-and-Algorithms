# First repeated word
<!-- Short summary or background information -->

Will given a string with no limied length, and find the first repeated word and return that word.

## Challenge
<!-- Description of the challenge -->

Write a function that accepts a lengthy string parameter.

Without utilizing any of the built-in library methods available to your language, return the first word to occur more than once in that provided string.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

BigO
T->O(n) worst case is go throught the whole string array
S->O(1)

Approach:

Create a hashset, for loop go throught the string array, if hashset already has that word we will return that word.

## Solution
<!-- Embedded whiteboard image -->

