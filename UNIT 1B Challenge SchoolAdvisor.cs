using System;

public class ExamGrader
{
	public static void Main()
	{
		Console.WriteLine("Please enter your Exam score out of 100.");
		int examScore = Convert.ToInt32(Console.ReadLine());
		if (examScore >= 90)
		{
			Console.WriteLine("You got an A! Awesome!");
		}

		if (examScore <= 89 && examScore >= 80)
		{
			Console.WriteLine("You got a B! Nice!");
		}

		if (examScore <= 79 && examScore >= 70)
		{
			Console.WriteLine("You got a C! Not Bad!");
		}

		if (examScore <= 69 && examScore >= 65)
		{
			Console.WriteLine("You got a D! Better luck next time!");
		}

		if (examScore <= 64)
		{
			Console.WriteLine("You got an F! You stupid fr bruh ☠");
		}

		Console.WriteLine();
		Console.WriteLine("What's your favorite subject?");
		string favoriteSubject = Console.ReadLine();
		
		FavSubjects favSubjects = new FavSubjects(); //create an instance of FavSubjects in Main
		favSubjects.GatherFavSubject(favoriteSubject); //summon the method to get the fave subjects
		
		favSubjects.CheckFavSubject(); //summon the method to check and provide the switch statement feedback on the subjects
	}
}

public class FavSubjects
{
	public enum Subjects
	{
		math,
		science,
		history,
		english,
		scripting,
		lunch,
		gym,
		pe
	}

	public string favSubject; 
	public void GatherFavSubject(string subject) //method in which the user input is translated into usable feedback for favorite subject
	{
		favSubject = subject.ToLower(); //set the value of favsubject without the need to worry about case specifics (ToLower)
	}

	public void CheckFavSubject()
	{
		Subjects subject;
		if (Enum.TryParse(favSubject, true, out subject))
		{
			switch (subject)
			{
				case Subjects.math:
					Console.WriteLine("Don't forget your calculator!");
					break;
				case Subjects.science:
					Console.WriteLine("I can't wait for you to meet the class pet!");
					break;
				case Subjects.history:
					Console.WriteLine("Make sure to bring your textbook! (An your pillow... zzz)");
					break;
				case Subjects.english:
					Console.WriteLine("Bring a Number 2 pencil!");
					break;
				case Subjects.scripting:
					Console.WriteLine("Get ready to overheat in that classroom.");
					break;
				case Subjects.gym:
					Console.WriteLine("Hopefully you brought a change of clothes!");
					break;
				case Subjects.lunch:
					Console.WriteLine("Lunch doesn't count!!!");
					break;
				default:
					Console.WriteLine("Invalid subject");
					break;
			}
		}
		else
		{
			Console.WriteLine("Invalid subject");
		}
	}
}