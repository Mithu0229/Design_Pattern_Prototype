using System;
//Prototype Design Pattern specifies the kind of objects to create using a prototypical instance, and create new objects by copying this prototype
namespace Design_Pattern_Prototype
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            Employee emp2 = emp1;
            emp2.Name = "Pranaya";
            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
            Console.Read();
        }
    }
}
