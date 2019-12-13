<?php
include('classes/seg.php');
include('classes/conexao.php');
include('classes/preencher.php');
?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Colégio Cavlac</title>

    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../fonts/css/all.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <link href="../fonts/css/all.css" rel="stylesheet">
    <link href="../fonts/css/brands.min.css" rel="stylesheet">

    <script src="../js/jquery.min.js"></script>
    <script src="js/script.js"></script>
    <script src="js/boletim.js"></script>
    <script src="../js/sweetalert2.min.js"></script>
</head>

<body>
    <header>
        <a href="classes/logoff.php">
            <i class="fas fa-sign-out-alt">Sair</i>
        </a>
    </header>
    <nav>
        <h3>Colégio Cavlac</h3>
        <hr>
        <ul>
            <li>
                <img id="logoAluno" src="../img/logoAluno.png">
            </li>
            <hr>
            <li>
                <a class="scroll" id="perfil" href="#Dados">
                    <i class="fas fa-user"></i>
                    <p>Perfil</p>
                </a>
            </li>
            <li>
                <a class="scroll" href="#Boletim">
                    <i class="fas fa-clipboard"></i>
                    <p>Boletim</p>
                </a>
            </li>
            <li>
                <a class="scroll" href="#Notificacao">
                    <i class="fas fa-bell"></i>
                    <p>Notificações</p>
                </a>
            </li>
            <li>
                <a class="scroll" href="#Contatos">
                    <i class="fas fa-address-book"></i>
                    <p>Contatos</p>
                </a>
            </li>
            <li>
                <a class="scroll" id="btn" href="#Boletim">
                    <i class="fas fa-print"></i>
                    <p>Imprimir Boletim</p>
                </a>
            </li>
        </ul>
    </nav>

    <section id="Dados" class="main">
        <h1 class="titulo">Dados Pessoais</h1>
        <section class="dados">
            <form>
                <div class="row">
                    <div class="col-sm-2 form-group">
                        <label>RA</label>
                        <input type="text" placeholder="" name="id" id="idmat" class="form-control" readonly value="<?php echo $row['id_matricula']; ?>">
                    </div>
                    <div class="col-sm-2 form-group">
                        <label>Data de Cadastro</label>
                        <input type="text" placeholder="" name="dtcad" class="form-control" readonly value="<?php echo $row['dt_cadf']; ?>">
                    </div>
                    <div class="col-sm-8 form-group">
                        <label>Nome</label>
                        <input type="text" placeholder="" name="sobrenome" id="nomecomp" class="form-control" readonly value="<?php echo $row['nome_aluno']; ?>">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2 form-group">
                        <label>Sexo</label>
                        <select id="selectbasic" name="uf" class="form-control" readonly="true">
                            <?php if($row['sexo'] == 0){ ?>
                            <option value="0">Masculino</option>
                            <?php }else{ ?>
                            <option value="1">Feminino</option>
                            <?php } ?>
                        </select>
                    </div>
                    <div class="col-sm-3 form-group">
                        <label>RG</label>
                        <input type="text" placeholder="" name="rg" class="form-control" readonly value="<?php echo $row['rgf']; ?>">
                    </div>
                    <div class="col-sm-3 form-group">
                        <label>CPF</label>
                        <input type="text" placeholder="" name="cpf" class="form-control" readonly value="<?php echo $row['cpff']; ?>">
                    </div>
                    <div class="col-sm-2 form-group">
                        <label>Data de Nascimento</label>
                        <input type="text" placeholder="" name="dtnasc" class="form-control" readonly value="<?php echo $row['dt_nascf']; ?>">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6 form-group">
                        <label>E-mail</label>
                        <input type="text" placeholder="" name="email" class="form-control" readonly value="<?php echo $row['email_aluno']; ?>">
                    </div>
                    <div class="col-sm-6 form-group">
                        <label>Nome do Responsável</label>
                        <input type="text" placeholder="" name="nomeresp" class="form-control" readonly value="<?php echo $row['nome_responsavel']; ?>">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3 form-group">
                        <label>CEP</label>
                        <input type="text" placeholder="" name="cep" id="cep" class="form-control" readonly value="<?php echo $row['cep_aluno']; ?>">
                    </div>
                    <div class="col-sm-3 form-group">
                        <label>Bairro</label>
                        <input type="text" placeholder="" name="bairro" id="bairro" class="form-control" readonly>
                    </div>
                    <div class="col-sm-5 form-group">
                        <label>Cidade</label>
                        <input type="text" placeholder="" name="cidade" id="cidade" class="form-control" readonly>
                    </div>
                    <div class="col-sm-1 form-group">
                        <label>UF</label>
                        <input type="text" placeholder="" name="uf" id="uf" class="form-control" readonly>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-7 form-group">
                        <label>Rua</label>
                        <input type="text" placeholder="" name="rua" id="rua" class="form-control" readonly>
                    </div>
                    <div class="col-sm-2 form-group">
                        <label>Nº Casa</label>
                        <input type="text" placeholder="" name="ncasa" class="form-control" readonly value="<?php echo $row['Num_Casa']; ?>">
                    </div>
                    <div class="col-sm-3 form-group">
                        <label>Ponto de Referência</label>
                        <input type="text" placeholder="" name="pref" class="form-control" readonly value="<?php echo $row['ponto_ref']; ?>">
                    </div>
                </div>
            </form>
        </section>
        <article id="Boletim">
            <div class="row">
                <h1 class="tituloSecundario" id="boltitulo">Boletim</h1>
                <div class="table-responsive" id="boletable">
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th class="opcao">
                                    <select id="anob" name="ano" onChange="boletim(this.value)" class="form-control">
                                        <option value="vazio">ANO...</option>
                                        <?php
										$busca = $pdo->prepare("select id_matricula, ano from TB_BOLETIM WHERE id_matricula = $id_banco group by id_matricula, ano order by ano");
										$busca->execute();
																		
										while($row = $busca->fetch()){
											echo "<option value=$row[ano]>$row[ano]</option>";
										}				
									?>
                                    </select></th>
                                <th class="text-center" colspan="2"><b style="color: #333;">1º Bimestre</b></th>
                                <th class="text-center" colspan="2"><b style="color: #333;">2º Bimestre</b></th>
                                <th class="text-center" colspan="2"><b style="color: #333;">3º Bimestre</b></th>
                                <th class="text-center" colspan="2"><b style="color: #333;">4º Bimestre</b></th>
                                <th class="text-center" colspan="2"><b style="color: #333;">Média Total</b></th>
                            </tr>
                        </thead>
                        <thead>
                            <tr>
                                <th><b>Disciplina</b></th>
                                <th><b>Nota</b></th>
                                <th><b>Faltas</b></th>
                                <th><b>Nota</b></th>
                                <th><b>Faltas</b></th>
                                <th><b>Nota</b></th>
                                <th><b>Faltas</b></th>
                                <th><b>Nota</b></th>
                                <th><b>Faltas</b></th>
                                <th><b>Nota</b></th>
                                <th><b>Faltas</b></th>
                            </tr>
                        </thead>
                        <tbody id="myTable">
                            <!-- Onde Gera o Boletim-->
                        </tbody>
                    </table>
                </div>
            </div>
        </article>

        <article id="Notificacao">
            <div class="row">
                <h1 class="tituloSecundario">Notificações</h1>
                <div class="table-responsive">
                    <table class="table table-hover" border="1">
                        <thead>
                            <tr>
                                <th class="opcao">
                                    <select id="selectbasic1" name="ano" onChange="notificacao(this.value)" class="form-control">
                                        <option value="vazio">ANO...</option>
                                        <?php
										$busca = $pdo->prepare("select id_matricula, year([data]) AS ano from notificacao where id_matricula = $id_banco group by id_matricula, year([data]) order by ano");
										$busca->execute();
																		
										while($row = $busca->fetch()){
											echo "<option value=$row[ano]>$row[ano]</option>";
										}
														
									   ?>
                                    </select>
                                </th>
                                <th class="text-center" colspan="2"><b>Observações sobre o Aluno</b></th>
                            </tr>
                        </thead>
                        <thead>
                            <tr>
                                <th class="text-center"><b>Data</b></th>
                                <th class="col-sm-4 text-center"><b>Professor</b></th>
                                <th class="text-center"><b>Descrição</b></th>
                            </tr>
                        </thead>
                        <tbody id="myTableNot">
                            <!-- Onde Gera as Notificações-->
                        </tbody>
                    </table>
                </div>
            </div>
        </article>

        <article id="Contatos">
            <div class="row">
                <h1 class="tituloSecundario">Contatos</h1>
                <table class="table table-hover">
                    <thead>
                        <tr>
                            <th class="text-center" colspan="2"><b>Contato dos educadores</b></th>

                        </tr>
                    </thead>
                    <thead>
                        <tr>
                            <th class="col-sm-4 text-center"><b>Educador</b></th>
                            <th class="text-center"><b>E-mail</b></th>
                        </tr>
                    </thead>
                    <tbody id="myTableEd">
                        <?php
						$query = $pdo->prepare("select nome_usuario, email_usuario FROM TB_USUARIO WHERE email_usuario <> ''");
						$query->execute();
						while($row = $query->fetch()){
							echo " <tr>
							<td>$row[nome_usuario]</td>
							<td>$row[email_usuario]</td>
							</tr>";													  
						}
					   ?>
                    </tbody>
                </table>
            </div>
        </article>
    </section>

    <footer>
        <div>
            <p>&copy; 2017 Colégio Cavlac</p>
        </div>
    </footer>
</body>

</html>
