using System;

namespace Gru
{
    internal class Gru
    {
        private string serialNumber;
        public string SerialNumber
        {
            get { return serialNumber; }
        }
        private string produttore;
        public string Produttore
        {
            get { return produttore; }
        }
        private int pesoMaxNominale;
        public int PesoMaxNominale
        {
            get { return pesoMaxNominale; }
        }
        private int altezzaMaxNominale;
        public int AltezzaMaxNominale
        {
            get { return altezzaMaxNominale; }
        }
        private int altezzaMinNominale;
        public int AltezzaMinNominale
        {
            get { return altezzaMinNominale; }
        }
        private int altezzaAttuale;
        public int AltezzaAttuale
        {
            get { return altezzaAttuale; }
        }

        public void alzaGru()
        {
            altezzaAttuale += 20;
        }
        public void abbassaGru()
        {
            altezzaAttuale -= 20;
        }
        public void riportoSicurezza()
        {
            //posizione reset
        }

        public Gru(string serialNumber, string produttore, int pesoMaxNominale, int altezzaMinNominale, int altezzaMaxNominale)
        {
            this.serialNumber = serialNumber;
            this.produttore = produttore;
            this.pesoMaxNominale = pesoMaxNominale;
            this.altezzaMinNominale = altezzaMinNominale;
            this.altezzaMaxNominale = altezzaMaxNominale;
            this.altezzaAttuale = altezzaMinNominale;
        }
    }
}

