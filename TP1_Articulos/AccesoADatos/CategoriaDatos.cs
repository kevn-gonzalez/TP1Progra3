using System;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
    public class CategoriaDatos
    {
        public List<Categorias> Listar()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}