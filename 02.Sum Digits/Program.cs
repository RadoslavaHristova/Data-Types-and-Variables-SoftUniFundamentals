//Input:
//single integer
int input=int.Parse(Console.ReadLine());
int sum = 0;
int currentNumber = 0;
//Calculations:
//find the sum of its digit
while (input!=0)
{
    currentNumber = input % 10;
    sum += currentNumber;
    input = input / 10;
}
//Print:
//(sum)
Console.WriteLine(sum);