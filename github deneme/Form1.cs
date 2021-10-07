using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("deneme 2 git hub");          
        }
    }
}
