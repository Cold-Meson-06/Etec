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
			<label>Digite a primeira string:
				<input type="text" name="string_1" id="str1" />
			</label>
			<br/>
			<label>Digite a segunda string:
				<input type="text" name="string_2" id="str2" />
			</label>
			<br/>
			<input type="submit" name="btnOK" id="btnOK" value="Testar strings"/>
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
		$str1 = $_POST['string_1'];
        $str2 = $_POST['string_2'];
        if($str1 == $str2){
            println("IGUAL");
        }else{
            println("DIFERENTE");
        }
	}
?>