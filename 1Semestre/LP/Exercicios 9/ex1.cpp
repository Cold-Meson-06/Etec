/*
	Desenvolva um programa que permita a entrada de 25 números inteiros 
	em uma matriz 5X5. Crie uma rotina que realize a somatória de cada 
	uma das linhas da matriz e uma somatória de cada uma das colunas. 
	Apresente as somatórias ao final.
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
	int totalColuna = 0;
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&mat[x][y]);
		}
	}
	
	for(int x = 0; x < c; x++){
		totalColuna = 0;
		for(int y = 0; y < c; y++){
			totalColuna += mat[x][y];
		}
		printf("O total da coluna %i é %i\n", x, totalColuna);
	}	
	
	getch();
	
	return 0;
}
