using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jjw0008_module2activity2
{
    public partial class employeeForm : Form
    {
        List<Employee> employeeList = new List<Employee>();
        
        public employeeForm()
        {
            InitializeComponent();
        }

        private void addEmployee(object sender, EventArgs e)
        {
            employeeList.Add(new Employee(
                name: nameBox.Text, idNumber: Int32.Parse(idBox.Text),
                department: departmentBox.Text, position: positionBox.Text));
            employeeToListItem(employeeList[employeeList.Count - 1]);
            //employeeListView.Items.Add(nameBox.Text).
            //    SubItems.AddRange(new string[] { idBox.Text,
            //        departmentBox.Text, positionBox.Text });
        }

        private void employeeToListItem (Employee employee)
        {
            String idString = employee.IdNumber.ToString();
            while (idString.Length < 5)
            {
                idString = "0" + idString;
            }
            employeeListView.Items.Add(employee.Name).
                SubItems.AddRange(new string[] {idString,
                    employee.Department, employee.Position });
        }
    }
}
