using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using FluentAvalonia.UI.Controls;
using ItemsRepeaterOddDataTemplateBehaviorTest.ViewModels.Interfaces;

namespace ItemsRepeaterOddDataTemplateBehaviorTest.ViewModels
{
    public class RepeaterHostViewModel : ViewModelBase
    {
        private readonly ObservableCollection<IRepeaterHostElementViewModel> _items       = new();
        private readonly int                                                 _columnCount = 4;
        public           int                                                 ColumnCount => _columnCount;

        public ObservableCollection<IRepeaterHostElementViewModel> Items
        {
            get => _items;
            init => RaiseAndSetIfChanged(ref _items, value);
        }

        public RepeaterHostViewModel()
        {
            List<int> numbers = Enumerable.Range(0, 20).ToList();
            foreach (var number in numbers)
            {
                Items.Add(new RepeaterElementViewModel(number));
            }

            LaunchDialogCommand = new FACommand(ExecuteLaunchCommand);
        }

        public async void ExecuteLaunchCommand(object parameter)
        {
            bool hasDeferral = bool.Parse(parameter.ToString()!);
            var cd = new ContentDialog {
                                           PrimaryButtonText        = "PrimaryButtonText",
                                           SecondaryButtonText      = "SecondaryButtonText",
                                           CloseButtonText          = "CloseButtonText",
                                           Title                    = "Title",
                                           Content                  = "Content",
                                           IsPrimaryButtonEnabled   = true,
                                           IsSecondaryButtonEnabled = true,
                                           DefaultButton            = ContentDialogButton.None,
                                           FullSizeDesired          = true,
                                       };

            if (hasDeferral)
            {
                cd.PrimaryButtonClick += OnPrimaryButtonClick;
                await cd.ShowAsync();
                cd.PrimaryButtonClick -= OnPrimaryButtonClick;
            }
            else
            {
                await cd.ShowAsync();
            }
        }

        private void      OnPrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args) { }
        public  FACommand LaunchDialogCommand { get; }
    }
    public class FACommand : ICommand
    {
        public FACommand(Action<object> executeMethod)
        {
            _executeMethod = executeMethod;
        }

        public event EventHandler CanExecuteChanged;
        public bool               CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _executeMethod.Invoke(parameter);
        }

        private Action<object> _executeMethod;
    }
}