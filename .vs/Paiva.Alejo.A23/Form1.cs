using Biblioteca;
using System.Text;

namespace Paiva.Alejo.A23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (lstMedicos.SelectedIndex != -1 && lstPacientes.SelectedIndex != -1)
            {
                Paciente pacienteSeleccionado = (Paciente)lstPacientes.SelectedItem;
                pacienteSeleccionado.Diagnostico = "Paciente curado";
                lstMedicos.SelectedIndices.Clear();
                lstPacientes.SelectedIndices.Clear();

                MessageBox.Show($"{pacienteSeleccionado.Diagnostico}", "Atención finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonalMedico medicoSeleccionado = (PersonalMedico)lstMedicos.SelectedItem;
            StringBuilder sb = new();
            sb.AppendLine($"{Persona.FichaPersonal(medicoSeleccionado)}");
            rtbInfoMedico.Text = sb.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("¿Seguro desea salir.?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}