//Faça um algoritmo para ler três números positivos
//e imprima-os em ordem crescente. 
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {

	setlocale(LC_ALL, "portuguese");
	
	int temp = 0;
	int n1 = 0, n2 = 0, n3 = 0;

	printf("Este Algoritimo organiza os números em forma crescente.\n");
	printf("Digite o primeiro número:\n");
	scanf("%i",&n1);
	
	printf("Digite o segundo número:\n");
	scanf("%i",&n2);
	
	//PuloDoGato: Organizar os números enquanto eles estão entrando.

	if(n1 > n2){
		temp = n1;
		n1 = n2;
		n2 = temp;
	}
	
	printf("Digite o terceiro número:\n");
	scanf("%i",&n3);
	
	if(n2 > n3){
		temp = n2;
		n2 = n3;
		n3 = temp;
	}
	
	if(n1 > n2){
		temp = n1;
		n1 = n2;
		n2 = temp;
	}
	
	printf("\n%i",n1);
	printf("\n%i",n2);
	printf("\n%i",n3);
	
	getch();

	return 0;
}
