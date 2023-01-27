using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using TextBox = System.Windows.Forms.TextBox;

namespace bdInterfaces.DB;

public class Db
{
    static MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=pocholo001;database=bdinterfaces");
   
    
    // login
    public static Boolean login(String usuario, String contrasena)
    {
        Boolean existe = false;
        
        conexion.Open();
        string consultaUser = "SELECT * FROM users WHERE User = @vusuario";
        MySqlCommand cmd = new MySqlCommand(consultaUser, conexion);
        cmd.Parameters.AddWithValue("@vusuario", usuario);
        cmd.Parameters.AddWithValue("@contrasenia", contrasena);

        MySqlDataReader lector = cmd.ExecuteReader();
        
        if (lector.Read())
        {
            existe = true;
        }
        conexion.Close();
        return existe;
    }
    
    // combobox categorias
    public static MySqlDataReader cbCategoria()
    {
        MySqlCommand cmd = new MySqlCommand("SELECT CategoryName FROM categories",conexion);
        conexion.Open();
        MySqlDataReader registro = cmd.ExecuteReader();
        return registro;
    }

    public static void cerrarConexion()
    {
        conexion.Close();
    }
    
    
}