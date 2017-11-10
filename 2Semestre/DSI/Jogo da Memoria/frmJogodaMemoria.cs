using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogodaMemoria
{
    public partial class frmJogodaMemoria : Form
    {
        Boolean jogada1;
        int clickjogada1,placar,acertos;
        String ImagemJogada1;

        public frmJogodaMemoria()
        {
            InitializeComponent();
            jogada1 = false;
            placar = 0;
            acertos = 0;
            sorteia();
        }

        private void analisaJogada(int pic, String Imagem)
        {
            //Exibe a Imagem
            if (pic == 1)
            {
                picImg1.Image = retornaImagem(Imagem);
                picImg1.Refresh();
            }else
            if (pic == 2)
            {
                picImg2.Image = retornaImagem(Imagem);
                picImg2.Refresh();
            }
            else
            if (pic == 3)
            {
                picImg3.Image = retornaImagem(Imagem);
                picImg3.Refresh();
            }
            else
            if (pic == 4)
            {
                picImg4.Image = retornaImagem(Imagem);
                picImg4.Refresh();
            }
            else
            if (pic == 5)
            {
                picImg5.Image = retornaImagem(Imagem);
                picImg5.Refresh();
            }
            else
            if (pic == 6)
            {
                picImg6.Image = retornaImagem(Imagem);
                picImg6.Refresh();
            }
            else
            if (pic == 7)
            {
                picImg7.Image = retornaImagem(Imagem);
                picImg7.Refresh();
            }
            else
            if (pic == 8)
            {
                picImg8.Image = retornaImagem(Imagem);
                picImg8.Refresh();
            }
            else
            if (pic == 9)
            {
                picImg9.Image = retornaImagem(Imagem);
                picImg9.Refresh();
            }
            else
            if (pic == 10)
            {
                picImg10.Image = retornaImagem(Imagem);
                picImg10.Refresh();
            }

            //Verifica se é a primeira Jogada
            if (jogada1==false)
            {
                jogada1 = true;
                clickjogada1 = pic;
                ImagemJogada1 = Imagem;
            }
            else
            {
                //Verifica se não clicou 2 vezes na mesma imagem
                if (pic == clickjogada1)
                {
                    MessageBox.Show("Clique em uma carta diferente !");
                }
                else
                {
                    //Temporiza para exibir a segunda imagem
                    System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(500));
                    //Verifica se houve acerto
                    if (ImagemJogada1.Equals(Imagem))
                    {
                        bloqueia(clickjogada1, pic);
                        placar++;
                        acertos++;
                        jogada1 = false;
                        if (acertos==5)
                        {
                            MessageBox.Show("Parabéns !");
                        }
                    }
                    else
                    {
                        viraCarta(clickjogada1, pic);
                        placar--;
                        jogada1 = false;
                    }
                }
            }
        }

        private void bloqueia(int pic1,int pic2)
        {
            if (pic1==1 || pic2 == 1)
                picImg1.Enabled = false;
            if (pic1 == 2 || pic2 == 2)
                picImg2.Enabled = false;
            if (pic1 == 3 || pic2 == 3)
                picImg3.Enabled = false;
            if (pic1 == 4 || pic2 == 4)
                picImg4.Enabled = false;
            if (pic1 == 5 || pic2 == 5)
                picImg5.Enabled = false;
            if (pic1 == 6 || pic2 == 6)
                picImg6.Enabled = false;
            if (pic1 == 7 || pic2 == 7)
                picImg7.Enabled = false;
            if (pic1 == 8 || pic2 == 8)
                picImg8.Enabled = false;
            if (pic1 == 9 || pic2 == 9)
                picImg9.Enabled = false;
            if (pic1 == 10 || pic2 == 10)
                picImg10.Enabled = false;
        }

        private void viraCarta(int pic1, int pic2)
        {
            if (pic1 == 1 || pic2 == 1)
                picImg1.Image = Properties.Resources.Capa;
            if (pic1 == 2 || pic2 == 2)
                picImg2.Image = Properties.Resources.Capa;
            if (pic1 == 3 || pic2 == 3)
                picImg3.Image = Properties.Resources.Capa;
            if (pic1 == 4 || pic2 == 4)
                picImg4.Image = Properties.Resources.Capa;
            if (pic1 == 5 || pic2 == 5)
                picImg5.Image = Properties.Resources.Capa;
            if (pic1 == 6 || pic2 == 6)
                picImg6.Image = Properties.Resources.Capa;
            if (pic1 == 7 || pic2 == 7)
                picImg7.Image = Properties.Resources.Capa;
            if (pic1 == 8 || pic2 == 8)
                picImg8.Image = Properties.Resources.Capa;
            if (pic1 == 9 || pic2 == 9)
                picImg9.Image = Properties.Resources.Capa;
            if (pic1 == 10 || pic2 == 10)
                picImg10.Image = Properties.Resources.Capa;
        }

        private System.Drawing.Image retornaImagem(String Imagem)
        {
            System.Drawing.Image retorno;
            if (Imagem.Equals("ReideCopas.jpg"))
                retorno = Properties.Resources.ReideCopas;
            else if (Imagem.Equals("ReidePaus.jpg"))
                retorno = Properties.Resources.ReidePaus;
            else if (Imagem.Equals("ReideOuros.jpg"))
                retorno = Properties.Resources.ReideOuros;
            else if (Imagem.Equals("uno.jpg"))
                retorno = Properties.Resources.uno;
            else
                retorno = Properties.Resources.ReideEspadas;
            return retorno;
        }
        private void picImg1_Click(object sender, EventArgs e)
        {
            analisaJogada(1, picImg1.Tag.ToString());
        }

        private void picImg2_Click(object sender, EventArgs e)
        {
            analisaJogada(2, picImg2.Tag.ToString());
        }

        private void picImg3_Click(object sender, EventArgs e)
        {
            analisaJogada(3, picImg3.Tag.ToString());
        }

        private void picImg4_Click(object sender, EventArgs e)
        {
            analisaJogada(4, picImg4.Tag.ToString());
        }

        private void picImg5_Click(object sender, EventArgs e)
        {
            analisaJogada(5, picImg5.Tag.ToString());
        }

        private void picImg6_Click(object sender, EventArgs e)
        {
            analisaJogada(6, picImg6.Tag.ToString());
        }

        private void picImg7_Click(object sender, EventArgs e)
        {
            analisaJogada(7, picImg7.Tag.ToString());
        }

        private void picImg8_Click(object sender, EventArgs e)
        {
            analisaJogada(8, picImg8.Tag.ToString());
        }

        private void picImg9_Click(object sender, EventArgs e)
        {
            analisaJogada(9, picImg9.Tag.ToString());
        }

        private void picImg10_Click(object sender, EventArgs e)
        {
            analisaJogada(10, picImg10.Tag.ToString());
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            sorteia();
            jogada1 = false;
            placar = 0;
            acertos = 0;
            //Habilita PictureBox para clicke
            picImg1.Enabled = true;
            picImg2.Enabled = true;
            picImg3.Enabled = true;
            picImg4.Enabled = true;
            picImg5.Enabled = true;
            picImg6.Enabled = true;
            picImg7.Enabled = true;
            picImg8.Enabled = true;
            picImg9.Enabled = true;
            picImg10.Enabled = true;

            //Vira as cartas
            picImg1.Image = Properties.Resources.Capa;
            picImg2.Image = Properties.Resources.Capa;
            picImg3.Image = Properties.Resources.Capa;
            picImg4.Image = Properties.Resources.Capa;
            picImg5.Image = Properties.Resources.Capa;
            picImg6.Image = Properties.Resources.Capa;
            picImg7.Image = Properties.Resources.Capa;
            picImg8.Image = Properties.Resources.Capa;
            picImg9.Image = Properties.Resources.Capa;
            picImg10.Image = Properties.Resources.Capa;

        }

        private void sorteia()
        {
            String[] vetImage = new string[5];
            vetImage[0] = "ReideCopas.jpg";
            vetImage[1] = "ReidePaus.jpg";
            vetImage[2] = "ReideOuros.jpg";
            vetImage[3] = "ReideEspadas.jpg";
            vetImage[4] = "uno.jpg";

            int[] vet = new int[10];
            Random r = new Random();
            String lista = "0011223344";
            int i, contador = 0;
            while (lista.Length > 1)
            {
                i = Convert.ToInt16(lista.Substring(r.Next(1, lista.Length), 1));
                int coorden = lista.IndexOf(i.ToString());
                if (coorden > 0)
                    lista = lista.Substring(0, coorden) + lista.Substring(coorden + 1, lista.Length - coorden - 1);
                else
                    lista = lista.Substring(1, lista.Length - 1);
                vet[contador] = i;
                contador++;
            }
            vet[9] = Convert.ToInt16(lista);

            picImg1.Tag = vetImage[vet[0]];
            picImg2.Tag = vetImage[vet[1]];
            picImg3.Tag = vetImage[vet[2]];
            picImg4.Tag = vetImage[vet[3]];
            picImg5.Tag = vetImage[vet[4]];
            picImg6.Tag = vetImage[vet[5]];
            picImg7.Tag = vetImage[vet[6]];
            picImg8.Tag = vetImage[vet[7]];
            picImg9.Tag = vetImage[vet[8]];
            picImg10.Tag = vetImage[vet[9]];
            

        }
    }
}
