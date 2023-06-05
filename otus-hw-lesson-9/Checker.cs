using System;

public class Checker
{
	public int Input { get; set; }
	public int ForCheck { get; set; }
	public int Output { get; set; }

	public Checker(int input, int forCheck)
	{
		Input = input;
		ForCheck = forCheck;
		Output = Input.CompareTo(ForCheck);

    }


}
