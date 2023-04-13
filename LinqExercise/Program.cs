using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            var sumOfNumbers = numbers.Sum();
            Console.WriteLine(sumOfNumbers);

            //TODO: Print the Average of numbers

            var averageOfNumbers = numbers.Average();
            Console.WriteLine(averageOfNumbers);

            //TODO: Order numbers in ascending order and print to the console

            var orderedAsc = numbers.OrderBy(x => x);
            foreach (int x in orderedAsc) { Console.WriteLine(x); }

            //TODO: Order numbers in decsending order and print to the console

            var orderedDesc = numbers.OrderByDescending(x => x);
            Console.WriteLine(orderedDesc);

            //TODO: Print to the console only the numbers greater than 6

            var greaterSix = numbers.Where(x => x > 6);
            foreach (int x in greaterSix) { Console.WriteLine(x); }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            var anyOrder = numbers.OrderBy(x => x);
            foreach (int x in anyOrder.Take(4))
            {
                Console.WriteLine(x);

            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            numbers[4] = 26;
            var newOrder = numbers.OrderByDescending(x => x);
            foreach (int x in newOrder) { Console.WriteLine(x); }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var cfilteredNames = employees.Where(employee => employee.FirstName.StartsWith("C") || employee.FirstName.StartsWith("S"));
            cfilteredNames.OrderBy(Employee => Employee.FirstName);
            foreach (var employee in cfilteredNames) { Console.WriteLine(employee.FullName); }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var overTwentySix = employees.Where(employee => employee.Age > 26);
            overTwentySix.OrderBy(employee => employee.Age).ThenBy(employee => employee.FullName);
            foreach (var employee in overTwentySix)
            {
                Console.WriteLine($"{employee.Age} {employee.FullName}");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var yoeFilter = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35);
            Console.WriteLine(yoeFilter.Sum(employee => employee.YearsOfExperience));
            Console.WriteLine(yoeFilter.Average(employee => employee.YearsOfExperience));

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Bill","Johnson", 20, 5 )).ToList(); 

            foreach (var employee in employees) { Console.WriteLine($"{employee.FirstName} {employee.LastName}"); }

            Console.WriteLine();

            Console.ReadLine();


            #region CreateEmployeesMethod
            static List<Employee> CreateEmployees()
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
                employees.Add(new Employee("Steven", "Bustamento", 56, 5));
                employees.Add(new Employee("Micheal", "Doyle", 36, 8));
                employees.Add(new Employee("Daniel", "Walsh", 72, 22));
                employees.Add(new Employee("Jill", "Valentine", 32, 43));
                employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
                employees.Add(new Employee("Big", "Boss", 23, 14));
                employees.Add(new Employee("Solid", "Snake", 18, 3));
                employees.Add(new Employee("Chris", "Redfield", 44, 7));
                employees.Add(new Employee("Faye", "Valentine", 32, 10));

                return employees;
            }
            #endregion


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
