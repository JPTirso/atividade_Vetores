namespace atividade_Vetores
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmQuadrado Quadrado = new FrmQuadrado();
            Quadrado.Show();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTroca troca = new FrmTroca();
            troca.Show();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCubo cubo = new FrmCubo();
            cubo.Show();
        }
    }
}
