// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sets = new Settings();
var rndm = new RandomDigitGenerator();
//var random = new NumberGenerator(sets);

Console.WriteLine($"угадайте число от {sets.MinNumber} до {sets.MaxNumber} за {sets.Steps} попытки");
var digit = (rndm.GenerateNumber(sets.MinNumber, sets.MaxNumber));

Console.WriteLine(digit);

for (int i = 0; i < sets.Steps; i++)
{
    Console.WriteLine("Введите число");
    int Input = int.Parse(Console.ReadLine());
    var dd = new Checker(Input, digit);
    var ff = new Messager();
    ff.Message(dd.Output);
    var vv = new Validator(dd.Output);
    if (vv.Validation)
        break;
    if (i == sets.Steps - 1)
        Console.WriteLine("Попытки закончились");

}



























/*
int first = 5;
int second = 5;


Console.WriteLine(first.CompareTo(second));


Console.ReadKey();

var rr = new RandomNumber();
var dd = new Checker();
int step = 5;


Console.WriteLine(rr.Number);

//int Input = int.Parse(Console.ReadLine());

Console.WriteLine("угадайте число от 1 до 99 за " + step + " попытки");

for (int i = 0; i < step; i++)
{
    Console.WriteLine("Введите число");
    int Input = int.Parse(Console.ReadLine());
    if (dd.Check(Input, rr.Number))
        break;
    

}

*/

Console.ReadKey();