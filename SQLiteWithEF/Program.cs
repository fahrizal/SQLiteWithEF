using System;
using System.Linq;

namespace SQLiteWithEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DatabaseContext())
            {
                db.EmployeeMasters.Add(new EmployeeMaster
                {
                    EmpName = "John Doe",
                    Salary = 10000,
                    Designation = "Software Engineer"
                });
                db.EmployeeMasters.Add(new EmployeeMaster
                {
                    EmpName = "Jane Doe",
                    Salary = 20000,
                    Designation = "Senior Software Engineer"
                });
                db.SaveChanges();

                var query = from b in db.EmployeeMasters
                            orderby b.EmpName
                            select b;

                Console.WriteLine("All employees in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.EmpName + " - "
                        + item.Salary + " - " + item.Designation);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
