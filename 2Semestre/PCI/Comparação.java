import javax.swing.JOptionPane;

class Main {
	public static void main(String[] args) {
		int intNum1 = Integer.parseInt(
			JOptionPane.showInputDialog("Digite o primeiro numero inteiro")
		),
		intNum2 = Integer.parseInt(
				JOptionPane.showInputDialog("Digite o segundo numero inteiro")
		);

		//CodeDump		
		JOptionPane.showMessageDialog(
			null,
			intNum1 == intNum2
				? intNum1 + " é igual a " + intNum1 :
			 	intNum1 + " é diferente de " + intNum2 + "\n" + intNum1 + " é " + (
					intNum1 < intNum2 
					? "maior" 
					: "menor"
				) + " que " + intNum2,
			"Resultados da Comparação",
			 JOptionPane.INFORMATION_MESSAGE
		);
	}
}
