using System;
using System.Collections.Generic;
using System.Text;

class Tire
{
    int tire1age;
    int tire2age;
    int tire3age;
    int tire4age;

    double tire1pressure;
    double tire2pressure;
    double tire3pressure;
    double tire4pressure;

    public int Tire1Age
    {
        get { return tire1age; }
        set { tire1age = value; }
    }

    public int Tire2Age
    {
        get { return tire2age; }
        set { tire2age = value; }
    }

    public int Tire3Age
    {
        get { return tire3age; }
        set { tire3age = value; }
    }

    public int Tire4Age
    {
        get { return tire4age; }
        set { tire4age = value; }
    }

    public double Tire1Pressure
    {
        get { return tire1pressure; }
        set { tire1pressure = value; }
    }

    public double Tire2Pressure
    {
        get { return tire2pressure; }
        set { tire2pressure = value; }
    }

    public double Tire3Pressure
    {
        get { return tire3pressure; }
        set { tire3pressure = value; }
    }

    public double Tire4Pressure
    {
        get { return tire4pressure; }
        set { tire4pressure = value; }
    }

    public void TireInfo(string t1p, string t1a, string t2p, string t2a, string t3p, string t3a, string t4p, string t4a)
    {
        Tire1Pressure = double.Parse(t1p);
        Tire1Age = int.Parse(t1a);

        Tire2Pressure = double.Parse(t2p);
        Tire2Age = int.Parse(t2a);

        Tire3Pressure = double.Parse(t3p);
        Tire3Age = int.Parse(t3a);

        Tire4Pressure = double.Parse(t4p);
        Tire4Age = int.Parse(t4a);
    }
}
