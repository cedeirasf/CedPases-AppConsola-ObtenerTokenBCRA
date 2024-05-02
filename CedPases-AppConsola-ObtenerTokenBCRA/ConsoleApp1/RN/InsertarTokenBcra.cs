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
            string archivoBcra = m_sesion.ArchivoBcra; 
            string directorioTokenBcra = m_sesion.TokenBcra;
            string path = Directory.GetFiles(directorioTokenBcra).Where(Archivo => Archivo.Contains(archivoBcra)).FirstOrDefault();
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
