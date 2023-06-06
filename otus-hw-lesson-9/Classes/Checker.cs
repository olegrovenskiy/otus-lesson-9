using System;

public class Checker : IChecker
{
	public int Input { get; set; }
	public int ForCheck { get; set; }
	public int Output { get; set; }

	public Checker(int input, int forCheck)
	{
		Input = input;
		ForCheck = forCheck;
		Output = Check (Input, ForCheck);

    }

	public int Check (int input, int forcheck)
	{
		return input.CompareTo(forcheck);
    }

}
