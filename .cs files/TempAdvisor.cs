<<<<<<< HEAD
using System; //I'm not really sure why there are two parts of my code on top of each other. I'm assuming it's because of a merge.
					
public class TempAdvisor
{
	public static void Main()
	{
		Console.WriteLine("Please enter the current temperature in Celcius!");
		int tempCels = Convert.ToInt32((Console.ReadLine())); //converts the user input into an integer the code is able toaccess as a number value.
		if (tempCels >= 30) {
			Console.WriteLine("Drink some water! Put that Stanley cup to use!");
		} else {
		Console.WriteLine("You're chillin', enjoy the nice weather!");
		}
	}
=======
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
>>>>>>> f072b4340d1b58c1e3125b22606c29598a8d8535
}