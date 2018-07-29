using System;
using System.Collections.Generic;
using System.Text;

public interface INumbersToCall
{
    ICollection<string> PhoneNumbers { get; }

    string Call(string numbers);
}
