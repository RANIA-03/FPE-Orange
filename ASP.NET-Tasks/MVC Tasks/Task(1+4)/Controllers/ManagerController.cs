using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Task_1_4_.Data;
using Task_1_4_.Models;

namespace Task_1_4_.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Person> _userManager;
        private readonly IUserStore<Person> _userStore;
        public ManagerController(ApplicationDbContext _context, UserManager<Person> _userManager, IUserStore<Person> _userStore)
        {
            this._context = _context;
            this._userManager = _userManager;
            this._userStore = _userStore; 
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Index()
        {
            ViewBag.Managers = _context.Managers.ToList();
            return View();
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Add()
        {
            return View();
        }
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> Insert(Manager manager, string Password)
        {
            manager.EmailConfirmed = true;
            manager.NormalizedEmail = manager.Email.ToUpper();
            manager.UserName= manager.Email;
            manager.NormalizedUserName= manager.Email.ToUpper();
            await _userManager.CreateAsync(manager, Password);
            var userId = manager.Id;
            var roleId = "2";
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
                return Activator.CreateInstance<Manager>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Manager)}'. " +
                    $"Ensure that '{nameof(Manager)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        public IActionResult Edit(string Id)
        {
            var Manager = _context.Managers.Where(m => m.Id == Id).SingleOrDefault();
            return View(Manager);
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Edited(Manager manager)
        {
            var Manager = _context.Managers.Where(e => e.Id == manager.Id).SingleOrDefault();
            Manager.Email = manager.Email;
            Manager.NormalizedEmail = manager.Email.ToUpper();
            Manager.UserName = manager.Email;
            Manager.NormalizedUserName = manager.Email.ToUpper();
            Manager.PhoneNumber = manager.PhoneNumber;
            Manager.FirstName = manager.FirstName;
            Manager.LastName = manager.LastName;
            Manager.SSN = manager.SSN;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "ADMIN")]
        public IActionResult Delete(string Id)
        {
            _context.Managers.Remove(_context.Managers.Where(m => m.Id == Id).SingleOrDefault());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
