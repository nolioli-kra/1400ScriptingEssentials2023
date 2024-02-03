using System;
					
public class TempAdvisor
{
	public static void Main()
	{
		Console.WriteLine("Please enter the current temperature in Celcius!");
		int tempCels = Convert.ToInt32((Console.ReadLine()));
		if (tempCels >= 50) {
			Console.WriteLine("Stay indoors!");
		} 
		if (tempCels < 50 && tempCels >= 40) {
			Console.WriteLine("Drink plenty of water and make sure to wear sunscreen!");
		}
		if (tempCels < 40 && tempCels >= 30) {
			Console.WriteLine("Enjoy the nice weather!");
		}
		if (tempCels < 30 && tempCels >= 20) {
			Console.WriteLine("Great day to get some work done! Be safe out there!");
		}
		if (tempCels < 20 && tempCels >= 10) {
			Console.WriteLine("Might be smart to pack a hoodie or sweater today!");
		}
		if (tempCels < 10 && tempCels >= 0) {
			Console.WriteLine("Roads may be icy today! Dress warm and make some hot cocoa!");
		}
	}
}