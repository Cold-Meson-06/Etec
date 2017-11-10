<?php
    include('conexao.php');
    
    #Warning: Header may not contain more than a single header, new line detected in C:\xampp\htdocs\fernando\projeto\cadastroAluno.php on line 5;
    $queryString = "insert into Aluno values ('{$_POST['inputRA']}','{$_POST['inputNome']}','{$_POST['inputRua']}','{$_POST['inputNumero']}','{$_POST['inputBairro']}','{$_POST['inputCidade']}','{$_POST['inputEstado']}')";

    if(empty($_POST["inputRA"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="RA"&qs=' . $queryString);
    }else if(empty($_POST["inputNome"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="Nome"&qs=' . $queryString);
    }else if(empty($_POST["inputRua"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="Rua"&qs=' . $queryString);
    }else if(empty($_POST["inputNumero"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="Numero"&qs=' . $queryString);
    }else if(empty($_POST["inputBairro"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="Bairro"&qs=' . $queryString);
    }else if(empty($_POST["inputCidade"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="Cidade"&qs=' . $queryString);
    }else if(empty($_POST["inputEstado"])){
    	header('Location: telaCadastro.php?status=erro&semDadosNoCampo="Estado"&qs=' . $queryString);
    }else{
    
        $conn->query($queryString);
    
        $conn->close();

        header("Location: telaCadastro.php?status=sucesso&qs=" . $queryString);

    }
    
?>