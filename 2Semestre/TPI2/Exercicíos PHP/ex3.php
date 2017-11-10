<style>
	p{
		font-size:20px;
		font-family:"segoe ui";
	}
</style>
<?php
	function println($str){
		$str = preg_replace("/é/", '&eacute;', $str);
		$str = preg_replace("/ã/", '&atilde;', $str);
		echo '<p>' . $str . '</p>';
	}
	
	//Atividade 3
	$valor = 12;
	if($valor > 0){
		println("Valor positivo");
	}else if($valor < 0){
		println("Valor negativo");
	}else{
		println("Valor Igual a 0");
	}

?>