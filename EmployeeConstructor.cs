 using System;

namespace PranishDotNetLab
{
    class Employee
    {
        int eid;
        string name, address, department;
        double salary;
        public Employee(int eid, string name, string address, string department, double salary)
        {
            this.eid = eid;
            this.name = name;
            this.address = address;
            this.department = department;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"eid:{eid} \t Name:{name} \t Address: {address} \t Department:{department} \t Salary:{salary}");
        }

        public void Edit(string choice, string value)
        {
            switch (choice)
            {
                case "eid":
                    Console.WriteLine("eid cannot be changed");
                    break;

                case "name":
                    name = value;
                    break;

                case "address":
                    address = value;
                    break;

                case "department":
                    department = value;
                    break;

                case "salary":
                    salary = double.Parse(value);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
    }
    public class EmployeeConstructor
    {
         static void Main(string[] args)
        {
            Console.WriteLine("First Employee");
            Employee emp1 = new Employee(001, "Pranish", "Imadol", "IT", 800000.00);
            emp1.Display();
            Console.WriteLine("After edit of first employee");
            emp1.Edit("salary", "97500");
            emp1.Edit("address", "Kathmandu");
            emp1.Edit("Phone", "9811111110");
            emp1.Display();

            Console.WriteLine("Second Employee");
            Employee emp2 = new Employee(2, "Simon", "Kathmandu", "Accountant", 800000.52);
            emp2.Display();
            Console.WriteLine("Second Employee after edit");
            emp2.Edit("eid", "5");
            emp2.Edit("name", "Zion Boro");
            emp2.Display();
            Console.WriteLine("Lab_work 9/Pranish Bajracharya/Roll no.: 13");

        }
    }
}
