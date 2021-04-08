using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Models
{
    public class Employee
    {
        public int EmpId { get; set;}
        public string Empname { get; set; }
        public float Salary { get; set; }
        public Employee() { }
        public Employee (int eid,string empname,float salary)
        {
            EmpId = eid;
            Empname = empname;
            Salary = salary;
        }
        public static List<Employee> employees = new List<Employee>();
        public static List<Employee> getAllEmployee()
        {
         
            employees.Add(new Employee(100, "Nisha", 55000));
            employees.Add(new Employee(101, "Vijay", 45000));
            employees.Add(new Employee(102, "Ramu", 65000));
            employees.Add(new Employee(103, "Somu", 50000));
             employees.Add(new Employee(104, "Sri", 80000));
            return employees;
        }
        public void Addemployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
