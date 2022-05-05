using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;
public class StartPoint : Sprite
{
    Vec2 position;
    public StartPoint(Vec2 pPosition) : base("colors.png")
    {
        position = pPosition;
        SetXY(position.x, position.y);
    }
}
