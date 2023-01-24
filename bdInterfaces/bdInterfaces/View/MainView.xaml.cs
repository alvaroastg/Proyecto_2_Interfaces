using System.Windows;
using System.Windows.Input;

namespace bdInterfaces.View;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
    }

    private void MainView_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }

    private void BtnMinimizar_OnClick(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void BtnCerrar_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}