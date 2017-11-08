#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>

int main() {	

	setlocale(LC_ALL, "portuguese");
	
	float media = 0, total = 0, nota = 0;
	int aprovados = 0, reprovados = 0;
	
	for(int i = 0; i< 4; i++){
		
		total = 0;
		
		for(int j = 0; j < 4; j++){
			printf("Digite a nota do aluno:\n");
			scanf("%f",&nota);
			total += nota;
		}
		
		media = total / 4;
		
		printf("\nA média do aluno foi :%f", media);
		printf("\n");
		
		if(media >= 7){
			aprovados ++;
		}else{
			reprovados++;
		}
		
	}
	
	printf("\n\nTotal de aprovados :%i", aprovados);
	printf("\nTotal de reprovados :%i", reprovados);
	
	getch();
	
	return 0;
}
