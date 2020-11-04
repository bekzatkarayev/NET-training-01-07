## NET-01. Introduction and .NET Basic
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