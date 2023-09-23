//Input:
//->first line receive the number of lines, which will follow.
int repetitions=int.Parse(Console.ReadLine());
int litresInTank = 0;

//Loop
for (int i = 0; i < repetitions; i++)
{
    //· On the next N lines, will receive quantities of water
    // which you have to pour into the tank (tank capacity = 255L )
    int pouredLitres = int.Parse(Console.ReadLine());
    litresInTank += pouredLitres;
    //Every time you do NOT have enough capacity to pour the given liters
    //print:  "Insufficient capacity!
    if (litresInTank>255)
        { Console.WriteLine("Insufficient capacity!");
        litresInTank -= pouredLitres;
    }
// CONTINUE reading the next line
}
//PRINT: ONLY the liters in the tank!
Console.WriteLine(litresInTank);