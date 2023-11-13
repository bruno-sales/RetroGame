using RetroGame.Extensions;

namespace RetroGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartValues();
        }

        private void StartValues()
        {
            var numeroDeJogadores = new List<int>() {2, 3, 4, 5, 6, 7, 8};
            cbNumeroJogadores.DataSource = numeroDeJogadores;
            cbNumeroJogadores.SelectedIndex = 2;

            var tipoDeDados = new List<int>() {6, 8, 10};
            cbDado.DataSource = tipoDeDados;
            cbDado.SelectedIndex = 0;

            rbMapaTradicional.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var numeroDeJogadores = (int)cbNumeroJogadores.SelectedValue;
            if (numeroDeJogadores == 0) return;

            foreach (Control control in Controls)
            {
                if (control is PlaceHolderTextBox txt)
                {
                    txt.ReadOnly = true;
                }
            }

            for (var i = 1; i <= numeroDeJogadores; i++)
            {
                var foundTxt = Controls.Find("txtJogador" + i, true);

                if (foundTxt?.Any() == true)
                {
                    if (foundTxt[0] is PlaceHolderTextBox foundPlaceholder)
                    {
                        foundPlaceholder.ReadOnly = false;
                    }
                }
            }
        }
    }
}