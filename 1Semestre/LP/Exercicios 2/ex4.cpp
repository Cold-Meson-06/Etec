#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int vFilhos = 0;
	float vSalario = 0.0, vReducao = 0.0, vNovoSalario = 0.0;
	
	printf("Digite a quantidade de filhos:\n");
	scanf("%i", &vFilhos);
	
	printf("Digite seu salário:\n");
	scanf("%f", &vSalario);
	
	if(vSalario >= 3000.00){
		
		if(vFilhos >= 3){
			vReducao = (vSalario * 3) / 100;	
		}else{
			vReducao = (vSalario * 5) / 100;
		}

	}else{
		
		if(vFilhos >= 3){
			vReducao = (vSalario * 3) / 100;
		}else{
			vReducao = (vSalario * 5) / 100;
		}

	}
	
	vNovoSalario = vSalario - vReducao;
	
	printf("Seu novo salario é de: %f",vNovoSalario);
	printf("\nA redução foi de %f",vReducao);
	printf("\n");

	getch();

	return 0;
}
