using System.Windows;
using System.Windows.Input;

namespace bdInterfaces.View;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
        // para que salga la barra de menu de abajo y no la tape al maximizar pantalla
    }

    private void MainView_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }

    private void Volver_OnClick(object sender, RoutedEventArgs e)
    {
        LoginView main = new LoginView();
        this.Close();
        main.Show();
    }
}