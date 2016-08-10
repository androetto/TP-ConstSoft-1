using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_ConstSoft_1
{
    public partial class FrmDetalleAlumno : Form
    {
        string g_llamador ="";
        ListBox g_listadoAlumnosCargados;

        public FrmDetalleAlumno( string llamador,ListBox listadoAlumnosCargados)
        {
            g_llamador = llamador;
            g_listadoAlumnosCargados = listadoAlumnosCargados;
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            ClListadoAlumnos.datosalumno = null;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarTextBox())
            {
                ClAlumno alumno = new ClAlumno();

                alumno.Nombre = TxtBoxNombre.Text;
                alumno.Apellido = TxtBoxApellido.Text;
                alumno.Legajo = TxtBoxLegajo.Text;
                alumno.Carrera = TxtBoxCarrera.Text;
                if (g_llamador == "agregar")
                {


                    if (alumno.ValidarLegajo(g_listadoAlumnosCargados))
                    {
                       alumno.AgregarAlumno();


                      
                    }
                    else
                    {
                        TxtBoxNombre.Focus();
                    }
                }
                if (g_llamador=="modificar" || g_llamador =="eliminar")
                {
                    alumno.AgregarAlumno();
                }
                this.Close();
            }
            
            
        }
        private void CompletarDatos()
        {
            string temporal = g_listadoAlumnosCargados.SelectedItem.ToString();
            string[] datostemporales = temporal.Split('|');
            TxtBoxLegajo.Text = datostemporales[0].ToString();
            string[] datospersonales = datostemporales[1].Split(',');



            TxtBoxNombre.Text = datospersonales[0].ToString();
            TxtBoxApellido.Text = datospersonales[1].ToString();
            TxtBoxCarrera.Text = datostemporales[2].ToString();
            BtnAceptar.Text = "Modificar";
            if (g_llamador == "eliminar")
            {
                TxtBoxApellido.Enabled = false;
                TxtBoxCarrera.Enabled = false;
                TxtBoxLegajo.Enabled = false;
                TxtBoxNombre.Enabled = false;
                BtnAceptar.Text = "Eliminar";
       
            }
        }
        private bool ValidarTextBox()
        {
            bool esvalido = true;
            if (TxtBoxNombre.Text == "")
            {
                MessageBox.Show("Complete el nombre");
                TxtBoxNombre.Focus();
                esvalido = false;
            }
            if (TxtBoxApellido.Text == "")
            {
                MessageBox.Show("Complete el Apellido");
                TxtBoxApellido.Focus();
                esvalido = false;
            }
            if (TxtBoxCarrera.Text == "")
            {
                MessageBox.Show("Seleccione una Carrera");
                TxtBoxCarrera.Focus();
                esvalido = false;
            }
            if (TxtBoxLegajo.Text == "")
            {
                MessageBox.Show("Complete con un legajo");
                TxtBoxLegajo.Focus();
                esvalido = false;
            }

            return esvalido;

        }
        private void FrmDetalleAlumno_Load(object sender, EventArgs e)
        {
            switch (g_llamador)
            {
                case "agregar":
                    BtnAceptar.Text = "Agregar";
                    break;
                case "modificar":
                    CompletarDatos();
                    break;
                case "eliminar":
                    CompletarDatos();
                    break;

                default:
                    break;
            }
        }
    }
}
