using Godot;
using System;

public partial class timerLabel : Label
{	
	[Signal]
    public delegate void DurationCompleteEventHandler();

	[Export]
	public int duration;

	[Export]
	public Node timer;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Text = duration.ToString();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_timer_timeout() {
		if (duration-1 == 0) {
			EmitSignal(SignalName.DurationComplete);
			timer.QueueFree();
		}
		duration -= 1;
		Text = duration.ToString();
	}
}
