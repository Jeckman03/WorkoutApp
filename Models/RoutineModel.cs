using System;
using System.Collections.Generic;

public class RoutineModel
{
	public string RoutineName { get; set; }
	public List<LiftModel> Lifts { get; set; } = new List<LiftModel>();

	public RoutineModel(string name)
	{
		RoutineName = name;
	}

	public void AddNewLift(string name, int numOfSets, int numOfReps)
	{
		LiftModel newLift = new LiftModel(name, numOfSets, numOfReps);
		
		Lifts.Add(newLift);
	}
}