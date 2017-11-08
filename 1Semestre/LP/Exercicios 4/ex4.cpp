//Desenvolva um programa que permita a entrada de números inteiros e realize a soma 
//dos mesmos até que o usuário digite um número negativo. 
//Quando um número negativo for encontrado, o programa deverá parar de receber 
//números e apresentar a somatória dos números digitados e a média dos números.
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

int main(){
	
	setlocale(LC_ALL,"portuguese");

	int num = 0, count = 0, total = 0, media = 0;

	do {
		count++;
		printf("Digite um número:\n");
		scanf("%i",&num);
		total += num;
	}while(num > 0);
	
	printf("\nTotal de números :%i",total);
	printf("\nMédia de números :%i", (total / count));

	getch();

	return 0;
}
