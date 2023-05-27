// See https://aka.ms/new-console-template for more information
//int firstnumber;
//int secondnumber;
try
{
Console.Write("Input the First number : ");
int firstnumber = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input the Second number : ");
int secondnumber = Convert.ToInt32(Console.ReadLine()) ;
var temp = firstnumber;
firstnumber = secondnumber;
secondnumber = temp;
Console.WriteLine("After Swapping : ");
Console.WriteLine($"First number : {firstnumber} ");
Console.WriteLine($"Second number : {secondnumber} ");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}