using System;

public class RandomDigitGenerator : IGenerator
{
	//private readonly Random _random;
	public int Min { get; set; }
	public int Max { get; set; }

	public RandomDigitGenerator()
	{

	}

	public int GenerateNumber (int min, int max)
	{
        Random rnd1 = new Random();
        return rnd1.Next(min, max);
    }
}
