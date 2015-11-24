namespace UWP10template.Base
{
    using System;
    using System.Threading.Tasks;
    using UWP10template.Base;
    using Windows.UI.Core;

    /// <summary>
    /// The class that every view model must inherit from
    /// </summary>
    public class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// Private reference to the <see cref="CoreWindow"/>
        /// </summary>
        private CoreWindow coreWindow;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel"/> class
        /// </summary>
        public BaseViewModel()
        {
            this.coreWindow = CoreWindow.GetForCurrentThread();
        }

        /// <summary>
        /// Invoked when the Page of the view model is loaded
        /// </summary>
        /// <param name="navigationContext">The parameters passed by the previous view model</param>
        public virtual void OnNavigatedTo(object navigationContext)
        {
        }

        /// <summary>
        /// Invoked when the Page of the view model is unloaded
        /// </summary>
        public virtual void OnNavigatedFrom()
        {
        }

        /// <summary>
        /// Runs code asynchronously on the UI Thread
        /// </summary>
        /// <param name="value">The function to be executed</param>
        /// <returns>The task to wait for the completion of the operation</returns>
        public async Task RunOnUIAsync(DispatchedHandler value)
        {
            await this.coreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, value);
        }
    }
}
