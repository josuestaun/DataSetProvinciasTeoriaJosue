

using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosDSet
{
    public class GestionDSet
    {
        DsEstado dsEstado = new DsEstado();

		public GestionDSet(out String msg)
		{
			msg = LlenarTablas();
		}
        public String LlenarTablas()
		{
            //Importamos los adaptadores para las tablas del DataSet
            DataSet1TableAdapters.LocalidadesTableAdapter localidadesTableAdapter = new DataSet1TableAdapters.LocalidadesTableAdapter();

            DataSet1TableAdapters.ProvinciasTableAdapter provinciasTableAdapter = new DataSet1TableAdapters.ProvinciasTableAdapter();

			//Llenamos las tablas
			try
			{
				localidadesTableAdapter.Fill(dsEstado.Localidades);
				provinciasTableAdapter.Fill(dsEstado.Provincias);
			}
			catch (Exception exc)
			{

			return exc.Message;
			}
			return "";
		}

		//Ejercicio 1 con ForEach
		public List<Provincia> ListaDeProvincias()
		{
			List<Provincia> listaProvincias = new List<Provincia>();
			foreach (DsEstado.ProvinciasRow p in dsEstado.Provincias)
			{
				Provincia prov = new Provincia(p.Id,p.Nombre);
				listaProvincias.Add(prov);
			}

			return listaProvincias.ToList();
		}

		//Ejercicio 2
		public List<Provincia> ProvinciasConComienzo(string text)
		{
			var provinciasComienzo = dsEstado.Provincias.Where(p => p.Nombre.ToUpper().StartsWith(text.ToUpper())).OrderBy(prov=> prov.Nombre).Select(p => new Provincia(p.Id, p.Nombre));
			return provinciasComienzo.ToList();
			
		}


		//Ejercicio 3
		public List<Localidad> PueblosAbandonados(string id, out string msj)
		{
			msj = "";
			if (String.IsNullOrEmpty(id))
            {
				msj = "En todas las provincias";
				var pueblosAbandonados = dsEstado.Localidades.Where(l => l.IsNumHabNull() == true).Select(l => new Localidad(l.Id, l.Nombre, l.IdProv, 0));
				return pueblosAbandonados.ToList();
			}
            else
            {
				//Busco provincia
				if (dsEstado.Provincias.FindById(id) == null)
                {
					msj = "No existe la provincia";
					return null;
                }
                else
                {
					msj = "Buscando en la provincia con Id: " + id;
					var pueblosAbandonados = dsEstado.Provincias.FindById(id).GetLocalidadesRows().Where(l => l.IsNumHabNull() == true).Select(l => new Localidad(l.Id, l.Nombre, l.IdProv, 0));
					return pueblosAbandonados.ToList();
				}
            }
		}

		//Ejercicio4
		public List<Provincia> ProvinciasSinLocalidades()
        {
			var provinciasSinLocalidades = from provin in dsEstado.Provincias
										   where provin.GetLocalidadesRows().Count() < 1
										   select new Provincia(provin.Id, provin.Nombre);

			return provinciasSinLocalidades.ToList();
        }

		//Ejercicio5
		
		//por id
		public int HabitantesDeProvinciaPorId(string id, out string msj)
        {
			msj = "";
			if (String.IsNullOrEmpty(id))
			{
				msj = "El id de la provincia está vacío.";
				return -1;
			}
			var drProv = dsEstado.Provincias.FindById(id);
			if(drProv  == null)
            {
				msj = "No existe la provincia";
				return -1;
            }
           
           	int numHabitantes = drProv.GetLocalidadesRows().Sum(l => l.IsNumHabNull() ? 0 : l.NumHab);
				return numHabitantes;
            }
		
		//por nombre
		public int HabitantesDeProvinciaPorNombre(string nombre, out string msj)
		{
			msj = "";
			if (String.IsNullOrEmpty(nombre))
			{
				msj = "El id de la provincia está vacío.";
				return -1;
			}
			var drProv = dsEstado.Provincias.SingleOrDefault(p => p.Nombre.ToUpper() == nombre.ToUpper());
			if (drProv == null)
			{
				msj = "No existe la provincia";
				return -1;
			}

			int numHabitantes = drProv.GetLocalidadesRows().Sum(l => l.IsNumHabNull() ? 0 : l.NumHab);
			return numHabitantes;
		}

        //Ejercicio 6
        public List<LocalidadDTO> localidadesOrdenadas(int numero, out string msj)
        {
            msj = "";
			var drLocalidades = dsEstado.Localidades.OrderByDescending(loc => loc.IsNumHabNull() ? 0 : loc.NumHab).ThenBy(loc => loc.Nombre).Take(numero)
								.Select(loc => new LocalidadDTO(loc.Id, loc.Nombre, (dsEstado.Provincias.FindById(loc.IdProv).Nombre), 
								loc.IsNumHabNull() ? "abandonada" : loc.NumHab.ToString("#,##0")));

			return drLocalidades.ToList();
        }


        //Ejercicio 7 -> falla los numHab nulos
        public List<LocalidadDTO> localidadesMasPequeñas()
        {
			//Primero calculo cual es el numero de habitantes minimo de esas localidades
			int minHabitantes = (from local in dsEstado.Localidades
								 where local.IsNumHabNull() == false
								 select local.NumHab).Min();

			//Ahora calculo que localidades tienen ese numero de habitantes
			var drLocalidades = from loc in dsEstado.Localidades
								where !loc.IsNumHabNull() && loc.NumHab == minHabitantes
								select new LocalidadDTO(loc.Id, loc.Nombre, (dsEstado.Provincias.FindById(loc.IdProv).Nombre), loc.IsNumHabNull() ? "abandonada" : loc.NumHab.ToString("#,##0"));
			return drLocalidades.ToList();
        }

		//Ejercicio 8
		public List<ProvinciaDTO> provinciasConLocalidades()
        {
			//Obtengo las provincias que tienen localidades y creo un objeto de clase ProvinciaDTO
			var provConLocalidades = from provin in dsEstado.Provincias
									 where provin.GetLocalidadesRows().Count() > 0
									 select new ProvinciaDTO(
										 provin.Id,
										 provin.Nombre,
										 (provin.GetLocalidadesRows().Length),
										 (provin.GetLocalidadesRows().Where(l => l.IsNumHabNull() == true).Count()),
										 (provin.GetLocalidadesRows().Sum(l => l.IsNumHabNull() ? 0 : l.NumHab))
										 );

			return provConLocalidades.ToList();
        }
    }
}
