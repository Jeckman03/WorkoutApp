using System;
using System.Collections.Generic;

public class LiftModel
{
	public string LiftName { get; set; }
	public List<SetModel> Sets { get; set; } = new List<SetModel>();

	public LiftModel(string name, int numOfSets, int numOfReps)
	{
		LiftName = name;

		for (var i = 0; i < numOfSets; i++)
		{
			SetModel newSet = new SetModel(numOfReps);
			Sets.Add(newSet);
		}
	}
}