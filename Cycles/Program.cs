
//ex.==========================================

uint oddNumbersCount = 0;
uint evenNumbersCount = 0;

int oddNumbersSum = 0;
int evenNumbersSum = 0;

Console.WriteLine("Enter first number from range");
int currentValue = int.Parse(Console.ReadLine());

Console.WriteLine("Enter last number from range");
int limit = int.Parse(Console.ReadLine());


while(currentValue <= limit)
{
    if (currentValue%2==0) 
    {
        evenNumbersCount++;
        evenNumbersSum += currentValue;    
    }
    else
    {   oddNumbersCount++;
        oddNumbersSum = oddNumbersSum + currentValue;
        

    }
   currentValue++;
}

Console.WriteLine("Quantity of odd numbers: "+ oddNumbersCount);
Console.WriteLine("Quantity of even numbers: " + evenNumbersCount);
Console.WriteLine("Sum of odd numbers: " + oddNumbersSum);
Console.WriteLine("Sum of even numbers: " + evenNumbersSum);

Console.ReadLine();

//for cycle ==================================
for (int i = 4; i < 10; i++)
{
    Console.WriteLine(i);
}

//while cycle =================================

int count1 = 0;
int limited = int.Parse(Console.ReadLine());

while (count1 < limited)
{
    count1++;
    Console.WriteLine(count1);
}

//do while cycle ==============================
int count2 = 0;
do
{
    count2++;
    Console.WriteLine(count2);
}
while (count2<5);


