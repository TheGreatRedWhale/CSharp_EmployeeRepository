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
            employeeListView.;
        }

        private void addEmployee(object sender, EventArgs e)
        {
            employeeList.Add(new Employee(
                name: nameBox.Text, idNumber: Int32.Parse(idBox.Text),
                department: departmentBox.Text, position: positionBox.Text));
            employeeListView.Items.Add($"{nameBox.Text},{idBox.Text},{departmentBox.Text},{positionBox.Text}");
        }
    }
}
