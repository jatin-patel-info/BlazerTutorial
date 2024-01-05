﻿using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {

        protected string Name { get; set; } = "Jatin";
        protected string Gender { get; set; } = "Male";

        protected string Colour { get; set; } =  "background-color:white";

        protected string Description { get; set; } =string.Empty;
    }
}
