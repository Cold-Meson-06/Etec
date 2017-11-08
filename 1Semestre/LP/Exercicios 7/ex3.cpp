/*Escrever um programa que declare um vetor de 20 inteiros, 
* leia um valor para cada posição e no final mostre quantos elementos 
* possuem valor maior, menor e igual ao primeiro elemento do vetor.
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
#include "utils.cpp"

int main() {	
	setlocale(LC_ALL, "portuguese");
	
	int vecLen = 20, vec[vecLen], val = 0, gT = 0, lT = 0, eT = 0;

	for(int i = 0; i < vecLen; i++){
		printf("\nDigite um número:  ");
		scanf("%i",&val);
		vec[i] = val;
	}
	
	int first = vec[0];
	
	for(int i = 0; i < vecLen; i++){
		vec[i] > first ? gT++ :
		vec[i] < first ? lT++ :
		vec[i] == first && eT++; 
	}
	
	printf("\nO número de elementos iguais a %i é %i", first, eT);
	printf("\nO número de elementos maiores que %i são %i", first, gT);
	printf("\nO número de elementos menores que %i são %i", first, lT);
	
	visualizeVector("\nVec: ", vec, vecLen);
	
	gecht();

	return 0;
}
