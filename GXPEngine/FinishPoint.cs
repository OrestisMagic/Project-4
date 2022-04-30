using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine;

public class FinishPoint : GameObject
{
    Vec2 position;
    public FinishPoint(Vec2 pPosition):base()
    {
        position = pPosition;
    }
}