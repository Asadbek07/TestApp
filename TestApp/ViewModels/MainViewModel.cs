using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TestApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private IEnumerable<string> _overviewFileSheetList = new List<string>() {"hello", "world"};
    
    [ObservableProperty]
    private IEnumerable<string> _reportsFileSheetList = new List<string>() {"hello", "world"};
    
    [ObservableProperty]
    private IEnumerable<string> _assignmentsFileSheetList = new List<string>() {"hello", "world"};
}