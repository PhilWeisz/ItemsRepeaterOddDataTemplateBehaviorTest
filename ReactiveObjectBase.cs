// // ReactiveObjectBase.cs 28:07:28

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using ReactiveUI;

namespace ItemsRepeaterOddDataTemplateBehaviorTest
{
    public abstract class ReactiveObjectBase : ReactiveObject, INotifyPropertyChanged
    {
        [NotifyPropertyChangedInvocator]
        protected virtual void RaiseAndSetIfChanged<T>(ref T backingField, T newValue, [CallerMemberName] string propertyName = null!)
        {
            IReactiveObjectExtensions.RaiseAndSetIfChanged(this, ref backingField, newValue, propertyName);
        }
    }
}