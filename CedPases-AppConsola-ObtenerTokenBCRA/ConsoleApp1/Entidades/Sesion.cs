using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CedPases_ObtenerTokenBCRA.Entidades
{
    [Serializable]
    public class Sesion
    {
        private string ambiente;
        private string tokenBcra;
        private string cnnStr;
        private string archivoBcra;

        public Sesion()
        {
        }

        public string Ambiente
        {
            get
            {
                return ambiente;
            }
            set
            {
                ambiente = value;
            }
        }
        public string TokenBcra
        {
            get
            {
                return tokenBcra;
            }
            set
            {
                tokenBcra = value;
            }
        }
        public string CnnStr
        {
            get
            {
                return cnnStr;
            }
            set
            {
                cnnStr = value;
            }
        }
        public string ArchivoBcra
        {
            get
            {
                return archivoBcra;
            }
            set
            {
                archivoBcra = value;
            }
        }
    }
}
