using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjw0008_module2activity2
{
    /**<summary>
     * Class <c>Employee</c> models an employee within a given company.
     * </summary>*/
    class Employee
    {
        public String Name { get; set; }        /// holds the employee’s name.
        public int IdNumber { get; set; }       /// holds the employee’s ID number.
        public String Department { get; set; }  /// holds the name of the department in which the employee works.
        public String Position { get; set; }    /// holds the employee’s job title.

        public Employee(String name, int idNumber, String department, String position)
        {
            Name = name;
            IdNumber = idNumber;
            Department = department;
            Position = position;
        }

        public Employee(String name, int idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            Department = "";
            Position = "";
        }

        public Employee()
        {
            Name = "";
            IdNumber = 0;
            Department = "";
            Position = "";
        }
    }
}
