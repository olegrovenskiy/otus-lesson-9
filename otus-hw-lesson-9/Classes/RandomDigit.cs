using System;

public class RandomDigit : IRandomDigit
{
	public int Min { get; set; }
	public int Max { get; set; }
	public RandomDigit(int min, int max)
	{
		Min = min;
		Max = max;
	}

	public int Generate()
	{
        Random rnd1 = new Random();
        return rnd1.Next(Min, Max);
    }

}
