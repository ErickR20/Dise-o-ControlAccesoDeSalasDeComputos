namespace Diseño_ControlAccesoDeSalasDeComputos
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void salasDeComputoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salaDeComputo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salaDeComputoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}