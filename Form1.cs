using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_citas_medicas
{
    public partial class Form1 : Form
    {
        List<Doctor> doctores = new List<Doctor>();
        List<Paciente> pacientes = new List<Paciente>();
        List<Cita> citas = new List<Cita>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerDoctores()
        {
            FileStream stream = new FileStream("Doctores.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Doctor doctor = new Doctor();

                doctor.Id = Convert.ToInt32(reader.ReadLine());
                doctor.Nombre = reader.ReadLine();  
                doctor.Especialidad = reader.ReadLine();

                doctores.Add(doctor);
            }

            reader.Close();
        }

        private void LeerPacientes()
        {
            FileStream stream = new FileStream("Pacientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Paciente paciente = new Paciente();

                paciente.Dpi = reader.ReadLine();
                paciente.NombreCompleto = reader.ReadLine();
                paciente.Telefono = Convert.ToInt32(reader.ReadLine());

                pacientes.Add(paciente);
            }

            reader.Close();
        }

        private void LeerCitas()
        {

            FileStream stream = new FileStream("Citas.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Cita cita = new Cita();

                cita.IdDoctor = Convert.ToInt32(reader.ReadLine());
                cita.IdPaciente = reader.ReadLine();
                cita.FechaCita = Convert.ToDateTime(reader.ReadLine());
                cita.HoraCita = Convert.ToDateTime(reader.ReadLine());

                citas.Add(cita);
            }

            reader.Close();
        }

        private void GuardarCita()
        {
            FileStream stream = new FileStream("Citas.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            // Se recorren todas las citas y se escriben en el archivo
            foreach (var ins in citas)
            {
                writer.WriteLine(ins.IdDoctor);
                writer.WriteLine(ins.IdPaciente);
                writer.WriteLine(ins.FechaCita);
                writer.WriteLine(ins.HoraCita);
            }

            writer.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            LeerDoctores();
            LeerPacientes();
            LeerCitas();

            comboBoxDoctor.DataSource = doctores;
            comboBoxDoctor.DisplayMember = "Nombre";

            comboBoxPaciente.DataSource = pacientes;
            comboBoxPaciente.DisplayMember = "NombreCompleto";
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)comboBoxDoctor.SelectedItem;
            Paciente paciente = (Paciente)comboBoxPaciente.SelectedItem;

            Cita cita = new Cita();

            cita.IdDoctor = doctor.Id;
            cita.IdPaciente = paciente.Dpi;
            cita.FechaCita = dateTimePickerFecha.Value;
            cita.HoraCita = dateTimePickerCita.Value;
        
            citas.Add(cita);
            GuardarCita();
        }

        private void MostrarCitas()
        {
            List<object> reporte = new List<object>();

            foreach (var c in citas)
            {
                Doctor doctor = null;
                Paciente paciente = null;

                
                foreach (var d in doctores)
                {
                    if (d.Id == c.IdDoctor)
                    {
                        doctor = d;
                        break;
                    }
                }

                // Buscar paciente
                foreach (var p in pacientes)
                {
                    if (p.Dpi == c.IdPaciente)
                    {
                        paciente = p;
                        break;
                    }
                }

                if (doctor != null && paciente != null)
                {
                    reporte.Add(new
                    {
                        Doctor = doctor.Nombre,
                        Especialidad = doctor.Especialidad,
                        Paciente = paciente.NombreCompleto,
                        Fecha = c.FechaCita,
                        Hora = c.HoraCita
                    });
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporte;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
          
            MostrarCitas();
        }

        private void buttonOrdenarFecha_Click(object sender, EventArgs e)
        {
            
            citas = citas.OrderBy(c => c.FechaCita).ToList();
            MostrarCitas();
        }

        private void buttonOrdenarDoctor_Click(object sender, EventArgs e)
        {
            doctores = doctores.OrderBy(d => d.Nombre).ToList();
            MostrarCitas();
        }

        private void buttonEstadisticas_Click(object sender, EventArgs e)
        {
            int TotalCitas = citas.Count();

            MessageBox.Show("Cantidad total de citas registradas: " + TotalCitas);
        }
    }
}

