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
			<label>Digite a string:
				<input type="text" name="string" id="numero" />
			</label>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Faça alguma coisa"/>
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
		$strings = $_POST['string'];
        $total = strlen($strings);
		for ($i = 1; $i < $total ; $i++){
            println($i); 
        }
	}
?>