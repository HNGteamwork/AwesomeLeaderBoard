using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;

namespace AwesomeLeaderBoard.Controllers
{
    public class LeaderboardController : Controller
    {
        
        private readonly ITodoItemService _todoItemService;
        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> IActionResult Index()
        {
            
            var items = await _todoItemService.GetIncompleteItemsAsync();

            var model = new TodoViewModel()
        {
            Items = items
        };

           return View(model);
        }

        

    }
}