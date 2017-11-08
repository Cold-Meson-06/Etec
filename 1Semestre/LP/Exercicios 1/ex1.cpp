#include <stdio.h>	
#include <conio.h>	
#include <stdlib.h>
#include <locale.h>

//Todo programa c++ deve ter a função main
//que é por onde o programa começa

int main(){	
	
	//SetLocale (penso eu) troca o charset do stdout para suportar uma linguagem.
	setLocale(LC_ALL, "portuguese");

	//Inicializar as variaves.
	float vQtdMin = 0,vQtdMax = 0;

	//Receber os valores do usuario.
	printf("Este programa tira a media do estoque de uma peça.\n digite a quantidade minima:\n");
	scanf("%f", &vQtdMin);	
	//&var significa que em vez de passar uma copia do valor
	//nós iremos enviar o endereço de memoria da variavel
	//logo ela pode ser modficada. 

	printf("digite a quantidade máxima:\n");
	scanf("%f", &vQtdMax);

	//Mostrar o resultado.
	printf("A média em estoque é: %f\n", ((vQtdMin + vQtdMax ) / 2));
	
	//Esperar o usuario pressionar uma tecla.
	getch();

	return 0;
}