using System;
using System.Windows;
using System.Windows.Controls;
using bdInterfaces.DB;
using MySql.Data.MySqlClient;

namespace bdInterfaces.Pages;

public partial class Agregar : Page
{
    public Agregar()
    {
        InitializeComponent();
        cargarComboBox();
    }
    
    public void cargarComboBox()
    {
        // cargamos el combobox
        MySqlDataReader registro = Db.cbCategoria();
        while (registro.Read())
        {
            CbCategoria.Items.Add(registro["CategoryName"].ToString());
        }
        Db.cerrarConexion();
    }

    private void BtnAgregarPro_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(CbCategoria.SelectedValue.ToString());
    }
}