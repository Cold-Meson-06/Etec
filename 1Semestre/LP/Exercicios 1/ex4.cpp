//Default imports
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

//Para não repetir printf("Pressione qualquer tecla para continuar.\n")
// varias vezes.
void message(){
	printf("Pressione qualquer tecla para continuar.\n");
}

//C++ te permite definir funções.

//As funções podem ser definidas direto...
void soma(){
	
	int n1 = 0, n2 = 0;
	
	printf("Este programa soma dois números.\nInsira o primeiro número :\n");
	scanf("%i",&n1);
	
	printf("Insira o segundo número\n");
	scanf("%i",&n2);
	
	printf("A soma dos números é :%i\n",(n1 + n2));
	
	message();
	
	getch();
};

void media() {	
	
	float n1=0,n2=0,n3=0,n4=0;
	
	printf("Este programa tira a média do aluno.\nDigite a primeira nota:\n");
	scanf("%f",&n1);
	
	printf("digite a segunda nota:\n");
	scanf("%f",&n2);
	
	printf("digite a terceira nota:\n");
	scanf("%f",&n3);
	
	printf("digite a quarta nota:\n");
	scanf("%f",&n4);
	
	printf("A media do aluno é : %f\n",((n1 + n2 + n3 + n4) / 4));
	
	message();
	
	getch();
}

//...Ou só o prototipo

void estoque()

void financiamento()

//O corpo das funções acima será definido após o main

void reload(){
  
    printf("Selecione o programa\n<1> = Soma dois números;\n<2> = média do aluno;\n<3> = media do estoque;\n<4> = calculo do financiamento;\n<5> = sair;\n");
	
	int select = 0;
	
	scanf("%i",&select);
	
	//O switch recebe uma variavel e testa ela
	//contra varios valores.
	//O fluxo de execução e desviado para o case correspondente.
	switch (select) {
		
		case 1:	
			soma();
			reload();
		break;
		
		case 2:
			media();
			reload();
		break;
		
		case 3:
			estoque();
			reload();
		break;
		
		case 4:
			financiamento();
			reload();
		break;
		
		case 5:
			printf("Terminado.");
		break;

		//Se nenhum dos falores especificados funcionar
		//o default é usado.
		default:
			printf(" Por favor selecione um numero entre 1 e 5");
			getch();
			reload();
		break;
	}
}


int main(){	
	
	setlocale(LC_ALL,"portuguese");
	
	reload();

	return 0;
}


void estoque(){	

	float vQtdMin=0.0, vQtdMax=0.0;

	printf("Este programa tira a media do estoque de uma peça.\nDigite a quantidade minima:\n");
	scanf("%f",&vQtdMin);

	printf("digite a quantidade máxima:\n");
	scanf("%f",&vQtdMax);

	printf("A media em estoque é : %f\n",((vQtdMin + vQtdMax ) / 2));

	message();

	getch();

}

void financiamento(){	
	
	float vValor=0.0;
	int vParcelas =0;
	
	printf("Este programa calcula o valor de cada parcela e o acrésimo em um financiamento.\nDigite a quantidade de parcelas:\n");
	scanf("%i",&vParcelas);
	
	printf("digite o valor do financiamento:\n");
	scanf("%f",&vValor);
	
	float vAcresimo = (vValor * 15) / 100;
	float vValorParcela = vValor / vParcelas;
	
	printf("O valor de cada parcela é :%f.2",vValorParcela); 
	printf("\nE o acrésimo foi de :%f.2",vAcresimo);
	
	message();
	
	getch();

}