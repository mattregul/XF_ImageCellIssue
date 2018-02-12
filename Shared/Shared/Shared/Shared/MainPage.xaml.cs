using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shared
{
    class Employee
    {
        public string Name { get; set; }
        public string Job { get; set; }

        public Employee(string _name, string _job)
        {
            Name = _name;
            Job = _job;
        }
    }

    public partial class MainPage : ContentPage
	{
        List<Employee> employeeList;
        public MainPage()
        {
            InitializeComponent();


            employeeList = new List<Employee>();

            // Create a few sample employees
            for (int i = 0; i < 50; i++)
            {
                employeeList.Add(
                    new Employee(
                        "Employee " + i,
                        "Developer"
                    )
                );
            }

            // Set the source
            EmployeeListview.ItemsSource = employeeList;
        }
    }
}
