using System;
using System.Collections.Generic;
using System.Text;

public interface ICar
{
    string DriverName { get; }

    string Model { get; }

    string UseBrakes();

    string PushGas();
}
