using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minhaBiblioteca.minhaClasse minhaClasse = new minhaBiblioteca.minhaClasse();
            MessageBox.Show(minhaClasse.texto);
        }
    }
}

namespace minhaBiblioteca
{
    public class minhaClasse
    {
        public string texto = "Mensagem do botão 2";
    }
}

