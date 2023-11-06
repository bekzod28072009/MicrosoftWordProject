using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word
{
    public partial class Файл : Form
    {
        public Файл()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Главная главная = new Главная();
            главная.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
