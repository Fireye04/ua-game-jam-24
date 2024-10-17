using Godot;
using System;

public partial class ProgressBar : Godot.ProgressBar
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{	if (Value > 0) {
		Value -= .1;
	}
		
	}

	public void _on_button_button_down() {
		Value += 10;
	}
}
