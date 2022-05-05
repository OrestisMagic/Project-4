using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class FinishPoint : Sprite
{
    Vec2 position;
    public FinishPoint(Vec2 pPosition):base("checkers.png")
    {
        position = pPosition;
        SetXY(position.x, position.y);
    }
}