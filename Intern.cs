using System;

namespace CorporatePolymorphism
{
    class Intern : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Intern assists with the project");
        }
        public override void SubmitDailyReport()
        {
            Console.WriteLine("Intern submits daily report.");
        }
}
}