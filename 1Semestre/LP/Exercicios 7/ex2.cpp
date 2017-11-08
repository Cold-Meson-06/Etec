/*
* Escrever um programa que leia um vetor de 30 elementos inteiros 
* e no final mostre os valores do vetor que são maiores do que 
* a média dos valores digitados.
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main(){	

	setlocale(LC_ALL, "portuguese");
 
 	int vecLen = 30, vec1[vecLen], total = 0, val = 0;

	for(int i = 0; i < vecLen; i++){
		printf("\nDigite um número:  ");
		scanf("%i", &val);
		vec1[i] = val;
		total += val;
	}

	int avg = total / vecLen;

	printf("\nA media é %i", avg);	
	printf("\nOs números do vetor que são maiores do que a média dos valores digitados são:\n");
	
	for(int i = 0; i < vecLen; i++)
	{
		vec1[i] > avg && printf("%i, ",vec1[i]);
	}

	getch();

	return 0;
}
