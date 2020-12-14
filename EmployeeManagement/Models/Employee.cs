using System.Collections.Generic;
namespace EmployeeManagement.Models{

public class Employee{
    public int Id { get;set;}
    public string FirstName { get;set;}
    public string LastName { get; set;}
    public string Address { get; set;}
    public byte Age { get; set;}
    public float Salary { get; set;}
     
     public static List<Employee> GetEmployee()
     {
     Employee employee1 = new Employee()
            {
                Id =1,
                FirstName = "Rem",
                LastName ="khadka", 
                Address = "Ktm",
                Age = 25,
                Salary = 156546

            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "ajskd",
                LastName ="Stha", 
                Address ="Bkt",
                Age = 62,
                Salary = 165111

            };
            List<Employee> employees =new List<Employee>(){employee1,employee2};
            return employees;
     }
}
}