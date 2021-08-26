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
    }
}
