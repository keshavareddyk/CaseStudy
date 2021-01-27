using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class EmployeePromotion
    {
        List<String> employeeName = new List<String>();
        public EmployeePromotion()
        {
            bool count = true;
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion");
            while (count)
            {
                String name = Console.ReadLine();
                if (name.Equals(" "))
                { count = false; }
                else
                employeeName.Add(name);
            }
        }
        public void FindIndexOfEmployee()
        {
            String name;
            int index;
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            name = Console.ReadLine();
            index = employeeName.IndexOf(name) + 1;
            if (index-1>= 0)
                Console.WriteLine(name + " is the position " + index + " for promotion.");
            else
                Console.WriteLine("No employee exists with the name "+name);
        }
        public void SizeOfList()
        {
            Console.WriteLine("The current size of collection is "+employeeName.Capacity );
            employeeName.TrimExcess();
            Console.WriteLine("The size after removing extra space is " + employeeName.Capacity);

        }
        public void SortedEmployeeNames()
        {
            Console.WriteLine("Promoted employees list:");
            employeeName.Sort();
            foreach (String names in employeeName)
            {
                Console.WriteLine(names);
            }

        }
    }
}
