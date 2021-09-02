using System;

class Program {
  public static void Main (string[] args) {

		// Create new user UserAccountModel
		UserAccountModel user = new UserAccountModel();

		// Create a new routine
		user.CreateNewRoutine("Chest Day");
		user.CreateNewRoutine("Leg Day");
		user.CreateNewRoutine("Back Day");

		user.SeeAllRoutines();

		Console.WriteLine();

		user.SelectedRoutine(1).DisplayRoutine();



		// Add a few lifts
			// routine.AddNewLift("Squat", 4, 6);
			// routine.AddNewLift("Front Squat", 3, 6);
			// routine.AddNewLift("Barbell Lunges", 2, 12);

		// Display routine
		// ConsoleHelper.DisplayRoutine(routine);
		
    Console.ReadLine();
  }

}

public static class ConsoleHelper
{
	// See all created routines
	public static void SeeAllRoutines(this UserAccountModel routines)
	{
		int routineCount = 1;

		Console.WriteLine("---Current Created Routines---");

		foreach (var routine in routines.MyRoutines)
		{
			Console.WriteLine($"{ routineCount }: { routine.RoutineName }");
			routineCount++;
		}
	}

	// Display workout routine
	public static void DisplayRoutine(this RoutineModel routine)
	{
		Console.WriteLine($"Routine: { routine.RoutineName }");

		foreach (var lift in routine.Lifts)
		{
			Console.WriteLine(lift.LiftName);

			int setCount = 1;

			foreach (var sets in lift.Sets)
			{
				Console.Write($"| Set { setCount }:  ");
				setCount++;
			}

			Console.WriteLine();
			Console.WriteLine();
		}
	}
}