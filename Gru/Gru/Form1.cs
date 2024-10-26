namespace Gru
{
    public partial class Form1 : Form
    {
        Gru gru;
        Comando radiocomando;
        const int deltaAltezza = 10; //differenza nuova altezza in px
        int altezzaMetri;

        public Form1()
        {
            InitializeComponent();
            gru = new Gru("01", "Il boss delle gru", 1000);
            radiocomando = new Comando("02", gru);
            gru.AltezzaMinNominale = 571;
            gru.AltezzaMaxNominale = 191;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            radiocomando.alzaGruC(deltaAltezza);
            AggiornaForm();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            radiocomando.abbassaGruC(deltaAltezza);
            AggiornaForm();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            radiocomando.riportoSicurezzaC();
            AggiornaForm();
        }

        private void AggiornaForm()
        {
            gancio_img.Top = gru.AltezzaAttuale; // Imposta la posizione Y dell'immagine
            label_Hgancio.Text = gru.ConversioneMetri(gru.AltezzaAttuale).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gru.AltezzaAttuale = gru.AltezzaMaxNominale; // Imposta l'altezza iniziale
            textBoxHMax.Text = gru.ConversioneMetri(gru.AltezzaMaxNominale).ToString();
            textBoxHMin.Text = gru.ConversioneMetri(gru.AltezzaMinNominale).ToString();

            AggiornaForm();
        }

        private void buttonApplica_Click(object sender, EventArgs e)
        {
            int mHmax;
            if (int.TryParse(textBoxHMax.Text, out mHmax) && mHmax<=38)
            {
                gru.AltezzaMaxNominale = gru.Conversionepx(mHmax);
            }
            else
            {
                MessageBox.Show("Inserisci un'altezza minore di 38 m.", "Altezza max errata");
            }

            int mHmin;
            if (int.TryParse(textBoxHMin.Text, out mHmin) && mHmin >= 0)
            {
                gru.AltezzaMinNominale = gru.Conversionepx(mHmin);
            }
            else
            {
                MessageBox.Show("Inserisci un'altezza maggiore di 0 m.", "Altezza minima errata");
            }
        }
    }
}
