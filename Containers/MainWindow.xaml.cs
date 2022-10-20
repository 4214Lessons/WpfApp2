using System.Windows;
using System.Windows.Controls;

namespace Containers;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Button btn = new()
        {
            Content = 4,
            FontSize = 42
        };

        // sp.Children.Add(btn);

    }
}
