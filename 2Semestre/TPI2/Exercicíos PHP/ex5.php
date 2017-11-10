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
			
				<label> Nota 1<input type="text" name="nota1" id="" /></label><br>
				<label> Nota 2<input type="text" name="nota2" id="" /></label><br>
				<label> Nota 3<input type="text" name="nota3" id="" /></label><br>
				<label> Nota 4<input type="text" name="nota4" id="" /></label><br>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Calcular a média"/>
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
	
		$nota_1 = $_POST['nota1'];
		$nota_2 = $_POST['nota2'];
		$nota_3 = $_POST['nota3'];
		$nota_4 = $_POST['nota4'];
	
		$media = ($nota_1 + $nota_2 + $nota_3 + $nota_4) / 4;
	
		if($media >= 7){
			println("Aluno Aprovado");
		}else{
			println("Aluno Reprovado");
		}
	}
?>


<style>
	p{
		font-size:20px;
		font-family:"segoe ui";
	}
</style>
<?php
	function println($str){
		$str = preg_replace("/�/", '&eacute;', $str);
		$str = preg_replace("/�/", '&atilde;', $str);
		echo '<p>' . $str . '</p>';
	}
	
	//Atividade 5!!!!!!
	$A = 5;
	$B = 3;
	
	if($A > $B){
		println($B . " " . $A);
	}else{
		println( $A . " " . $B);
	}
?>