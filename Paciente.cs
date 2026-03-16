using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_citas_medicas
{
    internal class Paciente
    {
        string dpi;
        string nombreCompleto;
        int telefono;

        public string Dpi { get => dpi; set => dpi = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
