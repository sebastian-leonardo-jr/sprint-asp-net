using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sprint.Models;

namespace Sprint.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public ViewResult Dashboard() 
        {
            return View();
        }

        public ActionResult MyBoards()
        {
            List<Board> boards = new List<Board>();

            Board board1 = new Board() { ID = 1,  Name = "First",  Description = "First Board", DefinitionOfDone = "Working."};
            Board board2 = new Board() { ID = 2,  Name = "Second",  Description = "Second Board", DefinitionOfDone = "Working."};
            
            boards.Add(board1);
            boards.Add(board2);

            return View(boards);
        }
    }
}
