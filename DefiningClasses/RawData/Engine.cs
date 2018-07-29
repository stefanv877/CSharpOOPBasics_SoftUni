using System;
using System.Collections.Generic;
using System.Text;

class Engine
{
    private int speed;
    private int power;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int Power
    {   get { return power; }
        set { power = value; }
    }

    public void EngineInfo(string speed, string power)
    {
        Speed = int.Parse(speed);
        Power = int.Parse(power);
    }
}
