using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Jogo_numero_sorte
{
    public partial class Form1 : Form
    {
        int sugestao;
        int i;
        int cont;

        public Form1()
        {
            InitializeComponent();
        


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            i = random.Next(0, 6);

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
                       
            while (sugestao!=i) {


                
                sugestao = Convert.ToInt32(textBox2.Text);

                    if (sugestao == i)
                {
                    
                    MessageBox.Show("Parabens vc acertou em "+cont+" tentativas e o número sorteado foi "+i);
                    Application.Exit();
                    
                }
                    else
                {
                    MessageBox.Show("Errou, tente outra vez");
                    
                }

                cont++;
                textBox2.Clear();
                return;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
