using System;

public class RandomNumber
{

	public int Number { get; set; }

	public RandomNumber()
	{
		Number = NumberGenerator();
	}

	public int NumberGenerator ()
	{

        Random rnd1 = new Random();
		return  rnd1.Next(0, 100);

	}


}
