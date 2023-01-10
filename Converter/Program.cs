

//2.
Console.WriteLine("Type your number");
int a ;

a = int.Parse(Console.ReadLine());

if (a == 5 ) 
{
    Console.WriteLine("a equals 5");
}
else
{
    Console.WriteLine("a not equal 5");
}
bool isInfected = false;
if (isInfected)
{
    Console.WriteLine("Person is infected!");
}
else 
{
    Console.WriteLine("Person is healthy!");
}
//3.
//int a = 4;
//int b = 6;
//Console.WriteLine(a<b);

double UsdToUah = 30.50;
double UsdToTl = 18.90;
double USD;

Console.WriteLine("Type your sum in USD");
USD = double.Parse(Console.ReadLine());
Console.WriteLine(USD +" USD in UAH = " + USD * UsdToUah);
Console.WriteLine(USD +" USD in Tl = " + USD * UsdToTl);