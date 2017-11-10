/*	Uma pesquisa sobre algumas características físicas da população de uma determinada região
 *  coletou os seguintes dados, referentes a cada habitante, para serem analisados:
		sexo (masculino, feminino)
		cor dos olhos (azuis, verdes, castanhos)
		cor dos cabelos (louros, castanhos, pretos)
		idade em anos.
	Para cada habitante, foi perfurado um cartão com esses dados, e o último cartão, que não 
	corresponde a ninguém, conterá o valor da idade igual a -1. Implementar um programa em Java
 	que determine e escreva:
	a) a maior idade dos habitantes;
	b) porcentagem de indivíduos do sexo feminino cuja idade esteja entre 18 e 35 anos, inclusive, 
	e que tenham olhos verdes e cabelos louros
*/

package Exercicios;

import javax.swing.JOptionPane;

public class Exercicio3 {
	public static void start() {
		
		//Variaveis principais.
		genero[] generos = {};
		corDeOlho[] coresDosOlhos = {};
		corDeCabelo[] coresDosCabelos = {};
		int[] anos = {};

		//Define o numero de pesquisas. (Não entendi muito bem o enunciado)
		int numeroDeHabitantes = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de habitantes a serem pesquisados."));

		//Coleta os dados dos habitantes
		for (int i = 0; i < numeroDeHabitantes; i++) {
			generos[i] = stringParaGenero(JOptionPane.showInputDialog("Digite seu sexo."));
			coresDosOlhos[i] = stringParaCorDeOlho(JOptionPane.showInputDialog("Digite a cor de seu olho."));
			coresDosCabelos[i] = stringParaCorDeCabelo(JOptionPane.showInputDialog("Digite a cor de seu cabelo."));
			anos[i] = Integer.parseInt(JOptionPane.showInputDialog("Digite a sua idade."));
		}
		
		//Diz a maior idade
		int maiorIdade = 0;
		for (int i = 0; i < numeroDeHabitantes; i++) {
			maiorIdade = Math.max(maiorIdade, anos[i]);
		}

		//Diz qual habitante tem as caracteristicas do eninciado
		int habitantesComAsCaracteristicas = 0;
		for (int i = 0; i < numeroDeHabitantes; i++) {
			if (generos[i] == genero.FEMININO && anos[i] >= 18 && anos[i] <= 35 && coresDosOlhos[i] == corDeOlho.VERDE
					&& coresDosCabelos[i] == corDeCabelo.LOURO) {
				habitantesComAsCaracteristicas++;
			}
		}
				
		double porcentagem = Exercicio2.cacularPorCento((double) habitantesComAsCaracteristicas,(double) numeroDeHabitantes);

		//Diz o resultado
		JOptionPane.showInputDialog("A maior idade é " + maiorIdade);
		JOptionPane.showInputDialog("A porcentagem de habitantes com as caracteristicas desejadas é " + porcentagem + "%.");
		
		//Aqui era pra ter algo como process.terminate(0) ou algo assim...
	}

	//Aqui que comessa o problema:
	public static genero stringParaGenero(String entrada) {
		if (entrada == "Masculino" || entrada == "M" || entrada == "m" || entrada == "Homem" || entrada == "m") {
			return genero.MASCULINO;
		}
		if (entrada == "Feminino" || entrada == "F" || entrada == "Mulher" || entrada == "f"

		) {
			return genero.MASCULINO;
		}

		return genero.INVALIDO;
	}

	public enum genero {
		MASCULINO, INVALIDO, FEMININO;
	}

	public static corDeOlho stringParaCorDeOlho(String entrada) {
		if (entrada == "azul" || entrada == "Azul") {
			return corDeOlho.AZUL;
		}
		if (entrada == "castanho" || entrada == "Castanho") {
			return corDeOlho.CASTANHO;
		}
		if (entrada == "verde" || entrada == "Verde") {
			return corDeOlho.VERDE;
		}
		return corDeOlho.INVALIDO;
	}

	public enum corDeOlho {
		AZUL, CASTANHO, INVALIDO, VERDE;
	}

	public static corDeCabelo stringParaCorDeCabelo(String entrada) {
		if (entrada == "azul" || entrada == "Azul") {
			return corDeCabelo.LOURO;
		}
		if (entrada == "castanho" || entrada == "Castanho") {
			return corDeCabelo.CASTANHO;
		}
		if (entrada == "verde" || entrada == "Verde") {
			return corDeCabelo.PRETO;
		}
		return corDeCabelo.INVALIDO;
	}

	public enum corDeCabelo {
		LOURO, CASTANHO, INVALIDO, PRETO;
	}
}
