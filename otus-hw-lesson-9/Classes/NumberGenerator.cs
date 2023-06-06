using System;

public class NumberGenerator
{

	public int Number { get; set; }

	public IGenerator Generator { get; set; }
	public Settings Sets { get; set; }

	public int GenerateNumber()
	{
		return Generator.GenerateNumber(Sets.MinNumber, Sets.MaxNumber);
	}
	public NumberGenerator(IGenerator generator, Settings settings)
	{
		this.Generator = generator;
		Sets = settings;
		Number = GenerateNumber();
	}


}
