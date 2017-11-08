/*
	Desenvolva um programa que permita a entrada de 25 números inteiros 
	em uma matriz 5 x5. Crie uma lógica que calcule a soma dos números 
	que estão nas colunas impares da matriz. Apresente a somatória.
*/
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	

	setlocale(LC_ALL, "portuguese");

	int c = 5, total = 0;
	int mat[c][c];
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&mat[x][y]);
		}
	}
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			if(y % 2 != 0){
				total += mat[x][y];
			}
		}
	}
	
	printf("A soma dos itens cuja coluna é impar é: %i", total);

	getch();

	return 0;
}
