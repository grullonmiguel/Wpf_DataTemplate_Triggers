using DataTemplateTriggers.UI.Models;
using DataTemplateTriggers.UI.Services;
using DataTemplateTriggers.UI.Utilities;
using System.Collections.ObjectModel;

namespace DataTemplateTriggers.UI.ViewModels
{
    public class ConsolesViewModel : ViewModelBase
    {
        private string _header;

        private readonly IConsoleDataService _dataService;

        /// <summary>
        /// Gets or sets the Header for the View
        /// </summary>
        public string Header
        {
            get => _header;
            private set => SetProperty(ref _header, value);
        }

        /// <summary>
        /// Gets a list of video game consoles
        /// </summary>
        public ObservableCollection<GameConsole> Consoles { get; private set; }

        public ConsolesViewModel()
        {
            _dataService = new MockDataService();
            Header = _dataService.GetHeader();
            Consoles = _dataService.GetConsoles().ToObservableCollection();
        }
    }
}