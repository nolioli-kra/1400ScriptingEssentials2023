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