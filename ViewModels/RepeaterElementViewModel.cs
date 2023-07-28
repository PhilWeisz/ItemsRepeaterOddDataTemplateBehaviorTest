using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemsRepeaterOddDataTemplateBehaviorTest.ViewModels.Interfaces;

namespace ItemsRepeaterOddDataTemplateBehaviorTest.ViewModels
{
    public class RepeaterElementViewModel : ViewModelBase, IRepeaterHostElementViewModel
    {
        public RepeaterElementViewModel(int testValue)
        {
            TestValue = testValue;
        }

        private int _testValue;
        public int TestValue
        {
            get => _testValue;
            set => RaiseAndSetIfChanged(ref _testValue, value);
        }
    }
}
