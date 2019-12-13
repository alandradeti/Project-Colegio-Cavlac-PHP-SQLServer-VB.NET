<?php
session_start();
//ini_set('default_charset','UTF-8');

include('conexao.php');
include('preencher.php');

$ano = $_GET['ano'];

if($ano != "vazio"){

	$id = $row['id_matricula'];
	$query = $pdo->prepare("select * , dbo.formatarData(data) as dataf FROM notificacao WHERE id_matricula = $id and year([data]) = '$ano' order by data");
	$query->execute();
	while($row = $query->fetch()){
		echo " <tr>
		<td>$row[dataf]</td>
		<td>$row[nome_usuario]</td>
		<td>$row[notificacao]</td>
		</tr>";													  
	}
}
?>