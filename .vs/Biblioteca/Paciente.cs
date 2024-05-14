using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente: Persona
    {
        private string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia):base(nombre,apellido,nacimiento,barrioResidencia)
        {
            this.diagnostico = "";
        }

        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }
            set
            {
                diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Reciden en: {barrioResidencia}");
            sb.AppendLine($"Diagnostico");
            return sb.ToString();
        }
    }
}
