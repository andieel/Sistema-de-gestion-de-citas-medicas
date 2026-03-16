using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_citas_medicas
{
    internal class Doctor
    {
        int id;
        string nombre;
        string especialidad;
      
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

    }
}
