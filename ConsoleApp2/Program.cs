//1.
using System.Globalization;

string str3 = "5";
//NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
//{
//    NumberDecimalSeparator = ".",
//};
int h; 

bool IsCorrect = int.TryParse(str3,out h);
if (IsCorrect)
 {
    Console.WriteLine("The operation success,result is: "+ h);
 }
else 
{
    Console.WriteLine("Can't be converted!");
}

//2.
int f = 10;
int k = 3;
double result = (double)f % k;
Console.WriteLine(result);

//3.
//string str2 = "1.9";

//NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
//{
//    NumberDecimalSeparator = ".",
//};  

//double d = Convert.ToDouble(str2,numberFormatInfo);

//Console.WriteLine(d);





