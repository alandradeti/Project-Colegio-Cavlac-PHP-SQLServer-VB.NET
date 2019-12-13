<?php
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

require 'PHPMailer/src/Exception.php';
require 'PHPMailer/src/PHPMailer.php';
require 'PHPMailer/src/SMTP.php';

if($_POST){
    
    if(empty($_POST['nome']) || empty($_POST['sobrenome']) || empty($_POST['telefone']) || empty($_POST['assunto']) || empty($_POST['email']) || empty($_POST['mensagem'])){
        echo '<script>
                $(document).ready(function(){
                    Swal.fire("Ops ...!","Por favor, preencha todos os campos!","error");
                });
            <script>';
    }else{
        $nome = utf8_decode($_POST['nome']);
        $sobrenome = utf8_decode($_POST['sobrenome']);
        $telefone = utf8_decode($_POST['telefone']);
        $assunto = utf8_decode($_POST['assunto']);
        $email = utf8_decode($_POST['email']);
        $mensagem = utf8_decode($_POST['mensagem']);
    }

    $Email = new PHPMailer(true);
		$Email->SetLanguage("br");
        $Email->Charset = 'UTF-8';
		$Email->IsSMTP(); // Habilita o SMTP 
		$Email->SMTPAuth = true; //Ativa e-mail autenticado
		$Email->Host = 'smtp.gmail.com'; //Servidor de envio # verificar qual o host correto com a hospedagem as vezes fica como smtp.
		$Email->Port = '587'; // Porta de envio
		$Email->SMTPSecure = 'tls';
		$Email->Username = 'alandradeti@gmail.com'; //e-mail que será autenticado
		$Email->Password = '4561238v'; // senha do email
		// ativa o envio de e-mails em HTML, se false, desativa.
		$Email->IsHTML(true); 
		// email do remetente da mensagem
		$Email->From = 'alandradeti@gmail.com';
		//$Email->SMTPDebug = 2; //mostra erros mais detalhados caso houver
		// nome do remetente do email
		$Email->FromName = ($nome);
		$Email->AddAddress("ailtonlm.andrade@outlook.com"); //  para quem será enviada a mensagem
		// informando no email, o assunto da mensagem
		$Email->Subject = $assunto;
		// Define o texto da mensagem (aceita HTML)
		$Email->Body .= "<br />
				        <strong>Nome: </strong>$nome $sobrenome<br />			<strong>Telefone: </strong>$nome $sobrenome<br />
						 <strong>E-mail: </strong>$email<br />
						 <strong>Mensagem: </strong>$mensagem 				
						 ";	
		// verifica se está tudo ok com oa parametros acima, se nao, avisa do erro. Se sim, envia.
		if(!$Email->Send()){				
			 echo'
			<script>
				$(document).ready(function(){
					Swal.fire("Ops '.utf8_encode($nome).'...","Houve um erro ao enviar a mensagem, tente novamente!", "error");
				});
			</script>';

		}else{
			 echo'
		<script>
			$(document).ready(function(){
				Swal.fire("Sucesso '.utf8_encode($nome).'...", "Sua mensagem foi enviada. \n Obrigado pelo contato!", "success");
			});
		</script>';
		}		
}
?>