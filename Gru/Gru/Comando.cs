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


        public void alzaGruC(int deltaH)
        {
            for (int i = 0; i < 2; i++) //permette uno spostamento maggiore ma avendo una precisione al singolo metro
            {
                gru.alzaGru(deltaH);
            }
        }

    public void abbassaGruC(int deltaH)
        {
            for (int i = 0; i < 2; i++)
            {
                gru.abbassaGru(deltaH);
            }
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
