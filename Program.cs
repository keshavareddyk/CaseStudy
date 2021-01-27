using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePromotion em = new EmployeePromotion();
            em.FindIndexOfEmployee();
            em.SizeOfList();
            em.SortedEmployeeNames();
            Console.ReadKey();

        }
    }
}
