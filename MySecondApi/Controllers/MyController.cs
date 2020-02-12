using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySecondApi.Entities;
using MySecondApi.providers;

namespace MySecondApi.Controllers
{
    [Route("api/Dcontroller")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [Route("First")]
        [HttpGet]
        public string myfirst()
        {
            EmployeeProvider employeeProvider = new EmployeeProvider();
            Employees employees = new Employees();
            employees.Name = "Dilip";
            employees.Description = "Backend Developer";
            employees.Experience = "2 years";
            employees.Salary = 30000;
            Employees employees1 = new Employees();
            employees1.Name = "Thulasi";
            employees1.Description = "Backend Developer";
            employees1.Experience = "3 years";
            employees1.Salary = 40000;
            Employees employees2 = new Employees();
            employees2.Name = "Mohammad Ali";
            employees2.Description = "FullStack Developer";
            employees2.Experience = "2 years";
            employees2.Salary = 45000;
            Employees employees3 = new Employees();
            employees3.Name = "Bhanu";
            employees3.Description = "Backend Developer";
            employees3.Experience = "2 years";
            employees3.Salary = 30000;
            Employees employees4 = new Employees();
            employees4.Name = "Jaheer";
            employees4.Description = "Backend Developer";
            employees4.Experience = "2 years";
            employees4.Salary = 35000;
            Employees employees5 = new Employees();
            employees5.Name = "Durga";
            employees5.Description = "Digital Marketing";
            employees5.Experience = "4 years";
            employees5.Salary = 50000;
            Employees employees6 = new Employees();
            employees6.Name = "Darshan";
            employees6.Description = "Offline Marketing";
            employees6.Experience = "2 years";
            employees6.Salary = 40000;
            Employees employees7 = new Employees();
            employees7.Name = "Naveen";
            employees7.Description = "Graphic designer";
            employees7.Experience = "4 years";
            employees7.Salary = 35000;
            Employees employees8 = new Employees();
            employees8.Name = "Bhuvan";
            employees8.Description = "Online Marketing";
            employees8.Experience = "2 years";
            employees8.Salary = 30000;
            
            employeeProvider.Add(employees);
            employeeProvider.Add(employees1);
            employeeProvider.Add(employees2);
            employeeProvider.Add(employees3);
            employeeProvider.Add(employees4);
            employeeProvider.Add(employees5);
            employeeProvider.Add(employees6);
            employeeProvider.Add(employees7);
            employeeProvider.Add(employees8);

            employeeProvider.SaveChanges();
            return "Updated";
          }
        [Route("GetAllDetails")]
        [HttpGet]
        public List<Employees> GetEmployeeDetails()
        {
            EmployeeProvider employeepro = new EmployeeProvider();
            return employeepro.GetEmployees.ToList();

        }
        [Route("GetDetailsById")]
        [HttpGet]
        public List<Employees> GetDetails(int id)
        {
            EmployeeProvider employee = new EmployeeProvider();
            return employee.GetEmployees.Where(i => i.Id == id).ToList();

           }
        [Route("Update")]
        [HttpPut]
        public string UpdateDetails(int id,Employees obj)
        {
            EmployeeProvider employee = new EmployeeProvider();
            var name = employee.GetEmployees.Where(i => i.Id == id).FirstOrDefault();
            name.Name = obj.Name;
            employee.SaveChanges();
            return "updated";
        }
        [Route("Delete")]
        [HttpDelete]
        public string UpdateDetails(int id)
        {
            EmployeeProvider employee = new EmployeeProvider();
            var name = employee.GetEmployees.Where(i => i.Id == id).FirstOrDefault();
            employee.GetEmployees.Remove(name);
            employee.SaveChanges();
            return "Deleted";
        }
    }
}