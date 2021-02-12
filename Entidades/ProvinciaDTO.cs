using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProvinciaDTO
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Localidades { get; set; }
        public int Abandonadas { get; set; }
        public int Habitantes { get; set; }

        public ProvinciaDTO()
        {
        }

        public ProvinciaDTO(string id)
        {
            Id = id;
        }

        public ProvinciaDTO(string id, string nombre) : this(id)
        {
            Nombre = nombre;
        }
        //Constructor
        public ProvinciaDTO(string id, string nombre, int localidades, int abandonadas, int habitantes) : this(id, nombre)
        {
            Localidades = localidades;
            Abandonadas = abandonadas;
            Habitantes = habitantes;
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as Provincia);
        }

        public bool Equals(Provincia other)
        {
            return other != null && Id.ToLower() == other.Id.ToLower();
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }

    }
}
