using Godot;
using Godot.Collections;
using System;
using System.Collections;
using System.Linq;

public partial class ButtonGrid : GridContainer
{
	public Random rand;

	public Godot.Collections.Array buttons;

	[Export]
	public PackedScene button;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		rand = new Random();
		buttons = new Godot.Collections.Array();
		for (int i = 0;i<36;i++) {
			var b = button.Instantiate();
			AddChild(b);
			buttons.Add(b);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}
}
