<!DOCTYPE html>
<html>
	<style>
    label{font-size:15px; font-family:"arial"; }
	p{font-size:20px;
	font-family:"segoe ui";}
	.consoleOutput{ 	display:inline; margin:8px}
	</style>
	<body>
		<form action="" method="post">
			<label>Digite o numero:
				<input type="text" name="numero" id="numero" />
			</label>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Calcular o  fatorial"/>
		</form>
	</body>
</html>

<?php
	function println($str){
		$str = preg_replace("/é/", '&eacute;', $str);
		$str = preg_replace("/ã/", '&atilde;', $str);
		echo '<p class="consoleOutput">' . $str . '</p>';
	}
	if(isset($_POST['btnOK'])){
		$valor=$_POST['numero'];
		$inicio = $valor;
        $total = $inicio;
        //Maior que 1 porque se chegar em 1 o proximo $inicio-- irá dar 0
        //E ($total *= 0) == 0
		while($inicio > 1){
			$total *= ($inicio--);
		}
        println("O fatorial de " . $valor . " é :" . $total); 
	}
?>