#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main(){	

	setLocale(LC_ALL, "portuguese");
	
	float vValor = 0.0;
	int vParcelas = 0;
	
	printf("Este programa calcula o valor de cada parcela e o acrésimo em um financiamento.\n digite a quantidade de parcelas:\n");
	scanf("%i", &vParcelas);
	
	printf("digite o valor do financiamento:\n");
	scanf("%f", &vValor);
	
	float vAcresimo = (vValor * 15) / 100;
	float vValorParcela = vValor / vParcelas;
	
	printf("O valor de cada parcela é: %f.2\n", vValorParcela); 
	printf("E o acrésimo foi de: %f.2\n", vAcresimo);

	getch();

	return 0;
}