
//for ==================================================
//for (int i = 4; i < 10; i++)
//{
//    Console.WriteLine(i);
//}//for with different conditions========================
for (int a = 0,b=10; a < 5 ; a++,b--)
{
    Console.WriteLine("a: " + a);
    Console.WriteLine("b: " + b);
}

//for with 2 conditions================================
for (int i=0,j=5; i < 10 && j<12; i++,j++)
{
    Console.WriteLine("i " + i );
    Console.WriteLine("j " + j);
}

//for cycle in reverse order ===========================
int k = int.Parse(Console.ReadLine());

for (; k >= 0;k--)
{
    Console.WriteLine(k);
}


