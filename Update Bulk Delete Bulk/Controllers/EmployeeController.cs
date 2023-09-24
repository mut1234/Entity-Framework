using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Update_Bulk_Delete_Bulk.Data;
using Update_Bulk_Delete_Bulk.Models;

namespace Update_Bulk_Delete_Bulk.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Employee> objectCategoryList = _db.Employees.ToList();

          //_db.Employees.ExecuteDelete();// delete all database table 

            _db.Employees.Where(e => e.EmployeeId > 4).ExecuteDelete();

            _db.Employees.Take(4).ExecuteUpdate(e => e.SetProperty(e => e.Name, e => e.Name + " Updated"));

            _db.Employees.ExecuteUpdate(e => e.SetProperty(e => e.IsActive, true));

            return View(objectCategoryList);

        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
