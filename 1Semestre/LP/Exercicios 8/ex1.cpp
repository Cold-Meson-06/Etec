/*
* Desenvolver um programa que permita a entrada de 10 números 
* inteiros em um vetor. Faça a varredura desse vetor e apresente 
* a soma dos números e a média dos mesmos.
*/

#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	
	setlocale(LC_ALL, "portuguese");
	
	int vecLen = 10, vec[vecLen], soma = 0, media = 0;
	
	fillVector(vec, vecLen);
	
	for(int i = 0; i < vecLen; i++){
		soma += vec[i];
	}
	
	printf("A média do vetor é: %i\n", soma / vecLen);
	printf("A soma dos números do vetor é %i", soma);

	getch();

	return 0 ;
}
