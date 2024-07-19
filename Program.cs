using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Assignment 2: 
            Assignemnt2_que1[] people = new Assignemnt2_que1[3];
            people[0] = new Assignemnt2_que1("Nandini", 25);
            people[1] = new Assignemnt2_que1("Tanisha", 20);
            people[2] = new Assignemnt2_que1("Roshani", 30);
           
            Console.WriteLine("People before sorting:");
            foreach (var person in people)
            {
                person.PrintDetails();
            }
            Array.Sort(people);
            Console.WriteLine("\nPeople after sorting:");
            foreach (var person in people)
            {
                person.PrintDetails();
            }
        }
    }
}
