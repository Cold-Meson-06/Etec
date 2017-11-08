/*
	Desenvolver um programa que permita a entrada de 25 números 
	inteiros em uma matriz 5X5. Faça uma rotina que encontre o maior 
	e o menor número existente na matriz. Apresente os números no final.
*/

#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int c = 5;
	int mat[c][c];
	int maior = 0, menor = 0;
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&mat[x][y]);
		}
	}
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
	
			if(mat[x][y] > maior){
				maior = mat[x][y];
			}else if(mat[x][y] < menor){
				menor = mat[x][y];
			}
	
		}
	}	
	
	printf("O maior item é %i\n", maior);
	printf("O menor item é %i\n", menor);
	
	getch();
	
	return 0;
}
