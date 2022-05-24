using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
         var MonstersInc = new Company("Monsters Inc.", new DateTime(2002,12,11));
         var Mike = new Employee
         {
             FirstName = "Mike",
             LastName = "Wizowsky",
             StartDate = new DateTime( 2003, 10, 9 ),
             Title = "Senior Scarer"       
         };
         MonstersInc.Employees.Add(Mike);
         MonstersInc.Employees.Add(new Employee
         {
             FirstName = "Sully",
             LastName = "Sullivan",
             StartDate = new DateTime( 2003, 10, 9 ),
             Title = "CEO"    
         });
         MonstersInc.Employees.Add(new Employee
         {
             FirstName = "Edna",
             LastName = "Tame",
             StartDate = new DateTime( 2003, 10, 9 ),
             Title = "HR"    
         });
         MonstersInc.ListEmployees();
        }
    }
}
