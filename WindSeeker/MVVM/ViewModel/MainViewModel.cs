using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindSeeker.Core;
using WindSeeker.Services;

namespace WindSeeker.MVVM.ViewModel;

public class MainViewModel : Core.ViewModel
{
    private INavigationService _navigation;

    public INavigationService Navigation 
    {
        get => _navigation;
        set
        {
            _navigation = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand NavigateToHomeCommand { get; set; }

    public RelayCommand NavigateToSearchViewCommand { get; set; }

    public MainViewModel(INavigationService navService)
    {
        Navigation = navService;
        NavigateToHomeCommand = new RelayCommand(execute => { Navigation.NavigateTo<HomeViewModel>(); }, canExecute => true);
        NavigateToSearchViewCommand = new RelayCommand(execute => { Navigation.NavigateTo<SearchViewModel>(); }, canExecute => true);
    }
}
