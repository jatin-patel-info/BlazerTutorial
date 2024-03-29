﻿using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        //can not use constructor as blazor do not accept dependcy injection same way. need to add inject attribute
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        public bool ShowChildFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            // hard coded values
            //await  Task.Run(LoadEmployees);

            //service call
            Employees = (await EmployeeService.GetEmployees()).ToList();

            //return base.OnInitializedAsync();   
        }

        public int SelectedEmployeeCount { get; set; } = 0;

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeeCount++;
            }
            else
            {
                SelectedEmployeeCount--;
            }
        }

        //private void LoadEmployees()
        //{
        //    Thread.Sleep(3000);
        //    Employee e1 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "John",
        //        LastName = "Hastings",
        //        Email = "David@pragimtech.com",
        //        DateOfBrith = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 1,
        //        PhotoPath = "images/john.png"
        //    };

        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Sam",
        //        LastName = "Galloway",
        //        Email = "Sam@pragimtech.com",
        //        DateOfBrith = new DateTime(1981, 12, 22),
        //        Gender = Gender.Male,
        //        DepartmentId = 2,
        //        PhotoPath = "images/sam.jpg"
        //    };

        //    Employee e3 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Mary",
        //        LastName = "Smith",
        //        Email = "mary@pragimtech.com",
        //        DateOfBrith = new DateTime(1979, 11, 11),
        //        Gender = Gender.Female,
        //        DepartmentId = 3,
        //        PhotoPath = "images/mary.png"
        //    };

        //    Employee e4 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Sara",
        //        LastName = "Longway",
        //        Email = "sara@pragimtech.com",
        //        DateOfBrith = new DateTime(1982, 9, 23),
        //        Gender = Gender.Female,
        //        DepartmentId = 4,
        //        PhotoPath = "images/sara.png"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4 };
        ////}


    }
}
