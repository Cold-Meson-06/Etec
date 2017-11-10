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
			<label>Digite o primeiro numero:
				<input type="text" name="numero_1" id="numero" />
			</label>
            <br/>
			<label>Digite o segundo numero:
				<input type="text" name="numero_2" id="numero" />
			</label>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Multiplicar usando +"/>
		</form>
	</body>
</html>

<?php
//TODO:Fix file encoding
	function println($str){
		$str = preg_replace("/é/", '&eacute;', $str);
		$str = preg_replace("/ã/", '&atilde;', $str);
		echo '<p class="consoleOutput">' . $str . '</p>';
	}
	if(isset($_POST['btnOK'])){
		$valor1 = $_POST['numero_1'];
        $valor2 = $_POST['numero_2'];
		$total = 0;
        for ($i = 0; $i < $valor2 * $valor1 ; $i++){
            $total ++;
        }
        println($valor1 . " x " . $valor2 . " = " . $total); 
	}
?>