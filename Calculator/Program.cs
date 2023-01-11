double firstValue, secondValue;
string action;
Console.WriteLine("Enter first number ");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Enter second number ");
secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("Choose an operation: '+','-','/','*'");
action = Console.ReadLine();
if (action == "+")
{
    Console.WriteLine(firstValue + secondValue);
}
else if(action == "-") 
{
    Console.WriteLine(firstValue - secondValue);

}
else if(action == "*")
{
    Console.WriteLine(firstValue * secondValue);
}
else if(action == "/")
{
    if (secondValue == 0)
        Console.WriteLine(0);
    else
        Console.WriteLine(firstValue / secondValue);
}
else 
{
    Console.WriteLine("Error!Not recognize action");
}
Console.ReadLine();









