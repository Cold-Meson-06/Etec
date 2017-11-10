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
			
				<label> Masculino <input value="M" type="radio" name="sexo" id="" /></label>
				<br>
				<label> Femimino <input value="F" type="radio" name="sexo" id="" /></label>
				<br>
				<label> Altura <input type="text" name="alutra" id="" /></label>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Calcular o Peso ideal"/>
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
		$escolha =$_POST['sexo'];
		$altura = $_POST['alutra'];
		if($escolha === "M"){
			println("Peso ideal : " . ((62.1 * $altura) - 44.7));
		}else {
			//Você não é uma mulher, logo presumo que só possa se tratar de um homem certo ???
			println("Peso ideal : " . ((72.7 * $altura) - 58));
		}
	}
?>