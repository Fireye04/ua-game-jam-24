using Godot;
using System;
using System.Diagnostics.Tracing;

public partial class InterfaceButton : Button
{	
	[Export]
	public Theme redTheme;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void makeRed() {
		Theme = redTheme;
	}

	public void clearRed() {
		Theme = new Theme();

	}


	public void _on_pressed() {
		clearRed();
	}
}
