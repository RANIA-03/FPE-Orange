using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_1_4_.Data;
using Task_1_4_.Models;

namespace Task_1_4_.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Person> _userManager;
        private readonly IUserStore<Person> _userStore;
        public EmployeeController(ApplicationDbContext _context, UserManager<Person> _userManager, IUserStore<Person> _userStore)
        {
            this._context = _context;
            this._userManager = _userManager;
            this._userStore = _userStore;
        }
        [Authorize(Roles = "ADMIN, MANAGER")]
        public IActionResult Index()
        {
            ViewBag.Employees = _context.Employees.Include(e => e.Department).ToList();
            return View();
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Add()
        {
            ViewBag.Departments = _context.Departments.ToList();
            return View();
        }
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> Insert(Employee employee, string Password)
        {
            employee.EmailConfirmed = true;
            employee.NormalizedEmail = employee.Email.ToUpper();
            employee.UserName = employee.Email;
            employee.NormalizedUserName = employee.Email.ToUpper();
            await _userManager.CreateAsync(employee, Password);
            var userId = employee.Id;  
            var roleId = "3";  
            var userRole = new IdentityUserRole<string>
            {
                UserId = userId,
                RoleId = roleId
            };
            _context.UserRoles.Add(userRole);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        private Person CreateUser()
        {
            try
            {
                return Activator.CreateInstance<Employee>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Employee)}'. " +
                    $"Ensure that '{nameof(Employee)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Edit(string Id)
        {
            var Employee = _context.Employees.Where(e => e.Id == Id).SingleOrDefault();
            ViewBag.Departments = _context.Departments.ToList();
            return View(Employee);
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Edited(Employee employee)
        {
            Employee Employee = _context.Employees.Where(e => e.Id == employee.Id).SingleOrDefault();
            Employee.Email = employee.Email;
            Employee.NormalizedEmail = employee.Email.ToUpper();
            Employee.UserName = employee.Email;
            Employee.NormalizedUserName = employee.Email.ToUpper();
            Employee.PhoneNumber = employee.PhoneNumber;
            Employee.FirstName = employee.FirstName;
            Employee.LastName = employee.LastName;
            Employee.MaritalStatus = employee.MaritalStatus;
            Employee.Birthdate = employee.Birthdate;
            Employee.NationalId = employee.NationalId;
            Employee.EntryDate = employee.EntryDate;
            Employee.DepartmentId = employee.DepartmentId;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Delete(string Id)
        {
            _context.Employees.Remove(_context.Employees.Where(e => e.Id == Id).SingleOrDefault());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
