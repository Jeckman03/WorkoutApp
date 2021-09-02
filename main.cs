using System;

class Program {
  public static void Main (string[] args) {
		
		ConsoleHelper.Header();
		Console.WriteLine("1. Create Routine");
		Console.WriteLine("0. Exit Program");
		string userSelecetion = Console.ReadLine();
		int userSelecetionInt;

		while(!int.TryParse(userSelecetion, out userSelecetionInt) || userSelecetionInt != 0 && userSelecetionInt != 1)
		{
			ConsoleHelper.Header();
			Console.WriteLine("Invalid input. Please enter a 1 or 0 for your selsection:");
			Console.WriteLine("1. Create Workout Routine");
			Console.WriteLine("0. Exit Program");
			userSelecetion = Console.ReadLine();
		}

		while(userSelecetionInt != 0)
		{
			// Create new user UserAccountModel
			UserAccountModel user = new UserAccountModel();

			// Naming and creating the new routine
			ConsoleHelper.Header();
			Console.WriteLine("-Creating new routine-");
			Console.Write("What is the name of your routine: ");
			string routineName = Console.ReadLine();

			user.CreateNewRoutine(routineName);

			// Display current routines	
			ConsoleHelper.Header();
			Console.WriteLine("New Routine Created! ");
			Console.WriteLine();

			user.SeeAllRoutines();

			Console.WriteLine();
			Console.WriteLine("Selections:");
			Console.WriteLine("1. Create workout routine");
			Console.WriteLine("2. Add Lifts to a created routine");
			Console.WriteLine("0. Exit Program");
			Console.WriteLine();
			Console.Write("Please select an option: ");
			userSelecetion = Console.ReadLine();

			while(!int.TryParse(userSelecetion, out userSelecetionInt) |userSelecetionInt != 0 && userSelecetionInt != 1)
			{
				ConsoleHelper.Header();
				user.SeeAllRoutines();
				Console.WriteLine();
				Console.WriteLine("Invalid input. Please enter a 1 or 0 for your selsection:");
				Console.WriteLine("1. Create workout routine");
				Console.WriteLine("2. Add Lifts to a created routine");
				Console.WriteLine("0. Exit Program");
				userSelecetion = Console.ReadLine();
		}

			Console.ReadLine();

		}

		Console.Clear();
		Console.WriteLine("Have a great day!");
		Console.ReadLine();




		// Create a new routine
		// user.CreateNewRoutine("Chest Day");
		// user.CreateNewRoutine("Leg Day");
		// user.CreateNewRoutine("Back Day");

		// Add a few lifts
			// user.SelectedRoutine(1).AddNewLift("Squat", 4, 6);
			// user.SelectedRoutine(1).AddNewLift("Front Squat", 3, 6);
			// user.SelectedRoutine(1).AddNewLift("Barbell Lunges", 2, 12);

		// Display routine
		// user.SelectedRoutine(1).DisplayRoutine();

		// ConsoleHelper.DisplayRoutine(routine);
		
    Console.ReadLine();
  }

}

public static class ConsoleHelper
{
	public static void Header()
	{
		Console.Clear();
		Console.WriteLine("---CONSOLE WORKOUT APP---");
		Console.WriteLine();
	}

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