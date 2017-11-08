#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");

	//Variaveis não inicializadas vem com números aleatorios
	//(Algo aver com o endereço de memoria)
	float vSalario, vReajuste, vAcresimo;

	printf("Digite seu salário:\n");
	scanf("%f", &vSalario);

	if(vSalario >= 12000.00){
		vReajuste = (vSalario * 12) / 100;
	}else{
		vReajuste = (vSalario * 15) / 100;
	}

	vAcresimo = vSalario - vReajuste;

	printf("O Reajuste foi de:%f", vReajuste);
	printf("\nSeu novo salário é de:%f", (vSalario + vAcresimo));

	getch();

	return 0;
}

