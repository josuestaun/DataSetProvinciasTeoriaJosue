using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia : IEquatable<Provincia>
    {
        public Provincia()
        {
        }

        public Provincia(string id)
        {
            Id = id;
        }

        public Provincia(string id, string nombre) : this(id)
        {
            Nombre = nombre;
        }

 

        public string Id { get; set; }
        public string Nombre { get; set; }
        
        public override bool Equals(object obj)
        {
            return Equals(obj as Provincia);
        }

        public bool Equals(Provincia other)
        {
            return other != null &&  Id.ToLower() == other.Id.ToLower();
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
