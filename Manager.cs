using System;

namespace CorporatePolymorphism
{
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager oversees the project.");
        }
        public override void SubmitDailyReport()
        {
            Console.WriteLine("Manager submits daily report.");
        }
    }
}
