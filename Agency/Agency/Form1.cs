namespace Agency
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

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диана Костромина", "Автор");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 qqe = new Form2();
            this.Hide();
            qqe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 qqe = new Form3();
            this.Hide();
            qqe.ShowDialog();
        }
    }
}