using System.Windows.Controls;
using bdInterfaces.DB;
using MySql.Data.MySqlClient;

namespace bdInterfaces.Pages;

public partial class Modificar : Page
{
    public Modificar()
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
}