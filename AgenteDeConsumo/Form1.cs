namespace Agente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Agente_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            var listaProduto = await produto.ObterPodutosAsync();

            dataGridView1.DataSource = listaProduto;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var carro = new Carro();
            var listacarro = await carro.ObterCarroAsync();

            dataGridView2.DataSource = listacarro;


        }
    }
}
