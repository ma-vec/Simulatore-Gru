using System;
using System.Security;

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
            set { altezzaMaxNominale = value; } //necessario per set dell'utente
        }
        private int altezzaMinNominale;
        public int AltezzaMinNominale
        {
            get { return altezzaMinNominale; }
            set { altezzaMinNominale = value; }
        }
        private int altezzaAttuale;
        public int AltezzaAttuale
        {
            get { return altezzaAttuale; }
            set { altezzaAttuale = value; }
        }

        private int altezzaMetri;
        public int AltezzaMetri
        {
            get { return altezzaMetri; }
            set { altezzaMetri = value; }
        }

        private int altezzaMaxPossibile;
        public int AltezzaMaxPossibile
        {
            get { return altezzaMaxPossibile; }
        }

        public void alzaGru(int deltaH)
        {
            if (altezzaAttuale > altezzaMaxNominale)
            {
                altezzaAttuale -= deltaH;
            }
        }
        public void abbassaGru(int deltaH)
        {
            if(altezzaAttuale < altezzaMinNominale)
                altezzaAttuale += deltaH;
        }
        public void riportoSicurezza()
        {
            altezzaAttuale = altezzaMinNominale;
        }

        public double ConversioneMetri(int AltezzaRifpx)
        {
            return Math.Abs((AltezzaRifpx - 571) * 0.1);
        }

        public int Conversionepx (double AltezzaRifm)
        {
            return (int)(Math.Abs((AltezzaRifm - (571 * 0.1)) / 0.1));
        }

        public Gru(string serialNumber, string produttore, int pesoMaxNominale)
        {
            this.serialNumber = serialNumber;
            this.produttore = produttore;
            this.pesoMaxNominale = pesoMaxNominale;
            this.altezzaAttuale = altezzaMaxNominale;
        }
    }
}

