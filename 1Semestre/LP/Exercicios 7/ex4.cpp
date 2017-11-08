/*Permita a entrada de 10 números inteiros em um vetor. 
* Crie uma rotina que apresente o último elemento par existente no vetor.
*/
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int vecLen = 10, vec[vecLen];
	
	for(int i = 0; i < vecLen; i++){
		printf("\nDigite um número: ");
		scanf("%i", &vec[i]);
	}
	
	int i = vecLen;
	
	do
	{
		
		i--;
		
		if(vec[i] % 2 == 0)
		{
			printf("\nO ultimo elemento par do vetor está na posição %i com o valor %i", i, vec[i]);
			printf(".");
			break;
		}else if(i == 0){
			printf("\n Não há nenhum elemento par no vetor.");
			break;
		}

	}while(true);
	
	getch();

	return 0;
}
