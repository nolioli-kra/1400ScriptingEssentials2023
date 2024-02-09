using System;

public class NumberPyramid
{
	public void Main()
	{
		//read and store the user input as a postive integer and set it as the size of the pyramid
		int pyramidSize = Math.Abs(Convert.ToInt32(Console.ReadLine()));
		//loop to go through each row of the pyramid
		for (var i = 0; i < pyramidSize; i++) //the loop variable of i is initialized at 0, which is where it begins its cycle, 
		{								      //the 2nd statement continues the loop but makes sure it doesnt go above the pyramidsize.
			//define the length of the current pyramid stack
			int stackLength = i + 1;
			//counter to control the number of times to repeat the current value of the row
			int repeatCounter = stackLength;
			//loop to repeat the current value of the row
			while (repeatCounter > 0)
			{
				//using the .Write instead of .WriteLine allows the repeated value of the stack without a new line
				Console.Write(stackLength);
				//decrease the counter after a stack. This ensures that the loop stops when the counter reaches 0
				//as indicated by the "while(repeatCounter > 0)"
				repeatCounter--;
			}

			//move to the next line to begin a new pyramid row
			Console.WriteLine();
		}
	}
}