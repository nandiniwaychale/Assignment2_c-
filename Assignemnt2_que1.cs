using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Assignemnt2_que1 : IComparable<Assignemnt2_que1>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Assignemnt2_que1(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public int CompareTo(Assignemnt2_que1 other)
        {
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)

                return -1;
            else
                return 0;
        }
    }
}
