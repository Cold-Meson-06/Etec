/*
 *	Desenvolver um programa que permita a entrada de 20 números inteiros.
 *	Crie uma lógica que calcule 
 *  quantos números são maiores ou iguais a 100 e
 *	quantos são menores do que 100. 
 *  Apresente as quantidades e 
 *	a média dos números maiores ou iguais a 100 e 
 *	a média dos números menores do que 100.
 */ 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int valor = 0, maioresQue100Total = 0, maioresQue100Count = 0, menoresQue100Total = 0, menoresQue100Count = 0;

	for(int i = 0; i < 20; i++){
		
		printf("Digite um número :\n");
		scanf("%i",&valor);
		
		if(valor >= 100){
			maioresQue100Total += valor;
			maioresQue100Count ++;
		}else{
			menoresQue100Total += valor;
			menoresQue100Count ++;
		}
	}
	
	float media1 = maioresQue100Total / maioresQue100Count;
	float media2 = menoresQue100Total / menoresQue100Count;
	
	printf("A média dos números maiores ou iguais a 100 é %f", media1);
	printf("A média dos números menores que 100 é %f", media2);
	
	getch();

	return 0;
}
