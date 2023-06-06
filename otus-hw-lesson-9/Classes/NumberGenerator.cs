using System;

public class NumberGenerator
{

	public int Number { get; set; }

	public Settings Sets { get; set; }
	public NumberGenerator(Settings sets)
	{
		Sets = sets;
		Number = new RandomDigit(Sets.MinNumber, Sets.MaxNumber).Generate();

	}


}
