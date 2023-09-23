//Input
/*
->first line, receive N (pokeРower) – an integer.
->second line, receive M (pokeTargetsDistance) – an integer.
->third line, receive Y (exhaustionFactor) – an integer.
 */
int pokeРower=int.Parse(Console.ReadLine());
int pokeTargetsDistance=int.Parse(Console.ReadLine());
int exhaustionFactor=int.Parse(Console.ReadLine());
int targetCounts = 0, originalPokePower = pokeРower;

while (pokeРower >= pokeTargetsDistance)
{
    //start (-)subtracting (pokeTargetsDistance) from (pokeРower)
    //UNTIL (pokeРower) becomes LESS than (pokeTargetsDistance)
    //COUNT! Every time when you subtract (targetCounts)
    pokeРower -= pokeTargetsDistance;
    targetCounts++;
    
    if (pokeРower==originalPokePower*0.5d&&exhaustionFactor!=0)
    {
        //IF (pokeРower) becomes equal to EXACTLY 50 % of its original value:
        //->(/)DIVIDE (pokeРower) by (exhaustionFactor), if it is POSSIBLE!
        pokeРower /= exhaustionFactor;
        //This DIVISION is between integer
    }
    //if NOT possible, you should NOT do it->continue subtracting
}
//When (pokeРower) becomes less than (pokeTargetsDistance)
//Print:
//-> what has remained of (pokeРower)
Console.WriteLine(pokeРower);
//->(targetCounts)
Console.WriteLine(targetCounts);

/*Examples:
 * N = 5, M = 2, Y = 3
 * We start subtracting M from N.
 * N – M = 3 ; 1 target poked
 * N – M = 1 ; 2 targets poked
 * N < M
 * We print what has remained of N, which is 1.
 * We print the count of targets, which is 2.
 

N = 10, M = 5, Y = 2
We start subtracting M from N.
N – M = 5 -> (N is still not less than M, they are equal)
N became EXACTLY 50 % of its original value. 5 is 50 % from 10
So we divide N by Y
N / Y = 5 / 2 = 2. (INTEGER DIVISION)
 */
