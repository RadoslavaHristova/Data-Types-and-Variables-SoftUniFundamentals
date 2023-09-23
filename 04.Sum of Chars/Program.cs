//Input 
//· On the first line, you will receive N – the number of lines
int inputsQty=int.Parse(Console.ReadLine());
int sum = 0;
//Create Loop
for (int i=1; i<=inputsQty; i++)
{
    //· On the next n lines – you will receive letters
    //Calculation: sum the ASCII codes of the letters characters
   char input= char.Parse(Console.ReadLine()) ;
    sum += (int)input ;
}
//Print "The sum equals: {totalSum}"
Console.WriteLine($"The sum equals: {sum}");
