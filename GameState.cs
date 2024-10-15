using Godot;
using System;

public partial class GameState : Node
{
	public static string choice1 = "";

	public static bool hackingGameSucceeded;

	public static void setC1(string newS) {
		choice1 = newS;
		GD.Print(choice1);
	}
}
