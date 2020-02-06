using DataTemplateTriggers.UI.ViewModels;
using DataTemplateTriggers.UI.Views;
using System.Windows;

namespace DataTemplateTriggers.UI
{
    public partial class App : Application
    {
        /// <summary>
        /// Sets the entry point to the application
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var viewModel = new ShellViewModel();
            var view = new ShellView { DataContext = viewModel };
            view.ShowDialog();
        }
    }
}