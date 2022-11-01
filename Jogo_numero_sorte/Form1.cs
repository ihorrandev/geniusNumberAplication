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
        int numeroDigitado;
        int numeroRandomico;
        int count;

        public Form1()
        {
            InitializeComponent();
        


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            Random random = new Random();

            numeroRandomico = random.Next(0, 11);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                while (numeroDigitado != numeroRandomico)
                {

                    numeroDigitado = Convert.ToInt32(textBox2.Text);

                    if (numeroDigitado == numeroRandomico)
                    {

                        MessageBox.Show("Parabens vc acertou em " + count + " tentativas e o número sorteado foi " + numeroRandomico);
                        Application.Exit();

                    }
                    else
                    {
                        MessageBox.Show("Errou, tente outra vez");

                    }

                    count++;
                    textBox2.Clear();
                    return;
                }
            }
            catch {
                DialogResult = MessageBox.Show("Não deixe a textBox em branco, deseja continuar?", "[ALERTA]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            DialogResult = MessageBox.Show("Tem certeza que deseja sair do Genius Number?", "Atenção", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
