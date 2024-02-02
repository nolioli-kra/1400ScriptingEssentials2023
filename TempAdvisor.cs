using System;
					
public class TempAdvisor
{
	public static void Main()
	{
		Console.WriteLine("Please enter the current temperature in Celcius!");
		int tempCels = Convert.ToInt32((Console.ReadLine()));
		if (tempCels >= 30) {
			Console.WriteLine("Drink some water! Put that Stanley cup to use!");
		} else {
		Console.WriteLine("You're chillin', enjoy the nice weather!");
		}
	}
}