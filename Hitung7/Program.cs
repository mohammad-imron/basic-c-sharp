// See https://aka.ms/new-console-template for more information
//int firstnumber;
//int secondnumber;
try
{
Console.Write("Input the First number : ");
int firstnumber = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input the Second number : ");
int secondnumber = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Input the Third number : ");
int thirdnumber = Convert.ToInt32(Console.ReadLine()) ;
var result = firstnumber * secondnumber * thirdnumber ;
Console.WriteLine($"{firstnumber} x {secondnumber} x {thirdnumber} = {result} ");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}