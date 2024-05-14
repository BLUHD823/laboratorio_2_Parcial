using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        protected Persona(string apellido, DateTime nacimiento, string nombre)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
            this.barrioResidencia = "No disponible";
        }

        public Persona(string nombre,string apellido, DateTime nacimiento,string barrioResidencia):this(apellido,nacimiento,nombre)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{apellido},{nombre}.";
            }
        }

        internal abstract string FichaExtra();

        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new();
            sb.AppendLine($"{p.ToString()}");
            sb.AppendLine($"Edad:{p.Edad}");
            sb.AppendLine($"Residencia: {p.barrioResidencia}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}