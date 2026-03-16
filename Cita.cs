using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_citas_medicas
{
    internal class Cita
    {
        int idDoctor;
        string idPaciente;
        DateTime fechaCita;
        DateTime horaCita;

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string IdPaciente { get => idPaciente; set => idPaciente = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public DateTime HoraCita { get => horaCita; set => horaCita = value; }
    }
}
