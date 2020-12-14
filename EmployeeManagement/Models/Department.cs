using System.Collections.Generic;
namespace EmployeeManagement.Models{

public class Department{
    public int Id { get;set;}
    public string Name { get;set;}
    public int Code { get; set;}
    public string Branch { get; set;}

    public static List<Department> GetDepartment()
        {   
            Department department1 = new Department()
            {
                Id =1,
                Name = "Management",
                Code =45, 
                Branch = "Ktm",

            };
            Department department2 = new Department()
            {
                Id = 2,
                Name = "Development",
                Code =20, 
                Branch = "Ktm",


            };
            List<Department> departments =new List<Department>(){department1,department2};
            return departments;
        }
}
}