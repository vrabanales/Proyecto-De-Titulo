using Process_SA.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_SA.Controller
{
    public class ControladorEspera
    {
        VistaEspera vistaespera;

        public ControladorEspera()
        {
            vistaespera = new VistaEspera();
        }

        public void IniciarVista()
        {
            vistaespera.ShowDialog();
        }
    }
}
