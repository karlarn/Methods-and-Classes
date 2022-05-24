using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; }

        // Create a public property for holding a list of current employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
                

            The constructor will set the value of the public properties

        */
public Company(string _name,DateTime _date)
{
    Name= _name;
    CreatedOn= _date;
    Employees= new List<Employee>();
}

public void ListEmployees()
{
    foreach(Employee i in Employees)
    {
        Console.WriteLine($"{i.FirstName} {i.LastName} works for {Name} as {i.Title} since {i.StartDate}.");
    }
}

    }
}