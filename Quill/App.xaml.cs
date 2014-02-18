using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.Activation;
using Microsoft.Practices.Prism.StoreApps;
using System.Threading.Tasks;
using Quill.Services;
using Quill.ViewModels;
using Quill.Views;
using Microsoft.Practices.Unity;
using Windows.Foundation;
using Windows.Storage;
using Windows.UI.Core;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace Quill
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : MvvmAppBase
    {
        private readonly IUnityContainer _container = new UnityContainer();
        ApplicationDataContainer roamingSettings = null;
        ApplicationData applicationData = null;

        // Declare any app services that you want to hold on to as singletons
        IDataRepository _dataRepository;

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Required override. Generally you do your initial navigation to launch page, or 
        /// to the page approriate based on a search, sharing, or secondary tile launch of the app
        /// </summary>
        /// <param name="args">The launch arguments passed to the application</param>
        protected override Task OnLaunchApplication(LaunchActivatedEventArgs args)
        {
            // Use the logical name for the view to navigate to. The default convention
            // in the NavigationService will be to append "Page" to the name and look 
            // for that page in a .Views child namespace in the project. IF you want another convention
            // for mapping view names to view types, you can override 
            // the MvvmAppBase.GetPageNameToTypeResolver method
            NavigationService.Navigate("Main", null);
            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// This is the place you initialize your services and set default factory or default resolver for the view model locator
        /// </summary>
        /// <param name="args">The same launch arguments passed when the app starts.</param>
        protected override void OnInitialize(IActivatedEventArgs args)
        {
            applicationData = ApplicationData.Current;
            roamingSettings = applicationData.RoamingSettings;

            _container.RegisterInstance(NavigationService);
            _container.RegisterInstance(SessionStateService);

            // New up the singleton data repository, and pass it the state service it depends on from the base class
            _dataRepository = new DataRepository(SessionStateService);

            // Register factory methods for the ViewModelLocator for each view model that takes dependencies so that you can pass in the
            // dependent services from the factory method here.
            ViewModelLocator.Register(typeof(MainPage).ToString(), () => new MainPageViewModel(_dataRepository, NavigationService));
            //ViewModelLocator.Register(typeof(UserInputPage).ToString(), () => new UserInputPageViewModel(_dataRepository, NavigationService));

            var dataChangedHandler = new TypedEventHandler<ApplicationData, object>(DataChangedHandler);
            applicationData.DataChanged += dataChangedHandler;
        }

        protected override object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        void DataChangedHandler(Windows.Storage.ApplicationData appData, object o)
        {

        }
    }
}