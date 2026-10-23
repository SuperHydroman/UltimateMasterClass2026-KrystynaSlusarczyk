## Lists - GetOnlyUpperCaseWords
Implement the **GetOnlyUpperCaseWords** method, which given a collection of strings, returns a List with only those strings which contain only uppercase letters.

The result collection should **not contain duplicates**.



#### For example:
* for input List **{"one", "TWO", "THREE", "four"}** the result shall be **{"TWO", "THREE"}** 
* for input List **{"one", "TWO", "THREE", "four", "TWO"}** the result shall be **{"TWO", "THREE"}** (the second "TWO" is ignored)
* for input List **{"one", "TWO123", "THREE!&^", "four"}** the result shall be an empty List because no word in this collection is built from only uppercase letters (digits and special characters are not letters at all).

#### Tips:
Strings are collections of characters. It means **we can iterate a string with a foreach loop**, and in each iteration, we have access to a specific character from this string.

<img src="https://img-c.udemycdn.com/redactor/raw/coding_exercise_instructions/2022-08-14_09-30-44-a06e5d1722a6a57aa404c533dc2cdfcf.PNG">

To check if a character is an uppercase letter, we can use the **char.IsUpper** method:

<img src="https://img-c.udemycdn.com/redactor/raw/coding_exercise_instructions/2022-08-14_09-30-44-d5907db19e5b1914396cd8c39c98a204.PNG">

Please notice that **digits and special characters are not letters at all**, so words containing them should not be considered uppercase words. Luckily, the char.IsUpper method covers that; it returns false for any non-letter characters.