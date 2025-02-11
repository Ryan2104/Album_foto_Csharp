using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;// Biblioteca para acessar arquivos 

namespace multi_telas
{
    public partial class Form1 : Form
    {
        // variáveis globais 
        //função que vai chamar o form2

         public static form2 segunda_tela;
         public static Form3 terceira_tela;
         public static Form4 quarta_tela;
         public static Form5 quinta_tela;
         public static Form6 sexta_tela;
         public static Form7 setima_tela;
         public static Form8 oitava_tela;
         public static Form9 nona_tela;
         public static Form10 decima_tela;
         public static Form11 decimaOnze_tela;


        public Form1()// Contrutor, aqui a tela é criada
        {
            InitializeComponent();// aqui os componentes são criados
        }


        // daqui em diante vem as funções e eventos a se programar 

        private void Form1_Load(object sender, EventArgs e)// função para comandos que irá rodar ao abrir o form
        {
            //Definimos que a imagem de fundo preencherá toda a tela 
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = new Bitmap(Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\index.jpeg");
        }
      
        private void btn_img1_Click(object sender, EventArgs e)
        {
            segunda_tela = new form2();
            segunda_tela.Show();
            this.Hide();
          
       }

        private void btn_img2_Click(object sender, EventArgs e)
        {
            terceira_tela = new Form3();
            terceira_tela.Show();
            this.Hide();
           
        }

        private void btn_img3_Click(object sender, EventArgs e)
        {
            quarta_tela = new Form4();
            quarta_tela.Show();
            this.Hide();
      
        }

        private void btn_img4_Click(object sender, EventArgs e)
        {
            quinta_tela = new Form5();
            quinta_tela.Show();
            this.Hide();
           
        }

        private void btn_img5_Click(object sender, EventArgs e)
        {
            sexta_tela = new Form6();
            sexta_tela.Show();
            this.Hide();
         
        }

        private void btn_img6_Click(object sender, EventArgs e)
        {
            setima_tela = new Form7();
            setima_tela.Show();
            this.Hide();
           
        }

        private void btn_img7_Click(object sender, EventArgs e)
        {
            oitava_tela = new Form8();
            oitava_tela.Show();
            this.Hide();
            
        }

        private void btn_img8_Click(object sender, EventArgs e)
        {
            nona_tela = new Form9();
            nona_tela.Show();
            this.Hide();
           
        }



        private void btn_img9_Click(object sender, EventArgs e)
        {
            decima_tela = new Form10();
            decima_tela.Show();
            this.Hide();
        }

        private void btn_img10_Click(object sender, EventArgs e)
        {
            decimaOnze_tela = new Form11();
            decimaOnze_tela.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
