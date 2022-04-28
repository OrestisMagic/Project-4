using System;
using GXPEngine;
using System.Drawing;

public class MyGame : Game
{
	public MyGame() : base(800, 600, false)		// Create a window that's 800x600 and NOT fullscreen
	{
		FileIO test = new FileIO();
		LevelEditor test2 = new LevelEditor();
		//test.Write("Level1", "CurrentLevel");
		test2.GetListItems();
	}

	void Update()
	{

	}

	static void Main()
	{
		new MyGame().Start();
	}
}