//Desenvolva um programa que permita a entrada de 15 números inteiros.
//Desenvolva uma rotina que encontre o maior e o menor número entre os números digitados. 
//Apresente o maior e o menor número.

#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <locale.h>

int main(){

	setlocale(LC_ALL, "portuguese");
	
    //Vetores são listas de "termos" de tamanho fixo.
    //Os valores podem ser acessados pela notação vetor[n]
    //onde n é um numero.
    int numeros[20], menor = 0, maior = 0;
   
    for (int num = 0; num < 14; num++ ) {
        printf("Digite um número\n");
        scanf("%i", &numeros[num]);
    }
    
	for (int num = 0; num < 14; num++){
        if(numeros[num] > maior) {
            maior = numeros[num];
        }
    }
    
	menor = maior;
	
	for (int num = 0; num < 14; num++){
  		if(numeros[num] < menor){
            menor = numeros[num];
        }
    }
            
    printf("\nO maior número é :%i", maior);
    printf("\nO menor número é :%i", menor);

    getch();

    return 0;
}
