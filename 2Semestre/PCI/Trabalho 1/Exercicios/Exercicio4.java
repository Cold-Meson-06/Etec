/*
4) Um banco concederá um crédito especial aos seus clientes, variável com o saldo médio no último
 ano. Faça um programa em Java que leia o saldo médio de um cliente e calcule o valor do crédito 
 de acordo com a tabela abaixo. Mostre uma mensagem informando o saldo médio e o valor do crédito. 
 (use o comando switch-case e não faça repetições)
	
	Saldo médio Percentual
	-	de 0 a 200 nenhum crédito
	-	de 201 a 400 20% do valor do saldo médio
	-	de 401 a 600 30% do valor do saldo médio
	-	acima de 601 40% do valor do saldo médio

 */
package Exercicios;

import javax.swing.JOptionPane;

public class Exercicio4 {
	
	public static void start(){
		
		double saldoMedio = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite seu saldo médio."));
		double creditoEspecial = 0;
		
		if(saldoMedio <= 200){
			creditoEspecial = Exercicio2.cacularPorCento(0, saldoMedio);
		}else if(saldoMedio <= 400){
			creditoEspecial = Exercicio2.cacularPorCento(20, saldoMedio);
		}else if(saldoMedio <= 600){
			creditoEspecial = Exercicio2.cacularPorCento(30, saldoMedio);
		}else{
			creditoEspecial = Exercicio2.cacularPorCento(40, saldoMedio);
		}
		
		JOptionPane.showMessageDialog(null, "Seu credito especial é de R$:" + creditoEspecial + ".");
		
	}

}