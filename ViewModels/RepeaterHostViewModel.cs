using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ItemsRepeaterOddDataTemplateBehaviorTest.ViewModels.Interfaces;

namespace ItemsRepeaterOddDataTemplateBehaviorTest.ViewModels
{
    public class RepeaterHostViewModel : ViewModelBase
    {
        private readonly ObservableCollection<IRepeaterHostElementViewModel> _items = new();
        private readonly int                                                      _columnCount = 4;

        public RepeaterHostViewModel()
        {
            List<int> numbers = Enumerable.Range(0, 20).ToList();

            foreach (var number in numbers)
            {
                Items.Add(new RepeaterElementViewModel(number));
            }
        }

        public ObservableCollection<IRepeaterHostElementViewModel> Items
        {
            get => _items;
            init => RaiseAndSetIfChanged(ref _items, value);
        }

        public int ColumnCount => _columnCount;
    }
}