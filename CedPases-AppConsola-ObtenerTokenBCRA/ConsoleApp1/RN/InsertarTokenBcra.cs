using CedPases_ObtenerTokenBCRA.Entidades;
using System.Data;

namespace CedPases_ObtenerTokenBCRA.RN
{
    public class ObtenerTokenBcra
    {
        private Sesion m_sesion;

        public ObtenerTokenBcra(Sesion sesion)
        {
            m_sesion = sesion;
        }

        public string ObtenerStringTokenBcraArchivo()
        {
            Console.WriteLine("");
            string path = Directory.GetFiles(m_sesion.TokenBcra)[0];

            return File.ReadAllText(path);
        }

        public int InsertarTokenBcra()
        {
            try
            {
                DB.InsertarTokenBcra db = new DB.InsertarTokenBcra(m_sesion);

                string tokenBcra = ObtenerStringTokenBcraArchivo();

                db.InsertarTokenBcraParm(tokenBcra);

                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 1;
            }
        }
    }
}
