namespace Word
{
    public partial class ������� : Form
    {
        public �������()
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
            saveFileDialog1.ShowDialog();
            StreamWriter streamWriter = new StreamWriter(richTextBox1.Text);
            streamWriter.Write(richTextBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ���� ���� = new ����();
            ����.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}