using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesCLI
{
    public class Numero
    {
        //Atributos
        private int valor;

        //Construtor sem campos.
        public Numero()
        {
            this.valor = 0;
        }

        //Construtor com campos.
        public Numero(int valorInicial)
        {
            this.valor = valorInicial;
        }

        //Gets/Sets
        public void setValor(int novoValor)
        {
            this.valor = novoValor;
        }
        public int getValor()
        {
            return this.valor;
        }

        //Metodos
        public bool ePar()
        {
            return this.valor % 2 == 0;
        }
        public bool ePositivo()
        {
            return this.valor > 0;
        }
        public bool ePrimo()
        {
            //Referencia https://stackoverflow.com/a/39599235
            bool ePrimo = true;

            //Se o valor for diferente de dois (o menor número primo)
            if (this.valor != 2)
            {
                //Se for menor que 2 ou o resto da divisão do valor for zero:
                if (this.valor < 2 || this.valor % 2 == 0)
                {
                    //Ele não é primo (pois ele deveria ser divisivel apenas por 1 e por ele mesmo)
                    ePrimo = false;
                }

                //Testar todas as outras possibilidades
                for (int i = 3; (i * i) <= this.valor; i += 2)
                {
                    //Se o numero for divisivel por qualquer um desses numeros.
                    if (this.valor % i == 0)
                    {
                        //Ele não e primo
                        ePrimo = false;
                    }
                }
            }

            //Lembrando que ele é inicializado com true
            return ePrimo;
        }

        //Dá uma string com todos os divisores
        public string divisores()
        {
            string resultado = "";

            for (int i = 1; i < this.valor; i++)
            {
                //Se valor % i e 0 o número é divisivek
                if (this.valor % i == 0)
                {
                    resultado += i.ToString() + ", ";
                }
            }

            return resultado;
        }
        //TODO: Gera 'StackOverflowExeption's
        public static ulong fatorialRecursivo(ulong n)
        { 
            return n == 0 ? 1 : n * fatorialRecursivo(n - 1);
        }
        //TODO: Não usar recursão
        public ulong fatorial()
        {
            return fatorialRecursivo((ulong)this.valor);
        }
        
        public string emBinario()
        {
            //Variaves 
            int divisor = this.valor;
            string retorno = "";

            //Logica para converter um numero para binario
            while (divisor >= 2)
            {
                retorno = (divisor % 2 == 0 ? "0" : "1") + retorno;
                divisor /= 2;
            }

            return divisor.ToString() + retorno;

        }

        public string emOctal()
        {

            //Variaves 
            int divisor = this.valor;
            string retorno = "";

            //Logica para converter um numero para octal
            while (divisor >= 8)
            {
                retorno = (divisor % 8).ToString() + retorno;
                divisor = divisor / 8;
            }

            return divisor.ToString() + retorno;
   
        }
        public string paraHex(int divisor){

            string retorno = "";
            
            switch (divisor % 16)
            {
                case 15:
                    retorno = "F";
                    break;
                case 14:
                    retorno = "E";
                    break;
                case 13:
                    retorno = "D";
                    break;
                case 12:
                    retorno = "C";
                    break;
                case 11:
                    retorno = "B";
                    break;
                case 10:
                    retorno = "A";
                    break;
                default:
                    retorno = (divisor % 16).ToString(); 
                    break;
            }
            return retorno;
        }

        public string emHexadecimal()
        {
            int divisor = this.valor;
            string retorno = "";

            while (divisor >= 16)
            {
                retorno = paraHex(divisor) + retorno;
                divisor = divisor / 16; 
            }
 
            return paraHex(divisor) + retorno;
        }
        
        public double raizQuadrada()
        {
            return Math.Sqrt(this.valor);
        }
        
        public double aoQuadrado()
        {
            return Math.Pow(this.valor, 2);
        }

        public bool ePerfeito()
        {
            int soma = 0;

            for (int i = 1; i < this.valor; i++)
            {
                if (this.valor % i == 0)
                {
                    soma += i;
                }
            }

            return soma < this.valor;
        }

        public bool Equals(int num)
        {
            return num == this.valor;
        }

        public void print()
        {
            Console.WriteLine("Valor: " + this.valor + "  =====================================");
            
            Console.WriteLine("\tÉ par:         " + this.ePar());
            Console.WriteLine("\tÉ positivo:    " + this.ePositivo());
            Console.WriteLine("\tÉ primo:       " + this.ePrimo());
            Console.WriteLine("\tDivisores:     " + this.divisores());
            Console.WriteLine("\tFatorial:      " + this.fatorial());
            Console.WriteLine("\tEm Binario:    " + this.emBinario());
            Console.WriteLine("\tEm Octal:      " + this.emOctal());
            Console.WriteLine("\tEm Hexadecimal:" + this.emHexadecimal());
            Console.WriteLine("\tRaiz Quadrada: " + this.raizQuadrada());
            Console.WriteLine("\tAo Quadrado:   " + this.aoQuadrado());
            Console.WriteLine("\tÉ perfeito:    " + this.ePerfeito());

            Console.WriteLine("\n");
        }
    }
}






