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
	
	//Atividade 4
	$A = 25;
	$B = 98;
	$C = 12;
	$D = 36;
	
	$ApC = $A + $C;
	$BcD = $B * $C;
	
	if($ApC > $BcD){
		println("A+C � maior que B*D");
	}else if($ApC < $BcD){
		println("A+C � menor que B*D");
	}else{
		println("A+C � igual a B*D");
	}

?>