# Instructions for the completion of the homework tasks

## Methods Execises Tasks

`1. Empty Cash Receipt`

Add the following line in your code, in order for the copyright sign to be visualed on the console output.

```cs
Console.OutputEncoding = System.Text.Encoding.Unicode;
```

`4. Drawing A Filled Square`

Follow the steps, described under the task.

`5. Fahrenheit To Celsius Converter`

Follow the steps, described under the task.

`6. Calculation Of Triangle Area`

Follow the steps, described under the task.

`7. Raise To Power`

There are two preferrable solutions: either to use an algorithmic aproach with a for loop
or to use a specific method for powers, coming from the Math class.

`8. Greater Than Two Values`

Follow the same logic for the char comparison as the one for integers. When comparing strings, take
the Compare method into consideration.

## Debugging And Code Fixing

`1. Get Multiplication Of Evens And Odds`

Follow the logic from the snippet under the task for the sum of even digits, as well.

`3. Price Change Alert`

Fix the code identation, rename variables and methods and multiply the difference by a specific percentage identfier to get to the result. Think at what place the multiplication must be made given the order of methods invocation. And ideally, improve the code quality.

## Strings Introduction Execises

`1. Conversion Decimal To Other Numeral System`

Use the following algorithm for the conversion to nth numeral system:

```cs
string convertedNumber = "";

while (number != 0)
{
   int remainder = number % numeralSystem;
   convertedNumber += remainder;
   number /= numeralSystem;
}
```

where the number and numeral system come from the input. In the end, resulting number must be reversed and joined by an empty string.

`3. Reverse A String`

Don't use the reverse method. Use a reversed for loop instead.

`4. Unicode Symbols`

For obtaining the escape sequence you can view the snippet below. Make sure to convert the sequence to lower case, as well. Which method will you use?

```cs
static string GetEscapeSequence(char singleCharacter)
{
   return "\\u" + ((int) singleCharacter).ToString("X4");
}
```

`5. Multiplication Of Symbols Codes`

Your input will be an array of strings. Next, the two needed strings are the array elements. To sum the symbol code of the first string use the code snippet below:

```cs
if (firstString.Length > secondString.Length)
{
    minLength = secondString.Length;

    for (int i = minLength; i < firstString.Length; i++)
    {
        sum += (int) firstString[i];
    }
}
```

The else statement will contain the same logic, but in reverse.

Finally, you'll have to iterate through the mininim length of the strings.

```cs
for (int i = 0; i < minLength; i++)
{
    int firstStringCharCode = (int) firstString[i];
    int secondStringCharCode = (int) secondString[i];

    # Increment the sum with the multiplication of the two variables in the scope.           
}
```
`6. Palindromes`

The iteration will be to the length of the string for checking, but divided by the half of it. You are checking
two symmetric elements, the right ones will be defined by the index.

```cs
stringToCheck[length - i - 1]
```
And the elements on the left will have the index of?

Hint: Break the loop, if two elements are not symmetric.

## StringBuilder Execises

`1. StringBuilder Task`

Check the usage of the methods: Append, Remove, Insert, Replace and ToString for the StringBuilder.

Implement the same approach for the commands, as we have done for the arrays manipulation. This time no infinite while
loop will be needed.

`2.  Send Me Email`

Split the email string by the at sign and do the needed subtraction (keep the string lengths in mind). 

`3. Send Me Email Unicode`

Split the email string by the at sign. Loop through each the splitted email sections and increment the sum of the unicode values. The unicode value of the characters can be retrieved by the casting to int. See the task Multiplication Of Symbols Codes from the section Strings Introduction Execises for more information. 
