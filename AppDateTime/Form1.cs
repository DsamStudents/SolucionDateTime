using AppDateTime.Helper;
using System;
using System.Windows.Forms;

namespace AppDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtGetFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = DtFecha.Value;


            MessageBox.Show("La fecha seleccionada es " + DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Now;
            MessageBox.Show("La fecha actual más 30 días es : " + fecha.AddDays(30));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fechaSeleccionada = DtFecha.Value;
            var fechaActual = DateTime.Now;
            if (fechaSeleccionada > fechaActual)
            {
                MessageBox.Show("Estupido, la fecha es mayor");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DtFechaNacimiento.MaxDate = DateTime.Now;
        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var estudiante = new Estudiante();
                if (string.IsNullOrEmpty(TbNombre.Text))
                {
                    throw new Exception(Utilidad.ERRORNAMEEMPTY);
                }
                estudiante.Nombre = TbNombre.Text;
                estudiante.FechaNacimiento = DtFechaNacimiento.Value;
                var edad = Utilidad.CalcularEdad(DtFechaNacimiento.Value);
                MessageBox.Show("La edad del estudiante es " + edad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Utilidad.ERROR01+" "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}