/*
	Desenvolva um programa que permita a entrada de 10 números inteiros em um vetor. 
	Desenvolva uma lógica que coloque o vetor em ordem crescente de números. 
	Apresente o vetor ordenado.
*/
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <conio.h>
#include "utils.cpp"

bool isShorted(int v[], int size){
	for(int i = 0; i < size; i++){
		if(i < size-1 && v[i] > v[i + 1]){
			return false;
		}
	}
	return true;
}

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int vecLen = 10, vec[vecLen], buffer = 0;
	
	fillVector(vec, vecLen);
	
	while(true){
	
		if(isShorted(vec, vecLen)){
			break;
		}
	
		for(int i = 0; i < vecLen; i++){
			if(i < vecLen-1 && vec[i] != vec[i + 1] && vec[i] > vec[i + 1]){
				buffer = vec[i];
				vec[i] = vec[i + 1];
				vec[i + 1] = buffer;
			}
		}	

	}
	
	visualizeVector("Resultado: ", vec, vecLen);

	getch();

	return 0;
}
