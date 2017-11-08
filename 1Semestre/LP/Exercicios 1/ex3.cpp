#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setLocale(LC_ALL, "portuguese");

	float n1 = 0, n2 = 0, n3 = 0,n4 =0;

	printf("Este programa tira a média do aluno.\n digite a primeira nota:\n");
	scanf("%f", &n1);	//%f no scanf significa que queremos uma float

	printf("digite a segunda nota:\n");
	scanf("%f", &n2);

	printf("digite a terceira nota:\n");
	scanf("%f", &n3);

	printf("digite a quarta nota:\n");
	scanf("%f", &n4);

	//%f no printf significa que queremos trocar todos os proximos parametros pelos %f no resultado
	printf("A media do aluno é : %f\n",((n1 + n2 + n3 + n4) / 4)); 
	
	//%f = float
	//%i = int
	//%b = bool
	//%c = char

	getch();
}