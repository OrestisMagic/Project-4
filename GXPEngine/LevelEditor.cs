using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;
using System.IO;

public class LevelEditor
{
    FileIO fileAcess = new FileIO();

    Level level = new Level();

    List<string> levelObjects;
    public LevelEditor()
    {

    }

    public void GetListItems()
    {
        levelObjects = fileAcess.ReadLevel(fileAcess.directory + level.currentLevelName + ".txt");
    }
}