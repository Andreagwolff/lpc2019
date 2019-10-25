
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain;
using ToDoList.Repositories.Interface;

namespace ToDoList.Web.Controllers
{
    public class ToDoController : Controller
    {
        private IToDoRepository repositoryToDo;
        public ToDoController(IToDoRepository repositoryToDo)
        {
            this.repositoryToDo = repositoryToDo;
        }

        public IActionResult Index()
        {
            var todos = repositoryToDo.GetAll();
            
            return View(todos);
        }

        public IActionResult Create()
        {
            ViewBag.TypesToDos = repositoryToDo.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo todo)
        {
            todo = repositoryToDo.GetById(todo.id);
            repositoryToDo.Create(todo);
            return RedirectToAction("Index");
        }

     
    }
}
