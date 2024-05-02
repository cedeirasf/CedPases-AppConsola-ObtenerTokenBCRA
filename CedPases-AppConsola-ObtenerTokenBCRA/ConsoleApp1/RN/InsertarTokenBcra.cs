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
            string archivoBcra = m_sesion.ArchivoBcra; 
            string directorioTokenBcra = m_sesion.TokenBcra;

            System.IO.StreamReader fs = new System.IO.StreamReader(Path.Combine(archivoBcra, directorioTokenBcra));

            while (!fs.EndOfStream)
            {
                string linea = fs.ReadLine();
                Console.WriteLine(linea);
                lineaArchivo = linea;
            }
            Console.WriteLine(lineaArchivo);

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
