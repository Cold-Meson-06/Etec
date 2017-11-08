//Faça um algoritmo para ler um número inteiro 
//e informar se o número é par ou ímpar. 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h> 

int main() {	

	setlocale(LC_ALL, "portuguese");	
	
	int n = 0;
	
	printf("Digite um número para ver se é par ou ímpar:\n");
	scanf("%i",&n);
	
	if(n % 2 != 0){
		printf("O número é ímpar.\n");
	}else{
		printf("O número é par.\n");
	}
	
	getch();

	return 0;
}
