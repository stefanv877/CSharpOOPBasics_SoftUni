using System;
using System.Collections.Generic;
using System.Text;

public class Human : Citizens, IIdable, IBirthable
{
    public string Age { get; private set; }

    public string Id { get; private set; }

    public Human(string name, string age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }
}
