using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class Level : GameObject
{
    public string currentLevelName; // = "Level1";

    bool levelWon = false;
    bool isPlaying = false;

    LevelEditor levelEditor = new LevelEditor();
    PlayerEditingMode playerEditingMode = new PlayerEditingMode();
    public Level(string filename)
    {
        currentLevelName = filename;
        AddChild(levelEditor);
        AddChild(playerEditingMode);

        playerEditingMode.SetParent();
        levelEditor.SetParent();
        levelEditor.CreateGameObjects();
    }

    void NextLevel()
    {
        if (Input.GetKeyUp(Key.SPACE))
            levelWon = true;

        if (levelWon)
        {
            ((MyGame)game).LoadLevel(levelEditor.GetNextLevel(currentLevelName));
        }
    }

    void GameState()
    {
        // 1: Run the level
        // 2: Return to editing the level
        // 3: Level Won -> Next level
        // -------------------------- //
        if (Input.GetKeyUp(Key.ONE))
            isPlaying = true;
        else if (Input.GetKeyUp(Key.TWO))
            isPlaying = false;
        else if (Input.GetKeyUp(Key.THREE))
            levelWon = true;
        // -------------------------- //

        if (isPlaying) {
            playerEditingMode.isEditing = false;
        }
        else{
            playerEditingMode.isEditing = true;
        }

        if (levelWon) {
            NextLevel();
        }
    }

    void Update()
    {
        GameState();
    }
}