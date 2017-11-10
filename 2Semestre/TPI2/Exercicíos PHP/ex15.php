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
				<input type="text" name="string_1" id="" />
			</label>
			<br/>
			<label>Digite um caractere:
				<input type="text" name="string_2" id="hash:f4b41a8c8d" />
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
        $count = 0;
        for($i = 0; $i < strlen($str1); $i++){
            if($str1[$i] == $str2){
                $count++;
            }
        }
        
        if($count == 0){
            println("\"" . $str1 . "\" não aparece em \"" . $str1 ."\".");
        }else if ($count == 1){
            println("\"" . $str1 . "\" aparece " . $count . " vez em \"" . $str1 ."\".");
        }else{
            println("\"" . $str1 . "\" aparece " . $count . " vezes em \"" . $str1 ."\".");
        }
	}
?>