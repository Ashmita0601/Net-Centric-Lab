using System;
namespace lab1
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;

        public Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void Display()
        {
            Console.Write("Full name : {0}\nSalary : {1}\n", firstName + " " + lastName, salary);
        }

        public void IncrementSalary(double S)
        {
            double prevSalary = salary;
            salary += (S / 100 * prevSalary);
            Console.Write("Your salary increased | {0} -> {1}\n", prevSalary, salary);
        }
    }
}

