using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TP_ConstSoft_1
{
    class ClAlumno
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }

        public bool ValidarLegajo(ListBox listado)
        {
            bool esvalido = false;

            try
            {
                int temporal= Convert.ToInt32(Legajo);
                esvalido = true;
                foreach(string item in listado.Items)
                {

                    string[] gg = item.Split('|');
                    MessageBox.Show(gg[0] + " " + Legajo.Trim());

                    if (gg[0] == Legajo.Trim())
                    {
                        MessageBox.Show("El Legajo que desea cargar ya existe");
                        esvalido = false;
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique el numero de Legajo");
                esvalido = false;
              
            }
            if (esvalido==false)
            {
                ClListadoAlumnos.datosalumno = null;
            }
            return esvalido;
        }
        
        public bool AgregarAlumno()
        {
            
           string texto = Legajo+'|'+Apellido + ',' + Nombre +'|'+ Carrera;
           Label Imagen = new Label();
           Imagen.Text = texto;

            ClListadoAlumnos.datosalumno = texto;
          
           return true;
        }
    }
}
