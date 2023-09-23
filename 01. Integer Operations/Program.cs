//INPUT:
//four integer numbers
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
int number4 = int.Parse(Console.ReadLine());
//Calculations:
/*
 · Add first to the second.
· Divide (integer) the result of the first operation by the third number.
· Multiply the result of the second operation by the fourth number.
 */
int firstOperation = number1 + number2;
int secondOperation = firstOperation / number3;
int thirdOperation = secondOperation * number4;
//PRINT:
//result after the last operation
Console.WriteLine(thirdOperation);
