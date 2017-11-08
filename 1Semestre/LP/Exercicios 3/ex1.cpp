#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <locale.h>

//As funções podem receber parametros.
float getPerCent(float total, float percent){
	return ((total * percent) / 100);
}

float removeByPerCent(float total, float percent){
	return ((total * percent) / 100);
}

int main(){
	
	setlocale(LC_ALL, "portuguese");

	float valorHora = 0, horasNoMes = 0, IR = 0;
	
	printf("Este programa imprime sua folha de pagamento.\n");

	printf("Digite o valor da sua hora:\n");
	scanf("%f", &valorHora);
	
	printf("Digite a quantidade de horas trabalhadas no mês:\n");
	scanf("%f",&horasNoMes);
	
	float salarioBruto = valorHora * horasNoMes;
	
	if(salarioBruto <= 1500){
		IR = 5;
	}else if(salarioBruto <= 2500){
		IR = 10;
	}else{
		IR = 20;
	}
	
	float menosIR = getPerCent(salarioBruto, IR);
	float menosSindicato = removeByPerCent(salarioBruto, 3);
	float menosINSS = 	removeByPerCent(salarioBruto, 10);
	float menosFGTS = removeByPerCent(salarioBruto, 1);
	
	float totalDescontos = menosIR + menosSindicato + menosINSS;
	float salarioLiquido = salarioBruto - totalDescontos;
	
	printf("Salário Bruto :(%.2f", valorHora);
	printf(" * %.2f", horasNoMes);
	printf(") :................................R$:%.2f", salarioBruto);
	printf("\n");
	printf("\n(-) IR (");
	printf("%.0f",IR);
	printf("%) :................................R$:%.2f", menosIR);
	printf("\n");
	printf("\n(-) Sindicato (3%) :................................R$:%.2f", menosSindicato);
	printf("\n");
	printf("\n(-) INSS (10%) :................................R$:%.2f", menosINSS);
	printf("\n");
	printf("\nFGTS (1%) :................................R$:%.2f", menosFGTS);
	printf("\n");
	printf("\nTotal de descontos :................................R$:%.2f", totalDescontos);
	printf("\nSalário liquido :................................$:%.2f", salarioLiquido);

	getch();
	
	return 0;
}
