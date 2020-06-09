using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplication.Models;
using RazorApplication.Services;

namespace RazorApplication.Web.Pages.Employees
{
    public class DetailModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public DetailModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [TempData]
        public string Message { get; set; }
        public Employee Employee { get; set; }

        public IActionResult OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);
            if(Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}