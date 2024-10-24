using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EFExample
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base(@"data source=.; integrated security=yes; initial catalog=company")
        { }
        public DbSet<Employee> Employees { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext db = new CompanyDbContext();

            // INSERTION
            /*Employee employee = new Employee();
            Console.Write("Emp Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Emp Name: ");
            string name = Console.ReadLine();
            Console.Write("Emp sal: ");
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            employee.EmpName = name;
            employee.Salary = sal;
            employee.EmpId = id;

            // Insert
            db.Employees.Add(employee);
            db.SaveChanges();
            Console.WriteLine("Inserted");*/

            // UPDATE
            Employee employee = db.Employees.Where(emp => emp.EmpId == 1).FirstOrDefault();
            employee.Salary = 10000;
            db.SaveChanges();

            // DELETE
            /*Employee empObj = db.Employees.Where(emp=>emp.EmpId == 7).FirstOrDefault();
            db.Employees.Remove(empObj);
            db.SaveChanges();*/

            //Get using Stored Precedures
            List<Employee> Employees1 = db.Database.SqlQuery<Employee>("GetAllEmployees").ToList();

            //List<Employee> Employees1 = db.Employees.ToList();
            foreach (Employee emp in Employees1)
            {
                Console.Write(emp.EmpId);
                Console.Write(", ");
                Console.Write(emp.EmpName);
                Console.Write(",");
                Console.Write(emp.Salary);
                Console.WriteLine();
            }
            Console.WriteLine();
            List<Employee> Employes = db.Employees.Where(x => x.Salary > 5000).ToList();
            foreach (Employee emp in Employes)
            {
                Console.Write(emp.EmpId);
                Console.Write(", ");
                Console.Write(emp.EmpName);
                Console.Write(",");
                Console.Write(emp.Salary);
                Console.WriteLine();
            }
            Console.WriteLine();
            // Get by Id using Stored Procedure
            int EmpId = 1;
            var emp2 = db.Database.SqlQuery<Employee>("GetEmployeeById @EmpId", new SqlParameter("@EmpId", EmpId)).ToList();
            foreach (Employee emp1 in emp2) {
                Console.Write(emp1.EmpId);
                Console.Write(", ");
                Console.Write(emp1.EmpName);
                Console.Write(",");
                Console.Write(emp1.Salary);
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
