#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main(){

	setLocale(LC_ALL, "portuguese");
	
	int n1 = 0, n2 = 0;
	
	printf("Este programa soma dois numeros.\nInsira o primeiro número :\n");
	scanf("%i", &n1);
	
	printf("Insira o segundo número\n");
	scanf("%i", &n2);

	printf("A soma dos números é :%i", (n1 + n2));

	getch();

	return 0;
};
