/*
Faca um programa que:
Crie um array bidimensional baseado em um número informado pelo usuário;
Apresente esse array como uma matriz identidade (x=y -> 1; x <> y -> 0). 
Na matriz 	identidade todos os elementos da diagonal 	principal são iguais a 1.
*/

import javax.swing.*;

public class Main {

	public static void main(String[] args) {
	
		//1: Coletar o número do usuario.
		String tamanho_Str = JOptionPane.showInputDialog("Digite o tamanho da matriz.");
		int tamanho = Integer.parseInt(tamanho_Str);

		//2: Criar uma matriz com o tamanho defindo pelo usuario.		
		int matriz[][] = new int[tamanho][tamanho];

		//3: Inicializar a string que será mostrada no JOptionPane.
		String saidaStr = "Matriz:\n";
		
		//4: Percorrer todos os elementos da matriz
		for(int x = 0; x < tamanho; x++){			
			for(int y = 0; y < tamanho; y++){
				
				//Se a posição x e y forem iguais 
				if(x == y){
					//Estamos na diagonal, logo aqui deve ser 1. 
					matriz[x][y] = 1;

					//Adicionar tambem para a saida.
					saidaStr += "1 ";
				}else{
					//Senão estamos em qualquer outro lugar
					//Matriz indentidade só tem 1 nas diagonais
					matriz[x][y] = 0;
					saidaStr += "0 ";
				}
			}
			
			//Quebra de linha uma vez por linha.
			saidaStr += "\n";
		}
		
		//Exibir o resultado
		JOptionPane.showMessageDialog( 
				null, 
				saidaStr,
	    	    "Matriz",
	    	    JOptionPane.INFORMATION_MESSAGE 
		);
	  
	}
}
