## NET-01. Introduction and .NET Basics
### Part 06. Basic Coding in C# 

#### Task 01
InsertNumber algorithm inserts bits of one 4 byte signed integer into another. Insertion is done by replacing bits from j-th to i-th position of source number with bits of other number. 

To achieve this, InsertNumber method first converts both numbers into binary strings, then builds new binary string bit by bit.
This string is converted to integer and returned as a result. MSTest and NUnit unit tests are added.

#### Task 02
FindMax recursive algorithm looks for maximum element in the given unsorted integer array.

Basically, last two elements of the array are compared, lesser one is ignored and array is resized by one. 
Resulting array is passed to FindMax method repeatedly until single element is left, that is the largest element of the initial array.
NUnit unit tests are provided.

#### Task 03
"Balanced array" is an array of size n, which has an element at position i, so that sum of elements at positions 0, 1, ..., i-1  and sum of elements at positions i+1, i+2, ..., n-1 are equal. FindElementOfBalancedArray algorithm searches for an element in the input array that makes the array "balanced". 

Since array contains real numbers, decimal type was used to ensure precision of calculation. 
Each element of the array is checked for the condition, first matching element's index is returned.
If no such element is found, null is returned. NUnit unit tests are provided.

#### Task 04
ConcatenateStringsWithoutRepeat algorithm concatenates one string to another and removes all repetittions of the characters.

Firstly, an array of characters is created of size equal to total length of given two strings. 
Then, it is filled with one instance of each character that appears in the strings. 
To convert the array to string and remove all null elements StringBuilder type is used.
NUnit unit tests are provided.

#### Task 05
<p align="justify">FindNextBiggerInteger method searches for nearest integer that is bigger than and contains exact same digits as the given integer.
It returns such integer, if found, and also time, that was needed to do the search.</p>

<p align="justify">First, an array containing digits of the input number is created, digits are placed in the same position as they are located in the number.
Closest needed number is obtained by swapping two consecutive digits that stand in ascending order. 
After that all other elements starting from the swapping position till the end of the array should be sorted in ascending order.
If all the digits in the number are in descending order initially, then no such number can be found.
Execution time of the method is calculated by using instance of StopWatch class.
NUnit unit tests are provided.</p>