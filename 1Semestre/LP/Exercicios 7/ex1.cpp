/*
* Fazer um programa que tem dois vetores do mesmo tamanho (6).
* O usuário fornecerá os dados do primeiro, e depois deverá ser 
* armazenado e exibido o valor do segundo vetor que é o valor 
* do primeiro vetor vezes a posição do elemento do vetor.
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
 
	int l = 6, vec1[l], vec2[l];

	for(int i = 0; i < l; i++){	
		printf("Digite um número: \n");
		scanf("%i", &vec1[i]);
	}

	for(int i = 0; i < l; i++){	
		vec2[i] = vec1[i] * i;
	}

	printf("Os valores do segundo vetor que são o valor do primeiro vetor vezes a posição do elemento do vetor são:\n");

	for(int i = 0; i < l; i++){
		printf("%i, ", vec2[i]);
	}	

	getch();

	return 0;
}

