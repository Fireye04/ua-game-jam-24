using Godot;
using System;
using DialogueManagerRuntime;

public partial class Scene1 : Node2D
{
	[Export]
	public Resource dialogue;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		DialogueManager.ShowExampleDialogueBalloon(dialogue, "start");
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
