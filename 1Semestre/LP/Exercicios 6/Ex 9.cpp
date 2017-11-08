/*
 *	Desenvolver um programa que permita 
 *	a entrada de 4 notas de provas para 10 alunos.
 *	Calcule a média de cada aluno.
 *	Apresente 
 *	quantos alunos passaram com nota maior ou igual a sete e 
 *	quantos reprovaram com notas menores do que sete.
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	float total =0, nota=0;
	int reprovados = 0, aprovados=0;
	
	for(int x = 1; x <= 10; x++){
		
		total = 0, nota = 0;

		for(int y = 1; y <= 4; y++){
			printf("Digite a nota %i", y);
			printf(" do aluno %i",x);
			printf("\n");
			scanf("%f",&nota);
			total+=nota;
		}
		
		total / 4 >= 7 ? aprovados ++ : reprovados ++;
	}
	
	printf("\nAlunos que passaram com nota maior ou igual a sete : %i", aprovados);
	printf("\nAlunos que reprovaram com notas menores do que sete : %i",reprovados);

	getch();

	return 0;
}
