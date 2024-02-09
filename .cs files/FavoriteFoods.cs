using System;
					
public class FavoriteFoods
{
	public static void Main()
	{
		Console.WriteLine("Please enter your three favorite foods!");
		Console.WriteLine("Separate each word with a space");
		string input = Console.ReadLine();
		string[] foods = input.Split(' ');
		
		for (int f = 0; f < foods.Length; f++) {
			Console.WriteLine("I love " + foods[0 + f] + "!");
		}
	}
}