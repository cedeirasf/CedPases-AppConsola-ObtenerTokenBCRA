using CedPases_ObtenerTokenBCRA.RN;
using System.Configuration;
using CedPases_ObtenerTokenBCRA.Entidades;

namespace CedST_ObtenerTokenBCRA;

class Program
{
    static int Main(string[] args)
    {
        return new ObtenerTokenBcra(CrearSesion()).InsertarTokenBcra();
    }

    private static CedPases_ObtenerTokenBCRA.Entidades.Sesion CrearSesion()
    {
        Console.WriteLine(string.Format("{0}--->{1}", DateTime.Now.ToString("HH:mm:ss"), System.Reflection.MethodBase.GetCurrentMethod().Name));
        CedPases_ObtenerTokenBCRA.Entidades.Sesion sesion = new CedPases_ObtenerTokenBCRA.Entidades.Sesion();
        sesion.Ambiente = ConfigurationManager.AppSettings["Ambiente"];
        sesion.TokenBcra = ConfigurationManager.AppSettings["TokenBcra"];

        string usuarioDBEnv = ConfigurationManager.AppSettings["UsuarioDBEnv"];
        string passwordDBEnv = ConfigurationManager.AppSettings["PasswordDBEnv"];
        string servernameDBEnv = ConfigurationManager.AppSettings["ServernameDBEnv"];
        string instancenameDBEnv = ConfigurationManager.AppSettings["InstancenameDBEnv"];
        string nameDBEnv = ConfigurationManager.AppSettings["NameDBEnv"];

        sesion.CnnStr = string.Format("Server={2}\\{3};Database={4};Trusted_Connection=false;user id={0};password={1};", usuarioDBEnv, passwordDBEnv, servernameDBEnv, instancenameDBEnv, nameDBEnv);

        return sesion;
    }
}
