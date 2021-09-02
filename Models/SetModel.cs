using System;
using System.Collections.Generic;

public class SetModel
{
	public int RepGoal { get; set; }
	public int ActualReps { get; set; }
	public int WeightGoal { get; set; }
	public int MaxWeight { get; set; }

	public SetModel(int reps)
	{
		RepGoal = reps;
	}

	public void SetWeight(int weight)
	{
		WeightGoal = weight;

		if (WeightGoal > MaxWeight)
		{
			MaxWeight = WeightGoal;
		}
	}
}