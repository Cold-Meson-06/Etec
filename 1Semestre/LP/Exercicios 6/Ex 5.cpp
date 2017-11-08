//Faça um algoritmo que calcule a soma dos primeiros 50 números pares.
//Este algoritmo não recebe valor do teclado.. 
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	
	setlocale(LC_ALL, "portuguese");
	
	int soma = 0;
	
	for(int i = 0; i < 50; i+=2){
		soma += i;
	}
	
	printf("A soma dos 50 primeiros pares é : %i", soma);
	getch();

	return 0;
}
