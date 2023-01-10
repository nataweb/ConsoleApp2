internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");

        string b = Console.ReadLine();
        int c;
        bool IsCorrect = int.TryParse(b, out c) ;
        if (IsCorrect) 
        {
            int a = int.Parse(b);

            if (a % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        
        }
        else
        {
            Console.WriteLine("Enter a valid number");
        }
    }
}