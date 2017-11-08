//Faça um algoritmo que receba 10 números,
//calcule e mostre a quantidade de números entre 30 e 90.

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	
	
	setlocale(LC_ALL, "portuguese");
	
	float num = 0;
	int total = 0;
	
	for(int i = 0; i < 10; i++){
	
		printf("Digite um número:\n");
		scanf("%f",& num);
		
		if(num > 30 && num < 90 ){
			total++;
		}

	}
	
	printf("\nA quantidade de números entre 30 e 90 é : %i", total);
	
	getch();

	return 0;
}
