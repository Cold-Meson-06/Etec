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
	
	//Atividade 2
	$valor_1 = 65;
	if($valor_1 >= 10){
		println("O valor � maior ou igual a 10");
	}else{
		println("O valor n�o � maior ou igual a 10");
	}

?>