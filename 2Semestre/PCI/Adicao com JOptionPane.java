package init;

import javax.swing.JOptionPane; 

public class Adicao {

  public static void main( String args[] )   {

    String primeiroNumero;
    String segundoNumero; 
    int numero1;          
    int numero2;          
    int soma;             
    
    primeiroNumero = JOptionPane.showInputDialog("Digite o Primeiro No Inteiro" );
    segundoNumero = JOptionPane.showInputDialog( "Digite o Segundo No Inteiro" );
    
    numero1 = Integer.parseInt(primeiroNumero);
    numero2 = Integer.parseInt(segundoNumero);

    soma = numero1 + numero2;

    JOptionPane.showMessageDialog(null, "A soma é "+soma,"Resultado da Soma: ",  JOptionPane.PLAIN_MESSAGE);
    System.exit( 0 );

 } 

}  
