<?php
    $serverName = "localhost";
    $userName = "alunos";
    $password = "etec";
    $database = "bdEscola";

    $conn = new mysqli($serverName, $userName, $password, $database);

    if($conn->connect_error){
        die("Erro de conexão" . $conn->connect_error);
    }
?>