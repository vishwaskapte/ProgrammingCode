// See https://aka.ms/new-console-template for more information
using ProgrammingCode;

// Factorial of a Nummber
Factorial fact = new Factorial();
fact.CountFactor(100);
Console.WriteLine($" ");


//Check Number is Prime or Not
CheckPrime chk = new CheckPrime();
chk.CheckNumberPrimeIsPrimeOrNot(558);
Console.WriteLine($" ");


// Sum of N Natural Numbers
SumOfNaturalNumbers sm = new SumOfNaturalNumbers();
Console.WriteLine($"Sum of N Natural Number is = > {sm.SumOfNumbers(4)} ");