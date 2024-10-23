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


    public void alzaGru()
        {
            gru.alzaGru();
        }

    public void abbassaGru()
        {

        gru.abbassaGru();
        }

    public void riportoSicurezza()
        {
            gru.riportoSicurezza();
        }


    public Comando(string serialNumber)
        {
            this.serialNumber = SerialNumber;
        }
    }
}
