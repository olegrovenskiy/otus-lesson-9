// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
    {
        Console.WriteLine("Вы угадали");
        break;
    }
    else
    {
        
        
        if (i == step - 1)
            Console.WriteLine("Попытки закончились");
        else if (Input < rr.Number)
            Console.WriteLine("Ввели меньше");
        else
            Console.WriteLine("Ввели больше");
            


    }


}



Console.ReadKey();