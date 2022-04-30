using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class LevelPlatformPoint : GameObject
{
    Vec2 position;
    public LevelPlatformPoint(Vec2 pPosition) : base()
    {
        position = pPosition;
    }
}
