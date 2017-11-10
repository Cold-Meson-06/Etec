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
			<label>Digite o salário:
				<input type="text" name="salario" id="numero" />
			</label>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Calcular o novo salário"/>
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
		$salario=$_POST['salario'];
		if($salario <= 300){
			$salario += ($salario * 50) / 100;
		}else{
			$salario += ($salario * 30) / 100;
		}
		println("R$: " . $salario);
	}
	function writeFile($str){
		$myfile = fopen("newfile.txt", "w") or die("Nao foi possivel abrir o aruqivo!");
		fwrite($myfile, $str);
		fclose($myfile);
	}
?>