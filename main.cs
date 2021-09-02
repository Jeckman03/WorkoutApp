using System;

class Program {
  public static void Main (string[] args) {

		// Create a new routine
		RoutineModel routine = new RoutineModel("Leg Day");

		// Add a few lifts
		routine.AddNewLift("Squat", 4, 6);
		routine.AddNewLift("Front Squat", 3, 6);
		routine.AddNewLift("Barbell Lunges", 2, 12);


		// View current lifts in routine
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
		
    Console.ReadLine();
  }
}