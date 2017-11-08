//Desenvolva um programa que permita a entrada de 10 números inteiros.
//Faça com que o programa apresente a somatória dos números pares e a somatória dos números ímpares.
//Apresente os totais no final e ainda quantos são pares e quantos são impares.

#include <conio.h>
#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main(){
	
	setlocale(LC_ALL,"portuguese");
	
	int num = 0, pares = 0, impares = 0, countPares = 0, countImpares = 0;
	
	for(int i = 1; i<=10; i++){
	
		printf("Digite um número:\n");
		scanf("%i",&num);
	
		if((num % 2) == 0){
			countPares++;
			pares += num;
		}else{
			countImpares++;
			impares+=num;
		}
	}
	
	printf("\nTotal de pares :%i", pares);
	printf("\nNúmero de pares :%i", countPares);
	printf("\n\nTotal de impares :%i", impares);
	printf("\nNúmero de pares :%i", countImpares);

	getch();

	return 0;
}
