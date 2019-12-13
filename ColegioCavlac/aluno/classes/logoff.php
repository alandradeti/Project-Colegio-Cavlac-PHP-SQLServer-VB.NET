<?php
session_start();
$_SESSION['id'] = false;
$_SESSION['logado'] = false;
session_destroy();

header("location:../../index.php");

?>