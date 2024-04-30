using CedPases_ObtenerTokenBCRA.RN;
using System.Configuration;
using CedPases_ObtenerTokenBCRA.Entidades;

namespace CedST_ObtenerTokenBCRA;

class Program
{
    static int Main(string[] args)
    {
        CedPases_ObtenerTokenBCRA.Entidades.Sesion sesion = CrearSesion();
        if (sesion != null)
        {
            return new ObtenerTokenBcra(sesion).InsertarTokenBcra();
        }
        else
        {
            Console.WriteLine("Error: No se pudo conectar a la base de datos");
            return 1;
        }
    }

    private static CedPases_ObtenerTokenBCRA.Entidades.Sesion CrearSesion()
    {
        Console.WriteLine(string.Format("{0}--->{1}", DateTime.Now.ToString("HH:mm:ss"), System.Reflection.MethodBase.GetCurrentMethod().Name));
        CedPases_ObtenerTokenBCRA.Entidades.Sesion sesion = new CedPases_ObtenerTokenBCRA.Entidades.Sesion();
        sesion.TokenBcra = ConfigurationManager.AppSettings["TokenBcra"];
        sesion.ArchivoBcra = ConfigurationManager.AppSettings["ArchivoBcra"];

        string usuarioDBEnv = ConfigurationManager.AppSettings["UsuarioDBEnv"];
        string passwordDBEnv = ConfigurationManager.AppSettings["PasswordDBEnv"];
        string servernameDBEnv = ConfigurationManager.AppSettings["ServernameDBEnv"];
        string nameDBEnv = ConfigurationManager.AppSettings["NameDBEnv"];

        try
        {
            sesion.CnnStr = string.Format("Server={2};Database={3};Trusted_Connection=false;Integrated Security=SSPI;", usuarioDBEnv, passwordDBEnv, servernameDBEnv, nameDBEnv);
            return sesion;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al crear la cadena de conexión a la base de datos: " + ex.Message);
            return null;
        }
    }
}
