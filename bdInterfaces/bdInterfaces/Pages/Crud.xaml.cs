using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace bdInterfaces.Pages;

public partial class Crud : Page
{
    public Crud()
    {
        InitializeComponent();
        list.Items.Add("1");
        list.Items.Add("2");
        list.Items.Add("3");
        list.Items.Add("4");
        list.Items.Add("5");
        list.Items.Add("6");
        list.Items.Add("7");
        list.Items.Add("8");
        list.Items.Add("9");
        list.Items.Add("10");
        list.Items.Add("11");
        list.Items.Add("12");
        
        list.SetValue(
            ScrollViewer.VerticalScrollBarVisibilityProperty,
            ScrollBarVisibility.Disabled);
            
    }



    private void RbtAgregar_OnClick(object sender, RoutedEventArgs e)
    {
        SubMenus.Content = new Agregar();
    }

    private void RbtModificar_OnClick(object sender, RoutedEventArgs e)
    {
        SubMenus.Content = new Modificar();
    }

    private void RbtBorrar_OnClick(object sender, RoutedEventArgs e)
    {
        SubMenus.Content = new Borrar();
    }
}