using System;
using System.Collections.Generic;
using System.Text;


class Car
{
    string model;
    Engine engine;
    double weight;
    string color;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        weight = 0;
        color = "n/a";
    }

    public Car(string model, Engine engine, double weight) : this(model, engine)
    {
        Weight = weight;
    }

    

    public Car(string model, Engine engine, string color) : this(model, engine)
    {
        Color = color;
    }

    public Car(string model, Engine engine, double weight, string color) : this(model, engine)
    {
        Weight = weight;
        Color = color;
    }

    public override string ToString()
    {
        if (weight != 0 && Engine.Displacement != 0)
        {
            return $"{Model}:{Environment.NewLine}" +
            $"  {Engine.Model}:{Environment.NewLine}" +
            $"    Power: {Engine.Power}{Environment.NewLine}" +
            $"    Displacement: {Engine.Displacement}{Environment.NewLine}" +
            $"    Efficiency: {Engine.Efficiency}{Environment.NewLine}" +
            $"  Weight: {Weight}{Environment.NewLine}" +
            $"  Color: {Color}";
        }
        else if (weight == 0 && Engine.Displacement == 0)
        {
            return $"{Model}:{Environment.NewLine}" +
            $"  {Engine.Model}:{Environment.NewLine}" +
            $"    Power: {Engine.Power}{Environment.NewLine}" +
            $"    Displacement: n/a{Environment.NewLine}" +
            $"    Efficiency: {Engine.Efficiency}{Environment.NewLine}" +
            $"  Weight: n/a{Environment.NewLine}" +
            $"  Color: {Color}";
        }
        else if (weight == 0 && Engine.Displacement != 0)
        {
            return $"{Model}:{Environment.NewLine}" +
            $"  {Engine.Model}:{Environment.NewLine}" +
            $"    Power: {Engine.Power}{Environment.NewLine}" +
            $"    Displacement: {Engine.Displacement}{Environment.NewLine}" +
            $"    Efficiency: {Engine.Efficiency}{Environment.NewLine}" +
            $"  Weight: n/a{Environment.NewLine}" +
            $"  Color: {Color}";
        }
        else
        {
            return $"{Model}:{Environment.NewLine}" +
            $"  {Engine.Model}:{Environment.NewLine}" +
            $"    Power: {Engine.Power}{Environment.NewLine}" +
            $"    Displacement: n/a{Environment.NewLine}" +
            $"    Efficiency: {Engine.Efficiency}{Environment.NewLine}" +
            $"  Weight: {Weight}{Environment.NewLine}" +
            $"  Color: {Color}";
        }
    }
}
