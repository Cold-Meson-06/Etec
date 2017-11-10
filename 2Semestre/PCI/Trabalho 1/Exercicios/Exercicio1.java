//Desenvolva um programa em Java que leia o nome e a idade de 3
//pessoas e mostre o nome da pessoa mais velha e o nome da pessoa 
//mais nova.
package Exercicios;

import javax.swing.JOptionPane;

public class Exercicio1 {
	public static void start() {

		String nomeMaisVelha = "", nomeMaisNova = "";
		int idadeMaisVelha = 0, idadeMaisNova = Integer.MAX_VALUE;
		
		for (int i = 0; i < 3; i++) {
			String nome = JOptionPane.showInputDialog(null, "Digite seu nome:");
			int idade = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite sua idade:"));

			if (idade > idadeMaisVelha) {
				idadeMaisVelha = idade;
				nomeMaisVelha = nome;
			} else if (idade < idadeMaisNova) {
				idadeMaisNova = idade;
				nomeMaisNova = nome;
			}

		}

		JOptionPane.showMessageDialog(null, "O nome da pessoa mais velha é " + nomeMaisVelha + ".\n\nO nome da pessoa mais nova é " + nomeMaisNova + ".");


	}
}
