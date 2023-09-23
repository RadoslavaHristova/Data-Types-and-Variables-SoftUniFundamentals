//Input:
//receive a number => the starting yield of the source(mined 1st day)
int startYield=int.Parse(Console.ReadLine());
int workingDays = 0, leavingSpice = 0, extractedSpice = 0;
while (startYield >= 100)
{
    //crew consumes 26 spices every day!
    leavingSpice = startYield - 26;
    extractedSpice += leavingSpice;
    workingDays++;
    //every NEXT day the yield drops by 10!
    startYield -= 10;
}
//when yield for next day is less than 100 abandon the source!
//add an additional (minus) 26 after the mine has been exhausted OR
//NB! : the workers can't consume more spice than there is in storage.
extractedSpice -= 26;
if (extractedSpice < 0) { extractedSpice = 0; }
//Print :two separate line
//->how many days the mine has operate
Console.WriteLine(workingDays);
//->the total amount of spice extracted
Console.WriteLine(extractedSpice);
/* Example:
 * 
On day 1 we extract 111 spices and at the end of the shift,
the workers consume 26, leaving 85. The yield drops by 10 to 101.

On day 2 we extract 101 spices, the workers consume 26, leaving 75.

The total is 160 and the yield has dropped to 91.
Since the expected yield is less than 100, we abandon the source.
The workers take another 26, leaving 134.
The mine has operated for 2 days.
 */
