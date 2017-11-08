//Elabore um algoritmo para testar se uma senha digita é igual a 123456.
//Se a senha estiver correta escreva "Acesso permitido",
//do contrario emita a mensagem "Você não tem acesso ao sistema". 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");

	int pass = 123456;
	int input = 0;

	printf("Digite sua senha:\n");
	scanf("%i",&input);

	if(input == pass){
		printf("Acesso permitido\n");
	}else{
		printf("Você não tem acesso ao sistema.");
	}

	getch();
}
