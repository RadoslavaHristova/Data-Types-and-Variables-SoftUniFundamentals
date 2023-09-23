//Input:
//-> the number of people N
//-> the capacity P of the elevato
int peopleQty = int.Parse(Console.ReadLine());
int capacity=int.Parse(Console.ReadLine());
//Calcilations:
//how many courses will be needed to elevate N people
//by using an elevator with the capacity of p persons
int courses=(int)Math.Ceiling((double)peopleQty/capacity);
//Print:
//(courses)
Console.WriteLine(courses);