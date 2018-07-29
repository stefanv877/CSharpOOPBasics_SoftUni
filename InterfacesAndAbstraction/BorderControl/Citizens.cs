using System;
using System.Collections.Generic;
using System.Text;


class Citizens
{
    public string Name { get; private set; }

    public string Age { get; private set; }

    public string Id { get; private set; }

    public Citizens(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public Citizens(string name, string age, string id)
        : this(name, id)
    {
        this.Age = age;
    }
}
