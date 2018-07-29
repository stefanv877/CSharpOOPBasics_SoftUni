using System;
using System.Collections.Generic;
using System.Text;

class Car
{
    string model;
    Engine engine;
    Cargo cargo;
    Tire tires;

    public string Model
    {
        get { return model; }
    }

    public Engine Engine
    {
        get { return engine; }
    }

    public Cargo Cargo
    {
        get { return cargo; }
    }

    public Tire Tires
    {
        get { return tires; }
    }

    public Car(string model, Engine engine, Cargo cargo, Tire tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }   
}
