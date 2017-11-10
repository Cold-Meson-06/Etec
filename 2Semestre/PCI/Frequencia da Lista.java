import javax.swing.*;

public class Entrada {
	
   public static void main( String args[] )   {  

	   int respostas[] = {
			   1, 2, 6, 4, 8, 5, 9, 7, 8, 10,
               1, 6, 3, 8, 6, 10, 3, 8, 2, 7,
               6, 5, 7, 6, 8, 6, 7, 5, 6, 6,
               5, 6, 7, 5, 6, 4, 8, 6, 8, 10 
	   };
      
	   int frequencia[] = new int[ 11 ];
	   
	   for ( int resp = 0; resp < respostas.length; resp++ ){
		   frequencia[respostas[resp]]++;  
	   }
         
      String saidaStr = "Grau\tFrequencia\n";
      
      for (int taxa = 1; taxa < frequencia.length; taxa++ ){
    	  saidaStr += taxa + "\t" + frequencia[ taxa ] + "\n"; 
      }
        
      int menosIndicado = Integer.MAX_VALUE;
      int menosIndicadoIndice = 1;
      
      int maisIndicado = 0;
      int maisIndicadoIndice = 0;
      
      for (int taxa = 1; taxa < frequencia.length; taxa++ ){
    	  
    	  if(frequencia[taxa] > maisIndicado){
    		  maisIndicado = frequencia[taxa];
    		  maisIndicadoIndice = taxa;
    	  }else if(frequencia[taxa] < menosIndicado){
    		  menosIndicado = frequencia[taxa];
    		  menosIndicadoIndice = taxa;
    	  }
    	  
      }      
         
      saidaStr += "\n Mais indicado: " + maisIndicadoIndice;
      saidaStr += "\n Menos indicado: " + menosIndicadoIndice;
      
      JTextArea saidaArea = new JTextArea();
      saidaArea.setText( saidaStr );
      JOptionPane.showMessageDialog( null, saidaArea, "Programa de Pesquisa dos Estudantes sobre RU", JOptionPane.INFORMATION_MESSAGE );
      System.exit( 0 );
   }
}
