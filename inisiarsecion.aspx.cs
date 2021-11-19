using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Npgsql;


namespace prueba_final1
{
    public partial class inisiarsecion : System.Web.UI.Page
    {
        NpgsqlConnection conexion = new NpgsqlConnection("server = localhost; port=5432;Database=mercacundic;User Id = postgres; Password=zonix1952;");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String usu1 = txtusuaro.Text;
            String con1 = txtcontraseña.Text;
            datos.Text = usu1;
            try
            {
                conexion.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT *FROM Public.tusuarios WHERE usuario = @usuario", conexion);

                command.Parameters.AddWithValue("@usuario", txtusuaro.Text);

                NpgsqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    //----- revisar 1*1
                    
                    if (usu1 == registro["usuario"].ToString() && con1 == registro["contraseña"].ToString())
                    {
                        datos.Text = "inisiando secion";

                    }
                    else
                    {
                        datos.Text = "usuario o contraseña incorrecta porfavor verifique";
                    }

                   
                }
            }
            catch (Exception ex)
            {
                datos.Text = (String)ex.Message;
            }
        }
       
    }
}