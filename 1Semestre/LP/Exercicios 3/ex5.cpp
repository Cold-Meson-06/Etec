//Faça um algoritmo para ler um número inteiro e informar 
//se este é maior que 10, ou se o número é menor ou igual a 10. 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");

	int n = 0;

	printf("Digite um número para ver se é maior que 10:\n");
	scanf("%i",&n);

	if(n == 10){
		printf("O número e igual a 10.\n");
	}else if(n > 10){
		printf("O número e maior que 10.\n");
	}else{
		printf("O número e menor que 10.\n");
	}

	getch();

	return 0;
}
