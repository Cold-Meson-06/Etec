import javax.swing.JOptionPane;

public class While{
	public static void main (String args[]) {
      String numeroInformado, saidaFinal = "";
      
      int numero = 0, pares = 0, impares = 0;
      
      numeroInformado = JOptionPane.showInputDialog("Entre com um valor inteiro:");
      numero = Integer.parseInt(numeroInformado);
      
      for (int i=0; i<= numero; i++) {
        if (!(i % 2!=0)){
        	pares++;
            saidaFinal += i + " ";
        }else{
        	impares++;
        }
      }
      
      int fatorial = 1;
      for(int i = 1; i < impares; i++){
    	  fatorial += i;
      }
      
      saidaFinal += "\nTotal de pares: " + pares;
      JOptionPane.showMessageDialog(null,saidaFinal);
      JOptionPane.showMessageDialog(null,"O fatorial dos impares é " + fatorial );
      System.exit(0);
   }
}
