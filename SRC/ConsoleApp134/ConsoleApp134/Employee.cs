using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp134
{
    public class Employee
    {
        public string Name { get; set; }

        public void DoJob()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Name = "Mike";
            employee1.Name = "Jerry";
            employee1.DoJob();
            

        }
    }
    public class Developer : Employee
    {
        public string Name { get; set; }
        public void DoJob()
        {
            Developer employee = new Developer();   
        }
        public void WriteClass()
        {

        }
    }
    public class Manager : Employee
    {
        public string Name { get; set; }        
        public void DoJob()
        {
            Manager manager1 = new Manager();   
            Manager manager2 = new Manager();
            manager1.Name = "Taylor";
            manager2.Name = "Selena";
        }
        public void CreateTask()
        {

        }
    }
}
