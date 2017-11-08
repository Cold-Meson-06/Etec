#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int vParcelas = 0;
	float vValorOriginal = 0.0, vReajuste = 0.0, vTotal = 0.0, vCustoParcela = 0.0;
	
	printf("Digite o valor da compra:\n");
	scanf("%f", &vValorOriginal);
	
	printf("Digite o número de parcelas:\n");
	scanf("%i", &vParcelas);
	
	switch (vParcelas){
		case 1: vReajuste = -(vValorOriginal * 5) / 100; break;
		case 2: vReajuste = (vValorOriginal * 3) / 100; break;
		case 3: vReajuste = (vValorOriginal * 5) / 100; break;
		default: vReajuste = (vValorOriginal * 10) / 100; break;
	}
	
	vCustoParcela = (vValorOriginal + vReajuste) / vParcelas;
	vTotal = vValorOriginal + vReajuste;
	
	printf("O Custo de cada parcela é de:%f", vCustoParcela);
	printf("\nO total é de:%f", vTotal);
	
	getch();

	return 0;
}
