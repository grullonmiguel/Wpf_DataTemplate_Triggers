using DataTemplateTriggers.UI.Models;
using System.Collections.Generic;

namespace DataTemplateTriggers.UI.Services
{
    public class MockDataService : IConsoleDataService
    {
        private readonly IEnumerable<GameConsole> _consoles;

        public MockDataService()
        {
            _consoles = new List<GameConsole>()
            {
                Create("XBox 360",          "Microsoft",    2005),
                Create("PlayStation 3",     "Sony",         2006),
                Create("Wii",               "Nintendo",     2006),
                Create("Wii U",             "Nintendo",     2012),
                Create("PlayStation 4",     "Sony",         2013),
                Create("XBox One",          "Microsoft",    2013),
                Create("Nintendo Switch",   "Nintendo",     2017)
            };
        }

        /// <summary>
        /// Returns a list of <see cref="GameConsole" />
        /// </summary>
        public IEnumerable<GameConsole> GetConsoles() => _consoles;

        /// <summary>
        /// Returns the Header title for the list
        /// </summary>
        public string GetHeader() => "Home Video Game Consoles";

        /// <summary>
        /// Creates a new instance of the <see cref="GameConsole" class/>
        /// </summary>
        private GameConsole Create(string name, string company, int year) => 
            new GameConsole { Name = name, Manufacturer = company, Year = year };
    }
}