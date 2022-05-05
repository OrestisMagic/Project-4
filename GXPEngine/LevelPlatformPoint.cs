using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class LevelPlatformPoint : Sprite
{
    Vec2 position;
    public LevelPlatformPoint(Vec2 pPosition) : base("circle.png")
    {
        position = pPosition;
        SetXY(position.x, position.y);
    }
}
