using System;

public class Settings
{

	public int Steps { get; set; }
	public int MinNumber { get; set; }
	public int MaxNumber { get; set; }
	public Settings()
	{
		Steps = 5;
		MinNumber = 0;
		MaxNumber = 100;
	}
}
