using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using Quill.Services;
using System.Collections.Generic;

namespace Quill.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private IDataRepository _dataRepository;
        private INavigationService _navigationService;

        public MainPageViewModel(IDataRepository dataRepository, INavigationService navigationService)
        {
            _dataRepository = dataRepository;
            _navigationService = navigationService;
        }

        public List<string> DisplayItems
        {
            get { return _dataRepository.GetFeatures(); }
        }
    }
}