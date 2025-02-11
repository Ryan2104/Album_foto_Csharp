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
    public partial class form2 : Form
    {
        
       

        public form2()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Path.GetDirectoryName(Application.ExecutablePath) + @"\imagem\2.jpg");
        }

        private void btn_primeira_Click(object sender, EventArgs e)
        {

            // descobrir o form principal, exibir e sair do form2
            Form principal = Application.OpenForms["Form1"];
            principal.Show();
            // o comando Dispose fecha e remove da memória o Form2 
            this.Dispose();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
         
        }
    }
}
