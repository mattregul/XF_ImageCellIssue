using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;


namespace XamarinForms_ListviewSelection
{
	
	/// <summary>
	/// Employee Class
	/// </summary>
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


    public partial class ListviewTestPage : ContentPage
	{
		// our global employee list
		List<Employee> employeeList;

		public ListviewTestPage()
		{
            List<Employee> employeeList;

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

