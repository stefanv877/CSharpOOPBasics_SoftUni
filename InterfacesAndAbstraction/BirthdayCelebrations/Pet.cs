using System;
using System.Collections.Generic;
using System.Text;


public class Pet : Citizens, IBirthable
{
    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }
}
