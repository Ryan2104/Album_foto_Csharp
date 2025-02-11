using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_telas
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\7.jpg");
        }

        private void btn_primeira_Click(object sender, EventArgs e)
        {
            Form principal = Application.OpenForms["Form1"];
            principal.Show();
            this.Dispose();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
