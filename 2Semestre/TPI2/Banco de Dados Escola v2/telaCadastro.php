<!DOCTYPE html>
<html>

    <head>
        <title>Cadastro de Aluno</title>
        <meta charset="utf-8"></meta>
        <link rel="stylesheet" href="./telaCadastro.css"/>
    </head>

    <body>
        
        <form action="cadastroAluno.php" method="post">

            <table class="formTable">
                <tr>
                    <td>RA:</td>    <td><input type="text" name="inputRA" id="inputRA"></td>
                </tr>
                <tr>
                    <td>Nome:</td>    <td><input type="text" name="inputNome" id="inputNome"></td>
                </tr>
                <tr>
                    <td>Rua:</td>    <td><input type="text" name="inputRua" id="inputRua"></td>
                </tr>
                <tr>
                    <td>Numero:</td>    <td><input type="text" name="inputNumero" id="inputNumero"></td>
                </tr>
                <tr>
                    <td>Bairro:</td>    <td><input type="text" name="inputBairro" id="inputBairro"></td>
                </tr>
                <tr>
                    <td>Cidade:</td>    <td><input type="text" name="inputCidade" id="inputCidade"></td>
                </tr>
                <tr>
                    <td>Estado:</td>    <td><input type="text" name="inputEstado" id="inputEstado"></td>
                </tr>
            </table>

            <center>
                <input type="submit" name="btnCadastrar" id="btnCadastrar" class="btnCadastrar" value="cadastrar"/>
                <input type="button" id="rndValues" value="valores aleatorios" onclick="randomizar()"/>
            </center>
            
        </form>

        <?php
            
            #Checar se `status` está na URL
            if(!empty($_GET['status'])){
                
                #Se o valor for erro
                if($_GET['status'] == 'erro'){
                
                    #Imprimir uma mensagem abaixo do formulário
                    echo "<p class='errMessage'>Erro: Sem dados no campo de " . $_GET['semDadosNoCampo'];
        
                #Caso contrário o usuario está voltando de um cadastro
                }else if($_GET['status'] == 'sucesso'){
                    echo '<p class="infMessage"> Aluno Cadastrado' ;
                }
                
                #Exibir um botão para mostrar a QueryString
                if(!empty($_GET['qs'])){
                    
                    echo '<br><button onclick="exibirQS()">Exibir Query String</button>';
                    echo "
                        <script>
                            function exibirQS(){
                                alert(\"{$_GET['qs'] }\") 
                            }
                        </script>";
                    }
                
                #Fechar um dos <p>
                echo "</p>";

            

            #Senão é a primeira vez que o usuario entra no site 
            }else {
                echo '<p class="sucMessage"> Cadastre um aluno </p>';                
            }
        ?>

        <table class="sqlResult">

            <!--Header da tabela-->
            <tr class="tableHeader">
                <td>RA</td>
                <td>Nome</td>
                <td>Rua</td>
                <td>Num</td>
                <td>Bairro</td>
                <td>Cidade</td>
                <td>Estado</td>
                <td>Deletar</td>
                <td>Alterar</td>
            </tr>

            <!--Inicializar a conexão e o loop-->
            <?php      
                include("conexao.php");

                $result = $conn->query("select * from aluno");
    
                while ($linha = $result->fetch_array()) {
            ?>
            
            <!--Dados para todas as linhas-->
            <tr class="tableRow">
                <td> <?php echo $linha['ra'];?>     </td>
                <td> <?php echo $linha['nome'];?>   </td>
                <td> <?php echo $linha['rua'];?>    </td>
                <td> <?php echo $linha['num'];?>    </td>
                <td> <?php echo $linha['bairro'];?> </td>
                <td> <?php echo $linha['cidade'];?> </td>
                <td> <?php echo $linha['estado'];?> </td>

                <td> <a href="deletarAluno.php?ra=<?php echo $linha['ra'];?>">Deletar<a></td>
                <td> <a href="alterarAluno.php?ra=<?php echo $linha['ra'];?>">Alterar<a></td>


            </tr>
            
            <!--Fecha o loop-->
            <?php
                }  
            ?>

        </table>
    </body>

    <script src="./script.js?pleaseChromeDontCache3"></script>
</html>