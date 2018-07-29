using System;
using System.Collections.Generic;
using System.Text;

public interface ISitesToBrowse
{
    ICollection<string> SitesToVisit { get; }

    string Browse(string sites);
}
