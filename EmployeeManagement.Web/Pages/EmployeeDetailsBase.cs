using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();

        protected string Coordinates { get; set; } = "abc";

        protected string MenuClass { get; set; } 
        protected string ButtonText { get; set; } = "Toggle Footer";

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; } 

        protected override async  Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee =  await EmployeeService.GetEmployee(int.Parse(Id));
        }

        //protected void Mouse_Move(MouseEventArgs e)
        //{
        //    Coordinates = $"X = {e.ClientX} Y= {e.ClientY}";
        //}

        protected void Toggle_Visibility(MouseEventArgs e)
        {
            MenuClass = MenuClass == "Hide-Footer" ? null : "Hide-Footer";

        }
    }
}
