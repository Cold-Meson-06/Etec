//Desenvolva um programa que permita a entrada de 10 números inteiros.
//Crie uma rotina que calcule a média dos números maiores do que 10, 
//menores do que 10 e iguais a 10. Apresente as  médias calculadas.

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

int main(){

	setlocale(LC_ALL,"portuguese");
	
	int maiorQue10Total = 0;
	int maiorQue10Count = 0;
	int iguaisA10Total = 0;
	int iguaisA10Count = 0;
	int menorQue10Total = 0;
	int menorQue10Count = 0;
	int num = 0;
	
	for(int i = 0; i < 10; i++ ){
	
		printf("Digite um número:\n");
		scanf("%i",&num);
	
		if(num == 10){
			iguaisA10Total += num;
			iguaisA10Count ++;
		}else if(num < 10){
			menorQue10Total += num;
			menorQue10Count ++;
		}else{
			maiorQue10Total += num;
			maiorQue10Count ++;
		}

	}
	
	if(iguaisA10Total == 0){
	    printf("\nNão houve numeros iguais a 10.");
    }else{
    	printf("\nA média dos iguais a 10 é: %i", (iguaisA10Total + iguaisA10Count) / 2);
    }
    
	if(menorQue10Total == 0){
    	printf("\nNão houve numeros menores que 10");
    }else{
      	printf("\nA média dos menores a 10 é: %i", (menorQue10Total + menorQue10Count) / 2);    
    }
    
	if(maiorQue10Total == 0){
    	printf("\nNão houve numeros maiores que 10");
    }else{
    	printf("\nA média dos maiores a 10 é: %i", (maiorQue10Total + maiorQue10Count) / 2);
    }
    
	//TODO: terminar
	if(iguaisA10Total == 0 && menorQue10Total == 0 && ){
    
    }
}
