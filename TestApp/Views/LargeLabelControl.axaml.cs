using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;

namespace TestApp.Views
{
    public class LargeLabelControl : Button
    {
        public LargeLabelControl()
        {
            
        }
        public static readonly StyledProperty<string> FilePathBoxNameProperty = AvaloniaProperty.Register<LargeLabelControl, string>(
            nameof(FilePathBoxName));

        public string FilePathBoxName
        {
            get => GetValue(FilePathBoxNameProperty);
            set => SetValue(FilePathBoxNameProperty, value);
        }
    
        public static readonly StyledProperty<string> FilePathProperty = AvaloniaProperty.Register<LargeLabelControl, string>(
            nameof(FilePath));

        public string FilePath
        {
            get => GetValue(FilePathProperty);
            set => SetValue(FilePathProperty, value);
        }

        public static readonly StyledProperty<IEnumerable<string>> SheetListProperty = AvaloniaProperty.Register<LargeLabelControl, IEnumerable<string>>(
            nameof(SheetList));
            
        public IEnumerable<string> SheetList
        {
            get => GetValue(SheetListProperty);
            set => SetValue(SheetListProperty, value);
        }
    
        public static readonly StyledProperty<string> SheetNameProperty = AvaloniaProperty.Register<LargeLabelControl, string>(
            nameof(SheetName));

        public string SheetName
        {
            get => GetValue(SheetNameProperty);
            set => SetValue(SheetNameProperty, value);
        }
    
        public static readonly StyledProperty<string> HeadersRowIndexProperty = AvaloniaProperty.Register<LargeLabelControl, string>(
            nameof(HeadersRowIndex));

        public string HeadersRowIndex
        {
            get => GetValue(HeadersRowIndexProperty);
            set => SetValue(HeadersRowIndexProperty, value);
        }

        private IEnumerable<string> _sheetListName;

        public static readonly DirectProperty<LargeLabelControl, IEnumerable<string>> SheetListNameProperty = AvaloniaProperty.RegisterDirect<LargeLabelControl, IEnumerable<string>>(
            nameof(SheetListName), o => o.SheetListName, (o, v) => o.SheetListName = v);

        public IEnumerable<string> SheetListName
        {
            get => _sheetListName;
            set => SetAndRaise(SheetListNameProperty, ref _sheetListName, value);
        }
    }
}
