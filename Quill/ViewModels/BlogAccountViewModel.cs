﻿using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;
using Quill.Services;
using System.Collections.Generic;

namespace Quill.ViewModels
{
    public class BlogAccountViewModel : ViewModel
    {
        private IDataRepository _dataRepository;

        public BlogAccountViewModel(IDataRepository dataRepository, INavigationService navService)
        {
            _dataRepository = dataRepository;
            NavigateCommand = new DelegateCommand(() => navService.Navigate("UserInput", null));
        }

        public DelegateCommand NavigateCommand { get; set; }

        public List<string> DisplayItems
        {
            get { return _dataRepository.GetFeatures(); }
        }
    }
}