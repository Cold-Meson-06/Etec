/*
Faça um programa que imprima as tabuadas do 1 ao 10, neste formato:
 Tabuada do 1: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.
 Tabuada do 2: 2, 4, 6, 8, 10, 12, 14, 16, 18, 20.
 Tabuada do 3: 3, 6, 9, 12, 15, 18, 21, 24, 27, 30.
 Tabuada do 4: 4, 8, 12, 16, 20, 24, 28, 32, 36, 40.
 Tabuada do 5: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50.
 Tabuada do 6: 6, 12, 18, 24, 30, 36, 42, 48, 54, 60.
 Tabuada do 7: 7, 14, 21, 28, 35, 42, 49, 56, 63, 70.
 Tabuada do 8: 8, 16, 24, 32, 40, 48, 56, 64, 72, 80.
 Tabuada do 9: 9, 18, 27, 36, 45, 54, 63, 72, 81, 90.
 Tabuada do 10: 10, 20, 30, 40, 50, 60, 70, 80, 90, 100.
*/
 
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");

	for(int x = 1; x <= 10; x++){

		printf("\nTabuada do %i", x);
		printf(": ");

		for(int y = 1; y <= 10; y++){
			printf("%i", (x * y));
			printf(", ");
		}	

	}

	getch();

	return 0;
}
