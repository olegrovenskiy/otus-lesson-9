using System;

public class RandomDigitGeneratorLiskov : IGenerator
{
	public int Min { get; set; }
	public int Max { get; set; }

	public RandomDigitGeneratorLiskov()
	{
	}

	public int GenerateNumber (int min, int max)
	{
        Random rnd1 = new Random();
		return rnd1.Next(min, max)/2;
    }
}
