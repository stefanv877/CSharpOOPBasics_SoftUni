using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        const int MinAge = 0;
        const int MaxAge = 15;

        string name;
        int age;

        public Chicken(string name, int age)
        {
            if (!String.IsNullOrWhiteSpace(name)) this.name = name;
            else throw new ArgumentException("Name cannot be empty.");
            if (age > MinAge && age < MaxAge) this.age = age;
            else throw new ArgumentException("Age should be between 0 and 15.");
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
