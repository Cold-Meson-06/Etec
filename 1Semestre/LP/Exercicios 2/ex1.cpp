#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	
	
	setlocale(LC_ALL, "portuguese");
	
	float vSalario = 0.0, vTempoDeServico = 0.0, vAbono = 0.0;
	
	printf("Digite seu salario.\n");
	scanf("%f",&vSalario);

	printf("Digite seu tempo de serviço.\n");
	scanf("%f",&vTempoDeServico);
	
	//If desvia o fluxo de execução para o bloco abaixo 
	//se a condição dentro do () resultar em true.
	if(vSalario > 1000 && vTempoDeServico < 5.0){
		vAbono = (vSalario * 5) / 100;

	//Se for false o fluxo é desviado para o else.
	}else{
		vAbono = (vSalario * 2) / 100;
	}

	printf("O Abono foi de :%f",vAbono);
	printf("Reais.\n");
	
	getch();

	return 0;
}
