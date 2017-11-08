//Faça um algoritmo que receba 10 idades, pesos e alturas, calcule e mostre: 
//A média das idades das 10 pessoas;
//A quantidade de pessoas com peso superior a 90 quilos e altura inferior a 1.50;
//A porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de 1.90.

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>


int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int idade = 0,totalIdade = 0,pesoAltura = 0,idade1030Altura190 = 0;
	float peso = 0,altura=0;
	
	for(int i = 0; i < 5; i++){

		printf("Digite a sua idade\n");
		scanf("%i", &idade);
		totalIdade += idade;
		
		printf("Digite o seu peso\n");
		scanf("%f", &peso);
		
		printf("Digite a sua altura\n");		
		scanf("%f", &altura);
		
		if(peso > 90 && altura < 1.50){
			pesoAltura ++;
		}
		
		if(idade > 10 && idade < 30 && altura > 1.90){
			idade1030Altura190++;
		}

	}
	
	printf("\nA média das idades das 10 pessoas é : %2f", totalIdade / 10);
	printf("\nA quantidade de pessoas com peso superior a 90 quilos e altura inferior a 1.50 é : %i", pesoAltura);
	printf("\nA porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de 1.90 é : %2f", (10 - idade1030Altura190) * 100);
	
	getch();

	return 0;
}

