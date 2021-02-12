using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionDataSet
{
    public partial class FrmConsultasDataSet : Form
    {
        List<Provincia> lp;
        public static CapaDatosDSet.GestionDSet gest;
        public FrmConsultasDataSet()
        {
            InitializeComponent();
        }

		private void FrmConsultasDataSet_Load(object sender, EventArgs e)
		{
            gest = new CapaDatosDSet.GestionDSet(out string msg);
			if (!(msg.Equals("")))
			{
                MessageBox.Show(msg, "Atencion!");
                
			}
             lp = gest.ListaDeProvincias();
			foreach (Provincia p in lp)
			{
                 cboProvincias1.Items.Add(p.Nombre);
			}
           
        }

		private void cboProvincias1_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (Provincia p in lp)
			{
				if (cboProvincias1.Text.Equals(p.Nombre))
				{
					txtIdProv1.Text = p.Id;
					lblNombreProvincia1.Text = cboProvincias1.Text;
				}
			}
		}

		private void btnBuscarPorComienzoNombre_Click(object sender, EventArgs e)
		{
			List<Provincia> provs;
			if (String.IsNullOrWhiteSpace(txtComienzoNombreProv2.Text))
			{
				provs = lp;				
			}
			else
			{
				List<Provincia> provinciasConComienzo = gest.ProvinciasConComienzo(txtComienzoNombreProv2.Text);
				if (provinciasConComienzo.Count == 0)
				{
					MessageBox.Show("No hay provincias que comiencen por: " + txtComienzoNombreProv2.Text, "Atencion!");
					lstProvinciasPorComienzoNombre2.Items.Clear();
					return;
				}
				provs = provinciasConComienzo;
			}

			
			
			lstProvinciasPorComienzoNombre2.Items.Clear();

			lstProvinciasPorComienzoNombre2.Items.AddRange(provs.ToArray());
			lstProvinciasPorComienzoNombre2.DisplayMember = "Nombre";
			//foreach (Provincia p in provs)
			//{
				
			//	lstProvinciasPorComienzoNombre2.Items.Add(p.Nombre);
			//}
		}

		private void btnVerIds_Click(object sender, EventArgs e)
		{
			//FORMA 1:
			//
			//if (lstProvinciasPorComienzoNombre2.SelectedItems.Count == 0)
			//         {
			//	MessageBox.Show("No has elegido ninguna");
			//	return;
			//         }
			//string valor = "";
			//         foreach (var item in lstProvinciasPorComienzoNombre2.SelectedItems)
			//         {
			//             Provincia prov = (Provincia)item;
			//             valor += "\nNombre: " + prov.Nombre + " Id: " + prov.Id;
			//         }

			//         MessageBox.Show(valor, "Atencion!");

			//FORMA 2:
			var datosProvinciasSeleccionadas = (from Provincia provin in lstProvinciasPorComienzoNombre2.SelectedItems
										  select $"Nombre: {provin.Nombre}  Id: {provin.Id}").ToList();
			String valor = String.Join("\n", datosProvinciasSeleccionadas);
			MessageBox.Show(valor, "Atencion!");
		}

		private void btnBuscarPorId_Click(object sender, EventArgs e)
		{
			String msj = "";
			List<Localidad> localidades = gest.PueblosAbandonados(txtIdProv3.Text,out msj);
			MessageBox.Show(msj, "Atencion!");
			lblNombreProvincia3.Text = msj;
			if (localidades != null)
            {
				dgv.DataSource = (from loc in localidades
								  select new { loc.Nombre, loc.Id }).ToList();
			}
		}

        private void txtIdProv3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProvinciasSinLocalidades_Click(object sender, EventArgs e)
        {
			List<Provincia> provin = gest.ProvinciasSinLocalidades();
			dgv.DataSource = provin;
        }

		//Ejercicio 5
        private void btnHabitantesProv_Click(object sender, EventArgs e)
        {
			int num = 0;
			String msj = "";
			Button btn = (Button)sender;
			if (btn.Name == "btnHabitantesProv")
            {
				num = gest.HabitantesDeProvinciaPorId(txtIdProv4.Text, out msj);
				if (num != -1)
				{
					lblHabitantesProv4.Text = num.ToString("#,##0");
				}
				else
				{
					lblHabitantesProv4.Text = msj;

				}
			}
            else
            {
				num = gest.HabitantesDeProvinciaPorNombre(txtNombreProvincia4.Text, out msj);
				if (num != -1)
				{
					lblHabitantesProv4.Text = num.ToString("#,##0");
				}
				else
				{
					lblHabitantesProv4.Text = msj;

				}
			}
		}


		//Ejercicio 6
		private void btnCantidadLocalidadesPorHabitante_Click(object sender, EventArgs e)
        {
			String msj = "";
			List<LocalidadDTO> localidadesDto = gest.localidadesOrdenadas(int.Parse(txtCantidadLocalidades6.Text), out msj);
			//dgv.DataSource = localidadesDto;
			int num = 0;
			dgv.DataSource = (from locDto in localidadesDto
							  select new {Numero = ++num, Localidad = locDto.Nombre, Provincia = locDto.NombreProvincia, Nºhabitantes = locDto.NumHab}).ToList();
		}

        
		//Ejercicio 7
		private void btnLocalidadesPequeñas_Click(object sender, EventArgs e)
        {
			List<LocalidadDTO> localidadesPequeñas = gest.localidadesMasPequeñas();
			dgv.DataSource = (from locDto in localidadesPequeñas
							  select new {Localidad = locDto.Nombre, Provincia = locDto.NombreProvincia}).ToList();
		}


		//Ejercicio 8
		private void btnProvinciasDTO_Click(object sender, EventArgs e)
        {
			List<ProvinciaDTO> provinciasConLocalidades = gest.provinciasConLocalidades();
			dgv.DataSource = (from provinConLoc in provinciasConLocalidades
							  select new { Id = provinConLoc.Id, Nombre = provinConLoc.Nombre, Localidades = provinConLoc.Localidades, Abandonadas = provinConLoc.Abandonadas, Habitantes = provinConLoc.Habitantes.ToString("#,##0") }).ToList();
        }

    }
}
