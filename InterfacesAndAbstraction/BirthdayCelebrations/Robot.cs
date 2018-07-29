using System;
using System.Collections.Generic;
using System.Text;

public class Robot : Citizens, IIdable
{
    public string Id { get; private set; }

    public Robot(string model, string id)
    {
        this.Name = model;
        this.Id = id;
    }
}
