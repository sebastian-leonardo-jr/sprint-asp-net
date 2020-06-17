using System;

namespace Sprint.Models
{
    public class Board
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DefinitionOfDone { get; set; }
        public DateTime Created { get; set; }

        public void OnGet()
        {
            Created = new DateTime();
        }
    }
}
