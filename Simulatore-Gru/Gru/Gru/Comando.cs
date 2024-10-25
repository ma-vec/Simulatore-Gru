using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gru
{
    internal class Comando
    {
        private Gru gru;

        private string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
        }


    public void alzaGruC()
        {
            gru.alzaGru();
        }

    public void abbassaGruC()
        {

        gru.abbassaGru();
        }

    public void riportoSicurezzaC()
        {
            gru.riportoSicurezza();
        }


    public Comando(string serialNumber, Gru gru)
        {
            this.serialNumber = serialNumber;
            this.gru = gru;
        }
    }
}
