using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sprint.Models;

namespace Sprint.Controllers
{
    public class MainController : Controller
    {
        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        public ViewResult Dashboard() 
        {
            return View();
        }

        public ViewResult MyBoards()
        {
            Board board = new Board();
            return View(board);
        }
    }
}
