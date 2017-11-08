//Faça um algoritmo que receba a idade e o sexo de 12 pessoas, calcule e mostre:
//A idade média do grupo;
//A idade média das mulheres; 
//A idade média dos homens. 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	float idadeF = 0, totalF = 0, idadeM = 0, totalM = 0, total = 0, idadeMediaT = 0;
	int idade = 0;
	
	for(int i = 0; i < 12; i++){
	
		printf("Digite sua idade:\n");
		scanf("%i", &idade);
		total += idade;
		
		printf("Você é de qual sexo? 1: feminino, 2: masculino\n");
		int sexo = 0;
		scanf("%i",& sexo);
		
		if(sexo == 1){
			idadeF += idade;
			totalF++;
		}else if(sexo == 2){
			idadeM += idade;
			totalM++;
		}else{
			printf("Digite ou 1 ou 2!\n");
			i--;
		}

	}
	
	printf("\nA idade média do grupo é : %f2", total / 10);
	printf("\nA idade média das mulheres é : %f2", idadeF / totalF);
	printf("\nA idade média dos homens é : %f2", idadeM / totalM);
	
	getch();

	return 0;
}
