
//nested cycles
Console.Write("Type the height of rectangle: ");
int height = int.Parse(Console.ReadLine());

Console.Write("Type the width of rectangle: ");
int width = int.Parse(Console.ReadLine());

for (int k = 0; k < height; k++)
{
    for (int l = 0; l< width; l++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.ReadLine();

//nested cycles
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("cycle iteration #: " + i);
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("\t cycle iteration #: " +j);
    }
}

//keyword continue

for (int i = 0; i < 10; i++)
{
    if (i == 4) 
    {
        continue;
    }
    Console.WriteLine(i);

}
//keyword break
for(int j = 0; j < 100; j++) 
{
    string msg = Console.ReadLine();
    if(msg == "exit") 
    {
        break;
    }
    Console.WriteLine(j);
}


