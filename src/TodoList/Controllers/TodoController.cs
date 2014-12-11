using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoList.Controllers
{
    //[Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoRepository _todoRepo;

        public TodoController(ITodoRepository repository)
        {
            _todoRepo = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var todos = _todoRepo.AllItems;

            return View(todos);
        }

    }
}
