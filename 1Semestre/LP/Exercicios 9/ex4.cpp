/*
	Desenvolver um programa que permita a entrada de 16 números inteiros em uma matriz 4x4. 
	Permita ainda a entrada de um número inteiro em uma variável. Desenvolva uma lógica que 
	informe se o número da variável está na matriz ou não. Caso o número esteja na matriz, 
	apresente a posição do mesmo na matriz (Linha e Coluna).
*/

#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "utils.cpp"

int main() {	
	
	setlocale(LC_ALL, "portuguese");
	
	int c = 4;
	int mat[c][c];
	int maior = 0;
	int search = 0;
	bool found = false;
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&mat[x][y]);
		}
	}
	
	search = getUserValue();
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
	
			if(mat[x][y] == search){
				printf("%i está na matrix (x:%i, y: %i)", search, x, y);
				found = true;
				break;
			}
	
		}
	}	
	
	if(!found){
		printf("%i Não esta na matriz", search);
	}
	
	getch();
	
	return 0;
}
