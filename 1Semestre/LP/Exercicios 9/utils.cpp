#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

int getUserValue(){
	int v = 0;
	printf("Digite um número: ");
	scanf("%i",&v);
	return v;
}

void fillVector(int v[], int size){
	int val = 0;
	for(int i = 0; i < size; i++){
		printf("Digite um numero para a posição [%i] do vetor: ", i);
		scanf("%i",&val);
		v[i] = val;
	}
}
void visualizeVector(char* message,int vec[], int size){
	printf(message);
	printf("int[%i]{", size);
	for(int i = 0; i < size ; i++){
		if(i < size-1){
			printf("%i, ", vec[i]);
		}else{
			printf("%i", vec[i]);	
		}
	}
	printf("}\n");
}

/*
void fillMatrix6i(int m[][6], int rows){
	int val = 0;
	for(int x = 0; x < rows; x++){
		for(int y = 0; y < 6; y++){
			printf("Digite um numero para a posição [%i][%i] da matrix: ", x, y);
			scanf("%i",&val);
			m[x] [y] = val;
		}
	}
}
*/

/*
void visualizeMatrix6i(char* message,int mat[][6]){
	printf(message);
	printf("[4][6] {\n");
	for(int x = 0; x < 4; x++){
		printf("  ");
		for(int y = 0; y < 6; y++){
			printf("%i, ",mat[x][y]);
		}
		printf("\n");
	}
	printf("}\n\n");
}
*/
