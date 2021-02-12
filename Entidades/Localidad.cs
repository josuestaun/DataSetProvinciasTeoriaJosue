using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad : IEquatable<Localidad>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string IdProv { get; set; }
        public int NumHab { get; set; }
        public Localidad()
        {
        }

        public Localidad(int id)
        {
            Id = id;
        }

        public Localidad(int id, string nombre, int numHab) : this(id)
        {
            Nombre = nombre;
            NumHab = numHab;
        }

        public Localidad(int id, string nombre, string idProv, int numHab) : this(id)
        {
            Nombre = nombre;
            IdProv = idProv;
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
