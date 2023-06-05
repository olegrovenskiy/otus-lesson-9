using System;

public class Validator
{
	public bool Validation { get; set; }
	public int Input { get; set; }
	public Validator(int input)
	{
		Input = input;
		Validation = Validate(Input);
	}

	public bool Validate (int input)
	{
		if (input == 0)
			return true;
		return false;
	}
}
