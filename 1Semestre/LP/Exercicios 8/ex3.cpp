/*
	Desenvolver um programa que permita a entrada de 10 Números inteiros 
	em um vetor. Permita ainda a entrada de um Número inteiro em uma variável.
	Desenvolva uma lógica que procure o Número digitado na variável dentro do vetor. 
	Se ele existir no vetor apresente uma mensagem de que o Número está no vetor,
	caso contrário, apresente uma mensagem que informe o usuário de que o Número não está no vetor.
*/
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

int main() {	

	setlocale(LC_ALL, "portuguese");

	int vecLen = 10, vec[vecLen], search = 0, found = false;

	fillVector(vec, vecLen);
	search = getUserValue();

	for(int i = 0; i < vecLen; i++){
		if(vec[i] == search){
			printf("O Número está no vetor.");
			found = true;
			break;
		}
	}

	if(!found){
		printf("Número não encontrado.");
	}

	getch();

	return 0;
}
