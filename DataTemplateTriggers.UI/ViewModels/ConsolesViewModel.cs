using DataTemplateTriggers.UI.Models;
using DataTemplateTriggers.UI.Utilities;
using System.Collections.ObjectModel;

namespace DataTemplateTriggers.UI.ViewModels
{
    public class ConsolesViewModel : ViewModelBase
    {
        #region Fields

        private string _header;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Header for the View
        /// </summary>
        public string Header
        {
            get => _header;
            private set => SetProperty(ref _header, value);
        }

        /// <summary>
        /// Keeps a list of video game consoles
        /// </summary>
        public ObservableCollection<GameConsole> ConsoleCollection { get; private set; }

        #endregion

        #region Constructor

        public ConsolesViewModel()
        {
            Header = "Home Video Game Consoles";
        }

        #endregion

        #region Methods


        #endregion
    }
}