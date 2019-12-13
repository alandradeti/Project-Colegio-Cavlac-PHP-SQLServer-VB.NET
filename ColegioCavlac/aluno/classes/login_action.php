<?php
session_start();
include('conexao.php');
$id = $_POST['id_matricula'];
$senha = $_POST['senha'];

$query = $pdo->prepare("SELECT * FROM viwaluno WHERE id_matricula = '{$id}' ");
$query->execute();
$row = $query->fetch();
$id_banco = $row['id_matricula'];
$senha_banco = $row['senha'];
if($id == $id_banco && $senha==$senha_banco){
	$_SESSION['id'] = $id_banco;
	$_SESSION['logado'] = true;
	header("location:../index.php");
}else{
    echo ("<script>
        window.alert('Usuário ou senha estão incorretos!')
        window.location.href='../../index.php';
    </script>");
	
}
?>