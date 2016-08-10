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
    public partial class FrmListadoAlumno : Form
    {

        public FrmListadoAlumno()
        {
            InitializeComponent();
        }
        #region abm
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmDetalleAlumno agregar = new FrmDetalleAlumno("agregar",ListAlumnos);
                   
            agregar.ShowDialog();
            if (ClListadoAlumnos.datosalumno!=null)
            {
               
                ListAlumnos.Items.Add(ClListadoAlumnos.datosalumno);
            }
           
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int seleccionado = ListAlumnos.SelectedIndex;
            if (ListAlumnos.SelectedItems.Count == 1)
            {
               
                FrmDetalleAlumno modificar = new FrmDetalleAlumno("modificar", ListAlumnos);
               
                modificar.ShowDialog();
                if (ClListadoAlumnos.datosalumno != null)
                {

                    ListAlumnos.Items[seleccionado]=ClListadoAlumnos.datosalumno;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un alumno");
            }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int seleccionado = ListAlumnos.SelectedIndex;
            if (ListAlumnos.SelectedItems.Count == 1)
            {
                FrmDetalleAlumno eliminar = new FrmDetalleAlumno("eliminar", ListAlumnos);
                eliminar.ShowDialog();
                if (ClListadoAlumnos.datosalumno != null)
                {
                    ListAlumnos.Items.RemoveAt(seleccionado);
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione un alumno");
            }
        }
        #endregion 
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FrmListadoAlumno_Load(object sender, EventArgs e)
        {
            //ordena
            ListAlumnos.Sorted = true;
            //determina si selecciona uno o no
            ListAlumnos.MultiColumn = false;
        }
    }
}
