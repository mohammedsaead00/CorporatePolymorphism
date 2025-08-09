namespace CorporatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hrRep = new HR();

            hrRep.ClockIn();
            hrRep.Work();
            hrRep.SubmitDailyReport();
            Console.WriteLine();
            // Upcasting Engineer to Employee
            Employee employee1 = new Engineer();
            employee1.SubmitDailyReport();
            Employee employee2 = new Manager();
            employee2.Work();
            employee2.ClockIn();
            employee2.SubmitDailyReport();
            Employee employee3 = new Intern();
            employee3.Work();
            employee3.ClockIn();
            employee3.SubmitDailyReport();
            // downcast
            Engineer engineer1 = employee1 as Engineer;
            if (engineer1 != null)
            {
                engineer1.SubmitDailyReport();
            }
            else
            {
                Console.WriteLine("Downcast Failed");
            }
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            foreach (Employee employee in employees)
            {
                employee.ClockIn();
                employee.SubmitDailyReport();
                employee.Work();
                if (employee is Engineer)
                {
                    Console.WriteLine("This is an Enginner");
                }
                else if (employee is Manager)
                {
                    Console.WriteLine("This is a Manager");
                }
                else if (employee is Intern)
                {
                    Console.WriteLine("This is an Intern");
                }
                else
                {
                    Console.WriteLine("This is a HR");
                }
            }
        }
    }
}