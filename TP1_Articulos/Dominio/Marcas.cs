using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Marcas
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
