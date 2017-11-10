import javax.swing.JOptionPane;
import javax.swing.JTextArea;

public class Aula {

   public static void main( String args[] )   {
	   
	  double matrixA[][] = {
			  {0.19, 0.72, 0.70, 0.71},
			  {0.78, 0.42, 0.79, 0.12},
			  {0.45, 0.98, 0.67, 0.97},
			  {0.78, 0.80, 0.75, 0.78},
	  };
	  
	  double matrixB[][] = {
			  {0.41, 0.87, 0.21, 0.78},
			  {0.78, 0.10, 0.01, 0.20},
			  {0.74, 0.45, 0.78, 0.74},
			  {0.10, 0.47, 0.74, 0.45},
	  };      
	  
	  double matrixC[][] = {
			  {0, 0, 0, 0},
			  {0, 0, 0, 0},
			  {0, 0, 0, 0},
			  {0, 0, 0, 0},
	  };	  

	  for (int x = 0; x < matrixA.length; x++){
		  for (int y = 0; y < matrixA.length; y++){
			  matrixC[x] = Dot(matrixA[x], matrixB[y]); 
		  }		  
	  }

	  String saidaStr = "Resultado:\n";

	  for (int x = 0; x < matrixA.length; x++){
		  for (int y = 0; y < matrixA.length; y++){
			  saidaStr += matrixC[x][y] + " "; 
		  }
		  saidaStr += "\n";		  
	  }
	  
      JTextArea saidaArea = new JTextArea();
    
      saidaArea.setText(saidaStr);

      JOptionPane.showMessageDialog(null, saidaArea, "Multiplicação de matriz", JOptionPane.INFORMATION_MESSAGE);

   }

   public double[] Dot(double[] vecA , double[] vecB){
	   
	   double result[] = new double[vecA.length];
	   
	   for (int i = 0; i < vecA.length; i++){
		   result[i] = vecA[i] * vecB[i];
	   }
	   
	   return result;
   }
}

