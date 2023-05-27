// See https://aka.ms/new-console-template for more information
float firstnumber;
float secondnumber;
Console.Write("Input the First Number : ");
firstnumber=int.Parse(Console.ReadLine());
Console.Write("Input the Second Number : ");
secondnumber=int.Parse(Console.ReadLine());
var result=firstnumber/secondnumber;
Console.WriteLine($"After Divide  {result}");
