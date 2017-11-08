/*
	Desenvolver um programa que permita a entrada de 25 números inteiros 
	em uma matriz 5X5. Faça uma rotina que apresente todos os números que 
	forem maiores do que 25. Caso não exista números maiores do que 25,
	apresente uma mensagem informando ao usuário.
*/

#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int c = 2;
	int mat[c][c];
	int maior = 0;
	bool found = false;
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&mat[x][y]);
		}
	}
	
	for(int x = 0; x < c; x++){
		for(int y = 0; y < c; y++){
	
			if(mat[x][y] > 25){
				printf("\n%i é maior que 25", mat[x][y]);
				found = true;
			}
	
		}
	}	
	
	if(!found){
		printf("Não ha numeros maiores que 25");
	}
	
	getch();
	
	return 0;
}
