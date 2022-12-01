using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TestApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private async void OnBrowseOverviewFileSheetListClick(object? sender, RoutedEventArgs e)
        {
            var sheetNameList = new List<string>()
            {
                "I",
                "am",
                "OverviewFileSheetList"
            };
            var inputFilePath = await new OpenFileDialog().ShowAsync(this);
            var control = sender as LargeLabelControl;
            if (inputFilePath != null)
            {
                control.SheetListName = sheetNameList;
                Console.WriteLine("everything is good!");
            }
        }

        private async void OnBrowseReportsFileSheetListClick(object? sender, RoutedEventArgs e)
        {
            var sheetNameList = new List<string>()
            {
                "I",
                "am",
                "ReportsFileSheetList"
            };
            var inputFilePath = await new OpenFileDialog().ShowAsync(this);
            var control = sender as LargeLabelControl;
            if (inputFilePath != null)
            {
                control.SheetListName = sheetNameList;
                Console.WriteLine("everything is good!");
            }
        }

        private async void OnBrowseAssignmentsFileSheetListClick(object? sender, RoutedEventArgs e)
        {
            var sheetNameList = new List<string>()
            {
                "I",
                "am",
                "AssignmentsFileSheetList"
            };
            var inputFilePath = await new OpenFileDialog().ShowAsync(this);
            var control = sender as LargeLabelControl;
            if (inputFilePath != null)
            {
                control.SheetListName = sheetNameList;
                Console.WriteLine("everything is good!");
            }
        }
    }
}