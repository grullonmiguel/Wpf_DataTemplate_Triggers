using DataTemplateTriggers.UI.Utilities;

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