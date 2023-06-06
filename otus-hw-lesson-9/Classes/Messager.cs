using System;

public class Messager
{
	int Variation { get; set; }
		
		public Messager()
		{
		}

	public void Message (int var)
	{
		if (var == 0)
			Console.WriteLine("Числа совпали");
		else if (var < 0)
			Console.WriteLine("Ввели меньше");
		else
			Console.WriteLine("Ввели больше");

	}


}
