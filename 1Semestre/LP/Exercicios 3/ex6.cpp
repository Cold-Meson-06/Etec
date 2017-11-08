//Faça um algoritmo para ler o nome, as três notas e o némero de faltas de um aluno 
//e escrever qual a sua situação final: Aprovado, Reprovado por Falta ou Reprovado por Média. 
//A média para aprovação é 7,0 e o limite de faltas é 25% do total de aulas. 
//O número de aulas ministradas no semestre foi de 80. 
//A reprovação por falta sobrepõe a reprovação por Média. 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

float media (float n1, float n2, float n3){
	return (n1 + n2 + n3) / 3;
}

float percent(float current, float max){
	return (current * 100) / max;
}

int main() {	
	
	setlocale(LC_ALL, "portuguese");

	float n1 = 0, n2 = 0, n3 = 0;
	
	int faltas = 0;
	
	const int totalAulas = 80;
	
	printf("Este programa testa se um aluno foi reprovado.\n");
	
	printf("Digite as 3 notas do aluno:\n");
	scanf("%f",&n1);
	scanf("%f",&n2);
	scanf("%f",&n3);	
	
	printf("Digite as faltas do aluno:\n");
	scanf("%i",&faltas);
	
	int diferenca = totalAulas - faltas;
	float percentualFaltas = percent(diferenca , totalAulas);
	
	if(percentualFaltas > 25){
	
		if(media(n1, n2, n3) > 7){
			printf("O aluno está aprovado.\n");
		}else{
			printf("O aluno foi reprovado por media.\n");
		}
	
	}else{
	
		printf("O aluno foi reprovado por falta.\n");
	
	}
	
	getch();

	return 0;
}
