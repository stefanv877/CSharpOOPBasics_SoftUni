using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : INumbersToCall, ISitesToBrowse
{
    public ICollection<string> PhoneNumbers { get; private set; }
    public ICollection<string> SitesToVisit { get; private set; }

    public Smartphone(ICollection<string> numbers, ICollection<string> sites)
    {
        this.PhoneNumbers = numbers;
        this.SitesToVisit = sites;
    }

    public string Call(string numbers)
    {
        if (!numbers.All(c => char.IsDigit(c)))
        {
            return "Invalid number!";
        }
        else
        {
            return $"Calling... {numbers}";
        }
    }

    public string Browse(string sites)
    {
        if (sites.Any(c => char.IsDigit(c)))
        {
            return "Invalid URL!";
        }
        else
        {
            return $"Browsing: {sites}!";
        }
    }

    public override string ToString()
    {
        var output = new StringBuilder();

        foreach (var number in PhoneNumbers)
        {
            output.AppendLine(Call(number));
        }

        foreach (var site in SitesToVisit)
        {
            output.AppendLine(Browse(site));
        }

        return output.ToString();
    }
}
