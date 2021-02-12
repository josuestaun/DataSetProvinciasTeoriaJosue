using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LocalidadDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreProvincia { get; set; }
        public String NumHab { get; set; }
        public LocalidadDTO()
        {
        }

        public LocalidadDTO(int id)
        {
            Id = id;
        }

        public LocalidadDTO(int id, string nombre, String numHab) : this(id)
        {
            Nombre = nombre;
            NumHab = numHab;
        }

        public LocalidadDTO(int id, string nombre, string nombreProvincia, String numHab) : this(id)
        {
            Nombre = nombre;
            NombreProvincia = nombreProvincia;
            NumHab = numHab;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Localidad);
        }

        public bool Equals(Localidad other)
        {
            return other != null && Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
