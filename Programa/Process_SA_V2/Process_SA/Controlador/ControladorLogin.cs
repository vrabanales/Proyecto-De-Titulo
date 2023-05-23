using Process_SA.View;

namespace Process_SA.Controller
{
    public class ControladorLogin
    {
        VistaLogin vistaLogin;
        ControladorEspera ctrHome;
        public ControladorLogin()
        {
            vistaLogin = new VistaLogin();
            ctrHome = new ControladorEspera();
            vistaLogin.testEvento += VistaLogin_testEvento;
        }

        public void VistaLogin_testEvento(string usaer, string pass)
        {
            if (usaer == "" || pass == "")
            {
                MessageBox.Show("Ingrese ussuario o contraseña", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctrHome.IniciarVista();
            }
        }

        public void IniciatrVista()
        {
            vistaLogin.ShowDialog();
        }

    }
}
