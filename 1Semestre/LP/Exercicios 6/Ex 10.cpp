//Permita a entrada de 10 números inteiros,
//apresente o maior e menor deles.

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	
	
	setlocale(LC_ALL, "portuguese");
	
	int maior = 0, menor=0, valor;
	
	for(int i = 0; i < 10; i++){

		printf("Digite um número:\n");
		scanf("%i",&valor);
		
		if(valor > maior){
			maior = valor;	
		}else if(valor < menor){
			menor = valor;
		}
	}

	printf("O maior numero foi : %i", maior);
	printf("O menor numero foi : %i", menor);

	getch();

	return 0;
}
