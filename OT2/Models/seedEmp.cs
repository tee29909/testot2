using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OT2.Models
{
    public class seedEmp
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OT2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OT2Context>>()))
            {
                // Look for any movies.
                if (context.Emp.Any())
                {
                    return;   // DB has been seeded
                }

                context.Emp.AddRange(
                    new Emp
                    {
                        

                        
        
                        FirstName = "sss",
                        LastName = "sss",
                        Gender = "ss",
                        Birthday = "sss",
                        Email = "sss",
                        Line = "sss",
                        Call = "sss",
                        Addr = "sss",
                        Image = "sss",
                        Date = DateTime.Parse("1989-2-12"),
                        Status = "ss",
                        CompanyName = "ss",
                        DepartmentName = "ss",
                        LocationName = "sss",
                        EmployeeTypeID = "ss",
                        PositionID = "ssss"
                    } 



                );
                context.SaveChanges();
            }
        }
    }
}
