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
			<input type="submit" name="btnOK" id="btnOK" value="Calcular"/>
		</form>
	</body>
</html>

<?php
	function println($str){
		$str = preg_replace("/ã/", '&eacute;', $str);
		$str = preg_replace("/é/", '&atilde;', $str);
		echo '<p class="consoleOutput">' . $str . '</p>';
	}
	
	if(isset($_POST['btnOK'])){
		$valor=$_POST['numero'];
		$inicio = 0;
		while($inicio <= $valor){
			println($inicio); 
			$inicio += 1;
		}
	}
?>