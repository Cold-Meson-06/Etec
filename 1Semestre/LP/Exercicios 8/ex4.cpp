/*
	Desenvolva um programa que permita a entrada de 10 números inteiros em um vetor.
	Permita também a entrada de um número inteiro em uma variável. 
	Desenvolva uma lógica que procure esse número no vetor e apresente em 
	que posições ele se encontra no vetor e se não existir no vetor,
	apresente uma mensagem de que o número não se encontra no vetor.
*/

#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	
	setlocale(LC_ALL, "portuguese");

	int vecLen = 10, vec[vecLen], search = 0, foundCount = 0, firstFound = 0;
	bool positions[vecLen];
	
	fillVector(vec, vecLen);
	search = getUserValue();
	
	for(int i = 0; i < vecLen; i++){
		if(vec[i] == search){
			positions[i] = true;		
			foundCount++;
			firstFound = i;
		}
	}
	
	if(!foundCount){
	
		printf("O número não está no vetor.\n");
	
	}else if(foundCount == 1){
	
		printf("O número está apenas na posição %i", firstFound);
	
	}else{
	
		printf("O número se encontra nas posiçães ");
	
		for(int i = 0; i < vecLen; i++){
	
			if(positions[i]){
				if(foundCount > 1){
					foundCount --;
					printf("%i ,", i);	
				}else{
					printf(" e %i.", i);	
				}
			}
	
		}	
	
	}
	
	getch();
	
	return 0;
}
