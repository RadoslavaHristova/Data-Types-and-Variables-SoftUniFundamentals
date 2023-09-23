//input : Qty of repetitions
int repetitions=int.Parse(Console.ReadLine());
string biggestModel = "";
double biggestKeg = 0;
//loop
for (int i = 0; i < repetitions; i++)
{
    /*
    · First – model – string
    · Second –radius – floating-point number
    · Third – height – integer numbe
     */
    string model=Console.ReadLine();
    double radius=double.Parse(Console.ReadLine());
    int height=int.Parse(Console.ReadLine());
    //Calculate the volume using the following formula: π * r^2 * h.
    double volume=Math.PI*Math.Pow(radius,2)*height;
    //Find the Model of the biggest keg (keep it)
    if(volume>=biggestKeg)
    {  biggestKeg = volume;
        biggestModel = model;
    }
}
//PRINT: the model of the biggest keg.
Console.WriteLine(biggestModel);

