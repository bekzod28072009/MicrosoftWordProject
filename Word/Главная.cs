namespace Word
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {



            openFileDialog1.ShowDialog();
            string res = openFileDialog1.FileName;
            StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
            richTextBox1.Text = streamReader.ReadToEnd();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(richTextBox1.Text);
            saveFileDialog1.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Файл файл = new Файл();
            файл.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Главная главная = new Главная();
            главная.Size = new Size(5803, 4050);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Главная главная = new Главная();
            главная.Hide();
        }
    }
}