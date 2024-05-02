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
            string lineaArchivo = "";
            string directorioTokenBcra = m_sesion.TokenBcra;
            string archivoBcra = m_sesion.ArchivoBcra;

            string path = Path.Combine(directorioTokenBcra, archivoBcra);

            Console.WriteLine(path);

            System.IO.StreamReader fs = new System.IO.StreamReader(path);

            while (!fs.EndOfStream)
            {
                string linea = fs.ReadLine();
                Console.WriteLine(linea);
                lineaArchivo = linea;
            }

            fs.Close();
            fs = null;

            return lineaArchivo;
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
