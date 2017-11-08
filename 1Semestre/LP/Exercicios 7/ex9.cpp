#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

int main(){

	int rows = 3;
	int cols = 3;

	int mat[rows][cols], val = 0, rep = 0;
	int disp[rows][cols];

	for(int x = 0; x < cols; x++){
		for(int y = 0; y < rows; y++){
			printf("Digite um numero:");
			scanf("%i",&mat[x][y]);
			disp[x][y] = 0;
		}
	}	

	for(int x1 = 0; x1 < cols; x1++){
		for(int y1 = 0; y1 < rows; y1++){

			val = mat[x1][y1];
			rep = 1;
			
			for(int x2 = 0; x2 < cols; x2++){
				for(int y2 = 0; y2 < rows; y2++){
			
					if(!(x1 == x2 && y1 == y2)){
						if(val == mat[x2][y2]){
							rep++;
							disp[x2][y2] = 1;
						}
					}
			
				}
			}

			if(!disp[x1][y1] == 1){
				printf("Encontrados %i de %i\n", rep, val);	
			}

		}
	}

	getch();

	return 0;
}
