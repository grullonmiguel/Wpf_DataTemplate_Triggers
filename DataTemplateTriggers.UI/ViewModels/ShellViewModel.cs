using DataTemplateTriggers.UI.Utilities;

namespace DataTemplateTriggers.UI.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private string _title;

        /// <summary>
        /// Gets or sets the Title for the application's Main Window
        /// </summary>
        public string Title
        {
            get => _title;
            private set => SetProperty(ref _title, value);
        }

        public ShellViewModel()
        {
            Title = "WPF - DataTemplate Triggers";
        }
    }
}