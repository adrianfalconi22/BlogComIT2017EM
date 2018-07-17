using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aplicacion.Models
{
    public class ArticuloManager
    {
        public void Insertar(Articulo articulo)
        {

        }

        public void Eliminar(Articulo articulo)
        {
            this.Eliminar(articulo.ID);
        }

        public void Eliminar(long ID)
        {

        }

        public void Actualizar(Articulo articulo)
        {

        }


        //public Articulo Consultar(long ID)
        //{
        //    return new Models.Articulo();
        //}

        //public List<Articulo> ConsultarTodos()
        //{
        //   List<Articulo> articulos = new List<Articulo>();
        //    //1Conexion a que base de datos
        //    SqlConnection conexion = new SqlConnection("Server=.\\SQLEXPRESS;Database=Blog;Trusted_Connection=True;");
            
        //    //2nox conectamos
        //     conexion.Open();
            
        //    //3-creamos el objeto
        //    SqlCommand sentencia = conexion.CreateCommand();
            
        //    //4escribimos
        //    sentencia.CommandText = "Select * From Articulos";
            
        //    //5 ejecutamos la consulta

        //    SqlDataReader reader = sentencia.ExecuteReader();


        //    while (reader.Read())
        //    {
        //        Articulo articulo = new Articulo();
        //        articulo.Titulo = reader["Titulo"].ToString();
        //        articulo.Texto = reader["Texto"].ToString();

        //        articulos.Add(articulo);
        //    }
            
            
        //    reader.Close();

        //     conexion.Close();   
            
            
             
        //    return new List<Articulo>();

        //}

        //public List<Articulo> Consultar(Usuario autor)
        //{
        //    return new List<Articulo>();
        //}






    }
}