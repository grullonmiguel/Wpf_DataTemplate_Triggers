using DataTemplateTriggers.UI.Models;
using System.Collections.Generic;

namespace DataTemplateTriggers.UI.Services
{
    public interface IConsoleDataService
    {
        IEnumerable<GameConsole> GetConsoles();
    }
}