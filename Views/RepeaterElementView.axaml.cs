using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ItemsRepeaterOddDataTemplateBehaviorTest.Views;

public partial class RepeaterElementView : UserControl
{
    public RepeaterElementView()
    {
        InitializeComponent();
    }

    private void InitializeComponent() { AvaloniaXamlLoader.Load(this); }
}