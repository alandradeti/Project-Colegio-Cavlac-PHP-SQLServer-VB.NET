<?php
include('conexao.php');

$query = $pdo->prepare("SELECT * , dbo.formatarData(dt_cad) as dt_cadf, dbo.formatarData(dt_nasc) as dt_nascf, dbo.formatarCPF(cpf) AS cpff, dbo.formatarRG(rg) AS rgf FROM viwaluno where id_matricula = $_SESSION[id]");
$query->execute();

$row = $query->fetch();

$id_banco= $row['id_matricula'];
$senha = $row['senha'];
?>
