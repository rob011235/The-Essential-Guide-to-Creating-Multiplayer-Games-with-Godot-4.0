using Godot;
using System;

public partial class MainMenu : Control
{

	public void OnClientPressed()
	{
		GetTree().ChangeSceneToFile("res://Client.tscn");
	}

	public void OnServerPressed()
	{
        GetTree().ChangeSceneToFile("res://Server.tscn");
    }
}
