﻿namespace EmployeePayrollServiceADO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepository repository = new EmployeeRepository();  //Creating a object of EmployeeRepository class.

            // UC1 Ensuring the database connection using the sql connection string
            //repository.DataBaseConnection();


            //UC2
            AddRecordInput();                  // Add Record into Store Procedure table
            repository.GetAllEmployeeData();     // View all Records            
            Console.WriteLine();
        }
        public static void AddRecordInput()
        {
            EmployeeRepository repository = new EmployeeRepository();//Creating a object of EmployeeRepository class.
            EmployeeModel model = new EmployeeModel();// Adding Employee To Database

            model.EmployeeName = "NAVEEN";
            model.PhoneNumber = "852479632";
            model.Address = "TELANGANA";
            model.Department = "EEE";
            model.Gender = "M";
            model.BasicPay = 620000;
            model.Deductions = 10000;
            model.TaxablePay = 15000;
            model.Tax = 8500;
            model.NetPay = 350000;
            model.StartDate = DateTime.Now;
            model.City = "PEDDAPALLI";
            model.Country = "India";

            Console.WriteLine(repository.AddEmployee(model) ? "Record Successfully Inserted On Table" : "Failed"); //Conditional (Ternary) operator
            // repository.GetAllEmployeeData(); //call method to show table record
        }
    }
}