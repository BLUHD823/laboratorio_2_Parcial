using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PersonalMedico:Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente):base(nombre,nacimiento,apellido)
        {
            this.consultas = new List<Consulta>();
            this.esResidente = esRecidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new();
            if (esResidente)
            {
                sb.AppendLine("¿Finalizó residencia? Si.");
            }
            else
            {
                sb.AppendLine("¿Finalizó residencia? No.");
            }
            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta cons1 = new(DateTime.Now, paciente);
            foreach (Consulta item in doctor.consultas)
            {
                if (item.Paciente.NombreCompleto != paciente.NombreCompleto )
                {
                    doctor.consultas.Add(cons1);
                    return cons1;
                }
            }
            return cons1;   
        }

    }
}
