namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            Employee firstemployee = new Employee()
            {
                Name = "fij",                
            };
            employees[0] = firstemployee;

            Employee secondemployee = new Employee()
            {
                Name="iojgoi",
            };
            employees[1] = secondemployee;

            Employee thridemployee=new Employee()
            {
                Name = "iejfoie"
            };
            employees[2] = thridemployee;

        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("sound of " + Name);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int ID { get; set; }
        public string Department { get; set; }
        public string Team { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Name of employee is " + Name);
        }

    }




    

}