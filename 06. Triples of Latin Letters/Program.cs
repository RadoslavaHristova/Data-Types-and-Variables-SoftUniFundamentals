//Input: integer N
int input=int.Parse(Console.ReadLine());
//find the first N small Latin letters
//Create loops
for (char a = 'a'; a < 'a' + input; a++)
{
    for (char b = 'a'; b < 'a' + input; b++)
    {
        for (char c = 'a'; c < 'a' + input; c++)
        {
            //PRINT: all triples of the first N small Latin letters
            Console.WriteLine($"{a}{b}{c}");
        }
    }
}

