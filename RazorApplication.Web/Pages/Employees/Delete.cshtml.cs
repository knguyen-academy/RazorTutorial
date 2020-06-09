using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplication.Models;
using RazorApplication.Services;

namespace RazorApplication.Web.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public DeleteModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);
            if(Employee == null)
            {
                return RedirectToPage("/Notfound");
            }
            return Page();
        }
        public IActionResult OnPost() 
        {
            Employee deletedEmployee = employeeRepository.Delete(Employee.Id);
            if (deletedEmployee == null)
            {
                return RedirectToPage("/Notfound");
            }
            return RedirectToPage("Index");
        }
    }
}