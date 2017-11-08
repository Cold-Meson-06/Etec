/*
* Elaborar um algoritmo preencha duas matrizes M(4,6) e N(4,6). Crie uma lógica
* que preencha 3 matrizes com informações provenientes dessas duas matrizes anteriores.
* As operações deverão ser realizas elemento por elemento. Ex. O valor da matriz M 
* que estiver na posição 0,0, deverá ser calculado com o valor da matriz N na posiçãoo 0,0.
* As matrizes deverão ter o seguinte conteúdo:
* M1) O produto de M por N;
* M2) A soma de M com N;
* M3) A diferença de M com N;
* Apresente as três matrizes com os seus resultados.
*/

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>


//Preenche uma matriz com valores do usuario.
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

//Imprime uma matriz no stdout
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
	
	int  M[4][6], N[4][6], M1[4][6], M2[4][6], M3[4][6];
	
	fillMatrix6i(M,4);	
	visualizeMatrix6i("M",M);
	printf("\n===============================================================\n");
	
	fillMatrix6i(N,4);
	visualizeMatrix6i("N",N);
	printf("\n===============================================================\n");
	
	for(int x = 0; x < 4; x++){
		for(int y = 0; y < 6; y++){
			M1[x][y] = M[x][y] / N[x][y];
			M2[x][y] = M[x][y] + N[x][y];
			M3[x][y] = M[x][y] - N[x][y];
		}
	}
	
	visualizeMatrix6i("M / N = M1",M1);
	visualizeMatrix6i("M + N = M2",M2);
	visualizeMatrix6i("M - N = M3",M3);
	
	printf("\n===============================================================\n");

	getch();

	return 0;
}
