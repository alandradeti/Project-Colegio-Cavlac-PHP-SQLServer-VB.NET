<?php
session_start();

if(isset($_SESSION['logado']) && isset($_SESSION['id'])){
		echo "<script>alert('Seja Bem Vindo!');</script>";
}



?>