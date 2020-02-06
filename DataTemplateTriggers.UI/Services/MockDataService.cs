using DataTemplateTriggers.UI.Models;
using System.Collections.Generic;

namespace DataTemplateTriggers.UI.Services
{
    public class MockDataService : IConsoleDataService
    {
        private readonly IEnumerable<GameConsole> _consoles;

        public IEnumerable<GameConsole> GetConsoles() => _consoles;

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

        private GameConsole Create(string name, string company, int year)
        {
            return new GameConsole { Name = name, Manufacturer = company, Year = year };
        }
    }
}