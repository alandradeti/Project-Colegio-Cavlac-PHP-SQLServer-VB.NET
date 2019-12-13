<?php
try {
    $hostname = "localhost";
    $dbname = "BD_TCC";
    $username = "sa";
    $pw = "etec";
    $pdo = new PDO ("sqlsrv:Server={$hostname};Database={$dbname}",$username,$pw);
  } catch ( PDOException $e ){
    echo "Drivers disponiveis: " . implode( ",", PDO::getAvailableDrivers() );
    echo "\nErro: " . $e->getMessage();
    exit;
}

ini_set('default_charset','UTF-8');

?>