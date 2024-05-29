using Microsoft.AspNetCore.Mvc;
using MyCRUD_App.DAL;
using MyCRUD_App.Models.ViewModels;
using MyCRUD_App.Models.DBEntities;

namespace MyCRUD_App.Controllers
{
    public class Employee : Controller
    {
        private readonly EmployeeDBContext _dbContext;
        public Employee(EmployeeDBContext context) 
        {
            this._dbContext = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _dbContext.Employees.ToList();
            List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
            if (employees != null)
            {
                foreach (var employee in employees)
                {
                    var employeeViewModel = new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Email = employee.Email,
                        DOB = employee.DOB,
                        Salary = employee.Salary
                    };
                    employeeList.Add(employeeViewModel);
                }
                return View(employeeList);
            }
            return View(employeeList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    FirstName = employeeViewModel.FirstName,
                    LastName = employeeViewModel.LastName,
                    Email = employeeViewModel.Email,
                    DOB = employeeViewModel.DOB,
                    Salary = employeeViewModel.Salary
                };
                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();
            }
            else
            {
                //TempData
            }
            return View();
        }
    }
}
