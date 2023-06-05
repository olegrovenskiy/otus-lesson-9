using System;

public class Checker
{
	public Checker()
	{
	}

	public bool Check(int input, int generated)
	{
		if (input == generated)
			return true;
		return false;
	}
}
