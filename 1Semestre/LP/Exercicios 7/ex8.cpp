/*
Elaborar um algoritmo que preencha uma matriz M(6,6) e permita a entrada 
de uma variável vnum. Crie uma lógica que multiplique a matriz M pelo 
valor de vnum, elemento por elemento. Armazene os valores multiplicados 
em vetor chamado vetnum com 36 posições. Apresente o vetor vetnum
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

//Retorna uma int do stdin
int getUserValue(){
	int v = 0;
	printf("Digite um número: ");
	scanf("%i",&v);
	return v;
}

//Preenche um vetor com dados do stdin
void fillVector(int v[], int size){
	int val = 0;
	for(int i = 0; i < size; i++){
		printf("Digite um numero para a posição [%i] do vetor: ", i);
		scanf("%i",&val);
		v[i] = val;
	}
}

//Preenche uma matriz com dados do stdin
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

//Vizualiza um vetor no stdout
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

//Vizualiza uma matriz no stdout
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

int main() {	
	setlocale(LC_ALL, "portuguese");
	
	int M[6][6], vnum = 0, vetnum[36], vIndex = 0;
	
	vnum = getUserValue();
	
	fillMatrix6i(M, 6);
	
	for(int x = 0; x < 6; x++){
		for(int y = 0; y < 6; y++){
			vetnum[vIndex++] = M[x][y] * vnum;
		}
	}
	
	visualizeVector("vetnum", vetnum, 36);
	
	getch();

	return 0;
}
