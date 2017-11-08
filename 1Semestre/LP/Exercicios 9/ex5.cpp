/*
	Desenvolver um programa que permita a entrada de 16 números inteiros 
	em uma matriz 4x4. Desenvolva uma lógica que realize a somatória de 
	todos os números que estão nas posções onde as linhas sejam pares 
	e as colunas sejam ímpares. Apresente a somatória no final.
*/
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int c = 3;
	int mat[c][c];
	int total = 0;
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&mat[x][y]);
		}
	}
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
	
			if(x % 2 == 0 &&  y % 2 != 0){
				total += mat[x][y];
			}
	
		}
	}	
	
	printf("Total : %i",total);
	
	getch();

	return 0;
}
