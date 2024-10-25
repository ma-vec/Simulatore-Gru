namespace Gru
{
    public partial class Form1 : Form
    {
        Gru gru; // Dichiarazione senza inizializzazione
        Comando radiocomando;

        public Form1()
        {
            InitializeComponent();
            gru = new Gru("01", "test", 500, 571, 191); // Inizializza gru nel costruttore
            radiocomando = new Comando("02", gru); // Passa l'istanza di Gru
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            radiocomando.alzaGruC();
            AggiornaForm();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            radiocomando.abbassaGruC();
            AggiornaForm();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            radiocomando.riportoSicurezzaC();
            AggiornaForm(); // Aggiorna anche dopo il reset
        }

        private void AggiornaForm()
        {
            gancio_img.Top = gru.AltezzaAttuale; // Imposta la posizione Y dell'immagine
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gru.AltezzaAttuale = gru.AltezzaMaxNominale; // Imposta l'altezza iniziale
            AggiornaForm(); // Aggiorna la form all'avvio
        }
    }
}
