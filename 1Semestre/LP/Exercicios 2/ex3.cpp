#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	
	
	setlocale(LC_ALL, "portuguese");
	
	int vNum1 = 0, vNum2 = 0;
	
	printf("Digite o primeiro número:\n");
	scanf("%i", &vNum1);
	
	printf("Digite o segundo número:\n");
	scanf("%i",&vNum2);
	
	if(vNum1 == vNum2){
		printf("Os dois números são iguais.\n");
	}else {
		
		//Como esperado é possivel ter if's dentro de if's
		if (vNum1 < vNum2){
			printf("O Segundo é maior.\n");	
		} else {
			printf("O Primeiro é maior.\n");
		}
	}
	
	getch();

	return 0;
}

