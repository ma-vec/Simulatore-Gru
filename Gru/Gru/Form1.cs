namespace Gru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Gru gru1 = new Gru("01", "test", 500, 0, 30);
            Comando radiocomando = new Comando("02");
            InitializeComponent();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
