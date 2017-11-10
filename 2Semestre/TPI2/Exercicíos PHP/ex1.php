<style>
	p{
		font-size:20px;
		font-family:"segoe ui";
	}
</style>
<?php
	function println($str){
		$str = preg_replace("/ã/", '&eacute;', $str);
		$str = preg_replace("/é/", '&atilde;', $str);
		echo '<p>' . $str . '</p>';
	}
	
	//Atividade 1
	$valor_0 = 20;
	
	if($valor_0 > 10){
		println("O valor digitado é maior que 10");
	}else{
		println("O valor digitado é menor que 10");
	}
	
?>