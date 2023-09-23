//Input 
//First ->The number of snowballs (N) will be an int
using System.Numerics;

int snowballQty=int.Parse(Console.ReadLine());
int  bestSnowballQuality = 0, bestSnowballTime = 0, bestSnowballSnow = 0;
BigInteger bestValue = 0;
for (int i = 0; i < snowballQty; i++)
{
    //Create loop for each snowball:
    /*
    ->The snowballSnow is an int
    ->The snowballTime is an int
    ->The snowballQuality is an int
    */
    int snowballSnow=int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());
    //For each snowball you must CALCULATE its (snowballValue)
    //by the following formula:
    //   (snowballSnow / snowballTime) ^ snowballQuality
    BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

    // FIND the highest calculated snowballValue
    if (snowballValue>bestValue)
    { bestValue = snowballValue;
    bestSnowballQuality=snowballQuality;
        bestSnowballSnow=snowballSnow;
        bestSnowballTime=snowballTime;
    }
}
//PRINT 
//{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestValue} ({bestSnowballQuality})");