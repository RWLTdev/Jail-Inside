using Godot;
using System;

public partial class initializescenarioF : Node
{
	public void CalledByCORE()
	{
		GD.Print("<initializerF> loud and clear! Getting things set up.");
		getstuffinorderTEMP();

		Node CORE = GetNode("/root/Root3D/LogicParent/GameLogic/CORE");
		CORE.Call("STARTFUNCTION");
	}
	private void getstuffinorderTEMP()
	{
		
	}
	private void GetSetStageElements()
	{
		
	}

	//Enemies are already predetermined in Roam
	private void GetSetPlayerElements()
	{

	}

	private void GetSetEnemies()
	{

	}

}
