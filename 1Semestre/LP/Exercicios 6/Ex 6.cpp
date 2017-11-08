//Faça um programa que leia o número de cidades N e,
//para cada uma delas, pergunte o número de nascimentos (NASC) no último ano.
//O programa deve responder o número de nascimentos da cidade onde ocorreu mais nascimentos e também a média
//de nascimentos por cidade. Faça com que o usuário determine o final da repetição.

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int N = 0, NASC=0, maisNascimentos = 0, total = 0, atual = 0, max=0;


	printf("Digite o número de cidades:\n");
	scanf("%i",&max);

	for(int i = 1; i <= max; i++){

		printf("Digite o numero de nascimentos da cidade número %i", i);
		printf("\n");
		
		scanf("%i",&atual);
		total += atual;
		
		maisNascimentos < atual && (maisNascimentos = atual);
	}

	printf("O número de nascimentos da cidade onde ocorreu mais nascimentos é : %i", maisNascimentos);
	printf("\na média de nascimentos por cidade é : %i", (total / max ));
	
	getch();

	return 0;
}
