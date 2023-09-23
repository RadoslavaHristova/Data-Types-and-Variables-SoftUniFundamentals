//Input
/*=first line receive the char index you should start with
 *=second line - the index of the last character you should prin*/
int startNum=int.Parse(Console.ReadLine());
int endNum=int.Parse(Console.ReadLine());
//Loop
for (int i=startNum; i<=endNum; i++)
{
    //Print:
    //print part of the ASCII table of characters with "" between 
    Console.Write($"{(char)i} ");
}
