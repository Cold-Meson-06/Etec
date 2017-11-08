//Um comerciante comprou um produto e quer vendê-lo com um lucro de 45% 
//se o valor da compra for menor que R$ 20,00; 
//caso contrário, o lucro será de 30%.
//Elabore um algoritmo que leia o valor do produto e imprima o valor de venda para o produto. 

#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

//pOf = (cur, max) => (cur * max) / 100
float percentOf(float current, float max){
	return (current * max) / 100;
}

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	int productValue = 0;
	int result = 0;
	
	printf("Digite o valor do produto para obter o lucro:\n");
	scanf("%f", &productValue);
	
	if(productValue < 20){
		result = productValue + percentOf(productValue, 45);
	}else{
		result = productValue + percentOf(productValue, 20);
	}

	printf("O valor do produto é:%i", result);
	
	getch();

	return 0;
}
