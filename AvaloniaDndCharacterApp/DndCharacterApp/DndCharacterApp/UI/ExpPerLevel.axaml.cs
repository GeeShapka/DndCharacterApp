using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DndCharacterApp;

public partial class ExpPerLevel : Window
{
    public ExpPerLevel()
    {
        InitializeComponent();
    }

    private void CloseWindow(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Close();
    }
}