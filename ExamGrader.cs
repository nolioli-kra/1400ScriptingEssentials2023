<<<<<<< HEAD
using System;
					
public class ExamGrader
{
	public static void Main()
	{
		Console.WriteLine("Please enter your Exam score out of 100.");
		int examScore = Convert.ToInt32(Console.ReadLine());
		if (examScore >= 90) {
		Console.WriteLine("You got an A! Awesome!");
		}
		if (examScore <= 89 && examScore >= 90) {
		Console.WriteLine("You got a B! Nice!");
		}
		if (examScore <= 79 && examScore >= 70) {
		Console.WriteLine("You got a C! Not Bad!");
		}
		if (examScore <= 69 && examScore >= 65) {
		Console.WriteLine("You got a D! Better luck next time!");
		}
		if (examScore <= 64) {
		Console.WriteLine("You got an F! You stupid fr bruh ☠");
		}
	}
}
=======
using System;
					
public class ExamGrader
{
	public static void Main()
	{
		Console.WriteLine("Please enter your Exam score out of 100.");
		int examScore = Convert.ToInt32(Console.ReadLine()); //changes the user input into a number the code can access for math and certain operations
		if (examScore >= 90) {
		Console.WriteLine("You got an A! Awesome!");
		}
		if (examScore <= 89 && examScore >= 90) {
		Console.WriteLine("You got a B! Nice!");
		}
		if (examScore <= 79 && examScore >= 70) {
		Console.WriteLine("You got a C! Not Bad!");
		}
		if (examScore <= 69 && examScore >= 65) {
		Console.WriteLine("You got a D! Better luck next time!");
		}
		if (examScore <= 64) {
		Console.WriteLine("You got an F! You stupid fr bruh ☠"); //writes a skull emoji to let you know you're really bad
		}
	}
}
>>>>>>> f072b4340d1b58c1e3125b22606c29598a8d8535
