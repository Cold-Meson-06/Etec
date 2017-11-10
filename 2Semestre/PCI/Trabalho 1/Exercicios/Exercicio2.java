/*
 * O custo ao consumidor de um carro novo é a soma do custo de fábrica com a percentagem do 
 * distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que a percentagem do 
 * distribuidor seja de 28% e os impostos de 45%, escreva um programa em Java que leia o custo 
 * de fábrica de um carro e escreva o custo ao consumidor.
*/
package Exercicios;

import javax.swing.JOptionPane;

public class Exercicio2 {
	public static void start(){
		
		double custoDoCarro = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o valor do carro."));
		
		double taxaFabrica = cacularPorCento(custoDoCarro, 28);
		double impostos =  cacularPorCento(custoDoCarro, 45);
		
		double total = custoDoCarro + taxaFabrica + impostos;
		
		JOptionPane.showMessageDialog(null, "O valor do carro é R$:" + total + ".");
				
	}
	
	public static double cacularPorCento(double amount, double total){
		
		return total * amount / 100;
		
	}
}
