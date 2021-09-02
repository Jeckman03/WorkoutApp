using System;
using System.Collections.Generic;

public class UserAccountModel
{
	public List<RoutineModel> MyRoutines { get; set; } = new List<RoutineModel>();

	public void CreateNewRoutine(string routineName)
	{
		RoutineModel newRoutine = new RoutineModel(routineName);

		MyRoutines.Add(newRoutine);
	}

	public RoutineModel SelectedRoutine(int selection)
	{
		return MyRoutines[selection];
	}

}