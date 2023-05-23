using Process_SA.Controller;
using Process_SA.View;
using Process_SA.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_SA.Controlador
{
    public class ControladorFuncionario
    {
        VistaFuncionario vistaFuncionario;
        ControladorFuncionario ctrFuncionario;
        public ControladorFuncionario()
        {
            vistaFuncionario = new VistaFuncionario();
            ctrFuncionario = new ControladorFuncionario();
            vistaFuncionario.testEvento += VistaFuncionario_testEvento;
        }
    }


}
