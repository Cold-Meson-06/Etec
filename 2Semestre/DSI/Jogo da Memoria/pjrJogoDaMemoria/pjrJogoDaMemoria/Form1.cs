using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace pjrJogoDaMemoria
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        //Será inicializada com `Controls.OfType<PictureBox>().ToList();`.
        List<PictureBox> Cards = new List<PictureBox>();

        //Será inicializada manualmente.
        List<Image> ImagensDosCards = new List<Image>();

        //Guarda 2x mais imagens que `ImagensDosCards`. (Nota: as `Image`s tem `Tag` com dados importantets)
        List<Image> IDParaImagemEmbaralhada = new List<Image> ();

        //Só é nessesario manter a referencia do primeiro card.
        public PictureBox primeiroCard;

        //Para amarzenar estado.
        public string estadoDaSeleção = "primeiro_click";

        //A imagem padrão
        public Image ImagemPadrao = Properties.Resources._default;

        public Form1()
        {
            InitializeComponent();
            
            //Adicinar as imagens importadas a lista.
            ImagensDosCards.Add(Properties.Resources.___1_);
            ImagensDosCards.Add(Properties.Resources.___2_);
            ImagensDosCards.Add(Properties.Resources.___3_);
            ImagensDosCards.Add(Properties.Resources.___4_);
            ImagensDosCards.Add(Properties.Resources.___5_);
            ImagensDosCards.Add(Properties.Resources.___6_);
            ImagensDosCards.Add(Properties.Resources.___7_);
            ImagensDosCards.Add(Properties.Resources.___8_);
            ImagensDosCards.Add(Properties.Resources.___9_);
            ImagensDosCards.Add(Properties.Resources.___10_);
            ImagensDosCards.Add(Properties.Resources.___11_);
            ImagensDosCards.Add(Properties.Resources.___12_);
            ImagensDosCards.Add(Properties.Resources.___13_);
            

            //Referencia: https://stackoverflow.com/questions/3419159/how-to-get-all-child-controls-of-a-windows-forms-form-of-a-specific-type-button#answer-3419209
            Cards = Controls.OfType<PictureBox>().ToList();

            for (int i = 0; i < Cards.Count; ++i)
            {
                //`Cards` é uma lista contendo todas as `PictureBox` no form.
                PictureBox card = Cards[i];

                //Inicializar as propiedades dos card
                card.Name = i.ToString();   //Dar o nome (sua posição na lista `Cards`).
                card.Tag = "0";              //Dizer que não foi virado ainda.
                card.Image = ImagemPadrao;

                //O Form1.Designer.cs gera este codigo automaticamente (mas não o mesmo para todos os pictureBox, então esse "hack" é nessesario).
                card.Click += new EventHandler(cardClicado);
            }

            //O jogo pode começar.
            Embaralhar();
        }

        //Função a ser usada quando o usuario clicar em um card.
        private void cardClicado(object sender, EventArgs e)
        {

            //Referencia: https://stackoverflow.com/questions/20296837/get-sender-name-event-handler#answer-20296982
            string IndiceDoCardStr = ((PictureBox)sender).Name;
            int IndiceDoCardInt = int.Parse(IndiceDoCardStr);

            //Foi o melhor jeito que achei para saber em qual card estamos clicando.
            PictureBox card = Cards[IndiceDoCardInt];

            //Se estamos no primeiro click:
            if (estadoDaSeleção == "primeiro_click")
            {
                //Esse card já estava virado (Pode até ser o propio `primeiroCard`).
                if ((string)card.Tag == "1")
                {
                    //não faça nada
                    return; //(Eu deveria rancar-lhe um ponto por isso).

                    //Ok esse card não estava virado, vire ele (Não cheque mais nada, ele é o primeiro).
                }
                else
                {
                    estadoDaSeleção = "segundo_click";
                    card.Tag = "1";
                    card.Image = ImagemDoCard(card.Name);
                    primeiroCard = card;
                }
            }

            //Se estamos no segundo click:
            else if (estadoDaSeleção == "segundo_click")
            {

                //Certo ou errado, mostre o card.
                card.Image = ImagemDoCard(card.Name);

                //Os dois cards tem o mesmo nome, logo são o mesmo card
                if (primeiroCard.Name == card.Name)
                {
                    card.Tag = "0";
                    //não faça nada
                    return; //(Novamente eu deveria rancar-lhe um ponto por isso)

                //Ok, os cards são diferentes, mas são do mesmo tipo?
                }
                else if (ImagemDoCard(primeiroCard.Name).Tag == ImagemDoCard(card.Name).Tag)
                {
                    //PONTUAÇÂO ++
                    card.Tag = "1";
                    //Nem são o mesmo card, nem são iguais, logo estão errados
                }
                else
                {
                    //PONTUAÇÂO --
                    card.Tag = "0";
                    primeiroCard.Image = ImagemPadrao;
                    card.Image = ImagemPadrao;
                }
                
                  Thread.Sleep(500);
                //Prepare a proxima jogada
                primeiroCard = null;
                estadoDaSeleção = "primeiro_click";
            }
        }

        //`IDDoCard` Usa os dados do embaralhamento para dar uma string
        //dizendo o id do card, (A imagem que ele tem por baixo, so que em string)
        public string IDDoCard(string nomeDoCard)
        {
            int IndiceDaImagem = int.Parse(nomeDoCard);
            return (string)IDParaImagemEmbaralhada[IndiceDaImagem].Tag;
        }

        //`ImagemDoCard` Usa os dados do embaralhamento para dar a imagem 
        //certa para o card com o nome certo
        public Image ImagemDoCard(string nomeDoCard)
        {
            int IndiceDaImagem = int.Parse(nomeDoCard);
            Console.WriteLine(IndiceDaImagem);
            return IDParaImagemEmbaralhada[IndiceDaImagem];
        }

        //`Embaralhar` Reseta os dados do embaralhamento para criar uma nova seção
        //de jogo
        public void Embaralhar()
        {
            //Pega uma imagem de `ImagensDosCards` e coloca-la em dois lugares em
            //`IDParaImagemEmbaralhada`. assim os IDs dos cards automaticamente 
            //irão mapear para as cartas.

            //Inicializar `IDParaImagemEmbaralhada`;
            for (int i = 0; i < ImagensDosCards.Count; i++)
            {
                IDParaImagemEmbaralhada.Add(null);
            }
            
            //Sem comentarios.
            for (int i = 0; i < ImagensDosCards.Count; i++)
            { 

                //Talvez seja inutil, mas não sei se o C# faz isso por 
                //referencia ou por valor .
                Image image1 = ImagensDosCards[i];
                Image image2 = ImagensDosCards[i];

                image1.Tag = i.ToString();
                image2.Tag = i.ToString();

                int lugar1 = PosicaoAleatoriaNaoUsadaEm(IDParaImagemEmbaralhada);
                IDParaImagemEmbaralhada[lugar1] = image1;

                int lugar2 = PosicaoAleatoriaNaoUsadaEm(IDParaImagemEmbaralhada);
                IDParaImagemEmbaralhada[lugar2] = image2;

            }
        }

        //`PosicaoAleatoriaNaoUsadaEm` retorna uma posição aleatoria não usada .
        public int PosicaoAleatoriaNaoUsadaEm(List<Image> lista)
        {
            int index = 0;
            bool encontrado = false;
            

            //Pode começar a travar quando as posições ficam escaças.
            while (!encontrado)
            {
                int i = random.Next(lista.Count);
                if (lista[i] == null)
                {
                    encontrado = true;
                    index = i;
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                    Console.WriteLine(lista[i].Tag);
                }
            }

            return index;
        }
    }
}
