<?php
session_start();

include('../classes/conexao.php');
include('../classes/preencher.php');

$sql = $pdo->prepare("SELECT disciplina FROM TB_DISCP");
$sql->execute();
$cont = 0;

$ano = $_GET['ano'];
$id = $row['id_matricula'];

while ($row = $sql->fetch()) {
    $arrayDisciplinas[$cont] = $row["disciplina"];

    if($ano != "vazio"){
        $query = $pdo->prepare("SELECT * FROM viwaluno WHERE id_matricula = '{$id}' AND disciplina like '{$arrayDisciplinas[$cont]}' and ano = '{$ano}' order by bimestre ");
        $query->execute();
        if($query->fetch() != 0){
            $query->execute();
            echo"<tr>
            <td>$arrayDisciplinas[$cont]</td>";
            while($row = $query->fetch()){
                echo "<td>$row[nota]</td>
                <td>$row[faltas]</td>";
                $a++;
            }
            if($a==4){
                $query = $pdo->prepare("SELECT CAST(AVG(nota) as numeric(3,1)) AS media, SUM(faltas) AS mfaltas FROM viwaluno WHERE id_matricula = '{$id}' AND disciplina = '{$arrayDisciplinas[$cont]}'");
                $query->execute();
                while($row = $query->fetch()){
                    echo "<td>$row[media]</td>
                    <td>$row[mfaltas]</td>";
                }
                echo"
                </tr>";
            }
        }
    }
    $cont++;
}
?>
