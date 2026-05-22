namespace Isaac_Items
{
    public partial class Inicio : Form
    {

        private AplicacionObjetos appObjetos;
        private Configuracion Config;
        private Preferencias Pref;

        public Inicio()
        {
            InitializeComponent();
            appObjetos = new AplicacionObjetos(this);
            Config = new Configuracion();
            Pref = new Preferencias();
        }



        private void configuracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config.ShowDialog();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pref.ShowDialog();
        }

        private void abrirIsaacItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appObjetos.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
