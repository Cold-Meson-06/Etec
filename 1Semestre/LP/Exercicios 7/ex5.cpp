/*
* Permita a entrada de 10 números inteiros em um vetor chamado vet1.
* Permita ainda a entrada de 10 números inteiros em um segundo vetor 
* chamado vet2. Apresente os números que são comuns nos dois vetores.
*/
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int vecLen = 10, vet1[vecLen], vet2[vecLen], comuns = 0;
	
	printf("\nPrimeiro Vetor:");
	for(int i = 0; i < vecLen; i++){
		printf("\nDigite um número: ");
		scanf("%i", &vet1[i]);
	}
	
	printf("\nSegundo Vetor:");
	for(int i = 0; i < vecLen; i++)
	{
		printf("\nDigite um número: ");
		scanf("%i", &vet2[i]);
	}
	
	for(int x = 0; x < vecLen; x++){
		for(int y = 0; y < vecLen; y++){
			vet1[x] == vet2[y] && (comuns++);
		}
	}
	
	printf("%i números são comuns nos dois vetores.", comuns);

	getch();
	
	return 0;
}
