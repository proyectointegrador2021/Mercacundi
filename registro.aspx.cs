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



namespace prueba_final1.Content
{
   
    public partial class registro : System.Web.UI.Page
    {
        
        NpgsqlConnection conexion = new NpgsqlConnection("server = localhost; port=5432;Database=mercacundic;User Id = postgres; Password=zonix1952;");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //datoserror.Visible = false;

        }

        protected void registrar1_Click(object sender, EventArgs e)
        {
            String usu1 = usure.Text;
            String con1 = contrare.Text;
            String con2 = contrare2.Text;
           long codi1 = Convert.ToInt64(codigo_estudiantil.Text);
           String code2 = codigo_estudiantil.Text;
            char serv ='a';
            int error = 0;
            try
            {
                  conexion.Open();
                 NpgsqlCommand sqlCmd = new NpgsqlCommand();
                String cadenacomando;
          
                sqlCmd.Connection = conexion;
                cadenacomando = "INSERT INTO Public.tusuarios(usuario,contraseña,cestudiantil,servicio) values (@usuario,@contraseña,@codigo,@service)";
              
                  sqlCmd.CommandText = cadenacomando;
                
                //------ los errores desde aqui----------------------------------------------------------------------------//
                
                if (usu1 !="")
                  {
                         sqlCmd.Parameters.AddWithValue("@usuario", usu1);

                  }
                  else
                  {
                    error = 5;
                  }
                  //---------
                  if (con1 != "") {
                      if (con2 != "") { 
                      if (con1 == con2)
                      {
                                  sqlCmd.Parameters.AddWithValue("@contraseña", con1);
                          }
                      }
                    else
                    {
                        error = 2;
                    }
                }
                  else
                  {
                    error = 2;
                  }
                  //__________________________
                  if ((codi1 >0) && (codi1 <999999999))
                  {
                        sqlCmd.Parameters.AddWithValue("@codigo", codi1);
                  }
                  else
                  {
                      error = 4;
                  }
                  //-----------------------------
                 
                if (boxcomprador.Checked==true && boxvendedor.Checked==true )
                      {
                    error = 3;
                  }
                 else if(boxcomprador.Checked == true)
                  {
                      serv = 'c';
                         sqlCmd.Parameters.AddWithValue("@service", serv);
                  }
                  else if(boxvendedor.Checked == true)
                  {
                      serv = 'v';
                         sqlCmd.Parameters.AddWithValue("@service", serv);
                  }

                //_---------revisar si existe ya---------------------------------
                /*
                String serv1 = serv.ToString();
                NpgsqlCommand command = new NpgsqlCommand("SELECT *FROM Public.tusuarios WHERE usuario = @usuario", conexion);
                   
                    command.Parameters.AddWithValue("@usuario",usure.Text);
                  
                    NpgsqlDataReader registro = command.ExecuteReader();
                if (registro.Read())
                {
                    //----- revisar 1*1
                    // contrare.Text = registro["contraseña"].ToString();---muestra principal
                    if ( code2== registro["cestudiantil"].ToString() ||  serv1 == registro["servicio"].ToString()|| usu1 == registro["usuarios"].ToString())
                    {
                        datoserror.Text = " estudiante ya registrado";
                        error = error + 1;
                    }
                
                  


                }
                */
                //_------------------------------------------------------------------------------

                if (error == 0)
                    {
                       
                   // revisar = "SELECT *FROM Public.tusuarios WHERE usuario = @usuario";
              
                    sqlCmd.ExecuteNonQuery();
                    datoserror.Text = "registrado correctamnte";
                    //---------------
                    //Response.Redirect("inisiarsecion.aspx");

                }








                else
                {
                   datoserror.Text ="datos erroneos en las casillas " + error;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                  datoserror.Text = (String)ex.Message;
        
            }
        }
        
    }
}