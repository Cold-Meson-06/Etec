/*
*	Desenvolver um programa que permita a entrada de 10 números inteiros 
*	em um vetor. Desenvolva uma lógica que faça uma varredura no vetor 
*	e some os números que estão nas posições pares. Apresente o resultado da soma.
*/
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"	//É possivel importar arquivos externos.

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int vecLen = 10, vec[vecLen], emPar = 0;
	
	fillVector(vec, vecLen);
	
	for(int i = 0; i < vecLen; i+=2){
		emPar += vec[i];
	}
	
	printf("O total dos numeros em posições pares é: %i", emPar);

	getch();

	return 0;
}
