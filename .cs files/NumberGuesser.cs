using System;

public class NumberGuesser
{
	public void Main()
	{
		Random r = new Random();
		int rInt = r.Next(1, 10);
		
		Console.WriteLine("Guess a number between 1 - 10!");
		for (var i = 3; i >= 0; i--)
		{
			int userGuess = Convert.ToInt32(Console.ReadLine());
			
			if (userGuess == rInt)
			{
				Console.WriteLine("Congrats! You guessed the number!");
				i = 0;
			}
			if (userGuess < rInt) 
			{
				Console.WriteLine("Hmm, not quite! Try a higher number.");
				Console.WriteLine("You have " + Convert.ToString(i) + " attempts remaining!");
			}
			if (userGuess > rInt) 
			{
				Console.WriteLine("Too high! Try a lower number!");
				Console.WriteLine("You have " + Convert.ToString(i) + " attempts remaining!");
			}
		}
	}
}