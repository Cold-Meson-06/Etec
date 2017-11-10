using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //Foi mal professor 
    //sem musica...

    public partial class Form1 : Form
    {

        //PARTE: 1
        //Será utilizado listas para facilitar a execução 
        public List<string> DadosDosEstados = new List<string>();
        public List<Image> ImagensDasBandeiras = new List<Image>();
        public List<Image> ImagensDasCapitais = new List<Image>();

        //PARTE: 2
        //Mesma logica será usada na segunda parte do exercicio
        public List<PictureBox> ListaDePicBox = new List<PictureBox>();
        public List<Label> ListaDeLabels = new List<Label>();
        public List<string> ListaDeInformacoes = new List<string>();
        public List<Image> ListaDeImagens = new List<Image>();

 
        public Form1()
        {
            InitializeComponent();

            //PARTE: 1
            //Inicializar os dados dos estados (A ordem dos indices conta)
            //O nome do estado ja vem junto com o numero dos habitantes e a capital
            DadosDosEstados.Add("Acre\nPopulação: 600.000 Habitantes\nCapital: Rio Branco");
            DadosDosEstados.Add("Alagoas\nPopulação: 3,322 milhões de Habitantes\nCapital: Maceió");
            DadosDosEstados.Add("Amapá\nPopulação: 751.000 Habitantes\nCapital: Macapá");
            DadosDosEstados.Add("Amazonas\nPopulação: 4,002 milhões de Habitantes\nCapital: Manaus");
            DadosDosEstados.Add("Bahia\nPopulação: 15,2 milhões de Habitantes\nCapital: Salvador");
            DadosDosEstados.Add("Ceará\nPopulação: 8,843 milhões de Habitantes\nCapital: Fortaleza");
            DadosDosEstados.Add("Distrito Federal\nPopulação: 3,013 milhões de Habitantes\nCapital: Brasília");
            DadosDosEstados.Add("Espírito Santo\nPopulação: 3,885 milhões de Habitantes\nCapital: Vitória");
            DadosDosEstados.Add("Goiás\nPopulação: 6,523 milhões Habitantes\nCapital: Goiânia");
            DadosDosEstados.Add("Maranhão\nPopulação: 6,851 milhões Habitantes\nCapital: São Luís");
            DadosDosEstados.Add("Mato Grosso\nPopulação: 3,345 milhões de Habitantes\nCapital: Cuiabá");
            DadosDosEstados.Add("Mato Grosso do Sul\nPopulação: 2,62 milhões de Habitantes\nCapital: Campo Grande");
            DadosDosEstados.Add("Minas Gerais\nPopulação: 20,87 milhões de Habitantes\nCapital: Belo Horizonte");
            DadosDosEstados.Add("Pará\nPopulação: 8,074 milhões de Habitantes\nCapital: Belém");
            DadosDosEstados.Add("Paraíba\nPopulação: 8,074 milhões de Habitantes\nCapital: João Pessoa");
            DadosDosEstados.Add("Paraná\nPopulação: 8,074 milhões de Habitantes\nCapital: Curitiba");
            DadosDosEstados.Add("Pernambuco\nPopulação: 9,278 milhões de Habitantes\nCapital: Recife");
            DadosDosEstados.Add("Piauí\nPopulação: 3,195 milhões de Habitantes\nCapital: Teresina");
            DadosDosEstados.Add("Rio de Janeiro\nPopulação: 16,46 milhões de Habitantes\nCapital: Rio de Janeiro");
            DadosDosEstados.Add("Rio Grande do Norte\nPopulação: 3,409 milhões de Habitantes\nCapital: Natal");
            DadosDosEstados.Add("Rio Grande do Sul\nPopulação: 11,29 milhões de Habitantes\nCapital: Porto Alegre");
            DadosDosEstados.Add("Rondônia\nPopulação: 1,749 milhão de Habitantes\nCapital: Porto Velho");
            DadosDosEstados.Add("Roraima\nPopulação: 496.936 Habitantes\nCapital: Boa Vista");
            DadosDosEstados.Add("Santa Catarina\nPopulação: 6,727 milhões de Habitantes\nCapital: Florianópolis");
            DadosDosEstados.Add("São Paulo\nPopulação: 6,727 milhões de Habitantes\nCapital: São Paulo");
            DadosDosEstados.Add("Sergipe\nPopulação: 2,22 milhões de Habitantes\nCapital: Aracaju");
            DadosDosEstados.Add("Tocantins\nPopulação: 1,497 milhão de Habitantes\nCapital: Palmas");

            //Inicializar as bandeiras dos estados (A ordem dos indices conta)
            ImagensDasBandeiras.Add(Properties.Resources.band__1_);
            ImagensDasBandeiras.Add(Properties.Resources.band__2_);
            ImagensDasBandeiras.Add(Properties.Resources.band__3_);
            ImagensDasBandeiras.Add(Properties.Resources.band__4_);
            ImagensDasBandeiras.Add(Properties.Resources.band__5_);
            ImagensDasBandeiras.Add(Properties.Resources.band__6_);
            ImagensDasBandeiras.Add(Properties.Resources.band__7_);
            ImagensDasBandeiras.Add(Properties.Resources.band__8_);
            ImagensDasBandeiras.Add(Properties.Resources.band__9_);
            ImagensDasBandeiras.Add(Properties.Resources.band__10_);
            ImagensDasBandeiras.Add(Properties.Resources.band__11_);
            ImagensDasBandeiras.Add(Properties.Resources.band__12_);
            ImagensDasBandeiras.Add(Properties.Resources.band__13_);
            ImagensDasBandeiras.Add(Properties.Resources.band__14_);
            ImagensDasBandeiras.Add(Properties.Resources.band__15_);
            ImagensDasBandeiras.Add(Properties.Resources.band__16_);
            ImagensDasBandeiras.Add(Properties.Resources.band__17_);
            ImagensDasBandeiras.Add(Properties.Resources.band__18_);
            ImagensDasBandeiras.Add(Properties.Resources.band__19_);
            ImagensDasBandeiras.Add(Properties.Resources.band__20_);
            ImagensDasBandeiras.Add(Properties.Resources.band__21_);
            ImagensDasBandeiras.Add(Properties.Resources.band__22_);
            ImagensDasBandeiras.Add(Properties.Resources.band__23_);
            ImagensDasBandeiras.Add(Properties.Resources.band__24_);
            ImagensDasBandeiras.Add(Properties.Resources.band__25_);
            ImagensDasBandeiras.Add(Properties.Resources.band__26_);
            ImagensDasBandeiras.Add(Properties.Resources.band__27_);
            
            //Inicializar as imagens das capitais (A ordem dos indices conta)
            ImagensDasCapitais.Add(Properties.Resources.C1);
            ImagensDasCapitais.Add(Properties.Resources.C2);
            ImagensDasCapitais.Add(Properties.Resources.C3);
            ImagensDasCapitais.Add(Properties.Resources.C4);
            ImagensDasCapitais.Add(Properties.Resources.C5);
            ImagensDasCapitais.Add(Properties.Resources.C6);
            ImagensDasCapitais.Add(Properties.Resources.C7);
            ImagensDasCapitais.Add(Properties.Resources.C8);
            ImagensDasCapitais.Add(Properties.Resources.C9);
            ImagensDasCapitais.Add(Properties.Resources.C10);
            ImagensDasCapitais.Add(Properties.Resources.C11);
            ImagensDasCapitais.Add(Properties.Resources.C12);
            ImagensDasCapitais.Add(Properties.Resources.C13);
            ImagensDasCapitais.Add(Properties.Resources.C14);
            ImagensDasCapitais.Add(Properties.Resources.C15);
            ImagensDasCapitais.Add(Properties.Resources.C16);
            ImagensDasCapitais.Add(Properties.Resources.C17);
            ImagensDasCapitais.Add(Properties.Resources.C18);
            ImagensDasCapitais.Add(Properties.Resources.C19);
            ImagensDasCapitais.Add(Properties.Resources.C20);
            ImagensDasCapitais.Add(Properties.Resources.C21);
            ImagensDasCapitais.Add(Properties.Resources.C22);
            ImagensDasCapitais.Add(Properties.Resources.C23);
            ImagensDasCapitais.Add(Properties.Resources.C24);
            ImagensDasCapitais.Add(Properties.Resources.C25);
            ImagensDasCapitais.Add(Properties.Resources.C26);
            ImagensDasCapitais.Add(Properties.Resources.C27);

            //PARTE: 2 
            //Inicializar a lista de PictureBox (apenas 3 itens)
            ListaDePicBox.Add(picLeite);
            ListaDePicBox.Add(picOvos);
            ListaDePicBox.Add(picFarinha);
            
            //Inicializar a lista de Label
            ListaDeLabels.Add(lbl_leite);
            ListaDeLabels.Add(lbl_ovos);
            ListaDeLabels.Add(lbl_farinha);
            
            //Inicializar a lista de string
            ListaDeInformacoes.Add("Calorias: 42\nNome Inglês: Milk\n\n" + "Ingredientes\n1 caixa de leite\n1 e 1 / 2 caixinha(350 g) de morangos limpos\n1 / 2 colher(de sopa) de açúcar\n1 / 2 xícara(de café) de água\nsuco de 1 limão\n\nModo de Preparo\nNo liquidificador bata os morangos, o açúcar, a água e o suco de limão\nLeve ao freezer para endurecer\nRetire os copos de dentro\nAcrescente o recheio de leite condensado e leve ao freezer de novo\nCom o recheio mais duro, coloque o palito, cubra com o restante da base do sorvete e leve ao freezer para endurecer\nPara retirar do copo, basta quebrar uma ponta dele na parte de cima e retirar por completo\n");
            ListaDeInformacoes.Add("Calorias: 155\nNome Inglês: Egg\n\n" + "Ingredientes\n2 ovos\n1 pitada de sal\n1 fatia de presunto\n2 fatias de queijo\ntempero verde a gosto\ncaldo de galinha a gosto\n\nModo de Preparo\nBata os 2 ovos, pode ser na batedeira ou não\nApós ter batido bem, coloque-o na frigideira já untada com óleo, acrescente o sal, o presunto picado em quadradinhos e as duas fatias de queijo (não precisa picar o queijo)\nColoque os temperos a gosto, espere ficar firme, e vire o omelete\nEstá pronto um omelete delicioso, bom apetite!");
            ListaDeInformacoes.Add("Calorias: 83\nNome Inglês: Flour\n\n" + "Ingredientes:\n6 ovos\n6 colheres de chocolate em pó nestlé\n1 xícara de chá de água\n1 xícara de chá de açúcar\n1 e 1/2 xícaras de chá de farinha\n1 colher de sobremesa de fermentoRoyal\n\nModo De Preparo:\nBata os ovos inteiros na batedeira com a água por 5 minutos\nSem parar de bater acrescente o açúcar e a farinha, em seguida o chocolate\nPor último o fermento, bata só para misturar\nAsse em forma retangular grande, untada e enfarinhada, em forno médio, pré-aquecido, por aproximadamente 40 minutos, ou até dourar\nFaça mais uma massa\n");
            
            //Inicializar a lista de Imagens
            ListaDeImagens.Add(Properties.Resources.Bolo);
            ListaDeImagens.Add(Properties.Resources.Omelete);
            ListaDeImagens.Add(Properties.Resources.Sorvete);
        }

        //PARTE: 2
        //Autaliza os estados das imagens e labels
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Para cada item da lista `listIngredientes`
            for (int i = 0; i < listIngredientes.Items.Count; i++)
            {
                //Se estiver selecionada...
                if (listIngredientes.GetSelected(i))
                {
                    //Exiba as informações nessesarias
                    ListaDePicBox[i].Image = ListaDeImagens[i];
                    ListaDeLabels[i].Text = ListaDeInformacoes[i];
                }
                else//Senão
                {
                    //Deixe-as em branco
                    ListaDePicBox[i].Image = null;
                    ListaDeLabels[i].Text = "";
                }
            }
        }

        private void cmbListaDeEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A ideia:
            //Organizar os estados em ordem alfabetica na lista

            //E todos os recursos nas Listas suas posições são 
            //correspondentes a um estado

            //Exemplo:
            //Se pegarmos o indice 0 de todas as listas, a informação (imagem ou texto)
            //sempre será correspondente ao Acre.

            int indiceDoEstadoSelecionado = cmbListaDeEstados.SelectedIndex;
            
            picBandeira.Image = ImagensDasBandeiras[indiceDoEstadoSelecionado];
            picImgCapital.Image = ImagensDasCapitais[indiceDoEstadoSelecionado];
            lblDadosDoEstado.Text = DadosDosEstados[indiceDoEstadoSelecionado];

        }
    }
}
