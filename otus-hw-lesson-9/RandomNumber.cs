using System;

public class RandomNumber
{

	public int Number { get; set; }
	public int Min { get; set; }

	public int Max { get; set; }

	public RandomNumber(int _min, int _max)
	{
		Min = _min;
		Max = _max;
		Number = NumberGenerator(Min, Max);
	}

	public int NumberGenerator (int min, int max)
	{

        Random rnd1 = new Random();
		return  rnd1.Next(min, max);

	}


}
