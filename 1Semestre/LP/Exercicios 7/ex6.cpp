/*Permita a entrada de 12 números inteiros em um vetor. 
* Crie uma rotina que copie os números do vetor para uma 
* matriz de 4 x3. Apresente a matriz.
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");

	int vec[12], mat[4][3];
	
	for(int i = 0; i < 12; i++){
		printf("\nDigite um número: ");
		scanf("%i", &vec[i]);
	}
	
	int v = 0;
	 
	for(int x = 0; x < 4; x++){
		for(int y = 0; y < 3; y++){
			mat[x][y] = vec[(v++)];
		}
	}

	printf("int[4][3]{\n");
	for(int x = 0; x < 4; x++){
		printf("[ ");
		for(int y = 0; y < 3; y++){
			printf("%i, ", mat[x][y]);
		}
		printf("]\n");
	}
	printf("}");
	
	return 0;
}
